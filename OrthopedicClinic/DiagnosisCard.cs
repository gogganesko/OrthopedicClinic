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
    public partial class DiagnosisCard : Form
    {
        public DiagnosisCard()
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
                Diagnosises temp = db.Diagnosises.Where(x => x.Id == id).FirstOrDefault<Diagnosises>();
                PatientNameLkLbl.Text = db.Patients.Find(temp.Patient_ID).Name;
                WorkerNameLkLbl.Text = db.Workers.Find(temp.Worker_ID).Name;
                DiagnosisNameLbl.Text = temp.Name;
                DateLbl.Text = Convert.ToString(temp.Date);
                StatusLbl.Text = temp.Status;
                DescLbl.Text = temp.Description;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            DiagnosisEdit d = new DiagnosisEdit();
            d.Currentid = id;
            d.ShowDialog();
            RefreshFormData(id);
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Diagnosises c = db.Diagnosises.Where(x => x.Id == id).FirstOrDefault<Diagnosises>();
                c.DeleteTime = DateTime.Now;
                MessageBox.Show("Диагноз успешно удален!", "Ортопедическая клиника");
                db.SaveChanges();
                this.Close();
            }            
        }

        private void DiagnosisCard_Load(object sender, EventArgs e)
        {
            RefreshFormData(this.id);
        }

        private void PatientNameLkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Patients p = db.Patients.Where(x => x.Name == PatientNameLkLbl.Text).FirstOrDefault<Patients>();
                PatientCard pc = new PatientCard();
                pc.Currentid = p.Id;
                pc.ShowDialog();
            }
        }

        private void WorkerNameLkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Workers w = db.Workers.Where(x => x.Name == WorkerNameLkLbl.Text).FirstOrDefault<Workers>();
                WorkerCard wc = new WorkerCard();
                wc.Currentid = w.Id;
                wc.ShowDialog();
            }
        }
    }
}
