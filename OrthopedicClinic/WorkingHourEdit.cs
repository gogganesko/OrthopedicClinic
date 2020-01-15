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
    public partial class WorkingHourEdit : Form
    {
        public WorkingHourEdit()
        {
            InitializeComponent();
            WorkerCmbx.Validating += WorkerCmbx_Validating;
            CabinetCmbx.Validating += CabinetCmbx_Validating;
        }

        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }

        public void FillWorkerCmbx()
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                foreach (Workers p in db.Workers.Where(x => x.DeleteTime == null).ToList())
                {
                    WorkerCmbx.Items.Add(p.Name);
                }
            }
        }
        public void FillCabinetCmbx()
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                foreach (Cabinets c in db.Cabinets.Where(x => x.DeleteTime == null).ToList())
                {
                    CabinetCmbx.Items.Add(c.Name);
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            WorkingHours temp = new WorkingHours();
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                if (radioButton2.Checked==true)
                {
                    radioButton1.Checked = false;
                    DateTime start = DTPStart.Value;
                    DateTime end = DTPEnd.Value;
                    DateTime date = dateTimePicker1.Value;
                   while (end <= date)
                    {
                        WorkingHours c = new WorkingHours();
                        c.Id = db.WorkingHours.Count()+1;
                        c.Worker_ID = db.Workers.Where(x => x.Name == WorkerCmbx.Text).FirstOrDefault<Workers>().Id;
                        c.Cabinet_ID = db.Cabinets.Where(x => x.Name == CabinetCmbx.Text).FirstOrDefault<Cabinets>().Id;
                        c.TimeStart = start;
                        start = start.AddDays(7);
                        c.TimeEnd = end;
                        end = end.AddDays(7);
                        db.WorkingHours.Add(c);
                        db.SaveChanges();                        
                    }
                    MessageBox.Show("Сохранение успешно", "Ортопедическая клиника");
                    this.Close();
                }
                if (radioButton1.Checked==true)
                {
                    radioButton2.Checked = false;
                    DateTime start = DTPStart.Value;
                    DateTime end = DTPEnd.Value;
                    int count = 1;
                    while(count<=Convert.ToInt16(numericUpDown1.Value))
                    {
                        count++;
                        WorkingHours c = new WorkingHours();
                        c.Id = db.WorkingHours.Count() + 1;
                        c.Worker_ID = db.Workers.Where(x => x.Name == WorkerCmbx.Text).FirstOrDefault<Workers>().Id;
                        c.Cabinet_ID = db.Cabinets.Where(x => x.Name == CabinetCmbx.Text).FirstOrDefault<Cabinets>().Id;
                        c.TimeStart = start;
                        start = start.AddDays(7);
                        c.TimeEnd = end;
                        end = end.AddDays(7);
                        db.WorkingHours.Add(c);
                        db.SaveChanges();                       
                    }
                    MessageBox.Show("Сохранение успешно", "Ортопедическая клиника");
                    this.Close();
                }               
            }
        }

        private void WorkingHourEdit_Load(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                FillWorkerCmbx();
                FillCabinetCmbx();
                if (db.WorkingHours.Find(id) != null)
                {
                    WorkingHours temp = db.WorkingHours.Where(x => x.Id == id).FirstOrDefault<WorkingHours>();
                    WorkerCmbx.Text = temp.Workers.Name;
                    CabinetCmbx.Text = temp.Cabinets.Name;
                    DTPStart.Value = Convert.ToDateTime(temp.TimeStart);
                    DTPEnd.Value = Convert.ToDateTime(temp.TimeEnd);
                }
                else
                {                    
                    Save.Enabled = false;
                    WorkingHours c = new WorkingHours();
                    c.Id = db.WorkingHours.Count() + 1;
                    Currentid = Convert.ToInt16(c.Id);
                    WorkerCmbx.SelectedIndex = 0;
                    CabinetCmbx.SelectedIndex = 0;
                }
            }
        }

        private void WorkerCmbx_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(WorkerCmbx.Text))
            {
                errorProvider1.SetError(WorkerCmbx, "Не указан работник");
                Save.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                Save.Enabled = true;
            }
        }

        private void CabinetCmbx_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(CabinetCmbx.Text))
            {
                errorProvider2.SetError(CabinetCmbx, "Не указан кабинет");
                Save.Enabled = false;
            }
            else
            {
                errorProvider2.Clear();
                Save.Enabled = true;
            }
        }
    }
}
