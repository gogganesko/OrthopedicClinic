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
    public partial class PatientCard : Form
    {
        public PatientCard()
        {
            InitializeComponent();         
   
        }
        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        private void RefreshFormData(int id)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Patients temp = db.Patients.Where(x => x.Id == id).FirstOrDefault<Patients>();
                NameLbl.Text = temp.Name;
                PhoneNmbrLbl.Text = temp.TelephoneNumber;
                HeightLbl.Text = Convert.ToString(temp.Height);
                WeightLbl.Text = Convert.ToString(temp.Weight);
                textBox1.Text = temp.Comment;            
            }
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            PatientEdit p = new PatientEdit();
            p.Currentid = id;
            p.ShowDialog();
            RefreshFormData(id);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Patients c = db.Patients.Where(x => x.Id == id).FirstOrDefault<Patients>();
                c.DeleteTime = DateTime.Now;
                MessageBox.Show("Пациент успешно удален!", "Ортопедическая клиника");
                db.SaveChanges();
                this.Close();
            }
        }

        private void PatientCard_Load(object sender, EventArgs e)
        {
            RefreshFormData(this.id);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Bill b = new Bill();
            b.Patientid = id;
            b.ShowDialog();
        }

        private void ShowTreatmentPlan_Click(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                try
                {
                    TreatmentPlans tp = db.TreatmentPlans.Where(x => x.Patient_ID == id).FirstOrDefault<TreatmentPlans>();
                    TreatmentPlanCard tpcard = new TreatmentPlanCard();
                    tpcard.Currentid = tp.Id;
                    tpcard.ShowDialog();
                }
                catch
                {
                    MessageBox.Show("У данного пациента нет плана лечения!", "Ортопедическая клиника");
                }
            }
        }

        private void ShowScheduleBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.feedbackid = id;
            f.stat = 11;
            f.ShowDialog();
        }
    }
}
