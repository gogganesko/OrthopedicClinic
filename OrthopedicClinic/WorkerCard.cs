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
    public partial class WorkerCard : Form
    {
        public WorkerCard()
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
                var temp1 = db.WorkerTypeOfProcedures.Where(x => x.DeleteTime == null && x.Worker_ID == id);
                List<WorkerTypeOfProcedures> wtop = temp1.ToList();
                foreach (WorkerTypeOfProcedures w in wtop)
                {
                    listBox1.Items.Add(w.TypeOfProcedures.Name);
                }
            }
        }

        private void RefreshFormData(int id)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Workers temp = db.Workers.Where(x => x.Id == id).FirstOrDefault<Workers>();
                NameLbl.Text = temp.Name;
                SpecializationLbl.Text = temp.Specialization;
                TelephonenbmrLbl.Text = temp.TelephoneNumber;
                FillListBox();
            }
           
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            WorkerEdit w = new WorkerEdit();
            w.Currentid = id;
            w.ShowDialog();
            RefreshFormData(id);
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Workers w = db.Workers.Where(x => x.Id == id).FirstOrDefault<Workers>();
                w.DeleteTime = DateTime.Now;
                MessageBox.Show("Врач успешно удален!", "Ортопедическая клиника");
                db.SaveChanges();
                this.Close();
            }
        }

        private void WorkerCard_Load(object sender, EventArgs e)
        {
            RefreshFormData(this.id);
        }

        private void ShowWorkigHoursBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.feedbackid = id;
            f.stat = 12;
            f.ShowDialog();
        }

        private void ShowScheduleBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.feedbackid = id;
            f.stat = 13;
            f.ShowDialog();
        }

        private void ShowTreatmentPlansBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.feedbackid = id;
            f.stat = 14;
            f.ShowDialog();
        }
    }
}
