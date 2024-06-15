namespace booking1
{
    public partial class frmBooking : Form
    {
        public frmBooking()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (frmBookingAddEdit frm = new frmBookingAddEdit() { BookingInfo = new Booking() })
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    bookingBindingSource.Add(frm.BookingInfo);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Booking obj = bookingBindingSource.Current as Booking;
            if( obj != null)
            {
                using (frmBookingAddEdit frm = new frmBookingAddEdit() { BookingInfo=obj })
                {
                    if(frm.ShowDialog() == DialogResult.OK)
                    {
                        bookingBindingSource.EndEdit();
                        btnEdit.Focus();
                    }
                }
            }
        }
    }
}
