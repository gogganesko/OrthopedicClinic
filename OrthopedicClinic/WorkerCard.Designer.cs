namespace OrthopedicClinic
{
    partial class WorkerCard
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SpecializationLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TelephonenbmrLbl = new System.Windows.Forms.Label();
            this.DelBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ShowScheduleBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ShowTreatmentPlansBtn = new System.Windows.Forms.Button();
            this.ShowWorkigHoursBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО ";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(180, 9);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(35, 13);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Специализация";
            // 
            // SpecializationLbl
            // 
            this.SpecializationLbl.AutoSize = true;
            this.SpecializationLbl.Location = new System.Drawing.Point(180, 35);
            this.SpecializationLbl.Name = "SpecializationLbl";
            this.SpecializationLbl.Size = new System.Drawing.Size(35, 13);
            this.SpecializationLbl.TabIndex = 0;
            this.SpecializationLbl.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Номер телефона";
            // 
            // TelephonenbmrLbl
            // 
            this.TelephonenbmrLbl.AutoSize = true;
            this.TelephonenbmrLbl.Location = new System.Drawing.Point(180, 61);
            this.TelephonenbmrLbl.Name = "TelephonenbmrLbl";
            this.TelephonenbmrLbl.Size = new System.Drawing.Size(35, 13);
            this.TelephonenbmrLbl.TabIndex = 0;
            this.TelephonenbmrLbl.Text = "label1";
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(196, 338);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 23);
            this.DelBtn.TabIndex = 1;
            this.DelBtn.Text = "Удалить";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(15, 104);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(256, 108);
            this.listBox1.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Список процедур";
            // 
            // ShowScheduleBtn
            // 
            this.ShowScheduleBtn.Location = new System.Drawing.Point(11, 251);
            this.ShowScheduleBtn.Name = "ShowScheduleBtn";
            this.ShowScheduleBtn.Size = new System.Drawing.Size(260, 23);
            this.ShowScheduleBtn.TabIndex = 1;
            this.ShowScheduleBtn.Text = "Просмотреть расписание процедур";
            this.ShowScheduleBtn.UseVisualStyleBackColor = true;
            this.ShowScheduleBtn.Click += new System.EventHandler(this.ShowScheduleBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(101, 309);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(170, 23);
            this.EditBtn.TabIndex = 11;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ShowTreatmentPlansBtn
            // 
            this.ShowTreatmentPlansBtn.Location = new System.Drawing.Point(11, 222);
            this.ShowTreatmentPlansBtn.Name = "ShowTreatmentPlansBtn";
            this.ShowTreatmentPlansBtn.Size = new System.Drawing.Size(260, 23);
            this.ShowTreatmentPlansBtn.TabIndex = 1;
            this.ShowTreatmentPlansBtn.Text = "Просмотреть планы лечения";
            this.ShowTreatmentPlansBtn.UseVisualStyleBackColor = true;
            this.ShowTreatmentPlansBtn.Click += new System.EventHandler(this.ShowTreatmentPlansBtn_Click);
            // 
            // ShowWorkigHoursBtn
            // 
            this.ShowWorkigHoursBtn.Location = new System.Drawing.Point(11, 280);
            this.ShowWorkigHoursBtn.Name = "ShowWorkigHoursBtn";
            this.ShowWorkigHoursBtn.Size = new System.Drawing.Size(260, 23);
            this.ShowWorkigHoursBtn.TabIndex = 1;
            this.ShowWorkigHoursBtn.Text = "Просмотреть режим работы";
            this.ShowWorkigHoursBtn.UseVisualStyleBackColor = true;
            this.ShowWorkigHoursBtn.Click += new System.EventHandler(this.ShowWorkigHoursBtn_Click);
            // 
            // WorkerCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 370);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ShowTreatmentPlansBtn);
            this.Controls.Add(this.ShowWorkigHoursBtn);
            this.Controls.Add(this.ShowScheduleBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.SpecializationLbl);
            this.Controls.Add(this.TelephonenbmrLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WorkerCard";
            this.Text = "Работник";
            this.Load += new System.EventHandler(this.WorkerCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SpecializationLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label TelephonenbmrLbl;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ShowScheduleBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button ShowTreatmentPlansBtn;
        private System.Windows.Forms.Button ShowWorkigHoursBtn;
    }
}