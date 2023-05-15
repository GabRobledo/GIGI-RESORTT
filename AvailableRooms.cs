using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIGI_RESORTT
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'resortReservationSystemDataSet4.Available_Rooms' table. You can move, or remove it, as needed.
            this.available_RoomsTableAdapter.Fill(this.resortReservationSystemDataSet4.Available_Rooms);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckIn CheckIn = new CheckIn();
            CheckIn.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
