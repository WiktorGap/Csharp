namespace WindowsFormsApp1
{
    partial class Form1
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
            this.txtInpurResult = new System.Windows.Forms.TextBox();
            this.lblFirstRandomNum = new System.Windows.Forms.Label();
            this.lblSecRandomNum = new System.Windows.Forms.Label();
            this.lblSignRandom = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblCorrectCounter = new System.Windows.Forms.Label();
            this.lblIncorrectAnswer = new System.Windows.Forms.Label();
            this.lblCorrect = new System.Windows.Forms.Label();
            this.lblIncorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInpurResult
            // 
            this.txtInpurResult.Location = new System.Drawing.Point(508, 89);
            this.txtInpurResult.Name = "txtInpurResult";
            this.txtInpurResult.Size = new System.Drawing.Size(100, 20);
            this.txtInpurResult.TabIndex = 0;
            // 
            // lblFirstRandomNum
            // 
            this.lblFirstRandomNum.AutoSize = true;
            this.lblFirstRandomNum.Location = new System.Drawing.Point(203, 89);
            this.lblFirstRandomNum.Name = "lblFirstRandomNum";
            this.lblFirstRandomNum.Size = new System.Drawing.Size(13, 13);
            this.lblFirstRandomNum.TabIndex = 1;
            this.lblFirstRandomNum.Text = "0";
            // 
            // lblSecRandomNum
            // 
            this.lblSecRandomNum.AutoSize = true;
            this.lblSecRandomNum.Location = new System.Drawing.Point(370, 89);
            this.lblSecRandomNum.Name = "lblSecRandomNum";
            this.lblSecRandomNum.Size = new System.Drawing.Size(13, 13);
            this.lblSecRandomNum.TabIndex = 2;
            this.lblSecRandomNum.Text = "0";
            // 
            // lblSignRandom
            // 
            this.lblSignRandom.AutoSize = true;
            this.lblSignRandom.Location = new System.Drawing.Point(282, 89);
            this.lblSignRandom.Name = "lblSignRandom";
            this.lblSignRandom.Size = new System.Drawing.Size(13, 13);
            this.lblSignRandom.TabIndex = 3;
            this.lblSignRandom.Text = "?";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(508, 135);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(65, 84);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblCorrectCounter
            // 
            this.lblCorrectCounter.AutoSize = true;
            this.lblCorrectCounter.Location = new System.Drawing.Point(474, 48);
            this.lblCorrectCounter.Name = "lblCorrectCounter";
            this.lblCorrectCounter.Size = new System.Drawing.Size(13, 13);
            this.lblCorrectCounter.TabIndex = 6;
            this.lblCorrectCounter.Text = "0";
            // 
            // lblIncorrectAnswer
            // 
            this.lblIncorrectAnswer.AutoSize = true;
            this.lblIncorrectAnswer.Location = new System.Drawing.Point(647, 48);
            this.lblIncorrectAnswer.Name = "lblIncorrectAnswer";
            this.lblIncorrectAnswer.Size = new System.Drawing.Size(13, 13);
            this.lblIncorrectAnswer.TabIndex = 7;
            this.lblIncorrectAnswer.Text = "0";
            // 
            // lblCorrect
            // 
            this.lblCorrect.AutoSize = true;
            this.lblCorrect.Location = new System.Drawing.Point(440, 9);
            this.lblCorrect.Name = "lblCorrect";
            this.lblCorrect.Size = new System.Drawing.Size(79, 13);
            this.lblCorrect.TabIndex = 8;
            this.lblCorrect.Text = "Correct Answer";
            // 
            // lblIncorrect
            // 
            this.lblIncorrect.AutoSize = true;
            this.lblIncorrect.Location = new System.Drawing.Point(588, 9);
            this.lblIncorrect.Name = "lblIncorrect";
            this.lblIncorrect.Size = new System.Drawing.Size(84, 13);
            this.lblIncorrect.TabIndex = 9;
            this.lblIncorrect.Text = "Incorect Answer";
            this.lblIncorrect.Click += new System.EventHandler(this.lblIncorrect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblIncorrect);
            this.Controls.Add(this.lblCorrect);
            this.Controls.Add(this.lblIncorrectAnswer);
            this.Controls.Add(this.lblCorrectCounter);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.lblSignRandom);
            this.Controls.Add(this.lblSecRandomNum);
            this.Controls.Add(this.lblFirstRandomNum);
            this.Controls.Add(this.txtInpurResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInpurResult;
        private System.Windows.Forms.Label lblFirstRandomNum;
        private System.Windows.Forms.Label lblSecRandomNum;
        private System.Windows.Forms.Label lblSignRandom;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblCorrectCounter;
        private System.Windows.Forms.Label lblIncorrectAnswer;
        private System.Windows.Forms.Label lblCorrect;
        private System.Windows.Forms.Label lblIncorrect;
    }
}

