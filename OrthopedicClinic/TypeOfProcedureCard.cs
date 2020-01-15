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
    public partial class TypeOfProcedureCard : Form
    {
        public TypeOfProcedureCard()
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
                TypeOfProcedures temp = db.TypeOfProcedures.Where(x => x.Id == id).FirstOrDefault<TypeOfProcedures>();
                NameLbl.Text = temp.Name;
                KOP.Text = db.KindOfProcedures.Find(temp.KindOfProcedure_ID).Name;
                PriceLbl.Text = Convert.ToString(temp.Price);
                DescTxtBox.Text = temp.Description;
            }
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            TypeOfProcedureEdit t = new TypeOfProcedureEdit();
            t.Currentid = id;
            t.ShowDialog();
            RefreshFormData(id);           
        }
        private void DelBtn_Click(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                TypeOfProcedures t = db.TypeOfProcedures.Where(x => x.Id == id).FirstOrDefault<TypeOfProcedures>();
                t.DeleteTime = DateTime.Now;
                MessageBox.Show("Тип процедур успешно удален!", "Ортопедическая клиника");
                db.SaveChanges();
                this.Close();
            }
        }

        private void TypeOfProcedureCard_Load(object sender, EventArgs e)
        {
            RefreshFormData(this.id);
        }
    }
}
