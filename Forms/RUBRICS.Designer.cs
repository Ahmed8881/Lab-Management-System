namespace sample.Forms
{
    partial class RUBRICS
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
            CLOID = new Label();
            textBox1 = new TextBox();
            ADD = new Button();
            CLONAME = new Label();
            textBox2 = new TextBox();
            CLODETAILS = new Label();
            UPDATECLO = new Button();
            DELETECLO = new Button();
            RUBRIC_LEVEL = new Button();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CLOID
            // 
            CLOID.AutoSize = true;
            CLOID.Location = new Point(143, 114);
            CLOID.Margin = new Padding(2, 0, 2, 0);
            CLOID.Name = "CLOID";
            CLOID.Size = new Size(54, 20);
            CLOID.TabIndex = 0;
            CLOID.Text = "CLO ID";
            CLOID.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(245, 114);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(104, 27);
            textBox1.TabIndex = 1;
            // 
            // ADD
            // 
            ADD.Location = new Point(424, 394);
            ADD.Margin = new Padding(2, 2, 2, 2);
            ADD.Name = "ADD";
            ADD.Size = new Size(81, 46);
            ADD.TabIndex = 2;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            // 
            // CLONAME
            // 
            CLONAME.AutoSize = true;
            CLONAME.Location = new Point(132, 159);
            CLONAME.Margin = new Padding(2, 0, 2, 0);
            CLONAME.Name = "CLONAME";
            CLONAME.Size = new Size(81, 20);
            CLONAME.TabIndex = 3;
            CLONAME.Text = "CLO NAME";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(245, 159);
            textBox2.Margin = new Padding(2, 2, 2, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(104, 27);
            textBox2.TabIndex = 4;
            // 
            // CLODETAILS
            // 
            CLODETAILS.AutoSize = true;
            CLODETAILS.Location = new Point(130, 216);
            CLODETAILS.Margin = new Padding(2, 0, 2, 0);
            CLODETAILS.Name = "CLODETAILS";
            CLODETAILS.Size = new Size(85, 20);
            CLODETAILS.TabIndex = 5;
            CLODETAILS.Text = "CLO Details";
            // 
            // UPDATECLO
            // 
            UPDATECLO.Location = new Point(525, 394);
            UPDATECLO.Margin = new Padding(2, 2, 2, 2);
            UPDATECLO.Name = "UPDATECLO";
            UPDATECLO.Size = new Size(81, 46);
            UPDATECLO.TabIndex = 6;
            UPDATECLO.Text = "UPDATE";
            UPDATECLO.UseVisualStyleBackColor = true;
            // 
            // DELETECLO
            // 
            DELETECLO.Location = new Point(627, 394);
            DELETECLO.Margin = new Padding(2, 2, 2, 2);
            DELETECLO.Name = "DELETECLO";
            DELETECLO.Size = new Size(81, 46);
            DELETECLO.TabIndex = 7;
            DELETECLO.Text = "DELETE";
            DELETECLO.UseVisualStyleBackColor = true;
            // 
            // RUBRIC_LEVEL
            // 
            RUBRIC_LEVEL.Location = new Point(116, 285);
            RUBRIC_LEVEL.Margin = new Padding(2, 2, 2, 2);
            RUBRIC_LEVEL.Name = "RUBRIC_LEVEL";
            RUBRIC_LEVEL.Size = new Size(257, 46);
            RUBRIC_LEVEL.TabIndex = 8;
            RUBRIC_LEVEL.Text = "Go  To Rubric Level Page";
            RUBRIC_LEVEL.UseVisualStyleBackColor = true;
            RUBRIC_LEVEL.Click += RUBRIC_LEVEL_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(245, 214);
            textBox3.Margin = new Padding(2, 2, 2, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(104, 27);
            textBox3.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(442, 46);
            dataGridView1.Margin = new Padding(2, 2, 2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(291, 321);
            dataGridView1.TabIndex = 10;
            // 
            // RUBRICS
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 550);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(RUBRIC_LEVEL);
            Controls.Add(DELETECLO);
            Controls.Add(UPDATECLO);
            Controls.Add(CLODETAILS);
            Controls.Add(textBox2);
            Controls.Add(CLONAME);
            Controls.Add(ADD);
            Controls.Add(textBox1);
            Controls.Add(CLOID);
            Margin = new Padding(2, 2, 2, 2);
            Name = "RUBRICS";
            Text = "RUBRICS";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CLOID;
        private TextBox textBox1;
        private Button ADD;
        private Label CLONAME;
        private TextBox textBox2;
        private Label CLODETAILS;
        private Button UPDATECLO;
        private Button DELETECLO;
        private Button RUBRIC_LEVEL;
        private TextBox textBox3;
        private DataGridView dataGridView1;
    }
}