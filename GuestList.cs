﻿using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GIGI_RESORTT
{
    public partial class Form1 : Form
    {
        private DataTable dataTable;
        private int currentRowIndex = -1;
        private GuessForm guessForm;

        public Form1()
        {
            InitializeComponent();
            guessForm = new GuessForm();
            //guessForm.SubmitClicked += guessForm_SubmitClicked;
            System.Console.WriteLine("testrun");
            timer1.Enabled = true;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            timer1.Tick += Timer1_Tick_1;
            dataGridView1.CurrentCell = null;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }

        private void guessForm_SubmitClicked(object sender, EventArgs e)
        {
            // Start the timer after the user has submitted the data from the GuessForm
            Console.WriteLine("submitbutton");
            dataGridView1.DataSource = LoadDataFromDatabase();
            timer1.Start();
            timer1.Enabled = true;

        }

        private DataTable LoadDataFromDatabase()
        {
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\KentGab\Desktop\Resort System\GIGI RESORTT\ResortReservationSystem.mdb";
            OleDbConnection connection = new OleDbConnection(connectionString);

            try
            {
                connection.Open();
                System.Console.WriteLine("connected");

                OleDbCommand command = new OleDbCommand("SELECT * FROM Guest", connection);

                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)

            {
                currentRowIndex = e.RowIndex;
                dataGridView1.ReadOnly = false;
                dataGridView1.BeginEdit(true);
                dataGridView1.Rows[e.RowIndex].Selected = true;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (currentRowIndex >= 0)
            {
                DataRow currentRow = dataTable.Rows[currentRowIndex];
                currentRow[dataGridView1.Columns[e.ColumnIndex].Name] = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                OleDbDataAdapter adapter = (OleDbDataAdapter)dataGridView1.DataSource;
                adapter.Update(dataTable);
                dataGridView1.ReadOnly = false;
                currentRowIndex = -1;
                timer1.Enabled = true;
            }
        }


        private void Form5_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LoadDataFromDatabase();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            var guessform = new GuessForm();
            guessform.Show();
        }


        public void Timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            dataGridView1.ClearSelection();
            if (currentRowIndex == -1)
            {
                dataGridView1.DataSource = LoadDataFromDatabase();
            }
        }

        //private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //  dataTable.RejectChanges();
        //}		$exception	{"Unable to cast object of type 'System.Data.DataTable' to type 'System.Data.OleDb.OleDbDataAdapter'."}	System.InvalidCastException


        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataTable.Rows[row.Index].Delete();
                }
                OleDbDataAdapter adapter = (OleDbDataAdapter)dataGridView1.DataSource;
                adapter.Update(dataTable);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataTable.Rows[row.Index].Delete();
                }
                OleDbDataAdapter adapter = new OleDbDataAdapter();
                string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\KentGab\Desktop\Resort System\GIGI RESORTT\ResortReservationSystem.mdb";
                adapter.SelectCommand = new OleDbCommand("SELECT * FROM Guest", new OleDbConnection(connectionString));
                OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);
                adapter.Update(dataTable);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}