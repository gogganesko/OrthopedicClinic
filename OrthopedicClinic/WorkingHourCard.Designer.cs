namespace OrthopedicClinic
{
    partial class WorkingHourCard
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
            this.DelBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CabinetNameLbl = new System.Windows.Forms.Label();
            this.DateStartLbl = new System.Windows.Forms.Label();
            this.DateEndLbl = new System.Windows.Forms.Label();
            this.WorkerLnkLbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(177, 117);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 23);
            this.DelBtn.TabIndex = 29;
            this.DelBtn.Text = "Удалить";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 89);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = "Время конца";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Время начала";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Номер кабинета";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "Врач";
            // 
            // CabinetNameLbl
            // 
            this.CabinetNameLbl.AutoSize = true;
            this.CabinetNameLbl.Location = new System.Drawing.Point(139, 34);
            this.CabinetNameLbl.Name = "CabinetNameLbl";
            this.CabinetNameLbl.Size = new System.Drawing.Size(35, 13);
            this.CabinetNameLbl.TabIndex = 52;
            this.CabinetNameLbl.Text = "label4";
            // 
            // DateStartLbl
            // 
            this.DateStartLbl.AutoSize = true;
            this.DateStartLbl.Location = new System.Drawing.Point(139, 62);
            this.DateStartLbl.Name = "DateStartLbl";
            this.DateStartLbl.Size = new System.Drawing.Size(35, 13);
            this.DateStartLbl.TabIndex = 52;
            this.DateStartLbl.Text = "label4";
            // 
            // DateEndLbl
            // 
            this.DateEndLbl.AutoSize = true;
            this.DateEndLbl.Location = new System.Drawing.Point(139, 89);
            this.DateEndLbl.Name = "DateEndLbl";
            this.DateEndLbl.Size = new System.Drawing.Size(35, 13);
            this.DateEndLbl.TabIndex = 52;
            this.DateEndLbl.Text = "label4";
            // 
            // WorkerLnkLbl
            // 
            this.WorkerLnkLbl.AutoSize = true;
            this.WorkerLnkLbl.Location = new System.Drawing.Point(139, 9);
            this.WorkerLnkLbl.Name = "WorkerLnkLbl";
            this.WorkerLnkLbl.Size = new System.Drawing.Size(55, 13);
            this.WorkerLnkLbl.TabIndex = 53;
            this.WorkerLnkLbl.TabStop = true;
            this.WorkerLnkLbl.Text = "linkLabel1";
            this.WorkerLnkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WorkerLnkLbl_LinkClicked);
            // 
            // WorkingHourCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 147);
            this.Controls.Add(this.WorkerLnkLbl);
            this.Controls.Add(this.DateEndLbl);
            this.Controls.Add(this.DateStartLbl);
            this.Controls.Add(this.CabinetNameLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DelBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WorkingHourCard";
            this.Text = "Режим работы";
            this.Load += new System.EventHandler(this.WorkingHourCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CabinetNameLbl;
        private System.Windows.Forms.Label DateStartLbl;
        private System.Windows.Forms.Label DateEndLbl;
        private System.Windows.Forms.LinkLabel WorkerLnkLbl;
    }
}