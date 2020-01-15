namespace OrthopedicClinic
{
    partial class Authoriz
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
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LoginTxtBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PswrdTxtBx = new System.Windows.Forms.TextBox();
            this.ForgotPasswordLnkLbl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // LoginBtn
            // 
            this.LoginBtn.Location = new System.Drawing.Point(130, 85);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(75, 23);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Войти";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // LoginTxtBx
            // 
            this.LoginTxtBx.Location = new System.Drawing.Point(105, 18);
            this.LoginTxtBx.Name = "LoginTxtBx";
            this.LoginTxtBx.Size = new System.Drawing.Size(100, 20);
            this.LoginTxtBx.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Пароль";
            // 
            // PswrdTxtBx
            // 
            this.PswrdTxtBx.Location = new System.Drawing.Point(105, 44);
            this.PswrdTxtBx.Name = "PswrdTxtBx";
            this.PswrdTxtBx.PasswordChar = '*';
            this.PswrdTxtBx.Size = new System.Drawing.Size(100, 20);
            this.PswrdTxtBx.TabIndex = 2;
            // 
            // ForgotPasswordLnkLbl
            // 
            this.ForgotPasswordLnkLbl.AutoSize = true;
            this.ForgotPasswordLnkLbl.Location = new System.Drawing.Point(12, 95);
            this.ForgotPasswordLnkLbl.Name = "ForgotPasswordLnkLbl";
            this.ForgotPasswordLnkLbl.Size = new System.Drawing.Size(91, 13);
            this.ForgotPasswordLnkLbl.TabIndex = 4;
            this.ForgotPasswordLnkLbl.TabStop = true;
            this.ForgotPasswordLnkLbl.Text = "Забыли пароль?";
            this.ForgotPasswordLnkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgotPasswordLnkLbl_LinkClicked);
            // 
            // Authoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 120);
            this.Controls.Add(this.ForgotPasswordLnkLbl);
            this.Controls.Add(this.PswrdTxtBx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LoginTxtBx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Authoriz";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LoginTxtBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox PswrdTxtBx;
        private System.Windows.Forms.LinkLabel ForgotPasswordLnkLbl;
    }
}