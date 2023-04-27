using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace GIGI_RESORTT
{
    public partial class AddReservation : Form
    {
        public AddReservation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the values entered by the user
            string guestName = GuestName.Text;
            string roomType = RoomType.Text;
            string NumberGuest = NumberGuests.Text;
            DateTime checkInDate = CheckInDate.Value;
            DateTime checkOutDate = CheckOutDate.Value;

            // Insert the values into the database
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\KentGab\Desktop\Resort System\GIGI RESORTT\ResortReservationSystem.mdb";
            OleDbConnection connection = new OleDbConnection(connectionString);

            try
            {
                connection.Open();
                Console.WriteLine("Connected");

                string query = "INSERT INTO Reservations ([Guest Name], [Check-In Date], [Check-Out Date], [Room Type], [Number of Guests]) VALUES (@GuestName, @CheckInDate, @CheckOutDate, @RoomType, @NumberGuest)";
                OleDbCommand command = new OleDbCommand(query, connection);

                command.Parameters.AddWithValue("@GuestName", guestName);
                command.Parameters.AddWithValue("@CheckInDate", checkInDate);
                command.Parameters.AddWithValue("@CheckOutDate", checkOutDate);
                command.Parameters.AddWithValue("@RoomType", roomType);
                command.Parameters.AddWithValue("@NumberGuest", NumberGuest);

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


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void GuestName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void RoomType_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void AddReservation_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void NumberGuests_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckInDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string formattedDateTime = now.ToString("yyyy-MM-dd");
            Console.WriteLine(formattedDateTime);

        }

        private void CheckOutDate_ValueChanged(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            string formattedDateTime = now.ToString("yyyy-MM-dd");
            Console.WriteLine(formattedDateTime);

        }
    }
}
