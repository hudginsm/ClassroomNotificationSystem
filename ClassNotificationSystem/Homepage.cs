using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassNotificationSystem
{
    public partial class Homepage : Form
    {
        public string SQLiteDB = "Data Source=ClassNotifySys.db; Version=3;";
        public string readQry = string.Empty;
        public string writeQry = string.Empty;
        public string updateQry = string.Empty;
        public string page = string.Empty;
        public SQLiteDataAdapter dAdapter;
        public SqlDataAdapter sdAdapter;
        public DataTable dTable;
        public SQLiteCommandBuilder cBuilder;
        public DataView myDataView;

        public Homepage()
        {
            InitializeComponent();
            dataGridView1.Visible = false;
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            page = "students";
            string period = periodComboBox.Text.ToString();
            if (int.TryParse(period, out int value))
            {
                readQry = $"SELECT s.fname+' '+s.lname \"student name\", s.email, grade, period, g1.fname+' '+g1.lname \"guardian1\", g2.fname+' '+g2.lname \"guardian2\" FROM students \"s\" " +
                    $"LEFT OUTER JOIN guardians \"g1\" ON s.guardian1 = g1.recordid " +
                    $"LEFT OUTER JOIN guardians \"g2\" ON s.guardian2 = g2.recordid " +
                    $"WHERE period = {period};";
                //readQry = $"SELECT * FROM students WHERE period = {{period}};";
            }
            else 
            {
                readQry = $"SELECT s.fname+' '+s.lname \"student name\", s.email, grade, period, g1.fname+' '+g1.lname \"guardian1\", g2.fname+' '+g2.lname \"guardian2\" FROM students \"s\" " +
                    $"LEFT OUTER JOIN guardians \"g1\" ON s.guardian1 = g1.recordid " +
                    $"LEFT OUTER JOIN guardians \"g2\" ON s.guardian2 = g2.recordid;";
                //readQry = $"SELECT * FROM students;";
            }

            dAdapter = new SQLiteDataAdapter(readQry, SQLiteDB);
            dTable = new DataTable();
            cBuilder = new SQLiteCommandBuilder(dAdapter);
            cBuilder.QuotePrefix = "`";
            cBuilder.QuoteSuffix = "`";
            myDataView = dTable.DefaultView;
            dAdapter.Fill(dTable);
            BindingSource bndSource = new BindingSource();
            bndSource.DataSource = dTable;
            this.dataGridView1.DataSource = bndSource;
            dataGridView1.Visible = true;
            filterComboBox.Visible = false;
            filterDateTime.Visible = false;
            fltrBtn.Visible = false;
            clrBtn.Visible = false;
            updLbl.Text = string.Empty;
            updLbl.Visible = false;
            addNewBtn.Text = "Add Student";
            addNewBtn.Visible = true;


        }
        private void guardiansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            page = "guardians";
            readQry = $"SELECT fname+' '+lname \"guardian name\", email FROM guardians;";
            //readQry = $"SELECT * FROM guardians;";
            dAdapter = new SQLiteDataAdapter(readQry, SQLiteDB);
            dTable = new DataTable();
            cBuilder = new SQLiteCommandBuilder(dAdapter);
            cBuilder.QuotePrefix = "`";
            cBuilder.QuoteSuffix = "`";
            myDataView = dTable.DefaultView;
            dAdapter.Fill(dTable);
            BindingSource bndSource = new BindingSource();
            bndSource.DataSource = dTable;
            this.dataGridView1.DataSource = bndSource;
            periodComboBox.Text = "Select Period";
            dataGridView1.Visible = true;
            filterComboBox.Visible = false;
            filterDateTime.Visible = false;
            fltrBtn.Visible = false;
            clrBtn.Visible = false;
            updLbl.Text = string.Empty;
            updLbl.Visible = false;
            addNewBtn.Text = "Add Guardian";
            addNewBtn.Visible = true;
        }
        private void assignmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            page = "assignments";
            //readQry = @"SELECT title, assigned, due FROM assignments;";
            readQry = @"SELECT * FROM assignments;";
            dAdapter = new SQLiteDataAdapter(readQry, SQLiteDB);
            dTable = new DataTable();
            cBuilder = new SQLiteCommandBuilder(dAdapter);
            cBuilder.QuotePrefix = "`";
            cBuilder.QuoteSuffix = "`";
            myDataView = dTable.DefaultView;
            dAdapter.Fill(dTable);
            BindingSource bndSource = new BindingSource();
            bndSource.DataSource = dTable;
            this.dataGridView1.DataSource = bndSource;
            periodComboBox.Text = "Select Period";
            dataGridView1.Visible = true;
            filterComboBox.Visible = true;
            filterDateTime.Visible = true;
            fltrBtn.Visible = true;
            clrBtn.Visible = true;
            updLbl.Text = string.Empty;
            updLbl.Visible = false;
            addNewBtn.Text = "Add Assignment";
            addNewBtn.Visible = true;
        }
        private void gradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            page = "grades";
            readQry = $"SELECT a.title, s.fname+' '+s.lname \"student name\", g.grade, missing, incomplete FROM grades \"g\" " +
                $"LEFT OUTER JOIN assignments \"a\" ON g.assignmentid = a.recordid " +
                $"LEFT OUTER JOIN students \"s\" ON g.studentid = s.recordid;";
            readQry = $"SELECT * FROM grades;";
            dAdapter = new SQLiteDataAdapter(readQry, SQLiteDB);
            dTable = new DataTable();
            cBuilder = new SQLiteCommandBuilder(dAdapter);
            cBuilder.QuotePrefix = "`";
            cBuilder.QuoteSuffix = "`";
            myDataView = dTable.DefaultView;
            dAdapter.Fill(dTable);
            BindingSource bndSource = new BindingSource();
            bndSource.DataSource = dTable;
            this.dataGridView1.DataSource = bndSource;
            periodComboBox.Text = "Select Period";
            dataGridView1.Visible = true;
            filterComboBox.Visible = true;
            filterDateTime.Visible = false;
            fltrBtn.Visible = true;
            clrBtn.Visible = true;
            updLbl.Text = string.Empty;
            updLbl.Visible = false;
            addNewBtn.Text = "Add Grade";
            addNewBtn.Visible = true;
        }

        private void fltrBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            filterComboBox.Text = string.Empty;
            filterComboBox.Visible = false;
            filterDateTime.Value = DateTime.Now;
            filterDateTime.Visible = false;
        }

        private void clrAllBtn_Click(object sender, EventArgs e)
        {
            periodComboBox.Text = "Select Period";
            updLbl.Text = string.Empty;
            updLbl.Visible = false;
            dataGridView1.Visible = false;
            filterComboBox.Text = string.Empty;
            filterComboBox.Visible = false;
            filterDateTime.Value = DateTime.Now;
            filterDateTime.Visible = false;
            fltrBtn.Visible = false;
            clrBtn.Visible = false;
            addNewBtn.Text = "";
            addNewBtn.Visible = false;
        }

        private void addNewBtn_Click(object sender, EventArgs e)
        {
            switch (page)
            {
                case "students":
                    addStudent add = new addStudent();
                    add.Show();
                    break;
                //case "guardians": ; break;
                //case "assignments": ; break;
                //case "grades": ; break;
                default: MessageBox.Show("Something went wrong!!"); break;
            }
        }
        //private void Cell_Update(object sender, DataGridViewCellEventArgs e)
        //{
        //    try
        //    {
        //        //sdAdapter = new SqlDataAdapter();
        //        dAdapter.Update(dTable.DataSet);
        //        updLbl.Visible = true;
        //        this.updLbl.Text = "Updated" + System.DateTime.Now.ToString();
        //    }
        //    catch (SQLiteException f)
        //    {
        //        updLbl.Visible = true;
        //        this.updLbl.Text = "Not Updated" + f.Source.ToString();
        //    }
        //}
    }
}
