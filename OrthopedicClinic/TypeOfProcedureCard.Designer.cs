﻿namespace OrthopedicClinic
{
    partial class TypeOfProcedureCard
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
            this.EditBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.NameLbl = new System.Windows.Forms.Label();
            this.PriceLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DescTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.KOP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(102, 210);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(170, 23);
            this.EditBtn.TabIndex = 22;
            this.EditBtn.Text = "Редактировать";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(197, 239);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(75, 23);
            this.DelBtn.TabIndex = 19;
            this.DelBtn.Text = "Удалить";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Location = new System.Drawing.Point(111, 9);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(35, 13);
            this.NameLbl.TabIndex = 12;
            this.NameLbl.Text = "label1";
            // 
            // PriceLbl
            // 
            this.PriceLbl.AutoSize = true;
            this.PriceLbl.Location = new System.Drawing.Point(111, 61);
            this.PriceLbl.Name = "PriceLbl";
            this.PriceLbl.Size = new System.Drawing.Size(35, 13);
            this.PriceLbl.TabIndex = 14;
            this.PriceLbl.Text = "label1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Вид процедуры";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Название";
            // 
            // DescTxtBox
            // 
            this.DescTxtBox.Enabled = false;
            this.DescTxtBox.Location = new System.Drawing.Point(15, 96);
            this.DescTxtBox.Multiline = true;
            this.DescTxtBox.Name = "DescTxtBox";
            this.DescTxtBox.Size = new System.Drawing.Size(257, 108);
            this.DescTxtBox.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 80);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Описание";
            // 
            // KOP
            // 
            this.KOP.AutoSize = true;
            this.KOP.Location = new System.Drawing.Point(111, 35);
            this.KOP.Name = "KOP";
            this.KOP.Size = new System.Drawing.Size(35, 13);
            this.KOP.TabIndex = 12;
            this.KOP.Text = "label1";
            // 
            // TypeOfProcedureCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 270);
            this.Controls.Add(this.DescTxtBox);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.KOP);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.PriceLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TypeOfProcedureCard";
            this.Text = "Типы процедур";
            this.Load += new System.EventHandler(this.TypeOfProcedureCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label PriceLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DescTxtBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label KOP;
    }
}