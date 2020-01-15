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
    public partial class CabinetEdit : Form
    {
        public CabinetEdit()
        {
            InitializeComponent();
            NameTxtBx.Validating += NameTxtBx_Validating;
            DescTxtBx.Validating += DescTxtBx_Validating;

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
        private void SaveBtn_Click(object sender, EventArgs e)
        {                        
            Cabinets temp = new Cabinets();
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                if (db.Cabinets.Find(id) == null)
                {
                    Cabinets c = new Cabinets();
                    c.Id = id;
                    c.Name = NameTxtBx.Text;
                    c.Description = DescTxtBx.Text;
                    db.Cabinets.Add(c);
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Ортопедическая клиника!");
                    this.Close();
                }
                else
                {
                    var temp1 = db.Cabinets.Where(x => x.Id == id).FirstOrDefault<Cabinets>();
                    temp = temp1;
                    temp.Name = NameTxtBx.Text;
                    temp.Description = DescTxtBx.Text;
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Ортопедическая клиника");
                    this.Close();
                }
            }
        }

        private void CabinetEdit_Load(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                if (db.Cabinets.Find(id) != null)
                {
                    Cabinets temp = db.Cabinets.Where(x => x.Id == id).FirstOrDefault<Cabinets>();
                    NameTxtBx.Text = temp.Name;
                    DescTxtBx.Text = temp.Description;
                    FillGrid();
                }
                else
                {
                    SaveBtn.Enabled = false;
                    Cabinets c = new Cabinets();
                    c.Id = db.Cabinets.Count()+1;
                    Currentid = Convert.ToInt16(c.Id);
                }
            }
        }

        private void AddCabProc_Click(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Form1 Form1 = new Form1();
                Form1.Text = "Добавить процедуру";
                Form1.feedbackid = id;
                Form1.stat = 2;
                Form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Form1.ShowDialog();
                FillGrid();
            }
        }

        private void DelCabProc_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(this.dataGridView7.CurrentRow.Cells[0].Value);
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                CabinetProcedures cp = db.CabinetProcedures.Where(x => x.Cabinet_ID == id && x.ProcedureType_ID ==index ).FirstOrDefault<CabinetProcedures>(); ;
                db.CabinetProcedures.Remove(cp);
                db.SaveChanges();
                FillGrid();
            }
        }

        private void NameTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(NameTxtBx.Text))
            {
                errorProvider1.SetError(NameTxtBx, "Не указан номер!");
                SaveBtn.Enabled = false;
            }            
            else
            {
                errorProvider1.Clear();
                SaveBtn.Enabled = true;
            }
        }

        private void DescTxtBx_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(DescTxtBx.Text))
            {
                errorProvider2.SetError(DescTxtBx, "Не указано описание!");
                SaveBtn.Enabled = false;
            }
            else
            {
                errorProvider2.Clear();
                SaveBtn.Enabled = true;
            }
        }

        private void CabinetEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                if (db.Cabinets.Find(id) == null)
                {
                    var temp1 = db.CabinetProcedures.Where(x => x.DeleteTime == null && x.Cabinet_ID == id);
                    List<CabinetProcedures> vplist = temp1.ToList();
                    if (dataGridView7.RowCount != 0)
                    {
                        foreach (CabinetProcedures vp in vplist)
                        {
                            db.CabinetProcedures.Remove(vp);
                            db.SaveChanges();
                        }
                    }
                }
            }
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
