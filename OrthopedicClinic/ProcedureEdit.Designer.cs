namespace OrthopedicClinic
{
    partial class ProcedureEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.savebtn = new System.Windows.Forms.Button();
            this.TypeOfProcedures = new System.Windows.Forms.ComboBox();
            this.KinfOfProcedure = new System.Windows.Forms.ComboBox();
            this.DateEventDTP = new System.Windows.Forms.DateTimePicker();
            this.DateFactDTP = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTxtBx = new System.Windows.Forms.TextBox();
            this.DescTxtBx = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CabinetCmbx = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WorkerAddBtn = new System.Windows.Forms.Button();
            this.WorkerDelBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.FileAddBtn = new System.Windows.Forms.Button();
            this.FileDelBtn = new System.Windows.Forms.Button();
            this.IsOurCheck = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AddPatient = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.DateEventEndDTP = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TimeStartEventDTP = new System.Windows.Forms.DateTimePicker();
            this.TimeEndEventDTP = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(204, 574);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 34;
            this.savebtn.Text = "Сохранить";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // TypeOfProcedures
            // 
            this.TypeOfProcedures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeOfProcedures.FormattingEnabled = true;
            this.TypeOfProcedures.Location = new System.Drawing.Point(152, 257);
            this.TypeOfProcedures.Name = "TypeOfProcedures";
            this.TypeOfProcedures.Size = new System.Drawing.Size(128, 21);
            this.TypeOfProcedures.TabIndex = 32;
            this.TypeOfProcedures.Validating += new System.ComponentModel.CancelEventHandler(this.TypeOfProcedures_Validating);
            // 
            // KinfOfProcedure
            // 
            this.KinfOfProcedure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KinfOfProcedure.FormattingEnabled = true;
            this.KinfOfProcedure.Location = new System.Drawing.Point(152, 230);
            this.KinfOfProcedure.Name = "KinfOfProcedure";
            this.KinfOfProcedure.Size = new System.Drawing.Size(128, 21);
            this.KinfOfProcedure.TabIndex = 31;
            this.KinfOfProcedure.SelectedIndexChanged += new System.EventHandler(this.KinfOfProcedure_SelectedIndexChanged);
            this.KinfOfProcedure.Validating += new System.ComponentModel.CancelEventHandler(this.KinfOfProcedure_Validating);
            // 
            // DateEventDTP
            // 
            this.DateEventDTP.Location = new System.Drawing.Point(152, 127);
            this.DateEventDTP.Name = "DateEventDTP";
            this.DateEventDTP.Size = new System.Drawing.Size(128, 20);
            this.DateEventDTP.TabIndex = 30;
            // 
            // DateFactDTP
            // 
            this.DateFactDTP.Location = new System.Drawing.Point(152, 100);
            this.DateFactDTP.Name = "DateFactDTP";
            this.DateFactDTP.Size = new System.Drawing.Size(128, 20);
            this.DateFactDTP.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Тип процедуры";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Вид процедуры";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Дата события начало";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Дата фактическая";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Описание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Название";
            // 
            // NameTxtBx
            // 
            this.NameTxtBx.Location = new System.Drawing.Point(152, 12);
            this.NameTxtBx.Name = "NameTxtBx";
            this.NameTxtBx.Size = new System.Drawing.Size(128, 20);
            this.NameTxtBx.TabIndex = 35;
            // 
            // DescTxtBx
            // 
            this.DescTxtBx.Location = new System.Drawing.Point(152, 73);
            this.DescTxtBx.Name = "DescTxtBx";
            this.DescTxtBx.Size = new System.Drawing.Size(128, 20);
            this.DescTxtBx.TabIndex = 35;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Кабинет";
            // 
            // CabinetCmbx
            // 
            this.CabinetCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CabinetCmbx.FormattingEnabled = true;
            this.CabinetCmbx.Location = new System.Drawing.Point(229, 284);
            this.CabinetCmbx.Name = "CabinetCmbx";
            this.CabinetCmbx.Size = new System.Drawing.Size(51, 21);
            this.CabinetCmbx.TabIndex = 39;
            this.CabinetCmbx.Validating += new System.ComponentModel.CancelEventHandler(this.CabinetCmbx_Validating);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 356);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(266, 95);
            this.listBox1.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Список работников";
            // 
            // WorkerAddBtn
            // 
            this.WorkerAddBtn.Location = new System.Drawing.Point(12, 457);
            this.WorkerAddBtn.Name = "WorkerAddBtn";
            this.WorkerAddBtn.Size = new System.Drawing.Size(82, 23);
            this.WorkerAddBtn.TabIndex = 34;
            this.WorkerAddBtn.Text = "Добавить";
            this.WorkerAddBtn.UseVisualStyleBackColor = true;
            this.WorkerAddBtn.Click += new System.EventHandler(this.WorkerAddBtn_Click);
            // 
            // WorkerDelBtn
            // 
            this.WorkerDelBtn.Location = new System.Drawing.Point(100, 457);
            this.WorkerDelBtn.Name = "WorkerDelBtn";
            this.WorkerDelBtn.Size = new System.Drawing.Size(82, 23);
            this.WorkerDelBtn.TabIndex = 34;
            this.WorkerDelBtn.Text = "Удалить";
            this.WorkerDelBtn.UseVisualStyleBackColor = true;
            this.WorkerDelBtn.Click += new System.EventHandler(this.WorkerDelBtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 483);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 13);
            this.label12.TabIndex = 47;
            this.label12.Text = "Прикрепленные файлы";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(13, 499);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(266, 69);
            this.listBox2.TabIndex = 46;
            this.listBox2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDoubleClick);
            // 
            // FileAddBtn
            // 
            this.FileAddBtn.Location = new System.Drawing.Point(12, 574);
            this.FileAddBtn.Name = "FileAddBtn";
            this.FileAddBtn.Size = new System.Drawing.Size(82, 23);
            this.FileAddBtn.TabIndex = 34;
            this.FileAddBtn.Text = "Добавить";
            this.FileAddBtn.UseVisualStyleBackColor = true;
            this.FileAddBtn.Click += new System.EventHandler(this.FileAddBtn_Click);
            // 
            // FileDelBtn
            // 
            this.FileDelBtn.Location = new System.Drawing.Point(100, 574);
            this.FileDelBtn.Name = "FileDelBtn";
            this.FileDelBtn.Size = new System.Drawing.Size(82, 23);
            this.FileDelBtn.TabIndex = 34;
            this.FileDelBtn.Text = "Удалить";
            this.FileDelBtn.UseVisualStyleBackColor = true;
            this.FileDelBtn.Click += new System.EventHandler(this.FileDelBtn_Click);
            // 
            // IsOurCheck
            // 
            this.IsOurCheck.AutoSize = true;
            this.IsOurCheck.Location = new System.Drawing.Point(14, 320);
            this.IsOurCheck.Name = "IsOurCheck";
            this.IsOurCheck.Size = new System.Drawing.Size(113, 17);
            this.IsOurCheck.TabIndex = 48;
            this.IsOurCheck.Text = "В нашей клинике";
            this.IsOurCheck.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Пациент";
            // 
            // AddPatient
            // 
            this.AddPatient.Location = new System.Drawing.Point(214, 44);
            this.AddPatient.Name = "AddPatient";
            this.AddPatient.Size = new System.Drawing.Size(66, 23);
            this.AddPatient.TabIndex = 49;
            this.AddPatient.Text = "Выбрать";
            this.AddPatient.UseVisualStyleBackColor = true;
            this.AddPatient.Click += new System.EventHandler(this.AddPatient_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(149, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Выберите";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // DateEventEndDTP
            // 
            this.DateEventEndDTP.Location = new System.Drawing.Point(152, 153);
            this.DateEventEndDTP.Name = "DateEventEndDTP";
            this.DateEventEndDTP.Size = new System.Drawing.Size(128, 20);
            this.DateEventEndDTP.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Дата события конец";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 185);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Время начала";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(12, 212);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(73, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "Время конец";
            // 
            // TimeStartEventDTP
            // 
            this.TimeStartEventDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeStartEventDTP.Location = new System.Drawing.Point(152, 178);
            this.TimeStartEventDTP.Name = "TimeStartEventDTP";
            this.TimeStartEventDTP.Size = new System.Drawing.Size(128, 20);
            this.TimeStartEventDTP.TabIndex = 30;
            // 
            // TimeEndEventDTP
            // 
            this.TimeEndEventDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeEndEventDTP.Location = new System.Drawing.Point(152, 204);
            this.TimeEndEventDTP.Name = "TimeEndEventDTP";
            this.TimeEndEventDTP.Size = new System.Drawing.Size(128, 20);
            this.TimeEndEventDTP.TabIndex = 51;
            // 
            // ProcedureEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 626);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.TimeEndEventDTP);
            this.Controls.Add(this.DateEventEndDTP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.AddPatient);
            this.Controls.Add(this.IsOurCheck);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CabinetCmbx);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DescTxtBx);
            this.Controls.Add(this.NameTxtBx);
            this.Controls.Add(this.FileDelBtn);
            this.Controls.Add(this.WorkerDelBtn);
            this.Controls.Add(this.FileAddBtn);
            this.Controls.Add(this.WorkerAddBtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.TypeOfProcedures);
            this.Controls.Add(this.KinfOfProcedure);
            this.Controls.Add(this.TimeStartEventDTP);
            this.Controls.Add(this.DateEventDTP);
            this.Controls.Add(this.DateFactDTP);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProcedureEdit";
            this.Text = "Редактирование процедуры";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProcedureEdit_FormClosed);
            this.Load += new System.EventHandler(this.ProcedureEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.ComboBox TypeOfProcedures;
        private System.Windows.Forms.ComboBox KinfOfProcedure;
        private System.Windows.Forms.DateTimePicker DateEventDTP;
        private System.Windows.Forms.DateTimePicker DateFactDTP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTxtBx;
        private System.Windows.Forms.TextBox DescTxtBx;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CabinetCmbx;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button WorkerAddBtn;
        private System.Windows.Forms.Button WorkerDelBtn;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button FileAddBtn;
        private System.Windows.Forms.Button FileDelBtn;
        private System.Windows.Forms.CheckBox IsOurCheck;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddPatient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker DateEventEndDTP;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker TimeEndEventDTP;
        private System.Windows.Forms.DateTimePicker TimeStartEventDTP;
        private System.Windows.Forms.Label label13;
    }
}