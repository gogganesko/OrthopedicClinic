namespace OrthopedicClinic
{
    partial class TreatmentPlanEdit
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
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DiagnosisesLstBx = new System.Windows.Forms.ListBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.workerscmbx = new System.Windows.Forms.ComboBox();
            this.PatientLbl = new System.Windows.Forms.Label();
            this.ChosePat = new System.Windows.Forms.Button();
            this.DelProced = new System.Windows.Forms.Button();
            this.AddProced = new System.Windows.Forms.Button();
            this.AddDiag = new System.Windows.Forms.Button();
            this.DelDiag = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(167, -14);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(55, 13);
            this.linkLabel2.TabIndex = 42;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "linkLabel2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, -14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Пациент";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 53;
            this.label4.Text = "Список процедур";
            // 
            // DiagnosisesLstBx
            // 
            this.DiagnosisesLstBx.FormattingEnabled = true;
            this.DiagnosisesLstBx.Location = new System.Drawing.Point(15, 327);
            this.DiagnosisesLstBx.Name = "DiagnosisesLstBx";
            this.DiagnosisesLstBx.Size = new System.Drawing.Size(255, 43);
            this.DiagnosisesLstBx.TabIndex = 50;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(298, 489);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 49;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 430);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 82);
            this.textBox1.TabIndex = 47;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 414);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 43;
            this.label9.Text = "Описание";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 44;
            this.label7.Text = "Диагнозы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Врач";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Пациент";
            // 
            // workerscmbx
            // 
            this.workerscmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.workerscmbx.FormattingEnabled = true;
            this.workerscmbx.Location = new System.Drawing.Point(74, 32);
            this.workerscmbx.Name = "workerscmbx";
            this.workerscmbx.Size = new System.Drawing.Size(121, 21);
            this.workerscmbx.TabIndex = 55;
            this.workerscmbx.Validating += new System.ComponentModel.CancelEventHandler(this.workerscmbx_Validating);
            // 
            // PatientLbl
            // 
            this.PatientLbl.AutoSize = true;
            this.PatientLbl.Location = new System.Drawing.Point(72, 9);
            this.PatientLbl.Name = "PatientLbl";
            this.PatientLbl.Size = new System.Drawing.Size(68, 13);
            this.PatientLbl.TabIndex = 56;
            this.PatientLbl.Text = "Не выбрано";
            // 
            // ChosePat
            // 
            this.ChosePat.Location = new System.Drawing.Point(146, 4);
            this.ChosePat.Name = "ChosePat";
            this.ChosePat.Size = new System.Drawing.Size(60, 22);
            this.ChosePat.TabIndex = 57;
            this.ChosePat.Text = "Выбрать";
            this.ChosePat.UseVisualStyleBackColor = true;
            this.ChosePat.Click += new System.EventHandler(this.ChosePat_Click);
            // 
            // DelProced
            // 
            this.DelProced.Location = new System.Drawing.Point(100, 282);
            this.DelProced.Name = "DelProced";
            this.DelProced.Size = new System.Drawing.Size(82, 23);
            this.DelProced.TabIndex = 58;
            this.DelProced.Text = "Удалить";
            this.DelProced.UseVisualStyleBackColor = true;
            this.DelProced.Click += new System.EventHandler(this.DelProced_Click);
            // 
            // AddProced
            // 
            this.AddProced.Location = new System.Drawing.Point(12, 282);
            this.AddProced.Name = "AddProced";
            this.AddProced.Size = new System.Drawing.Size(82, 23);
            this.AddProced.TabIndex = 59;
            this.AddProced.Text = "Добавить";
            this.AddProced.UseVisualStyleBackColor = true;
            this.AddProced.Click += new System.EventHandler(this.AddProced_Click);
            // 
            // AddDiag
            // 
            this.AddDiag.Location = new System.Drawing.Point(12, 376);
            this.AddDiag.Name = "AddDiag";
            this.AddDiag.Size = new System.Drawing.Size(82, 23);
            this.AddDiag.TabIndex = 59;
            this.AddDiag.Text = "Добавить";
            this.AddDiag.UseVisualStyleBackColor = true;
            this.AddDiag.Click += new System.EventHandler(this.AddDiag_Click);
            // 
            // DelDiag
            // 
            this.DelDiag.Location = new System.Drawing.Point(100, 376);
            this.DelDiag.Name = "DelDiag";
            this.DelDiag.Size = new System.Drawing.Size(82, 23);
            this.DelDiag.TabIndex = 58;
            this.DelDiag.Text = "Удалить";
            this.DelDiag.UseVisualStyleBackColor = true;
            this.DelDiag.Click += new System.EventHandler(this.DelDiag_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column2,
            this.Column1,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(12, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(361, 192);
            this.dataGridView1.TabIndex = 60;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Id";
            this.Column4.Name = "Column4";
            this.Column4.Width = 20;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Тип процедуры";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Дата процедуры";
            this.Column1.Name = "Column1";
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
            // TreatmentPlanEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 518);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DelDiag);
            this.Controls.Add(this.DelProced);
            this.Controls.Add(this.AddDiag);
            this.Controls.Add(this.AddProced);
            this.Controls.Add(this.ChosePat);
            this.Controls.Add(this.PatientLbl);
            this.Controls.Add(this.workerscmbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DiagnosisesLstBx);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TreatmentPlanEdit";
            this.Text = "Редактирование плана лечения";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TreatmentPlanEdit_FormClosed);
            this.Load += new System.EventHandler(this.TreatmentPlanEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox DiagnosisesLstBx;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox workerscmbx;
        private System.Windows.Forms.Label PatientLbl;
        private System.Windows.Forms.Button ChosePat;
        private System.Windows.Forms.Button DelProced;
        private System.Windows.Forms.Button AddProced;
        private System.Windows.Forms.Button AddDiag;
        private System.Windows.Forms.Button DelDiag;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}