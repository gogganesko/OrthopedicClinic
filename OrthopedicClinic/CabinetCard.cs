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
    public partial class CabinetCard : Form
    {
        public CabinetCard()
        {
            InitializeComponent();
        }
        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }

        public void FillGrid()
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                dataGridView7.Rows.Clear();
                var temp1 = db.CabinetProcedures.Where(x => x.DeleteTime == null && x.Cabinet_ID == id);
                List<CabinetProcedures> procedurelist = temp1.ToList();
                foreach (CabinetProcedures cp in procedurelist)
                {
                    dataGridView7.Rows.Add(cp.ProcedureType_ID, cp.TypeOfProcedures.Name, cp.TypeOfProcedures.KindOfProcedures1.Name, cp.TypeOfProcedures.Price);
                }
            }
        }
        private void RefreshFormData(int id)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Cabinets temp = db.Cabinets.Where(x => x.Id == id).FirstOrDefault<Cabinets>();
                CabinetNameLbl.Text = temp.Name;
                DescriptionLbl.Text = temp.Description;
            }
            FillGrid();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            CabinetEdit c = new CabinetEdit();
            c.Currentid = id;
            c.ShowDialog();
            RefreshFormData(id);
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Cabinets c = db.Cabinets.Where(x => x.Id == id).FirstOrDefault<Cabinets>();
                c.DeleteTime = DateTime.Now;
                MessageBox.Show("Кабинет успешно удален!", "Ортопедическая клиника");
                db.SaveChanges();
                this.Close();
            }
        }

        private void CabinetCard_Load(object sender, EventArgs e)
        {
            RefreshFormData(this.id);
        }

        private void ScheduleChckBtn_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.feedbackid = this.id;
            f.stat = 10;
            f.ShowDialog();
        }

        private void dataGridView7_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TypeOfProcedureCard tpcard = new TypeOfProcedureCard();
            int id = Convert.ToInt32(this.dataGridView7.CurrentRow.Cells[0].Value);
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                TypeOfProcedures t = db.TypeOfProcedures.Find(id);
                tpcard.Currentid = id;
                tpcard.ShowDialog();
                FillGrid();
            }
        }
    }
}
