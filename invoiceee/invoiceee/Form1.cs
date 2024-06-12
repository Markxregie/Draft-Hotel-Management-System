using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace invoiceee
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridView();
            SetDataGridViewStyles();
        }

        private void InitializeDataGridView()
        {
            // Add columns to the DataGridView
            dataGridView1.Columns.Add("InvoiceID", "Invoice ID");
            dataGridView1.Columns.Add("BookingID", "Booking ID");
            dataGridView1.Columns.Add("GuestName", "Guest Name");
            dataGridView1.Columns.Add("Amount", "Amount");

            // Add a DataGridViewComboBoxColumn for Status
            DataGridViewComboBoxColumn statusColumn = new DataGridViewComboBoxColumn();
            statusColumn.HeaderText = "Status";
            statusColumn.Name = "Status";
            statusColumn.Items.AddRange("Underpaid", "Paid", "Pending");

            dataGridView1.Columns.Add(statusColumn);

            // Add some sample rows (you can remove this if you are binding to a data source)
            dataGridView1.Rows.Add("1", "101", "Yesha Mier", "$xxxxxxx");
            dataGridView1.Rows.Add("2", "102", "jesalle Perez", "$xxxxxx");
        }

        private void SetDataGridViewStyles()
        {
            Font dataGridFont = new Font("Microsoft Sans Serif", 13, FontStyle.Bold);

            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#ececec");

            // Set the font for the entire DataGridView
            dataGridView1.Font = dataGridFont;

            // Set the font for all cells
            dataGridView1.DefaultCellStyle.Font = dataGridFont;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Additional initialization if needed
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Handle pictureBox1 click event
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Handle label5 click event
        }

        private void roundedPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Handle roundedPanel1 paint event
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle dataGridView1 cell content click event
        }

        private void LABEL_Click(object sender, EventArgs e)
        {
            // Handle LABEL click event
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}