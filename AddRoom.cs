using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIGI_RESORTT
{
    public partial class AddRoom : Form
    {
        public AddRoom()
        {
            InitializeComponent();
        }

        private void AddRoom_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //string roomId = this.RoomId.Text;
            string roomName = RoomName.Text;
            string roomNumber = RoomNumber.Text;
            string pax = Pax.Text;
            string price = Price.Text;
            string inclusions = Inclusions.Text;
            string roomStatus = RoomStatus.SelectedItem != null ? RoomStatus.SelectedItem.ToString() : null;
            // Insert the values into the database
            string fileName = "ResortReservationSystem.mdb";
            string path = AppDomain.CurrentDomain.BaseDirectory + fileName;
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + path;
            OleDbConnection connection = new OleDbConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connected");

                string query = "INSERT INTO Rooms ([Room Name], [Room Number], [Pax], [Price], [Inclusions], [Room Status]) VALUES (@RoomName, @RoomNumber, @Pax, @Price, @Inclusions, @RoomStatus)";
                OleDbCommand command = new OleDbCommand(query, connection);

                command.Parameters.AddWithValue("@RoomName", roomName);
                command.Parameters.AddWithValue("@RoomNumber", roomNumber);
                command.Parameters.AddWithValue("@Pax", pax);
                command.Parameters.AddWithValue("@Price", price);
                command.Parameters.AddWithValue("@Inclusions", inclusions);
                command.Parameters.AddWithValue("@RoomStatus", roomStatus);

                if (roomStatus == null)
                {
                    MessageBox.Show("Please Fill in Room Status", "Missing Room Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                command.ExecuteNonQuery();

                MessageBox.Show("Reservation saved successfully!");

                Form5 form = (Form5)Application.OpenForms["ReservationList"];
                if (form != null)
                {
                    form.UpdateData();
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                MessageBox.Show("Error adding reservation: " + ex.Message);
            }
            finally
            {
                connection.Close();

            }

            // Close the form
            this.Close();

        }

        private void RoomName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

