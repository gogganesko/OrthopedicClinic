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
    public partial class Authoriz : Form
    {
        public Authoriz()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Workers temp = db.Workers.Where(x => x.Login == LoginTxtBx.Text && x.Password == PswrdTxtBx.Text).FirstOrDefault<Workers>();
                if (temp != null)
                {
                    this.Hide();
                    Form1 f = new Form1();
                    f.stat = 1;
                    f.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль!", "Ортопедическая клиника");
                }
            }
        }

        private void ForgotPasswordLnkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Пожалуйста, обратитесь к системному администратору!", "Ортопедическая клиника");
        }
    }
}
