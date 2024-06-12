namespace invoice_reciept
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            roundedPanel1 = new RoundedPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            Refnumber = new Label();
            label4 = new Label();
            label5 = new Label();
            Invoice_date = new Label();
            valid_til = new Label();
            panel1 = new Panel();
            label6 = new Label();
            panel2 = new Panel();
            label7 = new Label();
            label8 = new Label();
            Name = new Label();
            label9 = new Label();
            Email = new Label();
            label10 = new Label();
            checkOut_date = new Label();
            label11 = new Label();
            bookingID = new Label();
            label12 = new Label();
            Contact_number = new Label();
            label14 = new Label();
            Checkin_time = new Label();
            label13 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            total_amount = new Label();
            invoice_amount = new Label();
            Balance = new Label();
            payment_method = new Label();
            status = new Label();
            roundedPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.White;
            roundedPanel1.BorderColor = Color.White;
            roundedPanel1.Controls.Add(status);
            roundedPanel1.Controls.Add(payment_method);
            roundedPanel1.Controls.Add(Balance);
            roundedPanel1.Controls.Add(invoice_amount);
            roundedPanel1.Controls.Add(total_amount);
            roundedPanel1.Controls.Add(label18);
            roundedPanel1.Controls.Add(label17);
            roundedPanel1.Controls.Add(label16);
            roundedPanel1.Controls.Add(label15);
            roundedPanel1.Controls.Add(label13);
            roundedPanel1.Controls.Add(Checkin_time);
            roundedPanel1.Controls.Add(label14);
            roundedPanel1.Controls.Add(Contact_number);
            roundedPanel1.Controls.Add(label12);
            roundedPanel1.Controls.Add(bookingID);
            roundedPanel1.Controls.Add(label11);
            roundedPanel1.Controls.Add(checkOut_date);
            roundedPanel1.Controls.Add(label10);
            roundedPanel1.Controls.Add(Email);
            roundedPanel1.Controls.Add(label9);
            roundedPanel1.Controls.Add(Name);
            roundedPanel1.Controls.Add(label8);
            roundedPanel1.Controls.Add(valid_til);
            roundedPanel1.Controls.Add(Invoice_date);
            roundedPanel1.Controls.Add(label5);
            roundedPanel1.Controls.Add(label4);
            roundedPanel1.Controls.Add(Refnumber);
            roundedPanel1.Controls.Add(label3);
            roundedPanel1.Controls.Add(label2);
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Location = new Point(192, 69);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Radius = 20;
            roundedPanel1.Size = new Size(1121, 574);
            roundedPanel1.TabIndex = 0;
            roundedPanel1.Thickness = 5F;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(80, 129, 145);
            label1.Location = new Point(31, 16);
            label1.Name = "label1";
            label1.Size = new Size(140, 37);
            label1.TabIndex = 0;
            label1.Text = "Invoices";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 66);
            label2.Name = "label2";
            label2.Size = new Size(164, 64);
            label2.TabIndex = 1;
            label2.Text = "123 Don Fabian Street \r\nBarangay Commonwealth \r\nQuezon City, Metro Manila \r\nPhilippines";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(769, 66);
            label3.Name = "label3";
            label3.Size = new Size(162, 16);
            label3.TabIndex = 2;
            label3.Text = "Invoice Reference no.:";
            label3.Click += label3_Click;
            // 
            // Refnumber
            // 
            Refnumber.AutoSize = true;
            Refnumber.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Refnumber.Location = new Point(937, 66);
            Refnumber.Name = "Refnumber";
            Refnumber.Size = new Size(71, 16);
            Refnumber.TabIndex = 3;
            Refnumber.Text = "XXXXXXXX";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(769, 82);
            label4.Name = "label4";
            label4.Size = new Size(98, 16);
            label4.TabIndex = 4;
            label4.Text = "Invoice Date:\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(769, 98);
            label5.Name = "label5";
            label5.Size = new Size(67, 16);
            label5.TabIndex = 5;
            label5.Text = "Valid till:";
            // 
            // Invoice_date
            // 
            Invoice_date.AutoSize = true;
            Invoice_date.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Invoice_date.Location = new Point(873, 82);
            Invoice_date.Name = "Invoice_date";
            Invoice_date.Size = new Size(81, 16);
            Invoice_date.TabIndex = 6;
            Invoice_date.Text = "mm/dd/yyyy";
            // 
            // valid_til
            // 
            valid_til.AutoSize = true;
            valid_til.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            valid_til.Location = new Point(842, 98);
            valid_til.Name = "valid_til";
            valid_til.Size = new Size(81, 16);
            valid_til.TabIndex = 7;
            valid_til.Text = "mm/dd/yyyy";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(236, 236, 236);
            panel1.Controls.Add(label6);
            panel1.Location = new Point(192, 215);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 41);
            panel1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(80, 129, 145);
            label6.Location = new Point(31, 8);
            label6.Name = "label6";
            label6.Size = new Size(197, 31);
            label6.TabIndex = 8;
            label6.Text = "Guess Details";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(236, 236, 236);
            panel2.Controls.Add(label7);
            panel2.Location = new Point(192, 426);
            panel2.Name = "panel2";
            panel2.Size = new Size(1120, 41);
            panel2.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(80, 129, 145);
            label7.Location = new Point(31, 8);
            label7.Name = "label7";
            label7.Size = new Size(227, 31);
            label7.TabIndex = 8;
            label7.Text = "Payment Details";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(31, 207);
            label8.Name = "label8";
            label8.Size = new Size(60, 20);
            label8.TabIndex = 8;
            label8.Text = "Name:";
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name.Location = new Point(89, 207);
            Name.Name = "Name";
            Name.Size = new Size(131, 20);
            Name.TabIndex = 9;
            Name.Text = "Sample .S Ample";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(31, 246);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 10;
            label9.Text = "Email:";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email.Location = new Point(89, 246);
            Email.Name = "Email";
            Email.Size = new Size(150, 20);
            Email.TabIndex = 11;
            Email.Text = "Sample@gmail.com";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(31, 283);
            label10.Name = "label10";
            label10.Size = new Size(143, 20);
            label10.TabIndex = 12;
            label10.Text = "Check-Out Date:";
            // 
            // checkOut_date
            // 
            checkOut_date.AutoSize = true;
            checkOut_date.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            checkOut_date.Location = new Point(180, 283);
            checkOut_date.Name = "checkOut_date";
            checkOut_date.Size = new Size(83, 20);
            checkOut_date.TabIndex = 13;
            checkOut_date.Text = "XX:XX pm";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(600, 207);
            label11.Name = "label11";
            label11.RightToLeft = RightToLeft.No;
            label11.Size = new Size(103, 20);
            label11.TabIndex = 14;
            label11.Text = "Booking ID:";
            // 
            // bookingID
            // 
            bookingID.AutoSize = true;
            bookingID.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bookingID.Location = new Point(709, 207);
            bookingID.Name = "bookingID";
            bookingID.Size = new Size(162, 20);
            bookingID.TabIndex = 15;
            bookingID.Text = "XXX-XXXXX-XXXXX";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(600, 246);
            label12.Name = "label12";
            label12.RightToLeft = RightToLeft.No;
            label12.Size = new Size(109, 20);
            label12.TabIndex = 16;
            label12.Text = "Contact No.:";
            // 
            // Contact_number
            // 
            Contact_number.AutoSize = true;
            Contact_number.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Contact_number.Location = new Point(709, 246);
            Contact_number.Name = "Contact_number";
            Contact_number.Size = new Size(108, 20);
            Contact_number.TabIndex = 17;
            Contact_number.Text = "09636334053";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(600, 283);
            label14.Name = "label14";
            label14.RightToLeft = RightToLeft.No;
            label14.Size = new Size(130, 20);
            label14.TabIndex = 18;
            label14.Text = "Check-In time: ";
            // 
            // Checkin_time
            // 
            Checkin_time.AutoSize = true;
            Checkin_time.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Checkin_time.Location = new Point(734, 283);
            Checkin_time.Name = "Checkin_time";
            Checkin_time.Size = new Size(83, 20);
            Checkin_time.TabIndex = 19;
            Checkin_time.Text = "XX:XX am";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(52, 422);
            label13.Name = "label13";
            label13.Size = new Size(116, 20);
            label13.TabIndex = 20;
            label13.Text = "Total Amount";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(283, 422);
            label15.Name = "label15";
            label15.Size = new Size(131, 20);
            label15.TabIndex = 21;
            label15.Text = "Invoice amount";
            label15.Click += label15_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(544, 422);
            label16.Name = "label16";
            label16.Size = new Size(79, 20);
            label16.TabIndex = 22;
            label16.Text = "Balance ";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(724, 422);
            label17.Name = "label17";
            label17.Size = new Size(143, 20);
            label17.TabIndex = 23;
            label17.Text = "Payment Method";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(958, 422);
            label18.Name = "label18";
            label18.Size = new Size(62, 20);
            label18.TabIndex = 24;
            label18.Text = "Status";
            // 
            // total_amount
            // 
            total_amount.AutoSize = true;
            total_amount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            total_amount.Location = new Point(65, 463);
            total_amount.Name = "total_amount";
            total_amount.Size = new Size(92, 20);
            total_amount.TabIndex = 25;
            total_amount.Text = "$ XXX,XXX";
            total_amount.Click += total_amount_Click;
            // 
            // invoice_amount
            // 
            invoice_amount.AutoSize = true;
            invoice_amount.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            invoice_amount.Location = new Point(306, 463);
            invoice_amount.Name = "invoice_amount";
            invoice_amount.Size = new Size(92, 20);
            invoice_amount.TabIndex = 29;
            invoice_amount.Text = "$ XXX,XXX";
            // 
            // Balance
            // 
            Balance.AutoSize = true;
            Balance.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Balance.Location = new Point(544, 463);
            Balance.Name = "Balance";
            Balance.Size = new Size(92, 20);
            Balance.TabIndex = 30;
            Balance.Text = "$ XXX,XXX";
            // 
            // payment_method
            // 
            payment_method.AutoSize = true;
            payment_method.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            payment_method.Location = new Point(757, 463);
            payment_method.Name = "payment_method";
            payment_method.Size = new Size(92, 20);
            payment_method.TabIndex = 31;
            payment_method.Text = "$ XXX,XXX";
            // 
            // status
            // 
            status.AutoSize = true;
            status.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            status.Location = new Point(949, 463);
            status.Name = "status";
            status.Size = new Size(92, 20);
            status.TabIndex = 32;
            status.Text = "$ XXX,XXX";
            status.Click += label19_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 129, 145);
            ClientSize = new Size(1325, 702);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(roundedPanel1);
            Name = "Form1";
            Text = "Form1";
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private RoundedPanel roundedPanel1;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label Refnumber;
        private Panel panel2;
        private Label label7;
        private Label valid_til;
        private Label Invoice_date;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private Label label6;
        private Label label11;
        private Label checkOut_date;
        private Label label10;
        private Label Email;
        private Label label9;
        private Label Name;
        private Label label8;
        private Label label16;
        private Label label15;
        private Label label13;
        private Label Checkin_time;
        private Label label14;
        private Label Contact_number;
        private Label label12;
        private Label bookingID;
        private Label label18;
        private Label label17;
        private Label total_amount;
        private Label status;
        private Label payment_method;
        private Label Balance;
        private Label invoice_amount;
    }
}
