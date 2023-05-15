using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GIGI_RESORTT
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            dataGridView1.CurrentCell = null;
        }

        private DataTable LoadDataFromDatabase()
        {
            string fileName = "ResortReservationSystem.mdb";
            string path = AppDomain.CurrentDomain.BaseDirectory + fileName;
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path;
            OleDbConnection connection = new OleDbConnection(connectionString);


            try
            {
                connection.Open();
                Console.WriteLine("Connected");
                OleDbCommand command = new OleDbCommand("SELECT * FROM Reservations", connection);
                OleDbDataAdapter adapter = new OleDbDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // This line of code loads data into the 'resortReservationSystemDataSet2.Reservations' table. You can move, or remove it, as needed.
            this.reservationsTableAdapter.Fill(this.resortReservationSystemDataSet2.Reservations);

            // Allow user to edit cells
            dataGridView1.ReadOnly = false;

            // Set the data source for the DataGridView
            dataGridView1.DataSource = LoadDataFromDatabase();

        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            var addReservation = new AddReservation();
            addReservation.Show();
        }

        public void UpdateData()
        {
            dataGridView1.DataSource = LoadDataFromDatabase();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;

                // Get the value of the ID column in the selected row
                int reservationId = Convert.ToInt32(dataGridView1[0, selectedIndex].Value);

                // Create a connection to the database
                string fileName = "ResortReservationSystem.mdb";
                string path = AppDomain.CurrentDomain.BaseDirectory + fileName;
                string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path;
                OleDbConnection connection = new OleDbConnection(connectionString);


                try
                {
                    connection.Open();
                    Console.WriteLine("Connected");

                    // Create a SQL DELETE command to remove the row from the Reservations table
                    OleDbCommand command = new OleDbCommand("DELETE FROM Reservations WHERE ID = @ID", connection);
                    command.Parameters.AddWithValue("@ID", reservationId);
                    command.ExecuteNonQuery();

                    // Refresh the DataGridView to show the updated data
                    dataGridView1.DataSource = LoadDataFromDatabase();

                    MessageBox.Show("Reservation deleted successfully!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string searchText = textBox1.Text.ToLower();
            bool found = false;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null && cell.Value.ToString().ToLower().Contains(searchText))
                    {
                        dataGridView1.CurrentCell = cell;
                        found = true;
                        break;
                    }
                }
                if (found) break;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}


