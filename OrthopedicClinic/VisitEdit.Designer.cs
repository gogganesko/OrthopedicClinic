namespace OrthopedicClinic
{
    partial class VisitEdit
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
            this.DateEndDTP = new System.Windows.Forms.DateTimePicker();
            this.dateStartDTP = new System.Windows.Forms.DateTimePicker();
            this.DescTxtBx = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ResultTxtBx = new System.Windows.Forms.TextBox();
            this.CabinetCmbx = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddProcedureBtn = new System.Windows.Forms.Button();
            this.DelProcedureBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.PatientLbl = new System.Windows.Forms.Label();
            this.AddPatientBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // DateEndDTP
            // 
            this.DateEndDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.DateEndDTP.Location = new System.Drawing.Point(132, 61);
            this.DateEndDTP.Name = "DateEndDTP";
            this.DateEndDTP.Size = new System.Drawing.Size(136, 20);
            this.DateEndDTP.TabIndex = 44;
            // 
            // dateStartDTP
            // 
            this.dateStartDTP.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateStartDTP.Location = new System.Drawing.Point(132, 33);
            this.dateStartDTP.Name = "dateStartDTP";
            this.dateStartDTP.Size = new System.Drawing.Size(136, 20);
            this.dateStartDTP.TabIndex = 45;
            // 
            // DescTxtBx
            // 
            this.DescTxtBx.Location = new System.Drawing.Point(20, 134);
            this.DescTxtBx.Multiline = true;
            this.DescTxtBx.Name = "DescTxtBx";
            this.DescTxtBx.Size = new System.Drawing.Size(248, 46);
            this.DescTxtBx.TabIndex = 40;
            this.DescTxtBx.Validating += new System.ComponentModel.CancelEventHandler(this.DescTxtBx_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 183);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "Результат";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Описание";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Пациент";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Дата конца";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Дата начала";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Кабинет";
            // 
            // ResultTxtBx
            // 
            this.ResultTxtBx.Location = new System.Drawing.Point(20, 199);
            this.ResultTxtBx.Multiline = true;
            this.ResultTxtBx.Name = "ResultTxtBx";
            this.ResultTxtBx.Size = new System.Drawing.Size(248, 38);
            this.ResultTxtBx.TabIndex = 47;
            // 
            // CabinetCmbx
            // 
            this.CabinetCmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CabinetCmbx.FormattingEnabled = true;
            this.CabinetCmbx.Location = new System.Drawing.Point(132, 6);
            this.CabinetCmbx.Name = "CabinetCmbx";
            this.CabinetCmbx.Size = new System.Drawing.Size(40, 21);
            this.CabinetCmbx.TabIndex = 49;
            this.CabinetCmbx.Validating += new System.ComponentModel.CancelEventHandler(this.CabinetCmbx_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "Список процедур";
            // 
            // AddProcedureBtn
            // 
            this.AddProcedureBtn.Location = new System.Drawing.Point(20, 454);
            this.AddProcedureBtn.Name = "AddProcedureBtn";
            this.AddProcedureBtn.Size = new System.Drawing.Size(103, 23);
            this.AddProcedureBtn.TabIndex = 42;
            this.AddProcedureBtn.Text = "Добавить";
            this.AddProcedureBtn.UseVisualStyleBackColor = true;
            this.AddProcedureBtn.Click += new System.EventHandler(this.AddProcedureBtn_Click);
            // 
            // DelProcedureBtn
            // 
            this.DelProcedureBtn.Location = new System.Drawing.Point(132, 454);
            this.DelProcedureBtn.Name = "DelProcedureBtn";
            this.DelProcedureBtn.Size = new System.Drawing.Size(103, 23);
            this.DelProcedureBtn.TabIndex = 42;
            this.DelProcedureBtn.Text = "Удалить";
            this.DelProcedureBtn.UseVisualStyleBackColor = true;
            this.DelProcedureBtn.Click += new System.EventHandler(this.DelProcedureBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(390, 454);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 51;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // PatientLbl
            // 
            this.PatientLbl.AutoSize = true;
            this.PatientLbl.Location = new System.Drawing.Point(132, 95);
            this.PatientLbl.Name = "PatientLbl";
            this.PatientLbl.Size = new System.Drawing.Size(68, 13);
            this.PatientLbl.TabIndex = 52;
            this.PatientLbl.Text = "Не выбрано";
            // 
            // AddPatientBtn
            // 
            this.AddPatientBtn.Location = new System.Drawing.Point(209, 91);
            this.AddPatientBtn.Name = "AddPatientBtn";
            this.AddPatientBtn.Size = new System.Drawing.Size(59, 23);
            this.AddPatientBtn.TabIndex = 53;
            this.AddPatientBtn.Text = "Выбрать";
            this.AddPatientBtn.UseVisualStyleBackColor = true;
            this.AddPatientBtn.Click += new System.EventHandler(this.AddPatientBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(20, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(445, 192);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Id процедуры";
            this.Column5.Name = "Column5";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Тип процедуры";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Дата процедуры";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Стоимость";
            this.Column3.Name = "Column3";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // VisitEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 486);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddPatientBtn);
            this.Controls.Add(this.PatientLbl);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.CabinetCmbx);
            this.Controls.Add(this.ResultTxtBx);
            this.Controls.Add(this.DateEndDTP);
            this.Controls.Add(this.dateStartDTP);
            this.Controls.Add(this.DelProcedureBtn);
            this.Controls.Add(this.AddProcedureBtn);
            this.Controls.Add(this.DescTxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "VisitEdit";
            this.Text = "Редактирование приёма";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VisitEdit_FormClosed);
            this.Load += new System.EventHandler(this.VisitEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DateEndDTP;
        private System.Windows.Forms.DateTimePicker dateStartDTP;
        private System.Windows.Forms.TextBox DescTxtBx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ResultTxtBx;
        private System.Windows.Forms.ComboBox CabinetCmbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddProcedureBtn;
        private System.Windows.Forms.Button DelProcedureBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label PatientLbl;
        private System.Windows.Forms.Button AddPatientBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}