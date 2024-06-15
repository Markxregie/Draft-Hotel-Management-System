namespace booking1
{
    partial class frmBookingAddEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOK = new HOTELMANAGE.Customs.RoundedButtonVer2();
            label1 = new Label();
            txtBookingID = new HOTELMANAGE.Customs.TextBox();
            txtFullName = new HOTELMANAGE.Customs.TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnOK
            // 
            btnOK.BackColor = Color.MediumSlateBlue;
            btnOK.BackgroundColor = Color.MediumSlateBlue;
            btnOK.BorderColor = Color.PaleVioletRed;
            btnOK.BorderRadius = 0;
            btnOK.BorderSize = 0;
            btnOK.DialogResult = DialogResult.OK;
            btnOK.FlatAppearance.BorderSize = 0;
            btnOK.FlatStyle = FlatStyle.Flat;
            btnOK.ForeColor = Color.White;
            btnOK.Location = new Point(324, 245);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(87, 40);
            btnOK.TabIndex = 0;
            btnOK.Text = "OK";
            btnOK.TextColor = Color.White;
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 58);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 1;
            label1.Text = "Booking ID:";
            // 
            // txtBookingID
            // 
            txtBookingID.BackColor = SystemColors.Window;
            txtBookingID.BorderColor = Color.MediumSlateBlue;
            txtBookingID.BorderFocusColor = Color.HotPink;
            txtBookingID.BorderRadius = 0;
            txtBookingID.BorderSize = 2;
            txtBookingID.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBookingID.ForeColor = Color.FromArgb(64, 64, 64);
            txtBookingID.Location = new Point(119, 52);
            txtBookingID.Margin = new Padding(4);
            txtBookingID.Multiline = false;
            txtBookingID.Name = "txtBookingID";
            txtBookingID.Padding = new Padding(10, 7, 10, 7);
            txtBookingID.PasswordChar = false;
            txtBookingID.PlaceholderColor = Color.DarkGray;
            txtBookingID.PlaceholderText = "";
            txtBookingID.Size = new Size(250, 31);
            txtBookingID.TabIndex = 2;
            txtBookingID.Texts = "";
            txtBookingID.UnderlinedStyle = false;
            // 
            // txtFullName
            // 
            txtFullName.BackColor = SystemColors.Window;
            txtFullName.BorderColor = Color.MediumSlateBlue;
            txtFullName.BorderFocusColor = Color.HotPink;
            txtFullName.BorderRadius = 0;
            txtFullName.BorderSize = 2;
            txtFullName.Font = new Font("Microsoft Sans Serif", 9.5F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFullName.ForeColor = Color.FromArgb(64, 64, 64);
            txtFullName.Location = new Point(119, 140);
            txtFullName.Margin = new Padding(4);
            txtFullName.Multiline = false;
            txtFullName.Name = "txtFullName";
            txtFullName.Padding = new Padding(10, 7, 10, 7);
            txtFullName.PasswordChar = false;
            txtFullName.PlaceholderColor = Color.DarkGray;
            txtFullName.PlaceholderText = "";
            txtFullName.Size = new Size(250, 31);
            txtFullName.TabIndex = 4;
            txtFullName.Texts = "";
            txtFullName.UnderlinedStyle = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 146);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 3;
            label2.Text = "Full Name:";
            label2.Click += label2_Click;
            // 
            // frmBookingAddEdit
            // 
            AcceptButton = btnOK;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 311);
            Controls.Add(txtFullName);
            Controls.Add(label2);
            Controls.Add(txtBookingID);
            Controls.Add(label1);
            Controls.Add(btnOK);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmBookingAddEdit";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Booking";
            Load += frmBookingAddEdit_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private HOTELMANAGE.Customs.RoundedButtonVer2 btnOK;
        private Label label1;
        private HOTELMANAGE.Customs.TextBox txtBookingID;
        private HOTELMANAGE.Customs.TextBox txtFullName;
        private Label label2;
    }
}