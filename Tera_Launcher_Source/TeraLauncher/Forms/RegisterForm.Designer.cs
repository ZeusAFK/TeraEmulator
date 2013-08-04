namespace TeraLauncher
{
    partial class RegisterForm
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
            this._btnClose = new System.Windows.Forms.Button();
            this._btnMinimize = new System.Windows.Forms.Button();
            this._btnRegister = new System.Windows.Forms.Button();
            this.textboxUsername = new System.Windows.Forms.TextBox();
            this.textboxPassword = new System.Windows.Forms.TextBox();
            this.textboxRePassword = new System.Windows.Forms.TextBox();
            this.textboxEmail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // _btnClose
            // 
            this._btnClose.Location = new System.Drawing.Point(786, 7);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(25, 25);
            this._btnClose.TabIndex = 0;
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // _btnMinimize
            // 
            this._btnMinimize.Location = new System.Drawing.Point(759, 7);
            this._btnMinimize.Name = "_btnMinimize";
            this._btnMinimize.Size = new System.Drawing.Size(25, 25);
            this._btnMinimize.TabIndex = 1;
            this._btnMinimize.UseVisualStyleBackColor = true;
            this._btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // _btnRegister
            // 
            this._btnRegister.Location = new System.Drawing.Point(325, 291);
            this._btnRegister.Name = "_btnRegister";
            this._btnRegister.Size = new System.Drawing.Size(149, 55);
            this._btnRegister.TabIndex = 2;
            this._btnRegister.UseVisualStyleBackColor = true;
            this._btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // textboxUsername
            // 
            this.textboxUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.textboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxUsername.Font = new System.Drawing.Font("Calibri", 14F);
            this.textboxUsername.ForeColor = System.Drawing.Color.White;
            this.textboxUsername.Location = new System.Drawing.Point(273, 111);
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(279, 29);
            this.textboxUsername.TabIndex = 3;
            // 
            // textboxPassword
            // 
            this.textboxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.textboxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxPassword.Font = new System.Drawing.Font("Calibri", 14F);
            this.textboxPassword.ForeColor = System.Drawing.Color.White;
            this.textboxPassword.Location = new System.Drawing.Point(273, 153);
            this.textboxPassword.Name = "textboxPassword";
            this.textboxPassword.Size = new System.Drawing.Size(279, 29);
            this.textboxPassword.TabIndex = 4;
            // 
            // textboxRePassword
            // 
            this.textboxRePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.textboxRePassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxRePassword.Font = new System.Drawing.Font("Calibri", 14F);
            this.textboxRePassword.ForeColor = System.Drawing.Color.White;
            this.textboxRePassword.Location = new System.Drawing.Point(273, 195);
            this.textboxRePassword.Name = "textboxRePassword";
            this.textboxRePassword.Size = new System.Drawing.Size(279, 29);
            this.textboxRePassword.TabIndex = 5;
            // 
            // textboxEmail
            // 
            this.textboxEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.textboxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textboxEmail.Font = new System.Drawing.Font("Calibri", 14F);
            this.textboxEmail.ForeColor = System.Drawing.Color.White;
            this.textboxEmail.Location = new System.Drawing.Point(273, 237);
            this.textboxEmail.Name = "textboxEmail";
            this.textboxEmail.Size = new System.Drawing.Size(279, 29);
            this.textboxEmail.TabIndex = 6;
            // 
            // Register
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(816, 454);
            this.Controls.Add(this.textboxEmail);
            this.Controls.Add(this.textboxRePassword);
            this.Controls.Add(this.textboxPassword);
            this.Controls.Add(this.textboxUsername);
            this.Controls.Add(this._btnRegister);
            this.Controls.Add(this._btnMinimize);
            this.Controls.Add(this._btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.Button _btnMinimize;
        private System.Windows.Forms.Button _btnRegister;
        private System.Windows.Forms.TextBox textboxUsername;
        private System.Windows.Forms.TextBox textboxPassword;
        private System.Windows.Forms.TextBox textboxRePassword;
        private System.Windows.Forms.TextBox textboxEmail;
    }
}