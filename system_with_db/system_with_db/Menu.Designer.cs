namespace system_with_db
{
    partial class Menu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.progamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnFInd = new System.Windows.Forms.Button();
            this.dataGridViewOfPacients = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pESELDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastVisitDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prescriptionNoteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet = new system_with_db.usersDataSet();
            this.clientsTableAdapter = new system_with_db.usersDataSetTableAdapters.ClientsTableAdapter();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPESEL = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.sqlConnection1 = new Microsoft.Data.SqlClient.SqlConnection();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtPrescription = new System.Windows.Forms.TextBox();
            this.txtLastVisit = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEntries = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfPacients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.progamToolStripMenuItem,
            this.toolsToolStripMenuItem2,
            this.logoutToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1029, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // progamToolStripMenuItem
            // 
            this.progamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.progamToolStripMenuItem.Name = "progamToolStripMenuItem";
            this.progamToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.progamToolStripMenuItem.Text = "Progam";
            this.progamToolStripMenuItem.Click += new System.EventHandler(this.progamToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem2
            // 
            this.toolsToolStripMenuItem2.Name = "toolsToolStripMenuItem2";
            this.toolsToolStripMenuItem2.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem2.Text = "Tools";
            this.toolsToolStripMenuItem2.Click += new System.EventHandler(this.toolsToolStripMenuItem2_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.themeToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightToolStripMenuItem,
            this.darkToolStripMenuItem,
            this.defaultToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.themeToolStripMenuItem.Text = "Theme";
            this.themeToolStripMenuItem.Click += new System.EventHandler(this.themeToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAdd.Location = new System.Drawing.Point(4, 18);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Patient";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUpdate.Location = new System.Drawing.Point(122, 18);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 28);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update Data";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(251, 18);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 28);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete Patient";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnRefresh);
            this.panel1.Controls.Add(this.btnFInd);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Location = new System.Drawing.Point(52, 334);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(524, 123);
            this.panel1.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnClear.Location = new System.Drawing.Point(251, 74);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(146, 28);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear Entries";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnRefresh.Location = new System.Drawing.Point(80, 74);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(152, 28);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnFInd
            // 
            this.btnFInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnFInd.Location = new System.Drawing.Point(384, 19);
            this.btnFInd.Margin = new System.Windows.Forms.Padding(4);
            this.btnFInd.Name = "btnFInd";
            this.btnFInd.Size = new System.Drawing.Size(100, 28);
            this.btnFInd.TabIndex = 5;
            this.btnFInd.Text = "Find";
            this.btnFInd.UseVisualStyleBackColor = true;
            this.btnFInd.Click += new System.EventHandler(this.btnFInd_Click);
            // 
            // dataGridViewOfPacients
            // 
            this.dataGridViewOfPacients.AllowUserToAddRows = false;
            this.dataGridViewOfPacients.AllowUserToDeleteRows = false;
            this.dataGridViewOfPacients.AutoGenerateColumns = false;
            this.dataGridViewOfPacients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOfPacients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.pESELDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.lastVisitDateDataGridViewTextBoxColumn,
            this.prescriptionNoteDataGridViewTextBoxColumn});
            this.dataGridViewOfPacients.DataSource = this.clientsBindingSource;
            this.dataGridViewOfPacients.Location = new System.Drawing.Point(13, 56);
            this.dataGridViewOfPacients.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewOfPacients.Name = "dataGridViewOfPacients";
            this.dataGridViewOfPacients.ReadOnly = true;
            this.dataGridViewOfPacients.Size = new System.Drawing.Size(622, 270);
            this.dataGridViewOfPacients.TabIndex = 6;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            this.lastNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pESELDataGridViewTextBoxColumn
            // 
            this.pESELDataGridViewTextBoxColumn.DataPropertyName = "PESEL";
            this.pESELDataGridViewTextBoxColumn.HeaderText = "PESEL";
            this.pESELDataGridViewTextBoxColumn.Name = "pESELDataGridViewTextBoxColumn";
            this.pESELDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lastVisitDateDataGridViewTextBoxColumn
            // 
            this.lastVisitDateDataGridViewTextBoxColumn.DataPropertyName = "LastVisitDate";
            this.lastVisitDateDataGridViewTextBoxColumn.HeaderText = "LastVisitDate";
            this.lastVisitDateDataGridViewTextBoxColumn.Name = "lastVisitDateDataGridViewTextBoxColumn";
            this.lastVisitDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // prescriptionNoteDataGridViewTextBoxColumn
            // 
            this.prescriptionNoteDataGridViewTextBoxColumn.DataPropertyName = "PrescriptionNote";
            this.prescriptionNoteDataGridViewTextBoxColumn.HeaderText = "PrescriptionNote";
            this.prescriptionNoteDataGridViewTextBoxColumn.Name = "prescriptionNoteDataGridViewTextBoxColumn";
            this.prescriptionNoteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.usersDataSet;
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "usersDataSet";
            this.usersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(19, 4);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 12;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(19, 55);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(132, 22);
            this.txtLastName.TabIndex = 13;
            // 
            // txtPESEL
            // 
            this.txtPESEL.Location = new System.Drawing.Point(19, 114);
            this.txtPESEL.Margin = new System.Windows.Forms.Padding(4);
            this.txtPESEL.Name = "txtPESEL";
            this.txtPESEL.Size = new System.Drawing.Size(132, 22);
            this.txtPESEL.TabIndex = 14;
            this.txtPESEL.TextChanged += new System.EventHandler(this.txtPESEL_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(19, 174);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 22);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(19, 242);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(132, 22);
            this.txtPhone.TabIndex = 16;
            this.txtPhone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.AccessTokenCallback = null;
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtPrescription);
            this.panel2.Controls.Add(this.txtLastVisit);
            this.panel2.Controls.Add(this.txtName);
            this.panel2.Controls.Add(this.txtPhone);
            this.panel2.Controls.Add(this.txtLastName);
            this.panel2.Controls.Add(this.txtEmail);
            this.panel2.Controls.Add(this.txtPESEL);
            this.panel2.Location = new System.Drawing.Point(649, 75);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(179, 382);
            this.panel2.TabIndex = 17;
            // 
            // txtPrescription
            // 
            this.txtPrescription.Location = new System.Drawing.Point(19, 354);
            this.txtPrescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrescription.Name = "txtPrescription";
            this.txtPrescription.Size = new System.Drawing.Size(132, 22);
            this.txtPrescription.TabIndex = 18;
            // 
            // txtLastVisit
            // 
            this.txtLastVisit.Location = new System.Drawing.Point(19, 295);
            this.txtLastVisit.Margin = new System.Windows.Forms.Padding(4);
            this.txtLastVisit.Name = "txtLastVisit";
            this.txtLastVisit.Size = new System.Drawing.Size(132, 22);
            this.txtLastVisit.TabIndex = 17;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblName.Location = new System.Drawing.Point(843, 71);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 18);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "Name";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLastName.Location = new System.Drawing.Point(843, 130);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(89, 18);
            this.lblLastName.TabIndex = 19;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(843, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "PESEL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(843, 242);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "EMAIL";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblPhone.Location = new System.Drawing.Point(843, 310);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(51, 16);
            this.lblPhone.TabIndex = 22;
            this.lblPhone.Text = "Phone";
            // 
            // lblEntries
            // 
            this.lblEntries.AutoSize = true;
            this.lblEntries.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblEntries.Location = new System.Drawing.Point(686, 34);
            this.lblEntries.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntries.Name = "lblEntries";
            this.lblEntries.Size = new System.Drawing.Size(86, 25);
            this.lblEntries.TabIndex = 23;
            this.lblEntries.Text = "Entries";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(836, 363);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Last Visit Date ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(843, 437);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Prescription";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1029, 528);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblEntries);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridViewOfPacients);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfPacients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem progamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnFInd;
        private System.Windows.Forms.DataGridView dataGridViewOfPacients;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRefresh;
        private usersDataSet usersDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private usersDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pESELDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastVisitDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prescriptionNoteDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPESEL;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private Microsoft.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEntries;
        private System.Windows.Forms.TextBox txtPrescription;
        private System.Windows.Forms.TextBox txtLastVisit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
    }
}