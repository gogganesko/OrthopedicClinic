namespace OrthopedicClinic
{
    partial class TypeOfProcedureEdit
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
            this.KOPcmbx = new System.Windows.Forms.ComboBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NameLbl = new System.Windows.Forms.TextBox();
            this.PriceLbl = new System.Windows.Forms.TextBox();
            this.DescLbl = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // KOPcmbx
            // 
            this.KOPcmbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KOPcmbx.FormattingEnabled = true;
            this.KOPcmbx.Location = new System.Drawing.Point(151, 34);
            this.KOPcmbx.Name = "KOPcmbx";
            this.KOPcmbx.Size = new System.Drawing.Size(121, 21);
            this.KOPcmbx.TabIndex = 35;
            this.KOPcmbx.Validating += new System.ComponentModel.CancelEventHandler(this.KOPcmbx_Validating);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(197, 188);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 31;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Вид процедуры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Название";
            // 
            // NameLbl
            // 
            this.NameLbl.Location = new System.Drawing.Point(151, 7);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(100, 20);
            this.NameLbl.TabIndex = 36;
            this.NameLbl.Validating += new System.ComponentModel.CancelEventHandler(this.NameLbl_Validating);
            // 
            // PriceLbl
            // 
            this.PriceLbl.Location = new System.Drawing.Point(151, 60);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(100, 20);
            this.PriceLbl.TabIndex = 36;
            this.PriceLbl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PriceLbl_KeyPress);
            this.PriceLbl.Validating += new System.ComponentModel.CancelEventHandler(this.PriceLbl_Validating);
            // 
            // DescLbl
            // 
            this.DescLbl.Location = new System.Drawing.Point(15, 106);
            this.DescLbl.Multiline = true;
            this.DescLbl.Name = "DescLbl";
            this.DescLbl.Size = new System.Drawing.Size(257, 79);
            this.DescLbl.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 90);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Описание";
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
            // TypeOfProcedureEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 215);
            this.Controls.Add(this.DescLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.KOPcmbx);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TypeOfProcedureEdit";
            this.Text = "Редактирование типов процедур";
            this.Load += new System.EventHandler(this.TypeOfProcedureEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox KOPcmbx;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameLbl;
        private System.Windows.Forms.TextBox PriceLbl;
        private System.Windows.Forms.TextBox DescLbl;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}