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
    public partial class TreatmentPlanEdit : Form
    {
        public TreatmentPlanEdit()
        {
            InitializeComponent();
            workerscmbx.Validating += workerscmbx_Validating;
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

        public void FillCmbxWithWorkers()
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                foreach (Workers p in db.Workers.Where(x => x.DeleteTime == null).ToList())
                {
                    workerscmbx.Items.Add(p.Name);
                }
            }
        }
        public void FillListBox()
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                DiagnosisesLstBx.Items.Clear();
                var temp1 = db.TreatmentPlanDagnosises.Where(x => x.DeleteTime == null && x.TreatmentPlan_ID == id);
                List<TreatmentPlanDagnosises> diagnosislist = temp1.ToList();
                foreach (TreatmentPlanDagnosises wp in diagnosislist)
                {
                    DiagnosisesLstBx.Items.Add(wp.Diagnosises.Name);
                }
            }
        }
        public void FillGrid()
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                dataGridView1.Rows.Clear();
                var temp1 = db.TreatmentPlanProcedures.Where(x => x.DeleteTime == null && x.TreatmentPlan_ID == id);
                List<TreatmentPlanProcedures> procedurelist = temp1.ToList();
                foreach (TreatmentPlanProcedures cp in procedurelist)
                {
                    dataGridView1.Rows.Add(cp.Procedures.Id, cp.Procedures.TypeOfProcedures.Name, cp.Procedures.DateEventStart, cp.Procedures.TypeOfProcedures.Price);
                }
            }
        }
        private void ChosePat_Click(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Form1 Form1 = new Form1();
                Form1.Text = "Добавить пациента";
                Form1.feedbackid = id;
                Form1.stat = 4;
                Form1.ShowDialog();
                PatientLbl.Text = db.Patients.Find(Form1.choosenid).Name;
            }
        }
        private void AddProced_Click(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                ProcedureEdit procedureedit = new ProcedureEdit();
                procedureedit.ShowDialog();
                TreatmentPlanProcedures temp = new TreatmentPlanProcedures();
                temp.TreatmentPlan_ID = id;
                temp.Procedure_ID = procedureedit.Currentid;
                db.TreatmentPlanProcedures.Add(temp);
                db.SaveChanges();                
            }
            FillGrid();
        }
        private void DelProced_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                TreatmentPlanProcedures cp = db.TreatmentPlanProcedures.Where(x => x.TreatmentPlan_ID == id && x.Procedure_ID == index).FirstOrDefault<TreatmentPlanProcedures>(); 
                db.TreatmentPlanProcedures.Remove(cp);
                db.SaveChanges();
                FillGrid();
            }
        }
        private void AddDiag_Click(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Form1 Form1 = new Form1();
                Form1.Text = "Добавить диагноз";
                Form1.feedbackid = id;
                Form1.stat = 7;
                Form1.ShowDialog();
                FillListBox();
            }
        }
        private void DelDiag_Click(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                string name = DiagnosisesLstBx.SelectedItem.ToString();
                int index = db.Diagnosises.Where(x => x.Name == name).FirstOrDefault<Diagnosises>().Id;
                TreatmentPlanDagnosises tp = db.TreatmentPlanDagnosises.Where(x => x.TreatmentPlan_ID == id && x.Diagnosis_ID == index).FirstOrDefault<TreatmentPlanDagnosises>();
                db.TreatmentPlanDagnosises.Remove(tp);
                db.SaveChanges();
                FillListBox();
            }
        }

        private void TreatmentPlanEdit_Load(object sender, EventArgs e)
        {
            FillCmbxWithWorkers();
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                if (db.TreatmentPlans.Find(id) != null)
                {
                    TreatmentPlans temp = db.TreatmentPlans.Where(x => x.Id == id).FirstOrDefault<TreatmentPlans>();
                    PatientLbl.Text = temp.Patients.Name;
                    workerscmbx.Text = temp.Workers.Name;
                    textBox1.Text = temp.Description;
                    FillGrid();
                    FillListBox();
                    
                }
                else
                {
                    SaveBtn.Enabled = false;
                    TreatmentPlans c = new TreatmentPlans();
                    c.Id = db.TreatmentPlans.Count() + 1;
                    Currentid = Convert.ToInt16(c.Id);
                    workerscmbx.SelectedIndex = 0;
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            TreatmentPlans temp = new TreatmentPlans();
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                if (db.TreatmentPlans.Find(id) == null)
                {
                    TreatmentPlans t = new TreatmentPlans();
                    t.Id = id;
                    t.Description = textBox1.Text;
                    t.Worker_ID = db.Workers.Where(x => x.Name == workerscmbx.Text).FirstOrDefault<Workers>().Id;
                    t.Patient_ID = db.Patients.Where(x => x.Name == PatientLbl.Text).FirstOrDefault<Patients>().Id;
                    db.TreatmentPlans.Add(t);
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Ортопедическая клиника!");
                    this.Close();
                }
                else
                {
                    var temp1 = db.TreatmentPlans.Where(x => x.Id == id).FirstOrDefault<TreatmentPlans>();
                    temp = temp1;
                    temp.Patient_ID = db.Patients.Where(x => x.Name == PatientLbl.Text).FirstOrDefault<Patients>().Id;
                    temp.Worker_ID = db.Workers.Where(x => x.Name == workerscmbx.Text).FirstOrDefault<Workers>().Id;
                    temp.Description = textBox1.Text;
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Ортопедическая клиника!");
                    this.Close();
                }
            }
        }

        private void workerscmbx_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(workerscmbx.Text))
            {
                errorProvider1.SetError(workerscmbx, "Не указан врач!");
                SaveBtn.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                SaveBtn.Enabled = true;
            }
        }

        private void TreatmentPlanEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                if (db.TreatmentPlans.Find(id) == null)
                {
                    var temp1 = db.TreatmentPlanProcedures.Where(x => x.DeleteTime == null && x.TreatmentPlan_ID == id);
                    List<TreatmentPlanProcedures> vplist = temp1.ToList();
                    if (dataGridView1.RowCount != 0)
                    {
                        foreach (TreatmentPlanProcedures vp in vplist)
                        {
                            db.TreatmentPlanProcedures.Remove(vp);
                            db.Procedures.Remove(db.Procedures.Find(vp.Procedure_ID));
                            db.WorkerProcedures.Remove(db.WorkerProcedures.Where(x => x.Procedure_ID == vp.Procedure_ID).FirstOrDefault<WorkerProcedures>());
                            db.SaveChanges();
                        }
                    }
                    var temp2 = db.TreatmentPlanDagnosises.Where(x => x.DeleteTime == null && x.TreatmentPlan_ID == id);
                    List<TreatmentPlanDagnosises> vpslist = temp2.ToList();
                    if (DiagnosisesLstBx.Items.Count != 0)
                    {
                        foreach (TreatmentPlanDagnosises tpd in vpslist)
                        {
                            db.TreatmentPlanDagnosises.Remove(tpd);
                            db.SaveChanges();
                        }
                    }
                }
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
