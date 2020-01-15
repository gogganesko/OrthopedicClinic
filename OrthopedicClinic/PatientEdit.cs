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
    public partial class PatientEdit : Form
    {
        public PatientEdit()
        {
            InitializeComponent();
            textBox2.Validating += textBox2_Validating;
            textBox3.Validating += textBox3_Validating;
            textBox4.Validating += textBox4_Validating;
            textBox5.Validating += textBox5_Validating; 
        }

        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Patients temp = new Patients();
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                if (db.Patients.Find(id) == null)
                {
                    Patients p = new Patients();
                    p.Id = id;
                    p.Name = textBox2.Text;
                    p.TelephoneNumber = textBox3.Text;
                    p.Height = Convert.ToDouble(textBox4.Text);
                    p.Weight = Convert.ToDouble(textBox5.Text);
                    p.Comment = textBox1.Text;
                    db.Patients.Add(p);
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Ортопедическая клиника!");
                    this.Close();
                }
                else
                {
                    var temp1 = db.Patients.Where(x => x.Id == id).FirstOrDefault<Patients>();
                    temp = temp1;
                    temp.Name = textBox2.Text;
                    temp.TelephoneNumber = textBox3.Text;
                    temp.Height = Convert.ToDouble(textBox4.Text);
                    temp.Weight = Convert.ToDouble(textBox5.Text);
                    temp.Comment = textBox1.Text;
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Ортопедическая клиника");
                    this.Close();
                }
            }
        }

        private void PatientEdit_Load(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                if (db.Patients.Find(id) != null)
                {
                    Patients temp = db.Patients.Where(x => x.Id == id).FirstOrDefault<Patients>();
                    textBox2.Text = temp.Name;
                    textBox3.Text = temp.TelephoneNumber;
                    textBox4.Text = Convert.ToString(temp.Height);
                    textBox5.Text = Convert.ToString(temp.Weight);
                    textBox1.Text = temp.Comment;                                        
                }
                else
                {
                    SaveBtn.Enabled = false;
                    Patients p = new Patients();
                    p.Id = db.Patients.Count() + 1;
                    Currentid = Convert.ToInt16(p.Id);
                }
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                errorProvider1.SetError(textBox2, "Не указано ФИО!");
                SaveBtn.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                SaveBtn.Enabled = true;
            }
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                errorProvider2.SetError(textBox3, "Не указан номер телефона!");
                SaveBtn.Enabled = false;
            }
            else
            {
                errorProvider2.Clear();
                SaveBtn.Enabled = true;
            }
        }

        private void textBox4_Validating(object sender, CancelEventArgs e)
        {

            if (String.IsNullOrEmpty(textBox4.Text))
            {
                errorProvider3.SetError(textBox4, "Не указан рост!");
                SaveBtn.Enabled = false;
            }
            else
            {
                errorProvider3.Clear();
                SaveBtn.Enabled = true;
            }
        }

        private void textBox5_Validating(object sender, CancelEventArgs e)
        {

            if (String.IsNullOrEmpty(textBox5.Text))
            {
                errorProvider4.SetError(textBox5, "Не указан вес!");
                SaveBtn.Enabled = false;
            }
            else
            {
                errorProvider4.Clear();
                SaveBtn.Enabled = true;
            }
        }
    }
}
