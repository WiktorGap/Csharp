namespace system_with_db
{
    partial class tools
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
            this.button5 = new System.Windows.Forms.Button();
            this.lblIsValidate = new System.Windows.Forms.Label();
            this.txtValid = new System.Windows.Forms.TextBox();
            this.details1 = new system_with_db.details();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(348, 29);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 28);
            this.button5.TabIndex = 13;
            this.button5.Text = "validate pesel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // lblIsValidate
            // 
            this.lblIsValidate.AutoSize = true;
            this.lblIsValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblIsValidate.Location = new System.Drawing.Point(345, 122);
            this.lblIsValidate.Name = "lblIsValidate";
            this.lblIsValidate.Size = new System.Drawing.Size(20, 18);
            this.lblIsValidate.TabIndex = 15;
            this.lblIsValidate.Text = "\"\"";
            this.lblIsValidate.Click += new System.EventHandler(this.lblIsValidate_Click);
            // 
            // txtValid
            // 
            this.txtValid.Location = new System.Drawing.Point(348, 77);
            this.txtValid.Name = "txtValid";
            this.txtValid.Size = new System.Drawing.Size(100, 20);
            this.txtValid.TabIndex = 16;
            // 
            // details1
            // 
            this.details1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.details1.Location = new System.Drawing.Point(12, 12);
            this.details1.Name = "details1";
            this.details1.Size = new System.Drawing.Size(278, 255);
            this.details1.TabIndex = 17;
            // 
            // tools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(610, 293);
            this.Controls.Add(this.details1);
            this.Controls.Add(this.txtValid);
            this.Controls.Add(this.lblIsValidate);
            this.Controls.Add(this.button5);
            this.Name = "tools";
            this.Text = "tools";
            this.Load += new System.EventHandler(this.tools_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label lblIsValidate;
        private System.Windows.Forms.TextBox txtValid;
        private details details1;
    }
}