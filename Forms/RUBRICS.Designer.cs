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
            CLOID.Location = new Point(179, 142);
            CLOID.Name = "CLOID";
            CLOID.Size = new Size(67, 25);
            CLOID.TabIndex = 0;
            CLOID.Text = "CLO ID";
            CLOID.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(306, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(129, 31);
            textBox1.TabIndex = 1;
            // 
            // ADD
            // 
            ADD.Location = new Point(530, 493);
            ADD.Name = "ADD";
            ADD.Size = new Size(101, 57);
            ADD.TabIndex = 2;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = true;
            // 
            // CLONAME
            // 
            CLONAME.AutoSize = true;
            CLONAME.Location = new Point(165, 199);
            CLONAME.Name = "CLONAME";
            CLONAME.Size = new Size(99, 25);
            CLONAME.TabIndex = 3;
            CLONAME.Text = "CLO NAME";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(306, 199);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(129, 31);
            textBox2.TabIndex = 4;
            // 
            // CLODETAILS
            // 
            CLODETAILS.AutoSize = true;
            CLODETAILS.Location = new Point(162, 270);
            CLODETAILS.Name = "CLODETAILS";
            CLODETAILS.Size = new Size(102, 25);
            CLODETAILS.TabIndex = 5;
            CLODETAILS.Text = "CLO Details";
            // 
            // UPDATECLO
            // 
            UPDATECLO.Location = new Point(656, 493);
            UPDATECLO.Name = "UPDATECLO";
            UPDATECLO.Size = new Size(101, 57);
            UPDATECLO.TabIndex = 6;
            UPDATECLO.Text = "UPDATE";
            UPDATECLO.UseVisualStyleBackColor = true;
            // 
            // DELETECLO
            // 
            DELETECLO.Location = new Point(784, 493);
            DELETECLO.Name = "DELETECLO";
            DELETECLO.Size = new Size(101, 57);
            DELETECLO.TabIndex = 7;
            DELETECLO.Text = "DELETE";
            DELETECLO.UseVisualStyleBackColor = true;
            // 
            // RUBRIC_LEVEL
            // 
            RUBRIC_LEVEL.Location = new Point(145, 356);
            RUBRIC_LEVEL.Name = "RUBRIC_LEVEL";
            RUBRIC_LEVEL.Size = new Size(321, 57);
            RUBRIC_LEVEL.TabIndex = 8;
            RUBRIC_LEVEL.Text = "Go  To Rubric Level Page";
            RUBRIC_LEVEL.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(306, 267);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(129, 31);
            textBox3.TabIndex = 9;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(553, 58);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(364, 401);
            dataGridView1.TabIndex = 10;
            // 
            // RUBRICS
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 688);
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