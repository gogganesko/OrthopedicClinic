namespace OrthopedicClinic
{
    partial class DiagnosisEdit
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
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Desc = new System.Windows.Forms.TextBox();
            this.Diagnosisname = new System.Windows.Forms.TextBox();
            this.WorkerCmbx = new System.Windows.Forms.ComboBox();
            this.PatientLbl = new System.Windows.Forms.Label();
            this.AddPatientBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.DateDTP = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.StatusCmbx = new System.Windows.Forms.ComboBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(197, 205);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 42;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Работник";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 41;
            this.label7.Text = "Пациент";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Описание";
            // 
            // Desc
            // 
            this.Desc.Location = new System.Drawing.Point(15, 151);
            this.Desc.Multiline = true;
            this.Desc.Name = "Desc";
            this.Desc.Size = new System.Drawing.Size(257, 48);
            this.Desc.TabIndex = 47;
            // 
            // Diagnosisname
            // 
            this.Diagnosisname.Location = new System.Drawing.Point(151, 52);
            this.Diagnosisname.Name = "Diagnosisname";
            this.Diagnosisname.Size = new System.Drawing.Size(121, 20);
            this.Diagnosisname.TabIndex = 48;
            this.Diagnosisname.Validating += new System.ComponentModel.CancelEventHandler(this.Diagnosisname_Validating);
            // 
            // WorkerCmbx
            // 
            this.WorkerCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WorkerCmbx.FormattingEnabled = true;
            this.WorkerCmbx.Location = new System.Drawing.Point(151, 26);
            this.WorkerCmbx.Name = "WorkerCmbx";
            this.WorkerCmbx.Size = new System.Drawing.Size(121, 21);
            this.WorkerCmbx.TabIndex = 49;
            this.WorkerCmbx.Validating += new System.ComponentModel.CancelEventHandler(this.WorkerCmbx_Validating);
            // 
            // PatientLbl
            // 
            this.PatientLbl.AutoSize = true;
            this.PatientLbl.Location = new System.Drawing.Point(151, 7);
            this.PatientLbl.Name = "PatientLbl";
            this.PatientLbl.Size = new System.Drawing.Size(57, 13);
            this.PatientLbl.TabIndex = 50;
            this.PatientLbl.Text = "Выберите";
            // 
            // AddPatientBtn
            // 
            this.AddPatientBtn.Location = new System.Drawing.Point(211, 2);
            this.AddPatientBtn.Name = "AddPatientBtn";
            this.AddPatientBtn.Size = new System.Drawing.Size(61, 20);
            this.AddPatientBtn.TabIndex = 51;
            this.AddPatientBtn.Text = "Выбрать";
            this.AddPatientBtn.UseVisualStyleBackColor = true;
            this.AddPatientBtn.Click += new System.EventHandler(this.AddPatientBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Дата";
            // 
            // DateDTP
            // 
            this.DateDTP.Location = new System.Drawing.Point(151, 78);
            this.DateDTP.Name = "DateDTP";
            this.DateDTP.Size = new System.Drawing.Size(121, 20);
            this.DateDTP.TabIndex = 59;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Статус";
            // 
            // StatusCmbx
            // 
            this.StatusCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusCmbx.FormattingEnabled = true;
            this.StatusCmbx.Location = new System.Drawing.Point(151, 104);
            this.StatusCmbx.Name = "StatusCmbx";
            this.StatusCmbx.Size = new System.Drawing.Size(121, 21);
            this.StatusCmbx.TabIndex = 49;
            this.StatusCmbx.Validating += new System.ComponentModel.CancelEventHandler(this.StatusCmbx_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkRate = 0;
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
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
            // DiagnosisEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 233);
            this.Controls.Add(this.DateDTP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddPatientBtn);
            this.Controls.Add(this.PatientLbl);
            this.Controls.Add(this.StatusCmbx);
            this.Controls.Add(this.WorkerCmbx);
            this.Controls.Add(this.Diagnosisname);
            this.Controls.Add(this.Desc);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DiagnosisEdit";
            this.Text = "Редактирование диагноза";
            this.Load += new System.EventHandler(this.DiagnosisEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Desc;
        private System.Windows.Forms.TextBox Diagnosisname;
        private System.Windows.Forms.ComboBox WorkerCmbx;
        private System.Windows.Forms.Label PatientLbl;
        private System.Windows.Forms.Button AddPatientBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DateDTP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox StatusCmbx;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}