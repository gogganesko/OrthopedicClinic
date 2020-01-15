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
    public partial class VisitCard : Form
    {
        public VisitCard()
        {
            InitializeComponent();
        }
        private int id;

        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }

        public void FillGrid()
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                dataGridView1.Rows.Clear();
                var temp1 = db.VisitProcedures.Where(x => x.DeleteTime == null && x.Visit_ID == id);
                List<VisitProcedures> vplist = temp1.ToList();
                foreach (VisitProcedures vp in vplist)
                {
                    dataGridView1.Rows.Add(vp.Procedures.Id, vp.Procedures.DateEventStart, vp.Procedures.TypeOfProcedures.Name, vp.Procedures.TypeOfProcedures.Price);
                }
            }
        }
        private void RefreshFormData(int id)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Visits temp = db.Visits.Where(x => x.Id == id).FirstOrDefault<Visits>();
                CabinetLkLbl.Text = db.Cabinets.Find(temp.Cabinet_ID).Name;
                dateStartDTP.Value = Convert.ToDateTime(temp.DateStart);
                dateEndDTP.Value = Convert.ToDateTime(temp.DateEnd);
                PatientLkLbl.Text = db.Patients.Find(temp.Patient_ID).Name;
                DescTxtBx.Text = temp.Description;
                ResultTxtBx.Text = temp.Result;
                FillGrid();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            VisitEdit v = new VisitEdit();
            v.Currentid = id;
            v.ShowDialog();
            FillGrid();
            RefreshFormData(id);            
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Visits v = db.Visits.Where(x => x.Id == id).FirstOrDefault<Visits>();
                v.DeleteTime = DateTime.Now;
                MessageBox.Show("Приём успешно удален!", "Ортопедическая клиника");
                db.SaveChanges();
                this.Close();
            }
        }

        private void VisitCard_Load(object sender, EventArgs e)
        {
            RefreshFormData(this.id);
        }

        private void CabinetLkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Cabinets c = db.Cabinets.Where(x => x.Name == CabinetLkLbl.Text).FirstOrDefault<Cabinets>();
                CabinetCard cc = new CabinetCard();
                cc.Currentid = c.Id;
                cc.ShowDialog();
            }
        }

        private void PatientLkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Patients p = db.Patients.Where(x => x.Name == PatientLkLbl.Text).FirstOrDefault<Patients>();
                PatientCard pc = new PatientCard();
                pc.Currentid = p.Id;
                pc.ShowDialog();
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
