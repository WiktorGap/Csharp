namespace system_with_db
{
    partial class details
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.lblvistDate = new System.Windows.Forms.Label();
            this.lblPrescription = new System.Windows.Forms.Label();
            this.txtPeselControlDt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(156, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show details";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblvistDate
            // 
            this.lblvistDate.AutoSize = true;
            this.lblvistDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblvistDate.Location = new System.Drawing.Point(24, 92);
            this.lblvistDate.Name = "lblvistDate";
            this.lblvistDate.Size = new System.Drawing.Size(20, 18);
            this.lblvistDate.TabIndex = 2;
            this.lblvistDate.Text = "\"\"";
            // 
            // lblPrescription
            // 
            this.lblPrescription.AutoSize = true;
            this.lblPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPrescription.Location = new System.Drawing.Point(24, 145);
            this.lblPrescription.Name = "lblPrescription";
            this.lblPrescription.Size = new System.Drawing.Size(20, 18);
            this.lblPrescription.TabIndex = 3;
            this.lblPrescription.Text = "\"\"";
            this.lblPrescription.Click += new System.EventHandler(this.lblPrescription_Click);
            // 
            // txtPeselControlDt
            // 
            this.txtPeselControlDt.Location = new System.Drawing.Point(27, 44);
            this.txtPeselControlDt.Name = "txtPeselControlDt";
            this.txtPeselControlDt.Size = new System.Drawing.Size(100, 20);
            this.txtPeselControlDt.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter Pesel";
            // 
            // details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPeselControlDt);
            this.Controls.Add(this.lblPrescription);
            this.Controls.Add(this.lblvistDate);
            this.Controls.Add(this.button1);
            this.Name = "details";
            this.Size = new System.Drawing.Size(278, 211);
            this.Load += new System.EventHandler(this.details_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblvistDate;
        private System.Windows.Forms.Label lblPrescription;
        private System.Windows.Forms.TextBox txtPeselControlDt;
        private System.Windows.Forms.Label label1;
    }
}
