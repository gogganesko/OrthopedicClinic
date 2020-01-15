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
    public partial class WorkerEdit : Form
    {
        public WorkerEdit()
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
                listBox2.Items.Clear();
                var temp1 = db.WorkerTypeOfProcedures.Where(x => x.DeleteTime == null && x.Worker_ID == id);
                List<WorkerTypeOfProcedures> wtop = temp1.ToList();
                foreach (WorkerTypeOfProcedures w in wtop)
                {
                    listBox2.Items.Add(w.TypeOfProcedures.Name);
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Workers temp = new Workers();
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                if (db.Workers.Find(id) == null)
                {
                    Workers w = new Workers();
                    w.Id = id;
                    w.Name = NameLbl.Text;
                    w.Specialization = SpecializationLbl.Text;
                    w.TelephoneNumber = TelephoneNmbrLbl.Text;
                    db.Workers.Add(w);
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Ортопедическая клиника!");
                    this.Close();
                }
                else
                {
                    var temp1 = db.Workers.Where(x => x.Id == id).FirstOrDefault<Workers>();
                    temp = temp1;
                    temp.Name = NameLbl.Text;
                    temp.Specialization = SpecializationLbl.Text;
                    temp.TelephoneNumber = TelephoneNmbrLbl.Text;
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Ортопедическая клиника");
                    this.Close();
                }
            }
        }

        private void WorkerEdit_Load(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                FillListBox();
                if (db.Workers.Find(id) != null)
                {
                    Workers temp = db.Workers.Where(x => x.Id == id).FirstOrDefault<Workers>();
                    NameLbl.Text = temp.Name;
                    SpecializationLbl.Text = temp.Specialization;
                    TelephoneNmbrLbl.Text = temp.TelephoneNumber;
                    FillListBox();        
                }
                else
                {
                    Workers w = new Workers();
                    w.Id = db.Workers.Count() + 1;
                    Currentid = Convert.ToInt16(w.Id);
                }
            }
        }

        private void AddProcedure_Click(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Form1 Form1 = new Form1();
                Form1.Text = "Добавить процедуру";
                Form1.feedbackid = id;
                Form1.stat = 5;
                Form1.ShowDialog();
                FillListBox();
            }
        }

        private void DelProcedure_Click(object sender, EventArgs e)
        {
            //int index = Convert.ToInt32(this.listBox2.SelectedIndex);
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                string typename = listBox2.SelectedItem.ToString();
                TypeOfProcedures tp = db.TypeOfProcedures.Where(x => x.Name == typename).FirstOrDefault<TypeOfProcedures>();
                WorkerTypeOfProcedures cp = db.WorkerTypeOfProcedures.Where(x => x.Worker_ID == id && x.TypeOfProcedure_ID == tp.Id ).FirstOrDefault<WorkerTypeOfProcedures>(); ;
                db.WorkerTypeOfProcedures.Remove(cp);
                db.SaveChanges();
                FillListBox();
            }
        }

        private void NameLbl_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(NameLbl.Text))
            {
                errorProvider1.SetError(NameLbl, "Не указано ФИО!");
                SaveBtn.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                SaveBtn.Enabled = true;
            }
        }

        private void SpecializationLbl_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(SpecializationLbl.Text))
            {
                errorProvider2.SetError(SpecializationLbl, "Не указана специализация!");
                SaveBtn.Enabled = false;
            }
            else
            {
                errorProvider2.Clear();
                SaveBtn.Enabled = true;
            }
        }

        private void TelephoneNmbrLbl_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(TelephoneNmbrLbl.Text))
            {
                errorProvider3.SetError(TelephoneNmbrLbl, "Не указан номер телефона!");
                SaveBtn.Enabled = false;
            }
            else
            {
                errorProvider3.Clear();
                SaveBtn.Enabled = true;
            }
        }

        private void WorkerEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                if (db.Workers.Find(id) == null)
                {                  
                    var temp2 = db.WorkerTypeOfProcedures.Where(x => x.DeleteTime == null && x.Worker_ID == id);
                    List<WorkerTypeOfProcedures> vpslist = temp2.ToList();
                    if (listBox2.Items.Count != 0)
                    {
                        foreach (WorkerTypeOfProcedures tpd in vpslist)
                        {
                            db.WorkerTypeOfProcedures.Remove(tpd);
                            db.SaveChanges();
                        }
                    }
                }
            }
        }
    }
}
