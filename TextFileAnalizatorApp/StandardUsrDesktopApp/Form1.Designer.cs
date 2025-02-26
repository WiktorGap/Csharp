namespace StandardUsrDesktopApp
{
    partial class mainFrame
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFileNameBox;
        private System.Windows.Forms.Button btnLoadFile;
        private System.Windows.Forms.RichTextBox txtFileContent;
        private System.Windows.Forms.TextBox txtLetter;
        private System.Windows.Forms.Button btnCountLetter;
        private System.Windows.Forms.Label lblLetterCount;
        private System.Windows.Forms.TextBox txtWord;
        private System.Windows.Forms.Button btnFindWord;
        private System.Windows.Forms.Label lblWordCount;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtFileNameBox = new System.Windows.Forms.TextBox();
            this.btnLoadFile = new System.Windows.Forms.Button();
            this.txtFileContent = new System.Windows.Forms.RichTextBox();
            this.txtLetter = new System.Windows.Forms.TextBox();
            this.btnCountLetter = new System.Windows.Forms.Button();
            this.lblLetterCount = new System.Windows.Forms.Label();
            this.txtWord = new System.Windows.Forms.TextBox();
            this.btnFindWord = new System.Windows.Forms.Button();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtFileNameBox
            this.txtFileNameBox.Location = new System.Drawing.Point(12, 12);
            this.txtFileNameBox.Size = new System.Drawing.Size(300, 22);

            // btnLoadFile
            this.btnLoadFile.Location = new System.Drawing.Point(320, 10);
            this.btnLoadFile.Size = new System.Drawing.Size(100, 25);
            this.btnLoadFile.Text = "Wczytaj plik";
            this.btnLoadFile.Click += new System.EventHandler(this.btnLoadFile_Click);

            // txtFileContent
            this.txtFileContent.Location = new System.Drawing.Point(12, 45);
            this.txtFileContent.Size = new System.Drawing.Size(500, 200);

            // txtLetter
            this.txtLetter.Location = new System.Drawing.Point(12, 260);
            this.txtLetter.Size = new System.Drawing.Size(50, 22);

            // btnCountLetter
            this.btnCountLetter.Location = new System.Drawing.Point(70, 258);
            this.btnCountLetter.Size = new System.Drawing.Size(150, 25);
            this.btnCountLetter.Text = "Zlicz literę";
            this.btnCountLetter.Click += new System.EventHandler(this.btnCountLetter_Click);

            // lblLetterCount
            this.lblLetterCount.Location = new System.Drawing.Point(230, 260);
            this.lblLetterCount.Size = new System.Drawing.Size(200, 22);

            // txtWord
            this.txtWord.Location = new System.Drawing.Point(12, 295);
            this.txtWord.Size = new System.Drawing.Size(200, 22);

            // btnFindWord
            this.btnFindWord.Location = new System.Drawing.Point(220, 293);
            this.btnFindWord.Size = new System.Drawing.Size(150, 25);
            this.btnFindWord.Text = "Znajdź słowo";
            this.btnFindWord.Click += new System.EventHandler(this.btnFindWord_Click);

            // lblWordCount
            this.lblWordCount.Location = new System.Drawing.Point(380, 295);
            this.lblWordCount.Size = new System.Drawing.Size(200, 22);

            // mainFrame
            this.ClientSize = new System.Drawing.Size(530, 340);
            this.Controls.Add(this.txtFileNameBox);
            this.Controls.Add(this.btnLoadFile);
            this.Controls.Add(this.txtFileContent);
            this.Controls.Add(this.txtLetter);
            this.Controls.Add(this.btnCountLetter);
            this.Controls.Add(this.lblLetterCount);
            this.Controls.Add(this.txtWord);
            this.Controls.Add(this.btnFindWord);
            this.Controls.Add(this.lblWordCount);
            this.Text = "Analizator tekstu";
            this.Load += new System.EventHandler(this.mainFrame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
