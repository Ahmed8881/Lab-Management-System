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
            createdDate = new Label();
            UpdatedDate = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ADDCLO = new Button();
            UPDATECLO = new Button();
            DELETECLO = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CLONAME
            // 
            CLONAME.AutoSize = true;
            CLONAME.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            CLONAME.Location = new Point(84, 106);
            CLONAME.Name = "CLONAME";
            CLONAME.Size = new Size(66, 28);
            CLONAME.TabIndex = 0;
            CLONAME.Text = "Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(213, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(179, 31);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(424, 103);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(509, 443);
            dataGridView1.TabIndex = 2;
            // 
            // createdDate
            // 
            createdDate.AutoSize = true;
            createdDate.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            createdDate.Location = new Point(60, 166);
            createdDate.Name = "createdDate";
            createdDate.Size = new Size(130, 28);
            createdDate.TabIndex = 3;
            createdDate.Text = "Created Date";
            // 
            // UpdatedDate
            // 
            UpdatedDate.AutoSize = true;
            UpdatedDate.Font = new Font("Yu Gothic UI Semibold", 10F, FontStyle.Bold | FontStyle.Italic);
            UpdatedDate.Location = new Point(59, 223);
            UpdatedDate.Name = "UpdatedDate";
            UpdatedDate.Size = new Size(138, 28);
            UpdatedDate.TabIndex = 4;
            UpdatedDate.Text = "Updated Date";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(213, 166);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 31);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(213, 223);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(179, 31);
            textBox3.TabIndex = 6;
            // 
            // ADDCLO
            // 
            ADDCLO.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ADDCLO.BackColor = SystemColors.MenuHighlight;
            ADDCLO.ForeColor = SystemColors.ControlLightLight;
            ADDCLO.Location = new Point(445, 583);
            ADDCLO.Name = "ADDCLO";
            ADDCLO.Size = new Size(116, 57);
            ADDCLO.TabIndex = 7;
            ADDCLO.Text = "ADD";
            ADDCLO.UseVisualStyleBackColor = false;
            // 
            // UPDATECLO
            // 
            UPDATECLO.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UPDATECLO.BackColor = SystemColors.MenuHighlight;
            UPDATECLO.ForeColor = SystemColors.ControlLightLight;
            UPDATECLO.Location = new Point(587, 583);
            UPDATECLO.Name = "UPDATECLO";
            UPDATECLO.Size = new Size(119, 57);
            UPDATECLO.TabIndex = 8;
            UPDATECLO.Text = "UPDATE";
            UPDATECLO.UseVisualStyleBackColor = false;
            // 
            // DELETECLO
            // 
            DELETECLO.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DELETECLO.BackColor = SystemColors.MenuHighlight;
            DELETECLO.ForeColor = SystemColors.ControlLightLight;
            DELETECLO.Location = new Point(736, 583);
            DELETECLO.Name = "DELETECLO";
            DELETECLO.Size = new Size(110, 57);
            DELETECLO.TabIndex = 9;
            DELETECLO.Text = "DELETE";
            DELETECLO.UseVisualStyleBackColor = false;
            // 
            // CLOS
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 665);
            Controls.Add(DELETECLO);
            Controls.Add(UPDATECLO);
            Controls.Add(ADDCLO);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(UpdatedDate);
            Controls.Add(createdDate);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(CLONAME);
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
        private Label createdDate;
        private Label UpdatedDate;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button ADDCLO;
        private Button UPDATECLO;
        private Button DELETECLO;
    }
}