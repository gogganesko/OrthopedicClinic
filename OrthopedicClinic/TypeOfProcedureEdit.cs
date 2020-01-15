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
    public partial class TypeOfProcedureEdit : Form
    {
        public TypeOfProcedureEdit()
        {
            InitializeComponent();
            NameLbl.Validating += NameLbl_Validating;
            KOPcmbx.Validating += KOPcmbx_Validating;
            PriceLbl.Validating += PriceLbl_Validating;
        }

        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            TypeOfProcedures temp = new TypeOfProcedures();
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                if (db.TypeOfProcedures.Find(id) == null)
                {
                    TypeOfProcedures t = new TypeOfProcedures();
                    t.Id = id;
                    t.Name = NameLbl.Text;
                    t.KindOfProcedure_ID = db.KindOfProcedures.Find(KOPcmbx.SelectedIndex + 1).Id;
                    t.Price = Convert.ToDouble(PriceLbl.Text);
                    t.Description = DescLbl.Text;
                    db.TypeOfProcedures.Add(t);
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Ортопедическая клиника!");
                    this.Close();
                }
                else
                {
                    var temp1 = db.TypeOfProcedures.Where(x => x.Id == id).FirstOrDefault<TypeOfProcedures>();
                    temp = temp1;
                    temp.Name = NameLbl.Text;
                    temp.KindOfProcedure_ID = KOPcmbx.SelectedIndex + 1;
                    temp.Price = Convert.ToDouble(PriceLbl.Text);
                    temp.Description = DescLbl.Text;
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Ортопедическая клиника");
                    this.Close();                    
                }
            }
        }

        private void TypeOfProcedureEdit_Load(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                foreach (KindOfProcedures k in db.KindOfProcedures.ToList())
                {
                    KOPcmbx.Items.Add(k.Name);
                }
                if (db.TypeOfProcedures.Find(id) != null)
                {
                    TypeOfProcedures temp = db.TypeOfProcedures.Where(x => x.Id == id).FirstOrDefault<TypeOfProcedures>();
                    NameLbl.Text = temp.Name;
                    KOPcmbx.SelectedIndex = Convert.ToInt16(temp.KindOfProcedure_ID - 1);
                    PriceLbl.Text = Convert.ToString(temp.Price);
                    DescLbl.Text = temp.Description;
                }
                else
                {
                    PriceLbl.Text = "0";
                    SaveBtn.Enabled = false;
                    TypeOfProcedures t = new TypeOfProcedures();
                    t.Id = db.TypeOfProcedures.Count() + 1;
                    Currentid = Convert.ToInt16(t.Id);
                    KOPcmbx.SelectedIndex = 0;
                }
            }
        }

        private void NameLbl_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(NameLbl.Text))
            {
                errorProvider1.SetError(NameLbl, "Не указано название!");
                SaveBtn.Enabled = false;
            }
            else
            {
                errorProvider1.Clear();
                SaveBtn.Enabled = true;
            }
        }

        private void KOPcmbx_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(KOPcmbx.Text))
            {
                errorProvider2.SetError(KOPcmbx, "Не указан вид процедуры!");
                SaveBtn.Enabled = false;
            }
            else
            {
                errorProvider2.Clear();
                SaveBtn.Enabled = true;
            }
        }

        private void PriceLbl_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(PriceLbl.Text))
            {
                errorProvider3.SetError(PriceLbl, "Не указана цена!");
                SaveBtn.Enabled = false;
            }
            else
            {
                errorProvider3.Clear();
                SaveBtn.Enabled = true;
            }
        }

        private void PriceLbl_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
