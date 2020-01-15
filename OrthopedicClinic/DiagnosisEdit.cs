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
    public partial class DiagnosisEdit : Form
    {
        public DiagnosisEdit()
        {
            InitializeComponent();
            WorkerCmbx.Validating += WorkerCmbx_Validating;
            Diagnosisname.Validating += Diagnosisname_Validating;
            StatusCmbx.Validating += StatusCmbx_Validating;
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

        public void FillStatusCmbx()
        {
            WorkerCmbx.Items.Clear();
            StatusCmbx.Items.Add("Подтверждённый");
            StatusCmbx.Items.Add("Не подтвержённый");
        }
        public void FillWorkersCmbx()
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                WorkerCmbx.Items.Clear();
                List<Workers> temp = db.Workers.Where(x => x.DeleteTime == null).ToList();
                foreach (Workers w in temp)
                {
                    WorkerCmbx.Items.Add(w.Name);   
                }
            }
        }
        private void DiagnosisEdit_Load(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                FillStatusCmbx();
                FillWorkersCmbx();
                if (db.Diagnosises.Find(id) != null)
                {
                    Diagnosises temp = db.Diagnosises.Where(x => x.Id == id).FirstOrDefault<Diagnosises>();
                    PatientLbl.Text = temp.Patients.Name;
                    WorkerCmbx.Text = temp.Workers.Name;
                    Diagnosisname.Text = temp.Name;
                    DateDTP.Value = Convert.ToDateTime(temp.Date);
                    StatusCmbx.Text = temp.Status;
                    Desc.Text = temp.Description;                    
                }
                else
                {
                    SaveBtn.Enabled = false;
                    Diagnosises c = new Diagnosises();
                    c.Id = db.Diagnosises.Count() + 1;
                    Currentid = Convert.ToInt16(c.Id);
                    WorkerCmbx.SelectedIndex = 0;
                    StatusCmbx.SelectedIndex = 0;                  
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Diagnosises temp = new Diagnosises();
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                if (db.Diagnosises.Find(id) == null)
                {
                    try
                    {
                        Diagnosises c = new Diagnosises();
                        c.Id = id;
                        c.Patient_ID = db.Patients.Where(x => x.Name == PatientLbl.Text).FirstOrDefault<Patients>().Id;
                        c.Worker_ID = db.Workers.Where(x => x.Name == WorkerCmbx.Text).FirstOrDefault<Workers>().Id;
                        c.Name = Diagnosisname.Text;
                        c.Date = Convert.ToDateTime(DateDTP.Value);
                        c.Status = StatusCmbx.Text;
                        c.Description = Desc.Text;
                        db.Diagnosises.Add(c);
                        db.SaveChanges();
                        MessageBox.Show("Сохранение успешно", "Ортопедическая клиника!");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Вы не выбрали пациента");
                    }
                }
                else
                {
                    var temp1 = db.Diagnosises.Where(x => x.Id == id).FirstOrDefault<Diagnosises>();
                    temp = temp1;
                    temp.Patient_ID = db.Patients.Where(x => x.Name == PatientLbl.Text).FirstOrDefault<Patients>().Id;
                    temp.Worker_ID = db.Workers.Where(x => x.Name == WorkerCmbx.Text).FirstOrDefault<Workers>().Id;
                    temp.Name = Diagnosisname.Text;
                    temp.Date = Convert.ToDateTime(DateDTP.Value);
                    temp.Description = Desc.Text;                    
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Ортопедическая клиника");
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
                Form1.stat = 9;
                Form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Form1.ShowDialog();
                PatientLbl.Text = db.Patients.Find(Form1.choosenid).Name;

            }
        }
        private void WorkerCmbx_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(WorkerCmbx.Text))
            {
                errorProvider1.SetError(WorkerCmbx, "Не указан номер!");
                SaveBtn.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                SaveBtn.Enabled = true;
            }
        }

        private void Diagnosisname_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(Diagnosisname.Text))
            {
                errorProvider2.SetError(Diagnosisname, "Не указано название диагноза!");
                SaveBtn.Enabled = false;
            }
            else
            {
                errorProvider2.Clear();
                SaveBtn.Enabled = true;
            }
        }

        private void StatusCmbx_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(StatusCmbx.Text))
            {
                errorProvider3.SetError(StatusCmbx, "Не указан статус диагноза!");
                SaveBtn.Enabled = false;
            }
            else
            {
                errorProvider3.Clear();
                SaveBtn.Enabled = true;
            }
        }
    }
}
