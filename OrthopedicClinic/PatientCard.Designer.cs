namespace OrthopedicClinic
{
    partial class PatientCard
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
            this.PhoneNmbrLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.HeightLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.WeightLbl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ShowScheduleBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.ShowTreatmentPlan = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ФИО";
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(194, 9);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(73, 13);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Иванов И. И.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Номер телефона";
            // 
            // PhoneNmbrLbl
            // 
            this.PhoneNmbrLbl.AutoSize = true;
            this.PhoneNmbrLbl.Location = new System.Drawing.Point(194, 31);
            this.PhoneNmbrLbl.Name = "PhoneNmbrLbl";
            this.PhoneNmbrLbl.Size = new System.Drawing.Size(73, 13);
            this.PhoneNmbrLbl.TabIndex = 0;
            this.PhoneNmbrLbl.Text = "89085451232";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Рост";
            // 
            // HeightLbl
            // 
            this.HeightLbl.AutoSize = true;
            this.HeightLbl.Location = new System.Drawing.Point(194, 56);
            this.HeightLbl.Name = "HeightLbl";
            this.HeightLbl.Size = new System.Drawing.Size(25, 13);
            this.HeightLbl.TabIndex = 0;
            this.HeightLbl.Text = "165";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Вес";
            // 
            // WeightLbl
            // 
            this.WeightLbl.AutoSize = true;
            this.WeightLbl.Location = new System.Drawing.Point(194, 79);
            this.WeightLbl.Name = "WeightLbl";
            this.WeightLbl.Size = new System.Drawing.Size(19, 13);
            this.WeightLbl.TabIndex = 0;
            this.WeightLbl.Text = "56";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Комментарий";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(12, 127);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 56);
            this.textBox1.TabIndex = 1;
            // 
            // ShowScheduleBtn
            // 
            this.ShowScheduleBtn.Location = new System.Drawing.Point(11, 189);
            this.ShowScheduleBtn.Name = "ShowScheduleBtn";
            this.ShowScheduleBtn.Size = new System.Drawing.Size(260, 23);
            this.ShowScheduleBtn.TabIndex = 2;
            this.ShowScheduleBtn.Text = "Просмотреть расписание";
            this.ShowScheduleBtn.UseVisualStyleBackColor = true;
            this.ShowScheduleBtn.Click += new System.EventHandler(this.ShowScheduleBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(101, 276);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(170, 23);
            this.EditBtn.TabIndex = 12;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(197, 305);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 13;
            this.button4.Text = "Удалить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ShowTreatmentPlan
            // 
            this.ShowTreatmentPlan.Location = new System.Drawing.Point(12, 218);
            this.ShowTreatmentPlan.Name = "ShowTreatmentPlan";
            this.ShowTreatmentPlan.Size = new System.Drawing.Size(260, 23);
            this.ShowTreatmentPlan.TabIndex = 2;
            this.ShowTreatmentPlan.Text = "Просмотреть план лечения";
            this.ShowTreatmentPlan.UseVisualStyleBackColor = true;
            this.ShowTreatmentPlan.Click += new System.EventHandler(this.ShowTreatmentPlan_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(12, 247);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(260, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Просмотреть счёт";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // PatientCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 334);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.ShowTreatmentPlan);
            this.Controls.Add(this.ShowScheduleBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.WeightLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.HeightLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PhoneNmbrLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PatientCard";
            this.Text = "Пациент";
            this.Load += new System.EventHandler(this.PatientCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ShowScheduleBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button ShowTreatmentPlan;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label PhoneNmbrLbl;
        private System.Windows.Forms.Label HeightLbl;
        private System.Windows.Forms.Label WeightLbl;
        private System.Windows.Forms.TextBox textBox1;
    }
}