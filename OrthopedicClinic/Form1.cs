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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }      
        private int Status;
        public int stat
        {
            get { return Status; }
            set { Status = value; }
        }

        private int backid; //для родительских форм
        public int feedbackid //для родительских форм
        {
            get { return backid; }
            set { backid = value; }
        }

        private int chid;

        public int choosenid//для родительских форм
        {
            get { return chid; }
            set { chid = value; }
        }

        private int currentpage;
        private int maxpage;
        private int currentcountonpage=10;
        public void CheckCurrentFormStatus(int status) //1 - obichnaya rabota s formoi 2 - dobavlenie cabinetu typa proceduri 3 - dobavlenie rabotnika 4 - dobavlenie pacienta 5 - dobavlenie workeru tipa proced
        {//6 - dobavlenie planu lecheniya proceduri 7 - dobavlenie diagnoza k treatmentplanu 8-dobavlenie pacienta k vizitu 9 - dobavlenie pacienta k diagnozu 10 - proceduri cabineta 11 - proc pacienta
            switch (Status)// 12 - workinghoursrabotnika 13 - proceduri rabotnika 14 - treatmentsplanrabotnika
            {
                case 1:
                    currentpage = 1;                    
                    FillGridWithVisits(currentpage, currentcountonpage);
                    button7.Enabled = false;
                    label3.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button8.Enabled = false; }
                    else
                    { button8.Enabled = true; }
                    break;
                case 2:
                    FillGridWithTypeOfProcedures(currentpage, currentcountonpage);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage10);
                   // button20.Visible = false;
                    //button21.Visible = false;
                    //label41.Visible = false;
                    AddTypeOfProcedureBtn.Visible = false;
                   // groupBox7.Visible = false;
                    break;
                case 3:
                    FillGridWithWorkers(currentpage, currentcountonpage);
                    tabControl1.TabPages.Remove(tabPage7);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage10);
                    //button2.Visible = false;
                    //button3.Visible = false;
                    //label1.Visible = false;
                    AddWorkerBtn.Visible = false;
                    //groupBox1.Visible = false;
                    break;
                case 4:
                    FillGridWithPatients(currentpage, currentcountonpage);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage7);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage10);
                    //button4.Visible = false;
                    //button5.Visible = false;
                    PatientAddBtn.Visible = false;
                   // label2.Visible = false;
                    //groupBox2.Visible = false;
                    break;
                case 5:
                    FillGridWithTypeOfProcedures(currentpage, currentcountonpage);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage10);
                   // button20.Visible = false;
                   // button21.Visible = false;
                   // label41.Visible = false;
                    AddTypeOfProcedureBtn.Visible = false;
                   // groupBox7.Visible = false;
                    break;
                case 6:
                    FillGridWithTypeOfProcedures(currentpage, currentcountonpage);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage10);
                    //button20.Visible = false;
                    //button21.Visible = false;
                    //label41.Visible = false;
                    AddTypeOfProcedureBtn.Visible = false;
                    //groupBox7.Visible = false;
                    break;
                case 7:
                    FillGridWithDiagnosises(currentpage, currentcountonpage);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Remove(tabPage7);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage10);
                    //button35.Visible = false;
                    //button36.Visible = false;
                    //label51.Visible = false;
                    AddDiagnosisBtn.Visible = false;
                  // groupBox9.Visible = false;
                    break;
                case 8:
                    FillGridWithPatients(currentpage, currentcountonpage);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage7);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage10);
                    //button4.Visible = false;
                   // button5.Visible = false;
                    PatientAddBtn.Visible = false;
                   // label2.Visible = false;
                   // groupBox2.Visible = false;
                    break;
                case 9:
                    FillGridWithPatients(currentpage, currentcountonpage);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage7);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage10);
                    //button4.Visible = false;
                    //button5.Visible = false;
                    PatientAddBtn.Visible = false;
                   // label2.Visible = false;
                    //groupBox2.Visible = false;
                    break;
                case 10:
                    FillGrifWithProceduresForCab(backid, currentpage,currentcountonpage);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage7);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage10);                    
                    button14.Visible = false;
                    button15.Visible = false;
                    AddProcedureBtn.Visible = false;
                    label5.Visible = false;
                    groupBox5.Visible = false;
                    numericUpDown1.Visible = false;
                    label11.Visible = false;
                    break;
                case 11:
                    FillGrifWithProceduresForPac(backid);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage7);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage10);
                    button14.Visible = false;
                    button15.Visible = false;
                    AddProcedureBtn.Visible = false;
                    label5.Visible = false;
                    groupBox5.Visible = false;
                    numericUpDown1.Visible = false;
                    label11.Visible = false;
                    break;
                case 12:
                    FillGridWithWorkingHoursForWorker(backid);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage7);
                    button18.Visible = false;
                    button25.Visible = false;
                    AddWorkingHourBtn.Visible = false;
                    label29.Visible = false;
                    groupBox10.Visible = false;
                    numericUpDown1.Visible = false;
                    label11.Visible = false;
                    break;
                case 13:
                    FillGrifWithProceduresForWorker(backid);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage7);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage9);
                    tabControl1.TabPages.Remove(tabPage10);
                    button14.Visible = false;
                    button15.Visible = false;
                    AddProcedureBtn.Visible = false;
                    label5.Visible = false;
                    groupBox5.Visible = false;
                    numericUpDown1.Visible = false;
                    label11.Visible = false;
                    break;
                case 14:
                    FillGridWithTreatMentPlansForWorker(backid);
                    tabControl1.TabPages.Remove(tabPage1);
                    tabControl1.TabPages.Remove(tabPage2);
                    tabControl1.TabPages.Remove(tabPage3);
                    tabControl1.TabPages.Remove(tabPage4);
                    tabControl1.TabPages.Remove(tabPage5);
                    tabControl1.TabPages.Remove(tabPage6);
                    tabControl1.TabPages.Remove(tabPage7);
                    tabControl1.TabPages.Remove(tabPage8);
                    tabControl1.TabPages.Remove(tabPage10);
                    button31.Visible = false;
                    button32.Visible = false;
                    AddTreatmentPlanBtn.Visible = false;
                    label47.Visible = false;
                    groupBox8.Visible = false;
                    numericUpDown1.Visible = false;
                    label11.Visible = false;
                    break;
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedTab.Text)
            {
                case "Пациенты":
                    currentpage = 1;
                    FillGridWithPatients(currentpage, currentcountonpage);                    
                    button4.Enabled = false;
                    label2.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button5.Enabled = false; }
                    else
                    { button5.Enabled = true; }
                    break;
                case "Процедуры":
                    currentpage = 1;
                    FillGridWithProcedures(currentpage, currentcountonpage);
                    FillWorkerCmbx(comboBox3);                    
                    button14.Enabled = false;
                    label5.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button15.Enabled = false; }
                    else
                    { button15.Enabled = true; }
                    break;
                case "Врачи":
                    currentpage = 1;
                    FillGridWithWorkers(currentpage, currentcountonpage);
                    FillWorkerCmbx(comboBox5);
                    BuildSpecializationCbmx();                    
                    button2.Enabled = false; //запрещаем листать назад т.к. страница и так первая
                    label1.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage==maxpage)
                    { button3.Enabled = false; }
                    else
                    { button3.Enabled = true; }
                    break;
                case "Диагнозы":
                    currentpage = 1;
                    FillGridWithDiagnosises(currentpage, currentcountonpage);
                    FillWorkerCmbx(comboBox9);
                    button35.Enabled = false;
                    label51.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button36.Enabled = false; }
                    else
                    { button36.Enabled = true; }
                    break;
                case "Кабинеты":
                    currentpage = 1;
                    FillGridWithCabinets(currentpage, currentcountonpage);                   
                    button11.Enabled = false;
                    label4.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button10.Enabled = false; }
                    else
                    { button10.Enabled = true; }
                    break;
                case "Режим работы":
                    currentpage = 1;
                    FillWorkerCmbx(comboBox6);
                    FillGridWithWorkingHours(currentpage, currentcountonpage);                    
                    button18.Enabled = false;
                    label29.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button25.Enabled = false; }
                    else
                    { button25.Enabled = true; }
                    break;
                case "Планы лечения":
                    currentpage = 1;
                    FillGridWithTreatMentPlans(currentpage, currentcountonpage);
                    FillWorkerCmbx(comboBox8);                    
                    button31.Enabled = false;
                    label47.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button32.Enabled = false; }
                    else
                    { button32.Enabled = true; }
                    break;
                case "Приёмы":
                    currentpage = 1;
                    FillGridWithVisits(currentpage, currentcountonpage);                    
                    button7.Enabled = false;
                    label3.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button8.Enabled = false; }
                    else
                    { button8.Enabled = true; }
                    break;
                case "Типы процедур":
                    currentpage = 1;
                    FillGridWithTypeOfProcedures(currentpage, currentcountonpage);
                    BuildKindOfProcCmbx();                    
                    button20.Enabled = false;
                    label41.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button21.Enabled = false; }
                    else
                    { button21.Enabled = true; }
                    break;
                case "Статистика":
                    FillChartCmbx();
                    FillWorkerCmbx(comboBox6);
                    button16.Enabled = false;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {           
            CheckCurrentFormStatus(stat);
            numericUpDown1.Value = 10;
        }
        /////////////////////////////////////////////////////////////////////////////////////RABOTASPACIENTAMI//////////////////////////////////////////////////////////////////////////
        private void FillGridWithPatients(int page, int countonpage)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                dataGridView2.Rows.Clear();
                var temp1 = db.Patients.Where(x => x.DeleteTime == null);
                List<Patients> patientlist = temp1.ToList();
                maxpage = patientlist.Count() / countonpage;
                if(patientlist.Count() % countonpage != 0)
                {
                    maxpage++;
                }               
                foreach (Patients p in patientlist.Skip((page - 1) * countonpage).Take(countonpage))
                {
                    dataGridView2.Rows.Add(p.Id, p.Name, p.TelephoneNumber);
                }

            }
        }

        private void FillGrifWithProceduresForPac(int pacid)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                dataGridView5.Rows.Clear();
                var temp1 = db.Procedures.Where(x => x.DeleteTime == null && x.Patient_ID == pacid);
                List<Procedures> cabinetlist = temp1.ToList();
                foreach (Procedures c in cabinetlist)
                {
                    dataGridView5.Rows.Add(c.Id, Convert.ToString(c.DateEventStart), c.TypeOfProcedures.Name, c.TypeOfProcedures.Price);
                }
            }
        }

        private void PatientAddBtn_Click(object sender, EventArgs e)
        {
            PatientEdit patientedit = new PatientEdit();            
            patientedit.ShowDialog();
            FillGridWithPatients(currentpage, currentcountonpage);
            label2.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
            if (currentpage == maxpage)
            { button5.Enabled = false; }
            else
            { button5.Enabled = true; }
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (stat == 1)
            {
                PatientCard Patientcard = new PatientCard();
                int id = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value);
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    Patients p = db.Patients.Find(id);
                    Patientcard.Currentid = id;
                    Patientcard.ShowDialog();
                    FillGridWithPatients(currentpage, currentcountonpage);
                    label2.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button5.Enabled = false; }
                    else
                    { button5.Enabled = true; }
                }
            }
            if (stat == 4)
            {                
                chid = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value);
                this.Close();
            }
            if (stat == 8)
            {
                chid = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value);
                this.Close();
            }
            if (stat == 9)
            {
                chid = Convert.ToInt32(this.dataGridView2.CurrentRow.Cells[0].Value);
                this.Close();
            }
        }
        ////////////////////////////////////////////////////////////////////RABOTASVRACHAMI//////////////////////////////////////////////////////////////////////////////////
        private void FillGridWithWorkers(int page, int countonpage)
        {            
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                dataGridView1.Rows.Clear();
                var temp1 = db.Workers.Where(x => x.DeleteTime == null);
                List<Workers> workerslist = temp1.ToList();
                maxpage = workerslist.Count() / countonpage;
                if (workerslist.Count()%countonpage!=0)
                {
                    maxpage++;
                }
                foreach (Workers t in workerslist.Skip((page-1)*countonpage).Take(countonpage))
                {
                    dataGridView1.Rows.Add(t.Id, t.Name, t.Specialization, t.TelephoneNumber);
                }                                
            }
        }

        private void FillGridWithWorkingHoursForWorker(int workid)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                dataGridView6.Rows.Clear();
                var temp1 = db.WorkingHours.Where(x => x.DeleteTime == null && x.Worker_ID == workid);
                List<WorkingHours> workinghourslist = temp1.ToList();
                foreach (WorkingHours w in workinghourslist)
                {
                    DateTime s = Convert.ToDateTime(w.TimeStart);
                    DateTime e = Convert.ToDateTime(w.TimeEnd);
                    dataGridView6.Rows.Add(w.Id, Convert.ToString(s), Convert.ToString(s.TimeOfDay), Convert.ToString(e.TimeOfDay), db.Cabinets.Find(w.Cabinet_ID).Name, db.Workers.Find(w.Worker_ID).Name);
                }
            }
        }

        private void FillGrifWithProceduresForWorker(int workid)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                dataGridView5.Rows.Clear();
                List<WorkerProcedures> wp = db.WorkerProcedures.Where(x => x.DeleteTime == null && x.Worker_ID == backid).ToList();
                List<Procedures> temp = new List<Procedures>();
                foreach (WorkerProcedures w in wp)
                {
                    temp.Add(db.Procedures.Find(w.Procedure_ID));
                }                
                foreach (Procedures c in temp)
                {
                   dataGridView5.Rows.Add(c.Id, Convert.ToString(c.DateEventStart), c.TypeOfProcedures.Name, c.TypeOfProcedures.Price);
                }
            }
        }

        private void FillGridWithTreatMentPlansForWorker(int workid)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                dataGridView8.Rows.Clear();
                var temp1 = db.TreatmentPlans.Where(x => x.DeleteTime == null && x.Worker_ID == workid);
                List<TreatmentPlans> treatmentplanlist = temp1.ToList();
                foreach (TreatmentPlans t in treatmentplanlist)
                {
                    dataGridView8.Rows.Add(t.Id, db.Patients.Find(t.Patient_ID).Name, db.Workers.Find(t.Worker_ID).Name);
                }
            }
        }
        private void AddWorkerBtn_Click(object sender, EventArgs e)
        {
            WorkerEdit workeredit = new WorkerEdit();
            workeredit.ShowDialog();
            FillGridWithWorkers(currentpage, currentcountonpage);
            label1.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
            if (currentpage == maxpage)
            { button3.Enabled = false; }
            else
            { button3.Enabled = true; }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (stat == 1)
            {
                WorkerCard Workercard = new WorkerCard();
                int id = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    Workers w = db.Workers.Find(id);
                    Workercard.Currentid = id;
                    Workercard.ShowDialog();
                    FillGridWithWorkers(currentpage, currentcountonpage);
                    label1.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button3.Enabled = false; }
                    else
                    { button3.Enabled = true; }
                }
            }
            else
            {
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    WorkerProcedures wp = new WorkerProcedures();
                    wp.Procedure_ID = backid;
                    wp.Worker_ID = Convert.ToInt32(this.dataGridView1.CurrentRow.Cells[0].Value);
                    try
                    {
                        db.WorkerProcedures.Add(wp);
                        db.SaveChanges();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("У этой процедуры уже есть такой врач", "Ортопедическая клиника!");
                    }
                }
            }           
        }
        private void BuildSpecializationCbmx()
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                SpecializationCmbx.Items.Clear();
                var listworker = db.Workers.Where(x => x.DeleteTime == null).ToList();
                List<Workers> temp = listworker;
                foreach (Workers w in listworker)
                {
                    SpecializationCmbx.Items.Add(w.Specialization);
                }
            }
        }
        ///////////////////////////////////////////////////////////////////////////////RABOTASDIAGNOZAMI//////////////////////////////////////////////////////////////////////////////////     
        private void FillGridWithDiagnosises(int page, int countonpage)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                dataGridView9.Rows.Clear();
                var temp1 = db.Diagnosises.Where(x => x.DeleteTime == null);
                List<Diagnosises> diagnosiseslist = temp1.ToList();
                maxpage = diagnosiseslist.Count() / countonpage;
                if (diagnosiseslist.Count()%countonpage!=0)
                {
                    maxpage++;
                }
                foreach (Diagnosises d in diagnosiseslist.Skip((page-1)*countonpage).Take(countonpage))
                {
                    dataGridView9.Rows.Add(d.Id, d.Date, d.Name, db.Patients.Find(d.Patient_ID).Name,db.Workers.Find(d.Worker_ID).Name, d.Status);
                }
            }
        }

        private void dataGridView9_CellDoubleClick(object sender, DataGridViewCellEventArgs e) 
        {
            if (stat == 1)
            {
                DiagnosisCard Diagnosiscard = new DiagnosisCard();
                int id = Convert.ToInt32(this.dataGridView9.CurrentRow.Cells[0].Value);
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    Diagnosises d = db.Diagnosises.Find(id);
                    Diagnosiscard.Currentid = id;
                    Diagnosiscard.ShowDialog();
                    FillGridWithDiagnosises(currentpage, currentcountonpage);
                    label51.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button36.Enabled = false; }
                    else
                    { button36.Enabled = true; }
                }
            }
            else
            {
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    TreatmentPlanDagnosises tp = new TreatmentPlanDagnosises();
                    tp.TreatmentPlan_ID = backid;
                    tp.Diagnosis_ID = Convert.ToInt32(this.dataGridView9.CurrentRow.Cells[0].Value);
                    try
                    {
                        db.TreatmentPlanDagnosises.Add(tp);
                        db.SaveChanges();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Вы пытаетесь добавить уже добавленный диагноз!", "Ортопедическая клиника!");
                    }
                }
            }
        }

        private void AddDiagnosisBtn_Click(object sender, EventArgs e)
        {
            DiagnosisEdit diagnosisedit = new DiagnosisEdit();
            diagnosisedit.ShowDialog();
            FillGridWithDiagnosises(currentpage, currentcountonpage);
            label51.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
            if (currentpage == maxpage)
            { button36.Enabled = false; }
            else
            { button36.Enabled = true; }
        }
        //////////////////////////////////////////////////////////////////////////////RABOTASPROCEDURAMI///////////////////////////////////////////////////////
        private void FillGridWithProcedures(int page, int countonpage)
        {
            if (stat == 1)
            {
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView5.Rows.Clear();
                    var temp1 = db.Procedures.Where(x => x.DeleteTime == null);
                    List<Procedures> procedureslist = temp1.ToList();
                    maxpage = procedureslist.Count() / countonpage;
                    if (procedureslist.Count() % countonpage != 0)
                    {
                        maxpage++;
                    }
                    foreach (Procedures p in procedureslist.Skip((page - 1) * countonpage).Take(countonpage))
                    {
                        dataGridView5.Rows.Add(p.Id, Convert.ToString(p.DateEventStart), p.TypeOfProcedures.Name, p.TypeOfProcedures.Price);
                    }
                }
            }            
        }

        private void dataGridView5_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProcedureCard Procedurecard = new ProcedureCard();
            int id = Convert.ToInt32(this.dataGridView5.CurrentRow.Cells[0].Value);
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Procedures p = db.Procedures.Find(id);
                Procedurecard.Currentid = id;
                Procedurecard.ShowDialog();
                FillGridWithProcedures(currentpage, currentcountonpage);
                label5.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                if (currentpage == maxpage)
                { button15.Enabled = false; }
                else
                { button15.Enabled = true; }
            }
        }

        private void AddProcedureBtn_Click(object sender, EventArgs e)
        {
            ProcedureEdit procedureedit = new ProcedureEdit();            
            procedureedit.ShowDialog();
            FillGridWithProcedures(currentpage, currentcountonpage);
            label5.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
            if (currentpage == maxpage)
            { button15.Enabled = false; }
            else
            { button15.Enabled = true; }
        }
        ////////////////////////////////////////////////////////////////////////////////////RAVOTASTYPAMIPROCEDUR////////////////////////////////////////////////////////////////////////////////////
        private void FillGridWithTypeOfProcedures(int page, int countonpage)
        {
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView7.Rows.Clear();
                    var temp1 = db.TypeOfProcedures.Where(x => x.DeleteTime == null);
                    List<TypeOfProcedures> typeofprocedureslist = temp1.ToList();
                    maxpage = typeofprocedureslist.Count() / countonpage;
                    if(typeofprocedureslist.Count() % countonpage != 0)
                        {
                            maxpage++;
                        }
                    foreach (TypeOfProcedures t in typeofprocedureslist.Skip((page - 1) * countonpage).Take(countonpage))
                    {
                        dataGridView7.Rows.Add(t.Id, t.Name, db.KindOfProcedures.Find(t.KindOfProcedure_ID).Name, t.Price);
                    }
                }            
        }
        private void AddTypeOfProcedureBtn_Click(object sender, EventArgs e)
        {
            TypeOfProcedureEdit topedit = new TypeOfProcedureEdit();
            topedit.ShowDialog();
            FillGridWithTypeOfProcedures(currentpage, currentcountonpage);
            label41.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
            if (currentpage == maxpage)
            { button21.Enabled = false; }
            else
            { button21.Enabled = true; }
        }
        private void dataGridView7_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (stat == 1)
            {
                TypeOfProcedureCard tpcard = new TypeOfProcedureCard();
                int id = Convert.ToInt32(this.dataGridView7.CurrentRow.Cells[0].Value);
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    TypeOfProcedures t = db.TypeOfProcedures.Find(id);
                    tpcard.Currentid = id;
                    tpcard.ShowDialog();
                    FillGridWithTypeOfProcedures(currentpage, currentcountonpage);
                    label41.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                    if (currentpage == maxpage)
                    { button21.Enabled = false; }
                    else
                    { button21.Enabled = true; }
                }
            }

            if (stat == 5)
            {
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    WorkerTypeOfProcedures cp = new WorkerTypeOfProcedures();
                    cp.Worker_ID= backid;
                    cp.TypeOfProcedure_ID = Convert.ToInt32(this.dataGridView7.CurrentRow.Cells[0].Value);
                    try
                    {
                        db.WorkerTypeOfProcedures.Add(cp);
                        db.SaveChanges();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Вы пытаетесь добавить уже существующий тип процедуры!", "Ортопедическая клиника");
                    }
                }
            }
            if (stat == 2)
            {
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    CabinetProcedures cp = new CabinetProcedures();
                    cp.Cabinet_ID = backid;
                    cp.ProcedureType_ID = Convert.ToInt32(this.dataGridView7.CurrentRow.Cells[0].Value);
                    try
                    {
                        db.CabinetProcedures.Add(cp);
                        db.SaveChanges();
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Вы пытаетесь добавить уже существующий у этого кабинета тип процедуры!", "Ортопедическая клиника");
                    }           
                }
            }
            if (stat == 6)
            {
                //using (ClinicEntities1 db = new ClinicEntities1())
                //{
                //    TreatmentPlanProcedures tp = new TreatmentPlanProcedures();
                //    tp.TreatmentPlan_ID = backid;
                //    tp.TypeOfProcedures_ID = Convert.ToInt32(this.dataGridView7.CurrentRow.Cells[0].Value);
                //    db.TreatmentPlanProcedures.Add(tp);
                //    db.SaveChanges();
                //    this.Close();
                //}
            }
        }

        private void BuildKindOfProcCmbx()
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                comboBox4.Items.Clear();
                List<KindOfProcedures> koflist = db.KindOfProcedures.Where(x => x.DeleteTime == null).ToList();
                foreach (KindOfProcedures k in koflist)
                {
                    comboBox4.Items.Add(k.Name);
                }
            }
        }

        /////////////////////////////////////////////////////////////////////RABOTASCABINETAMI////////////////////////////////////////////////////////////////////////
        private void FillGridWithCabinets(int page, int countonpage)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                dataGridView4.Rows.Clear();
                var temp1 = db.Cabinets.Where(x => x.DeleteTime == null);
                List<Cabinets> cabinetlist = temp1.ToList();
                maxpage = cabinetlist.Count() / countonpage;
                if (cabinetlist.Count() % countonpage != 0)
                {
                    maxpage++;
                }
                foreach (Cabinets c in cabinetlist.Skip((page - 1) * countonpage).Take(countonpage))
                {
                    dataGridView4.Rows.Add(c.Id,c.Name, c.Description);
                }
            }
        }
        private void FillGrifWithProceduresForCab(int cabid, int page, int countonpage)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                dataGridView5.Rows.Clear();
                var temp1 = db.Procedures.Where(x => x.DeleteTime == null && x.Cabinet_ID == cabid);
                List<Procedures> cabinetlist = temp1.ToList();
                maxpage = cabinetlist.Count() / countonpage;
                if (cabinetlist.Count() % countonpage != 0)
                {
                    maxpage++;
                }
                foreach (Procedures c in cabinetlist.Skip((page - 1) * countonpage).Take(countonpage))
                {
                    dataGridView5.Rows.Add(c.Id, Convert.ToString(c.DateEventStart), c.TypeOfProcedures.Name, c.TypeOfProcedures.Price);
                }
            }
        }
        private void dataGridView4_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CabinetCard Cabinetcard = new CabinetCard();
            int id = Convert.ToInt32(this.dataGridView4.CurrentRow.Cells[0].Value);
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Cabinets c = db.Cabinets.Find(id);
                Cabinetcard.Currentid = id;
                Cabinetcard.ShowDialog();
                FillGridWithCabinets(currentpage, currentcountonpage);
                label4.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                if (currentpage == maxpage)
                { button10.Enabled = false; }
                else
                { button10.Enabled = true; }
            }
        }
        private void AddCabinetBtn_Click(object sender, EventArgs e)
        {
            CabinetEdit cabinetedit = new CabinetEdit();
            cabinetedit.ShowDialog();
            FillGridWithCabinets(currentpage, currentcountonpage);
            label4.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
            if (currentpage == maxpage)
            { button10.Enabled = false; }
            else
            { button10.Enabled = true; }
        }

        ////////////////////////////////////////////////////////////////////////////////////RABOTASVIZITAMI/////////////////////////////////////////////////////////////////////////////////////////////
        private void FillGridWithVisits(int page, int countonpage)
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                dataGridView3.Rows.Clear();
                var temp1 = db.Visits.Where(x => x.DeleteTime == null);
                List<Visits> visitslist = temp1.ToList();
                maxpage = visitslist.Count() / countonpage;
                if (visitslist.Count() % countonpage != 0)
                {
                    maxpage++;
                }
                foreach (Visits v in visitslist.Skip((page - 1) * countonpage).Take(countonpage))
                {
                    dataGridView3.Rows.Add(v.Id, db.Patients.Find(v.Patient_ID).Name, db.Cabinets.Find(v.Cabinet_ID).Name, Convert.ToString(v.DateStart), Convert.ToString(v.DateEnd));
                }
            }
        }
        private void dataGridView3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            VisitCard Visitcard = new VisitCard();
            int id = Convert.ToInt32(this.dataGridView3.CurrentRow.Cells[0].Value);
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                Visits v = db.Visits.Find(id);
                Visitcard.Currentid = id;
                Visitcard.ShowDialog();
                FillGridWithVisits(currentpage, currentcountonpage);
                label3.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                if (currentpage == maxpage)
                { button8.Enabled = false; }
                else
                { button8.Enabled = true; }
            }
        }
        private void AddVisits_Click(object sender, EventArgs e)
        {
            VisitEdit visitedit = new VisitEdit();
            visitedit.ShowDialog();
            FillGridWithVisits(currentpage, currentcountonpage);
            label3.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
            if (currentpage == maxpage)
            { button8.Enabled = false; }
            else
            { button8.Enabled = true; }
        }

        /////////////////////////////////////////////////////////////////////////////////////RABOTASWORKINGHOURSAMI///////////////////////////////////////////////////////////////////////////////////////////////

        private void FillGridWithWorkingHours(int page, int countonpage)
        {
            if (stat == 1)
            {
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView6.Rows.Clear();
                    var groupbyname = from w in db.WorkingHours
                                      group w by w.Workers.Name;
                    foreach (var g in groupbyname)
                    {
                        dataGridView6.Rows.Add(g.Key);
                        maxpage = g.Count() / countonpage;//
                        if (g.Count() % countonpage != 0)
                        {
                            maxpage++;
                        }
                        foreach (var wc in g.Skip((page - 1) * countonpage).Take(countonpage))
                        {
                            DateTime s = Convert.ToDateTime(wc.TimeStart);
                            DateTime e = Convert.ToDateTime(wc.TimeEnd);
                            dataGridView6.Rows.Add(wc.Id, Convert.ToString(s), Convert.ToString(s.TimeOfDay), Convert.ToString(e.TimeOfDay), db.Cabinets.Find(wc.Cabinet_ID).Name, db.Workers.Find(wc.Worker_ID).Name);
                        }
                    }
                    //dataGridView6.Rows.Clear();
                    //var temp1 = db.WorkingHours.Where(x => x.DeleteTime == null);
                    //List<WorkingHours> workinghourslist = temp1.ToList();
                    //foreach (WorkingHours w in workinghourslist)
                    //{
                    //    DateTime s = Convert.ToDateTime(w.TimeStart);
                    //    DateTime e = Convert.ToDateTime(w.TimeEnd);
                    //    dataGridView6.Rows.Add(w.Id, Convert.ToString(s.Day), Convert.ToString(s.Month), Convert.ToString(s.Hour), Convert.ToString(e.Hour), db.Cabinets.Find(w.Cabinet_ID).Name, db.Workers.Find(w.Worker_ID).Name);
                    //}
                }
            }
        }


        private void dataGridView6_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            WorkingHourCard Workinghourcard = new WorkingHourCard();
            int id = Convert.ToInt32(this.dataGridView6.CurrentRow.Cells[0].Value);
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                WorkingHours w = db.WorkingHours.Find(id);
                Workinghourcard.Currentid = id;
                Workinghourcard.ShowDialog();
                FillGridWithWorkingHours(currentpage, currentcountonpage);
                label29.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                if (currentpage == maxpage)
                { button25.Enabled = false; }
                else
                { button25.Enabled = true; }
            }
        }


        private void AddWorkingHourBtn_Click(object sender, EventArgs e)
        {
            WorkingHourEdit workinghpuredit = new WorkingHourEdit();
            workinghpuredit.ShowDialog();
            FillGridWithWorkingHours(currentpage, currentcountonpage);
            label29.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
            if (currentpage == maxpage)
            { button25.Enabled = false; }
            else
            { button25.Enabled = true; }
        }
        ////////////////////////////////////////////////////////////////////////////////////RABOTASPLANAMILECHENIYA///////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void FillGridWithTreatMentPlans(int page, int countonpage)
        {
            if (stat == 1)
            {
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView8.Rows.Clear();
                    var temp1 = db.TreatmentPlans.Where(x => x.DeleteTime == null);
                    List<TreatmentPlans> treatmentplanlist = temp1.ToList();
                    maxpage = treatmentplanlist.Count() / countonpage;
                    if (treatmentplanlist.Count() % countonpage != 0)
                    {
                        maxpage++;
                    }
                    foreach (TreatmentPlans t in treatmentplanlist.Skip((page - 1) * countonpage).Take(countonpage))
                    {
                        dataGridView8.Rows.Add(t.Id, db.Patients.Find(t.Patient_ID).Name, db.Workers.Find(t.Worker_ID).Name);
                    }
                }
            }
        }
        private void dataGridView8_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            TreatmentPlanCard Treatmentplancard= new TreatmentPlanCard();
            int id = Convert.ToInt32(this.dataGridView8.CurrentRow.Cells[0].Value);
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                TreatmentPlans t = db.TreatmentPlans.Find(id);
                Treatmentplancard.Currentid = id;
                Treatmentplancard.Show();
                FillGridWithTreatMentPlans(currentpage, currentcountonpage);
                label47.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
                if (currentpage == maxpage)
                { button32.Enabled = false; }
                else
                { button32.Enabled = true; }
            }
        }
        private void AddTreatmentPlanBtn_Click(object sender, EventArgs e)
        {
            TreatmentPlanEdit treatmentplanedit = new TreatmentPlanEdit ();
            treatmentplanedit.ShowDialog();
            FillGridWithTreatMentPlans(currentpage, currentcountonpage);
            label47.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
            if (currentpage == maxpage)
            { button32.Enabled = false; }
            else
            { button32.Enabled = true; }
        }
        /////////////////////////////////////////////////////////////////////////////////////RABOTASGRAPHIKOM/////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void BuildChart(string worker)
        {
            this.chart1.Series["Заработано (руб.)"].Points.Clear();
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                double sum = 0;
                Workers w = db.Workers.Where(x => x.Name == worker).FirstOrDefault<Workers>();
                List<WorkerProcedures> lp = db.WorkerProcedures.Where(x => x.Worker_ID == w.Id).ToList();                
                foreach (WorkerProcedures p in lp)
                {
                    Procedures temp = db.Procedures.Find(p.Procedure_ID);
                    TypeOfProcedures temp1 = db.TypeOfProcedures.Find(temp.TypeOfProcedure_ID);
                    sum = sum + Convert.ToDouble(temp1.Price);
                    this.chart1.Series["Заработано (руб.)"].Points.AddXY(temp1.Name, temp1.Price);                    
                }
                label28.Text = Convert.ToString(sum);                
            }            
        }

        private void FillChartCmbx()
        {
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                comboBox2.Items.Clear();
                List<Workers> lw = db.Workers.Where(x => x.DeleteTime == null).ToList();
                foreach (Workers w in lw)
                {
                    comboBox2.Items.Add(w.Name);
                }
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            BuildChart(comboBox2.Text);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////SEARCH///////////////////////////////////////////////////////////////////////////////////

        private void FillWorkerCmbx(ComboBox comboBox1)
        {
            comboBox1.Items.Clear();
            using (ClinicEntities1 db = new ClinicEntities1())
            {
                List<Workers> temp = db.Workers.Where(x => x.DeleteTime == null).ToList();
                foreach (Workers w in temp)
                {
                    comboBox1.Items.Add(w.Name);
                }
            }
        }

        private void button22_Click(object sender, EventArgs e)/////////////////////////////////////////////////////////////visit///////////////////////////////////////////////////////////////////////////////////////////////
        {
            if(textBox5.Text != "")
            {
                string str = textBox5.Text;
                dataGridView3.Rows.Clear();
                List<Visits> visitslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView3.Rows.Clear();
                    visitslist = db.Visits.Where(x => x.Patients.Name==str && x.DeleteTime == null).ToList();
                    foreach (Visits v in visitslist)
                    {
                        dataGridView3.Rows.Add(v.Id, db.Patients.Find(v.Patient_ID).Name, db.Cabinets.Find(v.Cabinet_ID).Name, Convert.ToString(v.DateStart), Convert.ToString(v.DateEnd));
                    }
                }
                if (visitslist.Count == 0)
                {
                    MessageBox.Show("Приёмы не найдены!", "Ортопедическая клиника");
                }
            }

            if (dateTimePicker1.Enabled==true)
            {
                List<Visits> visitslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView3.Rows.Clear();
                    var temp1 = db.Visits.Where(x => x.DeleteTime == null && x.DateStart >= dateTimePicker1.Value && x.DateEnd <= dateTimePicker4.Value);
                    visitslist = temp1.ToList();
                    foreach (Visits v in visitslist)
                    {
                        dataGridView3.Rows.Add(v.Id, db.Patients.Find(v.Patient_ID).Name, db.Cabinets.Find(v.Cabinet_ID).Name, Convert.ToString(v.DateStart), Convert.ToString(v.DateEnd));
                    }
                }
            }
            if(dateTimePicker1.Enabled == true && textBox5.Text != "")
            {
                List<Visits> visitslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView3.Rows.Clear();
                    var temp1 = db.Visits.Where(x => x.DeleteTime == null && x.DateStart >= dateTimePicker1.Value && x.DateEnd <= dateTimePicker4.Value && x.Patients.Name == textBox5.Text);
                    visitslist = temp1.ToList();
                    foreach (Visits v in visitslist)
                    {
                        dataGridView3.Rows.Add(v.Id, db.Patients.Find(v.Patient_ID).Name, db.Cabinets.Find(v.Cabinet_ID).Name, Convert.ToString(v.DateStart), Convert.ToString(v.DateEnd));
                    }
                }
            }            
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker4.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker4.Enabled = false;
            }
        }
        private void button13_Click(object sender, EventArgs e)//сброс
        {
            textBox5.Text = "";
            radioButton2.Checked = false;
            tabControl1_SelectedIndexChanged(sender, e);
        }
        private void SearchBtn_Click(object sender, EventArgs e)/////////////////////////////////////////////////////////////////////patients////////////////////////////////////////////////////////////////////////////////////////
        {
            if (SearchPatientName.Text!="")
            {
                string str = SearchPatientName.Text;
                List<Patients> patientslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView2.Rows.Clear();
                    patientslist = db.Database.SqlQuery<Patients>("select * from Patients Where Patients.Name like" + "'" + str + "%" + "'" + "and DeleteTime is null").ToList();
                    foreach (Patients p in patientslist)
                    {
                        dataGridView2.Rows.Add(p.Id, p.Name, p.TelephoneNumber);
                    }
                }

                if (patientslist.Count == 0)
                {
                    MessageBox.Show("Пациенты не найдены", "Ортопедическая клиника");

                }
            }
            if (SearchPatientPhNum.Text != "")
            {
                string str = SearchPatientPhNum.Text;
                List<Patients> patientslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView2.Rows.Clear();
                    patientslist = db.Database.SqlQuery<Patients>("select * from Patients Where Patients.TelephoneNumber like" + "'" + str + "%" + "'" + "and DeleteTime is null").ToList();
                    foreach (Patients p in patientslist)
                    {
                        dataGridView2.Rows.Add(p.Id, p.Name, p.TelephoneNumber);
                    }
                }
                if (patientslist.Count == 0)
                {
                    MessageBox.Show("Пациенты не найдены", "Ортопедическая клиника");

                }
            }
            if (SearchPatientPhNum.Text != "" && SearchPatientName.Text != "")
            {
                List<Patients> patientslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    string str = SearchPatientPhNum.Text;
                    string str2 = SearchPatientName.Text;
                    dataGridView2.Rows.Clear();                    
                    patientslist = db.Database.SqlQuery<Patients>("select * from Patients Where Patients.TelephoneNumber like" + "'" + str + "%" + "'" + "and Name like" + "'" + str2 + "%" + "'" + "and DeleteTime is null").ToList();
                    foreach (Patients p in patientslist)
                    {
                        dataGridView2.Rows.Add(p.Id, p.Name, p.TelephoneNumber);
                    }
                }
                if (patientslist.Count == 0)
                {
                    MessageBox.Show("Пациенты не найдены", "Ортопедическая клиника");
                }
            }
        }
        private void button6_Click(object sender, EventArgs e)//сброс
        {
            SearchPatientName.Text = "";
            SearchPatientPhNum.Text = "";
            tabControl1_SelectedIndexChanged(sender, e);
        }
        private void button1_Click(object sender, EventArgs e)////////////////////////////////////////////////////////proceduri////////////////////////////////////////////////////////////////////////////////////////////////////////////
        {           
            if (comboBox3.Text != "")
            {
                try
                {
                    using (ClinicEntities1 db = new ClinicEntities1())
                    {
                        dataGridView5.Rows.Clear();
                        List<Procedures> procedurelist = new List<Procedures>();
                        Workers w = db.Workers.Where(x => x.Name == comboBox3.Text).FirstOrDefault<Workers>();
                        List<WorkerProcedures> wp = db.WorkerProcedures.Where(x => x.Worker_ID == w.Id).ToList();
                        foreach (WorkerProcedures q in wp)
                        {
                            procedurelist.Add(db.Procedures.Find(q.Procedure_ID));
                        }
                        foreach (Procedures p in procedurelist)
                        {
                            dataGridView5.Rows.Add(p.Id, Convert.ToString(p.DateEventStart), p.TypeOfProcedures.Name, p.TypeOfProcedures.Price);
                        }
                        if (procedurelist.Count == 0)
                        {
                            MessageBox.Show("Процедуры не найдены", "Ортопедическая клиника");
                        }
                    }
                }
                catch
                {
                    
                }
            }
            if (radioButton3.Checked == true)
            {
                if (dateTimePicker3.Enabled==true)
                {
                    List<Procedures> procedurelist;
                    using (ClinicEntities1 db = new ClinicEntities1())
                    {
                        dataGridView5.Rows.Clear();
                        var temp1 = db.Procedures.Where(x => x.DeleteTime == null && x.DateEventStart >= dateTimePicker3.Value && x.DateEventEnd <= dateTimePicker2.Value);
                        procedurelist = temp1.ToList();
                        foreach (Procedures p in procedurelist)
                        {
                            dataGridView5.Rows.Add(p.Id, Convert.ToString(p.DateEventStart), p.TypeOfProcedures.Name, p.TypeOfProcedures.Price);
                        }
                    }
                }
                if (dateTimePicker3.Enabled==true && comboBox3.Text != "")
                {
                    using (ClinicEntities1 db = new ClinicEntities1())
                    {
                        dataGridView5.Rows.Clear();
                        List<Procedures> procedurelist = new List<Procedures>();
                        Workers w = db.Workers.Where(x => x.Name == comboBox3.Text).FirstOrDefault<Workers>();
                        List<WorkerProcedures> wp = db.WorkerProcedures.Where(x => x.Worker_ID == w.Id ).ToList();
                        foreach (WorkerProcedures q in wp)
                        {
                            if (db.Procedures.Where(x => x.Id == q.Procedure_ID && x.DateEventStart >= dateTimePicker3.Value && x.DateEventEnd <= dateTimePicker2.Value).FirstOrDefault<Procedures>() != null)
                            {
                                procedurelist.Add(db.Procedures.Find(q.Procedure_ID));
                            } 
                        }
                        foreach (Procedures p in procedurelist)
                        {
                            dataGridView5.Rows.Add(p.Id, Convert.ToString(p.DateEventStart), p.TypeOfProcedures.Name, p.TypeOfProcedures.Price);
                        }
                        if (procedurelist.Count == 0)
                        {
                            MessageBox.Show("Процедуры не найдены", "Ортопедическая клиника");
                        }
                    }
                }                
            }
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           if (radioButton3.Checked == true)
            {
                dateTimePicker3.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
           else
            {
                dateTimePicker3.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }
        private void button9_Click(object sender, EventArgs e)//сброс
        {
            comboBox3.Text = "";
            radioButton3.Checked = false;
            tabControl1_SelectedIndexChanged(sender, e);
        }
        private void button26_Click(object sender, EventArgs e)////////////////////////////////////////////////////////////////////////cabinets///////////////////////////////////////////////////////////////////////////
        {
            if (textBox10.Text != "")
            {
                string str = textBox10.Text;
                List<Cabinets> cabinetlist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView4.Rows.Clear();
                    cabinetlist = db.Database.SqlQuery<Cabinets>("select * from Cabinets Where Cabinets.Description like" + "'" + str + "%" + "'" + " and DeleteTime is null").ToList();
                    foreach (Cabinets c in cabinetlist)
                    {
                        dataGridView4.Rows.Add(c.Id, c.Name, c.Description);
                    }
                }
                if (cabinetlist.Count == 0)
                {
                    MessageBox.Show("Кабинеты не найдены!", "Ортопедическая клиника");
                }
            }
            if (textBox8.Text != "")
            {
                string str = textBox8.Text;
                List<Cabinets> cabinetlist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView4.Rows.Clear();
                    cabinetlist = db.Database.SqlQuery<Cabinets>("select * from Cabinets Where Cabinets.Name like" + "'" +"%" + str + "%" + "'" + " and DeleteTime is null").ToList();
                    foreach (Cabinets c in cabinetlist)
                    {
                        dataGridView4.Rows.Add(c.Id, c.Name, c.Description);
                    }
                }
                if (cabinetlist.Count == 0)
                {
                    MessageBox.Show("Кабинеты не найдены!", "Ортопедическая клиника");
                }
            }
            if (textBox10.Text != "" && textBox8.Text != "")
            {
                string str = textBox10.Text;
                string str2 = textBox8.Text;
                List<Cabinets> cabinetlist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView4.Rows.Clear();
                    cabinetlist = db.Database.SqlQuery<Cabinets>("select * from Cabinets Where Cabinets.Description like" + "'" + str + "%" + "'" + "and Name like" + "'"+ "%" + str2 + "%" + "'" + "and DeleteTime is null").ToList();
                    foreach (Cabinets c in cabinetlist)
                    {
                        dataGridView4.Rows.Add(c.Id, c.Name, c.Description);
                    }
                }
                if (cabinetlist.Count == 0)
                {
                    MessageBox.Show("Кабинеты не найдены!", "Ортопедическая клиника");
                }
            }
        }
        private void button12_Click(object sender, EventArgs e)// сброс
        {
            textBox10.Text = "";
            textBox8.Text = "";
            tabControl1_SelectedIndexChanged(sender, e);
        }
        private void WorkersSearchButton_Click(object sender, EventArgs e)//////////////////////////////////////////////////////////////////////////workers///////////////////////////////////////////////////////////////////////
        {
            if (comboBox5.Text != "")
            {
                List<Workers> workerslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView1.Rows.Clear();
                    var temp1 = db.Workers.Where(x => x.DeleteTime == null && x.Name == comboBox5.Text);
                    workerslist = temp1.ToList();
                    foreach (Workers t in workerslist)
                    {
                        dataGridView1.Rows.Add(t.Id, t.Name, t.Specialization, t.TelephoneNumber);
                    }
                }
                if (workerslist.Count == 0)
                {
                    MessageBox.Show("Работники не найдены!", "Ортопедическая клиника");
                }
            }
            if (SpecializationCmbx.Text != "")
            {
                List<Workers> workerslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView1.Rows.Clear();
                    var temp1 = db.Workers.Where(x => x.DeleteTime == null && x.Specialization == SpecializationCmbx.Text);
                    workerslist = temp1.ToList();
                    foreach (Workers t in workerslist)
                    {
                        dataGridView1.Rows.Add(t.Id, t.Name, t.Specialization, t.TelephoneNumber);
                    }
                }
                if (workerslist.Count == 0)
                {
                    MessageBox.Show("Работники не найдены!", "Ортопедическая клиника");
                }
            }
            if (SearchWorkerPhNum.Text != "")
            {
                List<Workers> workerslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    string str = SearchWorkerPhNum.Text;
                    dataGridView1.Rows.Clear();                   
                    workerslist = db.Database.SqlQuery<Workers>("select * from Workers Where Workers.TelephoneNumber like" + "'" + "%" + str + "%" + "'" + " and DeleteTime is null").ToList();
                    foreach (Workers t in workerslist)
                    {
                        dataGridView1.Rows.Add(t.Id, t.Name, t.Specialization, t.TelephoneNumber);
                    }
                }
                if (workerslist.Count == 0)
                {
                    MessageBox.Show("Работники не найдены!", "Ортопедическая клиника");
                }
            }
            if (comboBox5.Text != "" && SearchWorkerPhNum.Text != "")
            {
                List<Workers> workerslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView1.Rows.Clear();
                    var temp1 = db.Workers.Where(x => x.DeleteTime == null && x.TelephoneNumber == SearchWorkerPhNum.Text && x.Name == comboBox5.Text);
                    workerslist = temp1.ToList();
                    foreach (Workers t in workerslist)
                    {
                        dataGridView1.Rows.Add(t.Id, t.Name, t.Specialization, t.TelephoneNumber);
                    }
                }
                if (workerslist.Count == 0)
                {
                    MessageBox.Show("Работники не найдены!", "Ортопедическая клиника");
                }
            }
            if (comboBox5.Text != "" && SpecializationCmbx.Text != "")
            {
                List<Workers> workerslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView1.Rows.Clear();
                    var temp1 = db.Workers.Where(x => x.DeleteTime == null && x.Specialization == SpecializationCmbx.Text && x.Name == comboBox5.Text);
                    workerslist = temp1.ToList();
                    foreach (Workers t in workerslist)
                    {
                        dataGridView1.Rows.Add(t.Id, t.Name, t.Specialization, t.TelephoneNumber);
                    }
                }
                if (workerslist.Count == 0)
                {
                    MessageBox.Show("Работники не найдены!", "Ортопедическая клиника");
                }
            }
            if (SearchWorkerPhNum.Text != "" && SpecializationCmbx.Text != "")
            {
                List<Workers> workerslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView1.Rows.Clear();
                    var temp1 = db.Workers.Where(x => x.DeleteTime == null && x.Specialization == SpecializationCmbx.Text && x.TelephoneNumber == SearchWorkerPhNum.Text);
                    workerslist = temp1.ToList();
                    foreach (Workers t in workerslist)
                    {
                        dataGridView1.Rows.Add(t.Id, t.Name, t.Specialization, t.TelephoneNumber);
                    }
                }
                if (workerslist.Count == 0)
                {
                    MessageBox.Show("Работники не найдены!", "Ортопедическая клиника");
                }
            }
        }
        private void button17_Click(object sender, EventArgs e)//сброс
        {
            comboBox5.Text = "";
            SpecializationCmbx.Text = "";
            SearchWorkerPhNum.Text = "";
            tabControl1_SelectedIndexChanged(sender, e);
        }
        private void button28_Click(object sender, EventArgs e)//////////////////////////////////////////////////////////////////////typeofprocedures///////////////////////////////////////////////////////////////
        {
            if (comboBox4.Text != "")
            {
                List<TypeOfProcedures> typeofprocedureslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView7.Rows.Clear();
                    var temp1 = db.TypeOfProcedures.Where(x => x.DeleteTime == null && x.KindOfProcedures1.Name == comboBox4.Text);
                    typeofprocedureslist = temp1.ToList();
                    foreach (TypeOfProcedures t in typeofprocedureslist)
                    {
                        dataGridView7.Rows.Add(t.Id, t.Name, db.KindOfProcedures.Find(t.KindOfProcedure_ID).Name, t.Price);
                    }
                }
                if (typeofprocedureslist.Count == 0)
                {
                    MessageBox.Show("Типы процедур не найдены!", "Ортопедическая клиника");
                }
            }
            if (textBox20.Text != "" && textBox17.Text != "")
            {
                List<TypeOfProcedures> typeofprocedureslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView7.Rows.Clear();
                    Double min = Convert.ToDouble(textBox20.Text);
                    Double max = Convert.ToDouble(textBox17.Text);
                    var temp1 = db.TypeOfProcedures.Where(x => x.DeleteTime == null && x.Price >= min && x.Price <= max);
                    typeofprocedureslist = temp1.ToList();
                    foreach (TypeOfProcedures t in typeofprocedureslist)
                    {
                        dataGridView7.Rows.Add(t.Id, t.Name, db.KindOfProcedures.Find(t.KindOfProcedure_ID).Name, t.Price);
                    }
                }
                if (typeofprocedureslist.Count == 0)
                {
                    MessageBox.Show("Типы процедур не найдены!", "Ортопедическая клиника");
                }
            }
            if (comboBox4.Text != "" && textBox20.Text != "" && textBox17.Text != "")
            {
                List<TypeOfProcedures> typeofprocedureslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView7.Rows.Clear();
                    Double min = Convert.ToDouble(textBox20.Text);
                    Double max = Convert.ToDouble(textBox17.Text);
                    var temp1 = db.TypeOfProcedures.Where(x => x.DeleteTime == null && x.Price >= min && x.Price <= max && x.KindOfProcedures1.Name == comboBox4.Text);
                    typeofprocedureslist = temp1.ToList();
                    foreach (TypeOfProcedures t in typeofprocedureslist)
                    {
                        dataGridView7.Rows.Add(t.Id, t.Name, db.KindOfProcedures.Find(t.KindOfProcedure_ID).Name, t.Price);
                    }
                }
                if (typeofprocedureslist.Count == 0)
                {
                    MessageBox.Show("Типы процедур не найдены!", "Ортопедическая клиника");
                }
            }
        }
        private void textBox20_KeyPress(object sender, KeyPressEventArgs e)//ввод только цифр
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void textBox17_KeyPress(object sender, KeyPressEventArgs e)//ввод только цифр
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
        private void button19_Click(object sender, EventArgs e)//сброс
        {
            comboBox4.Text = "";
            textBox20.Text = "";
            textBox17.Text = "";
            tabControl1_SelectedIndexChanged(sender, e);
        }
        private void button29_Click(object sender, EventArgs e)//////////////////////////////////////////////treatmentplans////////////////////////////////////////////////////////////////////////////////////////////////
        {
            if (textBox21.Text != "")
            {
                List<TreatmentPlans> treatmentplanlist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView8.Rows.Clear();
                    var temp1 = db.TreatmentPlans.Where(x => x.DeleteTime == null && x.Patients.Name == textBox21.Text);
                    treatmentplanlist = temp1.ToList();
                    foreach (TreatmentPlans t in treatmentplanlist)
                    {
                        dataGridView8.Rows.Add(t.Id, db.Patients.Find(t.Patient_ID).Name, db.Workers.Find(t.Worker_ID).Name);
                    }
                }
                if (treatmentplanlist.Count == 0)
                {
                    MessageBox.Show("Планы лечения не найдены!", "Ортопедическая клиника");
                }
            }
            if (comboBox8.Text != "")
            {
                List<TreatmentPlans> treatmentplanlist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView8.Rows.Clear();
                    var temp1 = db.TreatmentPlans.Where(x => x.DeleteTime == null && x.Workers.Name == comboBox8.Text);
                    treatmentplanlist = temp1.ToList();
                    foreach (TreatmentPlans t in treatmentplanlist)
                    {
                        dataGridView8.Rows.Add(t.Id, db.Patients.Find(t.Patient_ID).Name, db.Workers.Find(t.Worker_ID).Name);
                    }
                }
                if (treatmentplanlist.Count == 0)
                {
                    MessageBox.Show("Планы лечения не найдены!", "Ортопедическая клиника");
                }
            }
            if (comboBox8.Text != "" && textBox21.Text != "")
            {
                List<TreatmentPlans> treatmentplanlist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView8.Rows.Clear();
                    var temp1 = db.TreatmentPlans.Where(x => x.DeleteTime == null && x.Workers.Name == comboBox8.Text && x.Patients.Name == textBox21.Text);
                    treatmentplanlist = temp1.ToList();
                    foreach (TreatmentPlans t in treatmentplanlist)
                    {
                        dataGridView8.Rows.Add(t.Id, db.Patients.Find(t.Patient_ID).Name, db.Workers.Find(t.Worker_ID).Name);
                    }
                }
                if (treatmentplanlist.Count == 0)
                {
                    MessageBox.Show("Планы лечения не найдены!", "Ортопедическая клиника");
                }
            }
        }
        private void button23_Click(object sender, EventArgs e)//сброс
        {
            textBox21.Text = "";
            comboBox8.Text = "";
            tabControl1_SelectedIndexChanged(sender, e);
        }
        private void button33_Click(object sender, EventArgs e)//////////////////////////////////////////////////////////////////////////////////diagnosises///////////////////////////////////////////////////////////////////////////////
        {
            if (textBox24.Text != "")
            {
                List<Diagnosises> diagnosiseslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView9.Rows.Clear();
                    var temp1 = db.Diagnosises.Where(x => x.DeleteTime == null && x.Patients.Name == textBox24.Text);
                    diagnosiseslist = temp1.ToList();
                    foreach (Diagnosises d in diagnosiseslist)
                    {
                        dataGridView9.Rows.Add(d.Id, d.Date, d.Name, db.Patients.Find(d.Patient_ID).Name, db.Workers.Find(d.Worker_ID).Name, d.Status);
                    }
                }
                if (diagnosiseslist.Count == 0)
                {
                    MessageBox.Show("Диагнозы не найдены!", "Ортопедическая клиника");
                }
            }
            if (comboBox9.Text != "")
            {
                List<Diagnosises> diagnosiseslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView9.Rows.Clear();
                    var temp1 = db.Diagnosises.Where(x => x.DeleteTime == null && x.Workers.Name == comboBox9.Text);
                    diagnosiseslist = temp1.ToList();
                    foreach (Diagnosises d in diagnosiseslist)
                    {
                        dataGridView9.Rows.Add(d.Id, d.Date, d.Name, db.Patients.Find(d.Patient_ID).Name, db.Workers.Find(d.Worker_ID).Name, d.Status);
                    }
                }
                if (diagnosiseslist.Count == 0)
                {
                    MessageBox.Show("Диагнозы не найдены!", "Ортопедическая клиника");
                }
            }
            if (dateTimePicker6.Enabled == true)
            {
                List<Diagnosises> diagnosiseslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView9.Rows.Clear();
                    var temp1 = db.Diagnosises.Where(x => x.DeleteTime == null && x.Date >= dateTimePicker6.Value && x.Date <= dateTimePicker7.Value);
                    diagnosiseslist = temp1.ToList();
                    foreach (Diagnosises d in diagnosiseslist)
                    {
                        dataGridView9.Rows.Add(d.Id, d.Date, d.Name, db.Patients.Find(d.Patient_ID).Name, db.Workers.Find(d.Worker_ID).Name, d.Status);
                    }
                }
                if (diagnosiseslist.Count == 0)
                {
                    MessageBox.Show("Диагнозы не найдены!", "Ортопедическая клиника");
                }
            }
            if (comboBox9.Text != "" && textBox24.Text != "")
            {
                List<Diagnosises> diagnosiseslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView9.Rows.Clear();
                    var temp1 = db.Diagnosises.Where(x => x.DeleteTime == null && x.Workers.Name == comboBox9.Text && x.Patients.Name == textBox24.Text);
                    diagnosiseslist = temp1.ToList();
                    foreach (Diagnosises d in diagnosiseslist)
                    {
                        dataGridView9.Rows.Add(d.Id, d.Date, d.Name, db.Patients.Find(d.Patient_ID).Name, db.Workers.Find(d.Worker_ID).Name, d.Status);
                    }
                }
                if (diagnosiseslist.Count == 0)
                {
                    MessageBox.Show("Диагнозы не найдены!", "Ортопедическая клиника");
                }
            }
            if (dateTimePicker6.Enabled == true && textBox24.Text!="")
            {
                List<Diagnosises> diagnosiseslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView9.Rows.Clear();
                    var temp1 = db.Diagnosises.Where(x => x.DeleteTime == null && x.Patients.Name == textBox24.Text && x.Date >= dateTimePicker6.Value && x.Date <= dateTimePicker7.Value);
                    diagnosiseslist = temp1.ToList();
                    foreach (Diagnosises d in diagnosiseslist)
                    {
                        dataGridView9.Rows.Add(d.Id, d.Date, d.Name, db.Patients.Find(d.Patient_ID).Name, db.Workers.Find(d.Worker_ID).Name, d.Status);
                    }
                }
                if (diagnosiseslist.Count == 0)
                {
                    MessageBox.Show("Диагнозы не найдены!", "Ортопедическая клиника");
                }
            }
            if (dateTimePicker6.Enabled == true && comboBox9.Text != "")
            {
                List<Diagnosises> diagnosiseslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView9.Rows.Clear();
                    var temp1 = db.Diagnosises.Where(x => x.DeleteTime == null && x.Workers.Name == comboBox9.Text && x.Date >= dateTimePicker6.Value && x.Date <= dateTimePicker7.Value);
                    diagnosiseslist = temp1.ToList();
                    foreach (Diagnosises d in diagnosiseslist)
                    {
                        dataGridView9.Rows.Add(d.Id, d.Date, d.Name, db.Patients.Find(d.Patient_ID).Name, db.Workers.Find(d.Worker_ID).Name, d.Status);
                    }
                }
                if (diagnosiseslist.Count == 0)
                {
                    MessageBox.Show("Диагнозы не найдены!", "Ортопедическая клиника");
                }
            }
            if (dateTimePicker6.Enabled == true && textBox24.Text != "" && comboBox9.Text != "")
            {
                List<Diagnosises> diagnosiseslist;
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView9.Rows.Clear();
                    var temp1 = db.Diagnosises.Where(x => x.DeleteTime == null && x.Workers.Name == comboBox9.Text && x.Patients.Name == textBox24.Text && x.Date >= dateTimePicker6.Value && x.Date <= dateTimePicker7.Value);
                    diagnosiseslist = temp1.ToList();
                    foreach (Diagnosises d in diagnosiseslist)
                    {
                        dataGridView9.Rows.Add(d.Id, d.Date, d.Name, db.Patients.Find(d.Patient_ID).Name, db.Workers.Find(d.Worker_ID).Name, d.Status);
                    }
                }
                if (diagnosiseslist.Count == 0)
                {
                    MessageBox.Show("Диагнозы не найдены!", "Ортопедическая клиника");
                }
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked == true)
            {
                dateTimePicker6.Enabled = true;
                dateTimePicker7.Enabled = true;
            }
            else
            {
                dateTimePicker6.Enabled = false;
                dateTimePicker7.Enabled = false;
            }
        }
        private void button24_Click(object sender, EventArgs e)//сброс
        {
            textBox24.Text = "";
            comboBox9.Text = "";
            radioButton5.Checked = false;
            tabControl1_SelectedIndexChanged(sender, e);
        }

        private void button37_Click(object sender, EventArgs e)//////////////////////////////workinghours/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        {
            if (comboBox6.Text != "")
            {
                using (ClinicEntities1 db = new ClinicEntities1())
                {
                    dataGridView6.Rows.Clear();
                    var groupbyname = from w in db.WorkingHours.Where(x => x.Workers.Name == comboBox6.Text)
                                      group w by w.Workers.Name;
                    foreach (var g in groupbyname)
                    {
                        dataGridView6.Rows.Add(g.Key);
                        foreach (var wc in g)
                        {
                            DateTime start = Convert.ToDateTime(wc.TimeStart);
                            DateTime end = Convert.ToDateTime(wc.TimeEnd);
                            dataGridView6.Rows.Add(wc.Id, Convert.ToString(start), Convert.ToString(start.TimeOfDay), Convert.ToString(end.TimeOfDay), db.Cabinets.Find(wc.Cabinet_ID).Name, db.Workers.Find(wc.Worker_ID).Name);
                        }
                    }
                }
            }
        }
        private void button27_Click(object sender, EventArgs e)//сброс
        {
            comboBox6.Text = "";
            tabControl1_SelectedIndexChanged(sender, e);
        }
        ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////RABOTASOSTRANICAMI/////////////////////////////////////////////////////////////////////////////////////
        private void button2_Click(object sender, EventArgs e)//стр врачи лист назад
        {
            button3.Enabled = true;
            currentpage--;
            if (currentpage==1)
            {
                button2.Enabled = false;
            }            
            FillGridWithWorkers(currentpage, currentcountonpage);
            label1.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button3_Click(object sender, EventArgs e)//стр врачи лист вперёд
        {
            button2.Enabled = true;
            currentpage++;
            if (currentpage==maxpage)
            {
                button3.Enabled = false;
            }            
            FillGridWithWorkers(currentpage, currentcountonpage);
            label1.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button4_Click(object sender, EventArgs e)//стр пац лист вперёд
        {
            button5.Enabled = true;
            currentpage--;
            if (currentpage == 1)
            {
                button4.Enabled = false;
            }
            FillGridWithPatients(currentpage, currentcountonpage);
            label2.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button5_Click(object sender, EventArgs e)//стр пац лист nazad
        {
            button4.Enabled = true;
            currentpage++;
            if (currentpage == maxpage)
            {
                button5.Enabled = false;
            }
            FillGridWithPatients(currentpage, currentcountonpage);
            label2.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button35_Click(object sender, EventArgs e)//стр диагноза вперед
        {
            button36.Enabled = true;
            currentpage--;
            if (currentpage == 1)
            {
                button35.Enabled = false;
            }
            FillGridWithDiagnosises(currentpage, currentcountonpage);
            label51.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button36_Click(object sender, EventArgs e)//стр диагноза назад
        {
            button35.Enabled = true;
            currentpage++;
            if (currentpage == maxpage)
            {
                button36.Enabled = false;
            }
            FillGridWithDiagnosises(currentpage, currentcountonpage);
            label51.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button14_Click(object sender, EventArgs e)//стр процедуры назад
        {
            button15.Enabled = true;
            currentpage--;
            if (currentpage == 1)
            {
                button14.Enabled = false;
            }
            FillGridWithProcedures(currentpage, currentcountonpage);
            label5.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button15_Click(object sender, EventArgs e)//стр процедуры вперёд
        {
            button14.Enabled = true;
            currentpage++;
            if (currentpage == maxpage)
            {
                button15.Enabled = false;
            }
            FillGridWithProcedures(currentpage, currentcountonpage);
            label5.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button20_Click(object sender, EventArgs e)//стр типпроц назад
        {
            button21.Enabled = true;
            currentpage--;
            if (currentpage == 1)
            {
                button20.Enabled = false;
            }
            FillGridWithTypeOfProcedures(currentpage, currentcountonpage);
            label41.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button21_Click(object sender, EventArgs e)//стр типпроц вперёд
        {
            button20.Enabled = true;
            currentpage++;
            if (currentpage == maxpage)
            {
                button21.Enabled = false;
            }
            FillGridWithTypeOfProcedures(currentpage, currentcountonpage);
            label41.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button11_Click(object sender, EventArgs e)//стр кабинет назад
        {
            button10.Enabled = true;
            currentpage--;
            if (currentpage == 1)
            {
                button11.Enabled = false;
            }
            FillGridWithCabinets(currentpage, currentcountonpage);
            label4.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button10_Click(object sender, EventArgs e)//стр кабинет вперёд
        {
            button11.Enabled = true;
            currentpage++;
            if (currentpage == maxpage)
            {
                button10.Enabled = false;
            }
            FillGridWithCabinets(currentpage, currentcountonpage);
            label4.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button7_Click(object sender, EventArgs e)//стр визит назад
        {
            button8.Enabled = true;
            currentpage--;
            if (currentpage == 1)
            {
                button7.Enabled = false;
            }
            FillGridWithVisits(currentpage, currentcountonpage);
            label3.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button8_Click(object sender, EventArgs e)//стр визит вперёд
        {
            button7.Enabled = true;
            currentpage++;
            if (currentpage == maxpage)
            {
                button8.Enabled = false;
            }
            FillGridWithVisits(currentpage, currentcountonpage);
            label3.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button31_Click(object sender, EventArgs e)////стр планылечения назад
        {
            button32.Enabled = true;
            currentpage--;
            if (currentpage == 1)
            {
                button31.Enabled = false;
            }
            FillGridWithTreatMentPlans(currentpage, currentcountonpage);
            label47.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button32_Click(object sender, EventArgs e)//стр планы лечения вперёд
        {
            button31.Enabled = true;
            currentpage++;
            if (currentpage == maxpage)
            {
                button32.Enabled = false;
            }
            FillGridWithTreatMentPlans(currentpage, currentcountonpage);
            label47.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void button18_Click(object sender, EventArgs e)//стр воркингхаурс назад
        {
            button25.Enabled = true;
            currentpage--;
            if (currentpage == 1)
            {
                button18.Enabled = false;
            }
            FillGridWithWorkingHours(currentpage, currentcountonpage);
            label29.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }
        private void button25_Click(object sender, EventArgs e)//стр воркингхаурс вперёд
        {
            button18.Enabled = true;
            currentpage++;
            if (currentpage == maxpage)
            {
                button25.Enabled = false;
            }
            FillGridWithWorkingHours(currentpage, currentcountonpage);
            label29.Text = "Страница:" + Convert.ToString(currentpage) + "/" + maxpage;
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            button16.Enabled = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {            
            currentcountonpage = Convert.ToInt32(numericUpDown1.Value);
            tabControl1_SelectedIndexChanged(numericUpDown1, e);
        }

        private void textBox5_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Вводите имя пациента полностью!", this.textBox5);
        }

        private void SearchPatientName_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.Show("Учитывается регистр!", this.textBox5);
        }
    }
}
