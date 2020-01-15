namespace OrthopedicClinic
{
    partial class DiagnosisCard
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
            this.DescLbl = new System.Windows.Forms.TextBox();
            this.WorkerNameLkLbl = new System.Windows.Forms.LinkLabel();
            this.PatientNameLkLbl = new System.Windows.Forms.LinkLabel();
            this.EditBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.DiagnosisNameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DateLbl = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.StatusLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DescLbl
            // 
            this.DescLbl.Enabled = false;
            this.DescLbl.Location = new System.Drawing.Point(2, 148);
            this.DescLbl.Multiline = true;
            this.DescLbl.Name = "DescLbl";
            this.DescLbl.Size = new System.Drawing.Size(262, 48);
            this.DescLbl.TabIndex = 57;
            // 
            // WorkerNameLkLbl
            // 
            this.WorkerNameLkLbl.AutoSize = true;
            this.WorkerNameLkLbl.Location = new System.Drawing.Point(166, 34);
            this.WorkerNameLkLbl.Name = "WorkerNameLkLbl";
            this.WorkerNameLkLbl.Size = new System.Drawing.Size(55, 13);
            this.WorkerNameLkLbl.TabIndex = 55;
            this.WorkerNameLkLbl.TabStop = true;
            this.WorkerNameLkLbl.Text = "linkLabel1";
            this.WorkerNameLkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WorkerNameLkLbl_LinkClicked);
            // 
            // PatientNameLkLbl
            // 
            this.PatientNameLkLbl.AutoSize = true;
            this.PatientNameLkLbl.Location = new System.Drawing.Point(166, 9);
            this.PatientNameLkLbl.Name = "PatientNameLkLbl";
            this.PatientNameLkLbl.Size = new System.Drawing.Size(55, 13);
            this.PatientNameLkLbl.TabIndex = 56;
            this.PatientNameLkLbl.TabStop = true;
            this.PatientNameLkLbl.Text = "linkLabel1";
            this.PatientNameLkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PatientNameLkLbl_LinkClicked);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(94, 202);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(170, 23);
            this.EditBtn.TabIndex = 54;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(189, 231);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 23);
            this.DelBtn.TabIndex = 53;
            this.DelBtn.Text = "Удалить";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // DiagnosisNameLbl
            // 
            this.DiagnosisNameLbl.AutoSize = true;
            this.DiagnosisNameLbl.Location = new System.Drawing.Point(166, 60);
            this.DiagnosisNameLbl.Name = "DiagnosisNameLbl";
            this.DiagnosisNameLbl.Size = new System.Drawing.Size(35, 13);
            this.DiagnosisNameLbl.TabIndex = 48;
            this.DiagnosisNameLbl.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Название";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Работник";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 52;
            this.label7.Text = "Пациент";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Дата";
            // 
            // DateLbl
            // 
            this.DateLbl.AutoSize = true;
            this.DateLbl.Location = new System.Drawing.Point(166, 83);
            this.DateLbl.Name = "DateLbl";
            this.DateLbl.Size = new System.Drawing.Size(35, 13);
            this.DateLbl.TabIndex = 48;
            this.DateLbl.Text = "label1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Статус";
            // 
            // StatusLbl
            // 
            this.StatusLbl.AutoSize = true;
            this.StatusLbl.Location = new System.Drawing.Point(166, 106);
            this.StatusLbl.Name = "StatusLbl";
            this.StatusLbl.Size = new System.Drawing.Size(35, 13);
            this.StatusLbl.TabIndex = 48;
            this.StatusLbl.Text = "label1";
            // 
            // DiagnosisCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 259);
            this.Controls.Add(this.DescLbl);
            this.Controls.Add(this.WorkerNameLkLbl);
            this.Controls.Add(this.PatientNameLkLbl);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.StatusLbl);
            this.Controls.Add(this.DateLbl);
            this.Controls.Add(this.DiagnosisNameLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "DiagnosisCard";
            this.Text = "Диагноз";
            this.Load += new System.EventHandler(this.DiagnosisCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DescLbl;
        private System.Windows.Forms.LinkLabel WorkerNameLkLbl;
        private System.Windows.Forms.LinkLabel PatientNameLkLbl;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Label DiagnosisNameLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label DateLbl;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label StatusLbl;
    }
}