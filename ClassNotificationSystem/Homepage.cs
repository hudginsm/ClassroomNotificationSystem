using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.OleDb;
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
        public SQLiteDataAdapter dAdapter;
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
            string period = periodComboBox.Text.ToString();
            if (int.TryParse(period, out int value))
            {
                readQry = $"SELECT * FROM students WHERE period = {period};";
            }
            else 
            {
                readQry = "SELECT * FROM students;";
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
        }
        private void guardiansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            readQry = @"SELECT * FROM guardians";
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
        }
        private void assignmentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            readQry = @"SELECT * FROM assignments";
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
        }
        private void gradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            readQry = @"SELECT * FROM grades";
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
        }
    }
}
