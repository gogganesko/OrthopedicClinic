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
    public partial class Bill : Form
    {
        public Bill()
        {
            InitializeComponent();
        }
        private int id;
        public int Patientid
        {
            get { return id; }
            set { id = value; }
        }
        
        public void FillGrid()
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                dataGridView1.Rows.Clear();
                var temp1 = db.Pays.Where(x => x.Patient_ID==id);
                List<Pays> payslist = temp1.ToList();
                foreach (Pays cp in payslist)
                {
                    string status = "";
                    if (cp.Status == 1)
                    {
                        status = "Оплачено";
                    }
                    else
                    {
                        status = "Не оплачено";
                    }
                    dataGridView1.Rows.Add(cp.Id, cp.Procedures.TypeOfProcedures.Name, cp.Procedures.DateEventStart, cp.Date, cp.Procedures.TypeOfProcedures.Price, status);   
                }
            }
        }
        public void RefreshFormData()
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                double s = 0;
                double p = 0;
                linkLabel1.Text = db.Patients.Find(id).Name;
                var temp1 = db.Pays.Where(x => x.Patient_ID == id);
                List<Pays> payslistsum = temp1.ToList();
                foreach(Pays q in payslistsum)
                {
                    s = s + Convert.ToDouble(q.Procedures.TypeOfProcedures.Price);
                }
                Sum.Text = Convert.ToString(s);
                var temp2 = db.Pays.Where(x => x.Patient_ID == id && x.Status == 1);
                List<Pays> payslistpaid = temp2.ToList();
                foreach(Pays w in payslistpaid)
                {
                    p = p + Convert.ToDouble(w.Procedures.TypeOfProcedures.Price);
                }
                Paid.Text = Convert.ToString(p);
                debt.Text = Convert.ToString(p - s);
                FillGrid();
            }
        }

        private void Bill_Load(object sender, EventArgs e)
        {
            RefreshFormData();
        }

        private void PayProc_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Pays temp = db.Pays.Find(index);
                temp.Status = 1;
                temp.Date = Convert.ToDateTime(DateTime.Now);
                db.SaveChanges();
            }
            RefreshFormData();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Patients p = db.Patients.Where(x => x.Name == linkLabel1.Text).FirstOrDefault<Patients>();
                PatientCard pc = new PatientCard();
                pc.Currentid = p.Id;
                pc.ShowDialog();
            }
        }
    }
}
