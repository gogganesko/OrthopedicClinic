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
    public partial class TreatmentPlanCard : Form
    {
        public TreatmentPlanCard()
        {
            InitializeComponent();
        }

        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        public void FillListBox()
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                listBox1.Items.Clear();
                var temp1 = db.TreatmentPlanDagnosises.Where(x => x.DeleteTime == null && x.TreatmentPlan_ID == id);
                List<TreatmentPlanDagnosises> diagnosislist = temp1.ToList();
                foreach (TreatmentPlanDagnosises wp in diagnosislist)
                {
                    listBox1.Items.Add(wp.Diagnosises.Name);
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
                    dataGridView1.Rows.Add(cp.Procedures.Id, cp.Procedures.DateEventStart, cp.Procedures.TypeOfProcedures.Name, cp.Procedures.TypeOfProcedures.Price);//(cp.Procedures.TypeOfProcedures.Name, cp.Procedures.DateEventStart, cp.Procedures.TypeOfProcedures.Price);
                }
            }
        }
        private void RefreshFormData(int id)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                TreatmentPlans temp = db.TreatmentPlans.Where(x => x.Id == id).FirstOrDefault<TreatmentPlans>();
                PatientLkLbl.Text = db.Patients.Find(temp.Patient_ID).Name;
                WorkerLkLbl.Text = db.Workers.Find(temp.Worker_ID).Name;
                textBox1.Text = temp.Description;
                FillGrid();
                FillListBox();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            TreatmentPlanEdit t = new TreatmentPlanEdit();
            t.Currentid = id;
            t.ShowDialog();
            RefreshFormData(id);
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                TreatmentPlans t = db.TreatmentPlans.Where(x => x.Id == id).FirstOrDefault<TreatmentPlans>();
                t.DeleteTime = DateTime.Now;
                MessageBox.Show("План лечения успешно удален!", "Ортопедическая клиника");
                db.SaveChanges();
                this.Close();
            }
        }

        private void TreatmentPlanCard_Load(object sender, EventArgs e)
        {
            RefreshFormData(this.id);
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

        private void WorkerLkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Workers w = db.Workers.Where(x => x.Name == WorkerLkLbl.Text).FirstOrDefault<Workers>();
                WorkerCard wc = new WorkerCard();
                wc.Currentid = w.Id;
                wc.ShowDialog();
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
