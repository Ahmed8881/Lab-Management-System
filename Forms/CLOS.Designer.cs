namespace sample.Forms
{
    partial class CLOS
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
            CLONAME = new Label();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            ADDCLO = new Button();
            UPDATECLO = new Button();
            DELETECLO = new Button();
            label1 = new Label();
            DatePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CLONAME
            // 
            CLONAME.AutoSize = true;
            CLONAME.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            CLONAME.Location = new Point(40, 64);
            CLONAME.Margin = new Padding(2, 0, 2, 0);
            CLONAME.Name = "CLONAME";
            CLONAME.Size = new Size(46, 19);
            CLONAME.TabIndex = 0;
            CLONAME.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(149, 64);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 23);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(297, 62);
            dataGridView1.Margin = new Padding(2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(356, 266);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // ADDCLO
            // 
            ADDCLO.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ADDCLO.BackColor = SystemColors.MenuHighlight;
            ADDCLO.ForeColor = SystemColors.ControlLightLight;
            ADDCLO.Location = new Point(312, 350);
            ADDCLO.Margin = new Padding(2);
            ADDCLO.Name = "ADDCLO";
            ADDCLO.Size = new Size(81, 34);
            ADDCLO.TabIndex = 7;
            ADDCLO.Text = "ADD";
            ADDCLO.UseVisualStyleBackColor = false;
            ADDCLO.Click += AddClo_Click;
            // 
            // UPDATECLO
            // 
            UPDATECLO.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UPDATECLO.BackColor = SystemColors.MenuHighlight;
            UPDATECLO.ForeColor = SystemColors.ControlLightLight;
            UPDATECLO.Location = new Point(411, 350);
            UPDATECLO.Margin = new Padding(2);
            UPDATECLO.Name = "UPDATECLO";
            UPDATECLO.Size = new Size(83, 34);
            UPDATECLO.TabIndex = 8;
            UPDATECLO.Text = "UPDATE";
            UPDATECLO.UseVisualStyleBackColor = false;
            UPDATECLO.Click += UpdateClo_Click;
            // 
            // DELETECLO
            // 
            DELETECLO.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DELETECLO.BackColor = SystemColors.MenuHighlight;
            DELETECLO.ForeColor = SystemColors.ControlLightLight;
            DELETECLO.Location = new Point(515, 350);
            DELETECLO.Margin = new Padding(2);
            DELETECLO.Name = "DELETECLO";
            DELETECLO.Size = new Size(77, 34);
            DELETECLO.TabIndex = 9;
            DELETECLO.Text = "DELETE";
            DELETECLO.UseVisualStyleBackColor = false;
            DELETECLO.Click += DeleteClo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(40, 129);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(38, 19);
            label1.TabIndex = 10;
            label1.Text = "Date";
            label1.Click += label1_Click;
            // 
            // DatePicker
            // 
            DatePicker.Location = new Point(92, 129);
            DatePicker.Name = "DatePicker";
            DatePicker.Size = new Size(200, 23);
            DatePicker.TabIndex = 11;
            // 
            // CLOS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 399);
            Controls.Add(DatePicker);
            Controls.Add(label1);
            Controls.Add(DELETECLO);
            Controls.Add(UPDATECLO);
            Controls.Add(ADDCLO);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(CLONAME);
            Margin = new Padding(2);
            Name = "CLOS";
            Text = "CLOS";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CLONAME;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button ADDCLO;
        private Button UPDATECLO;
        private Button DELETECLO;
        private Label label1;
        private DateTimePicker DatePicker;
    }
}