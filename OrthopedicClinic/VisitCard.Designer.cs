namespace OrthopedicClinic
{
    partial class VisitCard
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
            this.EditBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DescTxtBx = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dateStartDTP = new System.Windows.Forms.DateTimePicker();
            this.dateEndDTP = new System.Windows.Forms.DateTimePicker();
            this.PatientLkLbl = new System.Windows.Forms.LinkLabel();
            this.CabinetLkLbl = new System.Windows.Forms.LinkLabel();
            this.ResultTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(394, 506);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 23);
            this.DelBtn.TabIndex = 27;
            this.DelBtn.Text = "Удалить";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(299, 477);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(170, 23);
            this.EditBtn.TabIndex = 26;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Пациент";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Дата конца";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Дата начала";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Кабинет";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Описание";
            // 
            // DescTxtBx
            // 
            this.DescTxtBx.Enabled = false;
            this.DescTxtBx.Location = new System.Drawing.Point(24, 120);
            this.DescTxtBx.Multiline = true;
            this.DescTxtBx.Name = "DescTxtBx";
            this.DescTxtBx.Size = new System.Drawing.Size(248, 46);
            this.DescTxtBx.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 15;
            this.label11.Text = "Результат";
            // 
            // dateStartDTP
            // 
            this.dateStartDTP.Enabled = false;
            this.dateStartDTP.Location = new System.Drawing.Point(136, 22);
            this.dateStartDTP.Name = "dateStartDTP";
            this.dateStartDTP.Size = new System.Drawing.Size(136, 20);
            this.dateStartDTP.TabIndex = 29;
            // 
            // dateEndDTP
            // 
            this.dateEndDTP.Enabled = false;
            this.dateEndDTP.Location = new System.Drawing.Point(136, 48);
            this.dateEndDTP.Name = "dateEndDTP";
            this.dateEndDTP.Size = new System.Drawing.Size(136, 20);
            this.dateEndDTP.TabIndex = 29;
            // 
            // PatientLkLbl
            // 
            this.PatientLkLbl.AutoSize = true;
            this.PatientLkLbl.Location = new System.Drawing.Point(133, 79);
            this.PatientLkLbl.Name = "PatientLkLbl";
            this.PatientLkLbl.Size = new System.Drawing.Size(55, 13);
            this.PatientLkLbl.TabIndex = 30;
            this.PatientLkLbl.TabStop = true;
            this.PatientLkLbl.Text = "linkLabel1";
            this.PatientLkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.PatientLkLbl_LinkClicked);
            // 
            // CabinetLkLbl
            // 
            this.CabinetLkLbl.AutoSize = true;
            this.CabinetLkLbl.Location = new System.Drawing.Point(133, 6);
            this.CabinetLkLbl.Name = "CabinetLkLbl";
            this.CabinetLkLbl.Size = new System.Drawing.Size(55, 13);
            this.CabinetLkLbl.TabIndex = 30;
            this.CabinetLkLbl.TabStop = true;
            this.CabinetLkLbl.Text = "linkLabel1";
            this.CabinetLkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CabinetLkLbl_LinkClicked);
            // 
            // ResultTxtBx
            // 
            this.ResultTxtBx.Enabled = false;
            this.ResultTxtBx.Location = new System.Drawing.Point(24, 185);
            this.ResultTxtBx.Multiline = true;
            this.ResultTxtBx.Name = "ResultTxtBx";
            this.ResultTxtBx.Size = new System.Drawing.Size(248, 46);
            this.ResultTxtBx.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Список процедур";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(24, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(445, 221);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Id процедуры";
            this.Column4.Name = "Column4";
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
            // VisitCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 533);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CabinetLkLbl);
            this.Controls.Add(this.PatientLkLbl);
            this.Controls.Add(this.dateEndDTP);
            this.Controls.Add(this.dateStartDTP);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.ResultTxtBx);
            this.Controls.Add(this.DescTxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "VisitCard";
            this.Text = "Приём";
            this.Load += new System.EventHandler(this.VisitCard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox DescTxtBx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dateStartDTP;
        private System.Windows.Forms.DateTimePicker dateEndDTP;
        private System.Windows.Forms.LinkLabel PatientLkLbl;
        private System.Windows.Forms.LinkLabel CabinetLkLbl;
        private System.Windows.Forms.TextBox ResultTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}