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
    public partial class ProcedureEdit : Form
    {
        public ProcedureEdit()
        {
            InitializeComponent();
            KinfOfProcedure.Validating += KinfOfProcedure_Validating;
            TypeOfProcedures.Validating += TypeOfProcedures_Validating;
            CabinetCmbx.Validating += CabinetCmbx_Validating;
        }

        private int id;
        public int Currentid
        {
            get { return id; }
            set { id = value; }
        }
        private int feedbackforpat;
        public int PatientID
        {
            get { return feedbackforpat; }
            set { feedbackforpat = value; }
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

        private void FillCmbxs()
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                foreach (KindOfProcedures f in db.KindOfProcedures.Where(x => x.DeleteTime == null ).ToList())
                {
                    KinfOfProcedure.Items.Add(f.Name);
                }
                foreach (TypeOfProcedures p in db.TypeOfProcedures.Where(x => x.DeleteTime == null).ToList())
                {
                    TypeOfProcedures.Items.Add(p.Name);
                }
                foreach (Cabinets c in db.Cabinets.Where(x => x.DeleteTime == null).ToList())
                {
                    CabinetCmbx.Items.Add(c.Name);
                }
            }
        }

        private void FillTypeofProcCmbx(string kindofproc)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                TypeOfProcedures.Items.Clear();
                List<TypeOfProcedures> temp = db.TypeOfProcedures.Where(x => x.KindOfProcedures1.Name == KinfOfProcedure.Text && x.DeleteTime == null).ToList();
                foreach (TypeOfProcedures t in temp)
                {
                    TypeOfProcedures.Items.Add(t.Name);
                }
            }
        }

        private void WorkerAddBtn_Click(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Form1 Form1 = new Form1();
                Form1.Text = "Добавить работника";
                Form1.feedbackid = id;
                Form1.stat = 3;
                Form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Form1.ShowDialog();
                FillListBox();
            }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            Procedures temp = new Procedures();
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                if (db.Procedures.Find(id) == null)
                {
                    Procedures c = new Procedures();
                    c.Id = id;
                    c.Name = NameTxtBx.Text;
                    if (label10.Text != "Выберите")
                    { c.Patient_ID = db.Patients.Where(x => x.Name == label10.Text).FirstOrDefault<Patients>().Id; }
                    c.Description = DescTxtBx.Text;
                    c.DateFact = Convert.ToDateTime(DateFactDTP.Value);
                    TimeSpan tss = TimeStartEventDTP.Value.TimeOfDay;
                    TimeSpan tse = TimeEndEventDTP.Value.TimeOfDay;
                    c.DateEventStart = Convert.ToDateTime(DateEventDTP.Value).Date.Add(tss);
                    c.DateEventEnd = Convert.ToDateTime(DateEventEndDTP.Value).Date.Add(tse);
                    c.KindOfProcedure_ID = db.KindOfProcedures.Where(x => x.Name == KinfOfProcedure.Text).FirstOrDefault<KindOfProcedures>().Id;
                    c.TypeOfProcedure_ID = db.TypeOfProcedures.Where(x => x.Name == TypeOfProcedures.Text).FirstOrDefault<TypeOfProcedures>().Id;
                    c.Cabinet_ID = db.Cabinets.Where(x => x.Name == CabinetCmbx.Text).FirstOrDefault<Cabinets>().Id;
                    if (IsOurCheck.Checked == true)
                    {
                        c.IsOurs = 1;
                    }
                    else
                    {
                        c.IsOurs = 2;
                    }
                    ////////////////////////////////////////////////////////////////////raspisanie/////////////////////////////////////////////////
                    DateTime procstart = Convert.ToDateTime(c.DateEventStart);
                    DateTime procend = Convert.ToDateTime(c.DateEventEnd);
                    TimeSpan dif = procend - procstart; //получим в часах длительность процедуры
                    DateTime procduration = procstart.Add(dif);                     
                    List<WorkerProcedures> workerlist = db.WorkerProcedures.Where(x => x.Procedure_ID == id).ToList();
                    foreach (WorkerProcedures wp in workerlist)
                    {
                        List<WorkingHours> whlist = db.WorkingHours.Where(x => x.Worker_ID == wp.Worker_ID).ToList();
                        WorkingHours wh = whlist.Where(x => Convert.ToDateTime(x.TimeStart).Day == procstart.Day).FirstOrDefault<WorkingHours>();
                        if (wh==null)
                        {
                            MessageBox.Show("Работник:" + " " + wp.Workers.Name + " " + "не работает в этот день, пожалуйста выберите другого!", "Ортопедическая клиника");
                            savebtn.Enabled = false;
                        }
                        else
                        {
                            DateTime whstart = Convert.ToDateTime(wh.TimeStart);
                            DateTime whend = Convert.ToDateTime(wh.TimeEnd);
                            if (procstart >= whstart && procduration <= whend)
                            {
                                List<Procedures> lastlist2 = db.Procedures.Where(x => x.Worker_ID == c.Worker_ID).ToList();
                                List<Procedures> lastlist = lastlist2.Where(x => procstart >= x.DateEventStart && procduration <= x.DateEventEnd).ToList();
                                if (lastlist.Count == 0)
                                {
                                    db.Procedures.Add(c);
                                    Pays p = new Pays();//пробный вариант добавления платежа
                                    p.Id = db.Pays.Count() + 1;
                                    p.Patient_ID = c.Patient_ID;
                                    p.Procedure_ID = c.Id;
                                    db.Pays.Add(p);
                                    db.SaveChanges();
                                    MessageBox.Show("Сохранение успешно", "Ортопедическая клиника!");
                                    this.Close();
                                }
                                else
                                {
                                    foreach (Procedures p in lastlist)
                                    {
                                        DateTime pstart = Convert.ToDateTime(p.DateEventStart);
                                        DateTime pend = Convert.ToDateTime(p.DateEventEnd);
                                        if (procstart >= pstart && procduration <= pend)
                                        {
                                            MessageBox.Show("Врач занят в это время");
                                        }
                                        else
                                        {
                                            db.Procedures.Add(c);
                                            Pays q = new Pays();//пробный вариант добавления платежа
                                            q.Id = db.Pays.Count() + 1;
                                            q.Patient_ID = c.Patient_ID;
                                            q.Procedure_ID = c.Id;
                                            db.Pays.Add(q);
                                            db.SaveChanges();
                                            MessageBox.Show("Сохранение успешно", "Ортопедическая клиника!");
                                            this.Close();
                                        }
                                    }                                    
                                }
                                
                            }
                            else
                            {
                                MessageBox.Show("Работник:" + " " + wp.Workers.Name + " " + "не работает в это время, пожалуйста выберите другого!", "Ортопедическая клиника");
                                savebtn.Enabled = false;
                            }
                        }                                                    
                    }
                    //db.Procedures.Add(c);
                    //Pays p = new Pays();//пробный вариант добавления платежа
                    //p.Id = db.Pays.Count() + 1;
                    //p.Patient_ID = c.Patient_ID;
                    //p.Procedure_ID = c.Id;                    
                    //db.Pays.Add(p);
                    //db.SaveChanges();
                    //MessageBox.Show("Сохранение успешно", "Ортопедическая клиника!");
                    //this.Close();
                }
                else
                {
                    var temp1 = db.Procedures.Where(x => x.Id == id).FirstOrDefault<Procedures>();
                    temp = temp1;
                    temp.Name = NameTxtBx.Text;
                    temp.Patient_ID = db.Patients.Where(x => x.Name == label10.Text).FirstOrDefault<Patients>().Id;
                    temp.Description = DescTxtBx.Text;
                    temp.DateFact = Convert.ToDateTime(DateFactDTP.Value);
                    TimeSpan tss = TimeStartEventDTP.Value.TimeOfDay;
                    TimeSpan tse = TimeEndEventDTP.Value.TimeOfDay;
                    temp.DateEventStart = Convert.ToDateTime(DateEventDTP.Value).Date.Add(tss);
                    temp.DateEventEnd = Convert.ToDateTime(DateEventEndDTP.Value).Date.Add(tse);
                    temp.KindOfProcedure_ID = db.KindOfProcedures.Where(x => x.Name == KinfOfProcedure.Text).FirstOrDefault<KindOfProcedures>().Id;
                    temp.TypeOfProcedure_ID = db.TypeOfProcedures.Where(x => x.Name == TypeOfProcedures.Text).FirstOrDefault<TypeOfProcedures>().Id;
                    temp.Cabinet_ID = db.Cabinets.Where(x => x.Name == CabinetCmbx.Text).FirstOrDefault<Cabinets>().Id;
                    if (IsOurCheck.Checked == true)
                    {
                        temp.IsOurs = 1;
                    }
                    else
                    {
                        temp.IsOurs = 2;
                    }
                    db.SaveChanges();
                    MessageBox.Show("Сохранение успешно", "Ортопедическая клиника");
                    this.Close();
                }
            }
        }

        private void ProcedureEdit_Load(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                FillCmbxs();
                if (db.Procedures.Find(id) != null)
                {                    
                    Procedures temp = db.Procedures.Where(x => x.Id == id).FirstOrDefault<Procedures>();
                    NameTxtBx.Text = temp.Name;
                    label10.Text = temp.Patients.Name;
                    DescTxtBx.Text = temp.Description;
                    DateFactDTP.Value = Convert.ToDateTime(temp.DateFact.Value);
                    DateEventDTP.Value = Convert.ToDateTime(temp.DateEventStart.Value);
                    TimeStartEventDTP.Value = Convert.ToDateTime(temp.DateEventStart.Value);
                    DateEventEndDTP.Value = Convert.ToDateTime(temp.DateEventEnd.Value);
                    TimeEndEventDTP.Value = Convert.ToDateTime(temp.DateEventEnd.Value);
                    KinfOfProcedure.Text = temp.KindOfProcedures.Name;
                    TypeOfProcedures.Text = temp.TypeOfProcedures.Name;
                    CabinetCmbx.Text = temp.Cabinets.Name;
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
                else
                {
                    KinfOfProcedure.SelectedIndex = 0;
                    TypeOfProcedures.SelectedIndex = 0;
                    CabinetCmbx.SelectedIndex = 0;
                    savebtn.Enabled = false;
                    Procedures c = new Procedures();
                    c.Id = db.Procedures.Count() + 1;
                    Currentid = Convert.ToInt16(c.Id);
                }
            }
        }

        private void WorkerDelBtn_Click(object sender, EventArgs e)
        {
            //int index = Convert.ToInt32(this.listBox1.SelectedIndex);
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Workers w = db.Workers.Where(x => x.Name == listBox1.SelectedItem.ToString()).FirstOrDefault<Workers>();
                WorkerProcedures cp = db.WorkerProcedures.Where(x => x.Procedure_ID == id && x.Worker_ID==w.Id).FirstOrDefault<WorkerProcedures>(); ;
                db.WorkerProcedures.Remove(cp);
                db.SaveChanges();
                FillListBox();
            }
        }

        private void AddPatient_Click(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Form1 Form1 = new Form1();
                Form1.Text = "Добавить пациента";
                Form1.feedbackid = id;
                Form1.stat = 4;
                Form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                Form1.ShowDialog();
                label10.Text = db.Patients.Find(Form1.choosenid).Name;
            }
        }

        private void FileAddBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string str = dialog.FileName;
                listBox2.Items.Add(str);
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    FilesProcedures fp = new FilesProcedures();
                    fp.Procedure_ID = id;
                    fp.Path = str;
                    db.FilesProcedures.Add(fp);
                    db.SaveChanges();
                }
            }
            FillFilesListBox();            
        }

        private void listBox2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.listBox2.IndexFromPoint(e.Location);            
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                Process.Start(listBox2.SelectedItem.ToString());
            }
        }

        private void FileDelBtn_Click(object sender, EventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                FilesProcedures fp = db.FilesProcedures.Where(x => x.Procedure_ID == id && x.Path == listBox2.SelectedItem.ToString()).FirstOrDefault<FilesProcedures>();
                db.FilesProcedures.Remove(fp);
                db.SaveChanges();
                FillFilesListBox();
            }
        }
        private void KinfOfProcedure_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(KinfOfProcedure.Text))
            {
                errorProvider3.SetError(KinfOfProcedure, "Не указан вид процедуры!");
                savebtn.Enabled = false;
            }
            else
            {
                errorProvider3.Clear();
                savebtn.Enabled = true;
            }
        }

        private void TypeOfProcedures_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(TypeOfProcedures.Text))
            {
                errorProvider4.SetError(TypeOfProcedures, "Не указан тип процедуры!");
                savebtn.Enabled = false;
            }
            else
            {
                errorProvider4.Clear();
                savebtn.Enabled = true;
            }
        }

        private void CabinetCmbx_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(CabinetCmbx.Text))
            {
                errorProvider5.SetError(CabinetCmbx, "Не указан кабинет!");
                savebtn.Enabled = false;
            }
            else
            {
                errorProvider5.Clear();
                savebtn.Enabled = true;
            }
        }

        private void ProcedureEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                if (db.Procedures.Find(id) == null)
                {
                    var temp1 = db.WorkerProcedures.Where(x => x.DeleteTime == null && x.Procedure_ID == id);
                    List<WorkerProcedures> vplist = temp1.ToList();
                    if (listBox1.Items.Count != 0)
                    {
                        foreach (WorkerProcedures vp in vplist)
                        {
                            db.WorkerProcedures.Remove(vp);                            
                            db.SaveChanges();
                        }
                    }
                    var temp2 = db.FilesProcedures.Where(x => x.Procedure_ID == id);
                    List<FilesProcedures> fp = temp2.ToList();
                    if (listBox2.Items.Count != 0)
                    {
                        foreach (FilesProcedures f in fp)
                        {
                            db.FilesProcedures.Remove(f);
                            db.SaveChanges();
                        }
                    }
                }
            }
        }

        private void KinfOfProcedure_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillTypeofProcCmbx(KinfOfProcedure.Text);
        }
    }
}
