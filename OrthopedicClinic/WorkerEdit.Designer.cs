namespace OrthopedicClinic
{
    partial class WorkerEdit
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
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.TextBox();
            this.SpecializationLbl = new System.Windows.Forms.TextBox();
            this.TelephoneNmbrLbl = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.DelProcedure = new System.Windows.Forms.Button();
            this.AddProcedure = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Номер телефона";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Специализация";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "ФИО ";
            // 
            // NameLbl
            // 
            this.NameLbl.Location = new System.Drawing.Point(51, 4);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(221, 20);
            this.NameLbl.TabIndex = 15;
            this.NameLbl.Validating += new System.ComponentModel.CancelEventHandler(this.NameLbl_Validating);
            // 
            // SpecializationLbl
            // 
            this.SpecializationLbl.Location = new System.Drawing.Point(131, 31);
            this.SpecializationLbl.Name = "SpecializationLbl";
            this.SpecializationLbl.Size = new System.Drawing.Size(141, 20);
            this.SpecializationLbl.TabIndex = 15;
            this.SpecializationLbl.Validating += new System.ComponentModel.CancelEventHandler(this.SpecializationLbl_Validating);
            // 
            // TelephoneNmbrLbl
            // 
            this.TelephoneNmbrLbl.Location = new System.Drawing.Point(131, 58);
            this.TelephoneNmbrLbl.Name = "TelephoneNmbrLbl";
            this.TelephoneNmbrLbl.Size = new System.Drawing.Size(141, 20);
            this.TelephoneNmbrLbl.TabIndex = 15;
            this.TelephoneNmbrLbl.Validating += new System.ComponentModel.CancelEventHandler(this.TelephoneNmbrLbl_Validating);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(192, 239);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 16;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(19, 105);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(248, 95);
            this.listBox2.TabIndex = 52;
            // 
            // DelProcedure
            // 
            this.DelProcedure.Location = new System.Drawing.Point(164, 210);
            this.DelProcedure.Name = "DelProcedure";
            this.DelProcedure.Size = new System.Drawing.Size(103, 23);
            this.DelProcedure.TabIndex = 50;
            this.DelProcedure.Text = "Удалить";
            this.DelProcedure.UseVisualStyleBackColor = true;
            this.DelProcedure.Click += new System.EventHandler(this.DelProcedure_Click);
            // 
            // AddProcedure
            // 
            this.AddProcedure.Location = new System.Drawing.Point(19, 210);
            this.AddProcedure.Name = "AddProcedure";
            this.AddProcedure.Size = new System.Drawing.Size(103, 23);
            this.AddProcedure.TabIndex = 51;
            this.AddProcedure.Text = "Добавить";
            this.AddProcedure.UseVisualStyleBackColor = true;
            this.AddProcedure.Click += new System.EventHandler(this.AddProcedure_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Список процедур";
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
            // WorkerEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 270);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.DelProcedure);
            this.Controls.Add(this.AddProcedure);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.TelephoneNmbrLbl);
            this.Controls.Add(this.SpecializationLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "WorkerEdit";
            this.Text = "Редактирование работника";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WorkerEdit_FormClosed);
            this.Load += new System.EventHandler(this.WorkerEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameLbl;
        private System.Windows.Forms.TextBox SpecializationLbl;
        private System.Windows.Forms.TextBox TelephoneNmbrLbl;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button DelProcedure;
        private System.Windows.Forms.Button AddProcedure;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}