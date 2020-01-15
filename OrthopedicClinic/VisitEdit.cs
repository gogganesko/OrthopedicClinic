using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrthopedicClinic
{
    public partial class VisitEdit : Form
    {
        public VisitEdit()
        {
            InitializeComponent();
            CabinetCmbx.Validating += CabinetCmbx_Validating;
            DescTxtBx.Validating += DescTxtBx_Validating;
        }
        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        private int feedbackforpat;
        public int PatientID
        {
            get { return feedbackforpat; }
            set { feedbackforpat = value; }
        }
        public void FillCmbxWithCabinets()
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                foreach (Cabinets c in db.Cabinets.Where(x=>x.DeleteTime==null).ToList())
                {
                    CabinetCmbx.Items.Add(c.Name);
                }
            }
        }
        public void FillGrid()
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                dataGridView1.Rows.Clear();
                var temp1 = db.VisitProcedures.Where(x => x.DeleteTime == null && x.Visit_ID == id);
                List<VisitProcedures> vplist = temp1.ToList();
                try
                {
                    foreach (VisitProcedures vp in vplist)
                    {
                        dataGridView1.Rows.Add(vp.Procedures.Id, vp.Procedures.TypeOfProcedures.Name, vp.Procedures.DateEventStart, vp.Procedures.TypeOfProcedures.Price);
                    }
                }
                catch
                {

                }               
            }
        }


        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Visits temp = new Visits();
            using (ClinicEntities1 db = new ClinicEntities1())
            {
               if (db.Visits.Find(id)==null)
                {
                    Visits t = new Visits();
                    t.Id = id;
                    t.Cabinet_ID = db.Cabinets.Where(x => x.Name == CabinetCmbx.Text && x.DeleteTime == null).FirstOrDefault<Cabinets>().Id;
                    t.DateStart = Convert.ToDateTime(dateStartDTP.Value);
                    t.DateEnd = Convert.ToDateTime(DateEndDTP.Value);
                    t.Patient_ID = db.Patients.Where(x => x.Name == PatientLbl.Text && x.DeleteTime == null).FirstOrDefault<Patients>().Id;
                    t.Description = DescTxtBx.Text;
                    t.Result = ResultTxtBx.Text;
                    db.Visits.Add(t);
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Ортопедическая клиника!");
                    this.Close();
                }
               else
                {
                    var temp1 = db.Visits.Where(x => x.Id == id).FirstOrDefault<Visits>();
                    temp = temp1;
                    temp.Patient_ID = db.Patients.Where(x => x.Name == PatientLbl.Text).FirstOrDefault<Patients>().Id;
                    temp.Cabinet_ID = db.Cabinets.Where(x => x.Name == CabinetCmbx.Text && x.DeleteTime == null).FirstOrDefault<Cabinets>().Id;
                    temp.DateStart = Convert.ToDateTime(dateStartDTP.Value);
                    temp.DateEnd = Convert.ToDateTime(DateEndDTP.Value);
                    temp.Description = DescTxtBx.Text;
                    temp.Result = ResultTxtBx.Text;
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Ортопедическая клиника!");
                    this.Close();
                }
            }
        }

        private void AddPatientBtn_Click(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Form1 Form1 = new Form1();
                Form1.Text = "Добавить пациента";
                Form1.feedbackid = id;
                Form1.stat = 8;
                Form1.ShowDialog();
                PatientLbl.Text = db.Patients.Find(Form1.choosenid).Name;
            }
        }

        private void AddProcedureBtn_Click(object sender, EventArgs e)
        {
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    ProcedureEdit procedureedit = new ProcedureEdit();                   
                    procedureedit.ShowDialog();
                    VisitProcedures temp = new VisitProcedures();
                    temp.Visit_ID = id;
                    temp.Procedure_ID = procedureedit.Currentid;
                    db.VisitProcedures.Add(temp);
                    db.SaveChanges();
                }
                FillGrid();
        }

        private void DelProcedureBtn_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                VisitProcedures cp = db.VisitProcedures.Where(x => x.Visit_ID == id && x.Procedure_ID == index).FirstOrDefault<VisitProcedures>();
                db.VisitProcedures.Remove(cp);
                db.SaveChanges();
                FillGrid();
            }
        }
        private void VisitEdit_Load(object sender, EventArgs e)
        {
            FillCmbxWithCabinets();
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                if (db.Visits.Find(id) != null)
                {
                    Visits temp = db.Visits.Where(x => x.Id == id).FirstOrDefault<Visits>();
                    PatientLbl.Text = temp.Patients.Name;
                    CabinetCmbx.Text = temp.Cabinets.Name;
                    dateStartDTP.Value = Convert.ToDateTime(temp.DateStart);
                    DateEndDTP.Value = Convert.ToDateTime(temp.DateEnd);
                    PatientLbl.Text = temp.Patients.Name;
                    DescTxtBx.Text = temp.Description;
                    ResultTxtBx.Text = temp.Result;                                        
                    FillGrid();                    

                }
                else
                {
                    SaveBtn.Enabled = false;
                    Visits c = new Visits();
                    c.Id = db.Visits.Count() + 1;
                    Currentid = Convert.ToInt16(c.Id);
                    CabinetCmbx.SelectedIndex = 0;
                }
            }
        }
        private void VisitEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                if (db.Visits.Find(id) == null)
                {
                    var temp1 = db.VisitProcedures.Where(x => x.DeleteTime == null && x.Visit_ID == id);
                    List<VisitProcedures> vplist = temp1.ToList();
                    if (dataGridView1.RowCount != 0)
                    {
                        foreach (VisitProcedures vp in vplist)
                        {
                            db.VisitProcedures.Remove(vp);
                            db.Procedures.Remove(db.Procedures.Find(vp.Procedure_ID));
                            db.WorkerProcedures.Remove(db.WorkerProcedures.Where(x => x.Procedure_ID == vp.Procedure_ID).FirstOrDefault<WorkerProcedures>());
                            db.SaveChanges();
                        }
                    }
                }
            }
        }

        private void CabinetCmbx_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(CabinetCmbx.Text))
            {
                errorProvider1.SetError(CabinetCmbx, "Не указан кабинет!");
                SaveBtn.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                SaveBtn.Enabled = true;
            }
        }

        private void DescTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(DescTxtBx.Text))
            {
                errorProvider2.SetError(DescTxtBx, "Не указано название!");
                SaveBtn.Enabled = false;
            }
            else
            {
                errorProvider2.Clear();
                SaveBtn.Enabled = true;
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProcedureCard Procedurecard = new ProcedureCard();
            int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Procedures p = db.Procedures.Find(id);
                Procedurecard.Currentid = id;
                Procedurecard.ShowDialog();
                FillGrid();
            }
        }
    }
}
