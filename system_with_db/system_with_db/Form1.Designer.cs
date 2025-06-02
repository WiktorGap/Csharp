namespace system_with_db
{
    partial class Login
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPasswod = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPasswd = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(317, 97);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 0;
            // 
            // txtPasswod
            // 
            this.txtPasswod.Location = new System.Drawing.Point(317, 201);
            this.txtPasswod.Name = "txtPasswod";
            this.txtPasswod.Size = new System.Drawing.Size(100, 20);
            this.txtPasswod.TabIndex = 1;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLogin.Location = new System.Drawing.Point(327, 45);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(90, 32);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            // 
            // lblPasswd
            // 
            this.lblPasswd.AutoSize = true;
            this.lblPasswd.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPasswd.Location = new System.Drawing.Point(311, 150);
            this.lblPasswd.Name = "lblPasswd";
            this.lblPasswd.Size = new System.Drawing.Size(143, 32);
            this.lblPasswd.TabIndex = 4;
            this.lblPasswd.Text = "Password";
            this.lblPasswd.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogin.Location = new System.Drawing.Point(323, 261);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 45);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lblPasswd);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtPasswod);
            this.Controls.Add(this.txtLogin);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPasswod;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPasswd;
        private System.Windows.Forms.Button btnLogin;
    }
}

