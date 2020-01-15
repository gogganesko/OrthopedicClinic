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
    public partial class WorkingHourCard : Form
    {
        public WorkingHourCard()
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
                WorkingHours temp = db.WorkingHours.Where(x => x.Id == id).FirstOrDefault<WorkingHours>();
                WorkerLnkLbl.Text = db.Workers.Find(temp.Worker_ID).Name;
                CabinetNameLbl.Text = db.Cabinets.Find(temp.Cabinet_ID).Name;
                DateTime s = Convert.ToDateTime(temp.TimeStart);
                DateTime e = Convert.ToDateTime(temp.TimeEnd);
                DateStartLbl.Text = s.TimeOfDay.ToString();
                DateEndLbl.Text = e.TimeOfDay.ToString();
            }
        }
        private void DelBtn_Click(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                WorkingHours w = db.WorkingHours.Where(x => x.Id == id).FirstOrDefault<WorkingHours>();
                w.DeleteTime = DateTime.Now;
                MessageBox.Show("Запись расписания успешно удалена!", "Ортопедическая клиника");
                db.SaveChanges();
                this.Close();
            }
        }

        private void WorkingHourCard_Load(object sender, EventArgs e)
        {
            RefreshFormData(this.id);
        }

        private void WorkerLnkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Workers w = db.Workers.Where(x => x.Name == WorkerLnkLbl.Text).FirstOrDefault<Workers>();
                WorkerCard wc = new WorkerCard();
                wc.Currentid = w.Id;
                wc.ShowDialog();
            }
        }
    }
}
