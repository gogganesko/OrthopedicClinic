using System;
using System.Diagnostics;
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
    public partial class ProcedureCard : Form
    {
        public ProcedureCard()
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
                var temp1 = db.WorkerProcedures.Where(x => x.DeleteTime == null && x.Procedure_ID == id);
                List<WorkerProcedures> procedurelist = temp1.ToList();
                foreach (WorkerProcedures wp in procedurelist)
                {
                    listBox1.Items.Add(wp.Workers.Name);
                }
            }
        }
        private void FillFilesListBox()
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                listBox2.Items.Clear();
                var temp1 = db.FilesProcedures.Where(x => x.Procedure_ID == id);
                List<FilesProcedures> procedurelist = temp1.ToList();
                foreach (FilesProcedures wp in procedurelist)
                {
                    listBox2.Items.Add(wp.Path);
                }
            }
        }

        private void RefreshFormData(int id)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Procedures temp = db.Procedures.Where(x => x.Id == id).FirstOrDefault<Procedures>();
                NameLbl.Text = temp.Name;
                DescLbl.Text = temp.Description;
                PatientLnkLbl.Text = temp.Patients.Name;
                DateFactDTP.Value = Convert.ToDateTime(temp.DateFact);
                DateEventDTP.Value = Convert.ToDateTime(temp.DateEventStart);
                dateTimePicker1.Value = Convert.ToDateTime(temp.DateEventEnd);
                TimeStartDTP.Value = Convert.ToDateTime(temp.DateEventStart);
                TimeEndDTP.Value = Convert.ToDateTime(temp.DateEventEnd);
                KOPLbl.Text = temp.KindOfProcedures.Name;
                TOPLkLbl.Text = temp.TypeOfProcedures.Name;
                CabinetLkLbl.Text = temp.Cabinets.Name;
                if (temp.IsOurs == 1)
                {
                    IsOurCheck.Checked = true;
                }
                else
                {
                    IsOurCheck.Checked = false;
                }
                FillListBox();
                FillFilesListBox();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            ProcedureEdit c = new ProcedureEdit();
            c.Currentid = id;
            c.ShowDialog();
            RefreshFormData(id);
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Procedures c = db.Procedures.Where(x => x.Id == id).FirstOrDefault<Procedures>();
                c.DeleteTime = DateTime.Now;
                MessageBox.Show("Процедура успешно удалена!", "Ортопедическая клиника");
                db.SaveChanges();
                this.Close();
            }
        }
        private void ProcedureCard_Load(object sender, EventArgs e)
        {
            RefreshFormData(this.id);
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox2.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Process.Start(listBox2.SelectedItem.ToString());
            }
        }

        private void PatientLnkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Patients p = db.Patients.Where(x => x.Name == PatientLnkLbl.Text).FirstOrDefault<Patients>();
                PatientCard pc = new PatientCard();
                pc.Currentid = p.Id;
                pc.ShowDialog();
            }
        }

        private void TOPLkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                TypeOfProcedures top = db.TypeOfProcedures.Where(x => x.Name == TOPLkLbl.Text).FirstOrDefault<TypeOfProcedures>();
                TypeOfProcedureCard topc = new TypeOfProcedureCard();
                topc.Currentid = top.Id;
                topc.ShowDialog();
            }
        }

        private void CabinetLkLbl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Cabinets c = db.Cabinets.Where(x => x.Name == CabinetLkLbl.Text).FirstOrDefault<Cabinets>();
                CabinetCard cc = new CabinetCard();
                cc.Currentid = c.Id;
                cc.ShowDialog();             
            }
        }
    }
}
