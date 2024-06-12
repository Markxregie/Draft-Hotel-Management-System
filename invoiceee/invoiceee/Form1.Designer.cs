namespace invoiceee
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridView1;

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            roundedPanel1 = new RoundedPanel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            roundedPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(4, 55);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1153, 517);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(248, 248, 248);
            roundedPanel1.BorderColor = Color.White;
            roundedPanel1.Controls.Add(label1);
            roundedPanel1.Controls.Add(dataGridView1);
            roundedPanel1.Location = new Point(192, 76);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Radius = 20;
            roundedPanel1.Size = new Size(1121, 574);
            roundedPanel1.TabIndex = 1;
            roundedPanel1.Thickness = 5F;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(80, 129, 145);
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(187, 37);
            label1.TabIndex = 1;
            label1.Text = "Invoice List";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 129, 145);
            ClientSize = new Size(1325, 702);
            Controls.Add(roundedPanel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Invoice Status";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private RoundedPanel roundedPanel1;
        private Label label1;
    }
}
