namespace ClassNotificationSystem
{
    partial class Homepage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.periodComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.guardiansToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assignmentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.filterDateTime = new System.Windows.Forms.DateTimePicker();
            this.filterComboBox = new System.Windows.Forms.ComboBox();
            this.fltrBtn = new System.Windows.Forms.Button();
            this.clrBtn = new System.Windows.Forms.Button();
            this.clrAllBtn = new System.Windows.Forms.Button();
            this.updLbl = new System.Windows.Forms.Label();
            this.addNewBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1338, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentsToolStripMenuItem,
            this.guardiansToolStripMenuItem,
            this.assignmentsToolStripMenuItem,
            this.gradesToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.periodComboBox});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.studentsToolStripMenuItem.Text = "Students";
            this.studentsToolStripMenuItem.Click += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // periodComboBox
            // 
            this.periodComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "All"});
            this.periodComboBox.Name = "periodComboBox";
            this.periodComboBox.Size = new System.Drawing.Size(121, 23);
            this.periodComboBox.Text = "Select Period";
            this.periodComboBox.SelectedIndexChanged += new System.EventHandler(this.studentsToolStripMenuItem_Click);
            // 
            // guardiansToolStripMenuItem
            // 
            this.guardiansToolStripMenuItem.Name = "guardiansToolStripMenuItem";
            this.guardiansToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.guardiansToolStripMenuItem.Text = "Guardians";
            this.guardiansToolStripMenuItem.Click += new System.EventHandler(this.guardiansToolStripMenuItem_Click);
            // 
            // assignmentsToolStripMenuItem
            // 
            this.assignmentsToolStripMenuItem.Name = "assignmentsToolStripMenuItem";
            this.assignmentsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.assignmentsToolStripMenuItem.Text = "Assignments";
            this.assignmentsToolStripMenuItem.Click += new System.EventHandler(this.assignmentsToolStripMenuItem_Click);
            // 
            // gradesToolStripMenuItem
            // 
            this.gradesToolStripMenuItem.Name = "gradesToolStripMenuItem";
            this.gradesToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.gradesToolStripMenuItem.Text = "Grades";
            this.gradesToolStripMenuItem.Click += new System.EventHandler(this.gradesToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1338, 691);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            // 
            // filterDateTime
            // 
            this.filterDateTime.CustomFormat = "";
            this.filterDateTime.Location = new System.Drawing.Point(12, 748);
            this.filterDateTime.Name = "filterDateTime";
            this.filterDateTime.Size = new System.Drawing.Size(200, 20);
            this.filterDateTime.TabIndex = 2;
            this.filterDateTime.Visible = false;
            // 
            // filterComboBox
            // 
            this.filterComboBox.FormattingEnabled = true;
            this.filterComboBox.Location = new System.Drawing.Point(12, 721);
            this.filterComboBox.Name = "filterComboBox";
            this.filterComboBox.Size = new System.Drawing.Size(200, 21);
            this.filterComboBox.TabIndex = 3;
            this.filterComboBox.Visible = false;
            // 
            // fltrBtn
            // 
            this.fltrBtn.Location = new System.Drawing.Point(12, 774);
            this.fltrBtn.Name = "fltrBtn";
            this.fltrBtn.Size = new System.Drawing.Size(75, 23);
            this.fltrBtn.TabIndex = 4;
            this.fltrBtn.Text = "Filter";
            this.fltrBtn.UseVisualStyleBackColor = true;
            this.fltrBtn.Visible = false;
            this.fltrBtn.Click += new System.EventHandler(this.fltrBtn_Click);
            // 
            // clrBtn
            // 
            this.clrBtn.Location = new System.Drawing.Point(137, 774);
            this.clrBtn.Name = "clrBtn";
            this.clrBtn.Size = new System.Drawing.Size(75, 23);
            this.clrBtn.TabIndex = 5;
            this.clrBtn.Text = "Clear";
            this.clrBtn.UseVisualStyleBackColor = true;
            this.clrBtn.Visible = false;
            this.clrBtn.Click += new System.EventHandler(this.clrBtn_Click);
            // 
            // clrAllBtn
            // 
            this.clrAllBtn.Location = new System.Drawing.Point(1195, 721);
            this.clrAllBtn.Name = "clrAllBtn";
            this.clrAllBtn.Size = new System.Drawing.Size(131, 47);
            this.clrAllBtn.TabIndex = 7;
            this.clrAllBtn.Text = "Clear";
            this.clrAllBtn.UseVisualStyleBackColor = true;
            this.clrAllBtn.Click += new System.EventHandler(this.clrAllBtn_Click);
            // 
            // updLbl
            // 
            this.updLbl.AutoSize = true;
            this.updLbl.Location = new System.Drawing.Point(1055, 784);
            this.updLbl.Name = "updLbl";
            this.updLbl.Size = new System.Drawing.Size(0, 13);
            this.updLbl.TabIndex = 8;
            this.updLbl.Visible = false;
            // 
            // addNewBtn
            // 
            this.addNewBtn.Location = new System.Drawing.Point(1058, 721);
            this.addNewBtn.Name = "addNewBtn";
            this.addNewBtn.Size = new System.Drawing.Size(131, 47);
            this.addNewBtn.TabIndex = 9;
            this.addNewBtn.UseVisualStyleBackColor = true;
            this.addNewBtn.Visible = false;
            this.addNewBtn.Click += new System.EventHandler(this.addNewBtn_Click);
            // 
            // Homepage
            // 
            this.ClientSize = new System.Drawing.Size(1338, 810);
            this.Controls.Add(this.addNewBtn);
            this.Controls.Add(this.updLbl);
            this.Controls.Add(this.clrAllBtn);
            this.Controls.Add(this.clrBtn);
            this.Controls.Add(this.fltrBtn);
            this.Controls.Add(this.filterComboBox);
            this.Controls.Add(this.filterDateTime);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Homepage";
            this.Text = "ClassNotificationSystem";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardiansToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assignmentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gradesToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripComboBox periodComboBox;
        private System.Windows.Forms.DateTimePicker filterDateTime;
        private System.Windows.Forms.ComboBox filterComboBox;
        private System.Windows.Forms.Button fltrBtn;
        private System.Windows.Forms.Button clrBtn;
        private System.Windows.Forms.Button clrAllBtn;
        private System.Windows.Forms.Label updLbl;
        private System.Windows.Forms.Button addNewBtn;
    }
}
#endregion