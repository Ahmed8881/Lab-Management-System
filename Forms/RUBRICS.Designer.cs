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
            UPDATECLO = new Button();
            DELETECLO = new Button();
            RUBRIC_LEVEL = new Button();
            RUBRICSGRID = new DataGridView();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)RUBRICSGRID).BeginInit();
            SuspendLayout();
            // 
            // CLOID
            // 
            CLOID.AutoSize = true;
            CLOID.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            CLOID.ForeColor = SystemColors.ActiveCaptionText;
            CLOID.Location = new Point(52, 86);
            CLOID.Margin = new Padding(2, 0, 2, 0);
            CLOID.Name = "CLOID";
            CLOID.Size = new Size(117, 21);
            CLOID.TabIndex = 0;
            CLOID.Text = "Rubrics Details";
            CLOID.Click += label1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(200, 88);
            textBox1.Margin = new Padding(2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 23);
            textBox1.TabIndex = 1;
            // 
            // ADD
            // 
            ADD.BackColor = SystemColors.Highlight;
            ADD.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            ADD.ForeColor = SystemColors.ControlLightLight;
            ADD.Location = new Point(387, 393);
            ADD.Margin = new Padding(2);
            ADD.Name = "ADD";
            ADD.Size = new Size(102, 34);
            ADD.TabIndex = 2;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = false;
            ADD.Click += ADD_Click;
            // 
            // CLONAME
            // 
            CLONAME.AutoSize = true;
            CLONAME.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            CLONAME.ForeColor = SystemColors.ActiveCaptionText;
            CLONAME.Location = new Point(78, 139);
            CLONAME.Margin = new Padding(2, 0, 2, 0);
            CLONAME.Name = "CLONAME";
            CLONAME.Size = new Size(64, 21);
            CLONAME.TabIndex = 3;
            CLONAME.Text = "CLO  ID";
            // 
            // UPDATECLO
            // 
            UPDATECLO.BackColor = SystemColors.Highlight;
            UPDATECLO.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            UPDATECLO.ForeColor = SystemColors.ControlLightLight;
            UPDATECLO.Location = new Point(517, 393);
            UPDATECLO.Margin = new Padding(2);
            UPDATECLO.Name = "UPDATECLO";
            UPDATECLO.Size = new Size(103, 34);
            UPDATECLO.TabIndex = 6;
            UPDATECLO.Text = "UPDATE";
            UPDATECLO.UseVisualStyleBackColor = false;
            UPDATECLO.Click += UPDATECLO_Click;
            // 
            // DELETECLO
            // 
            DELETECLO.BackColor = SystemColors.Highlight;
            DELETECLO.Font = new Font("Yu Gothic UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic);
            DELETECLO.ForeColor = SystemColors.ControlLightLight;
            DELETECLO.Location = new Point(648, 393);
            DELETECLO.Margin = new Padding(2);
            DELETECLO.Name = "DELETECLO";
            DELETECLO.Size = new Size(103, 34);
            DELETECLO.TabIndex = 7;
            DELETECLO.Text = "DELETE";
            DELETECLO.UseVisualStyleBackColor = false;
            DELETECLO.Click += DELETECLO_Click;
            // 
            // RUBRIC_LEVEL
            // 
            RUBRIC_LEVEL.BackColor = SystemColors.Highlight;
            RUBRIC_LEVEL.Font = new Font("Yu Gothic UI Semibold", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            RUBRIC_LEVEL.ForeColor = SystemColors.ButtonHighlight;
            RUBRIC_LEVEL.Location = new Point(52, 206);
            RUBRIC_LEVEL.Margin = new Padding(2);
            RUBRIC_LEVEL.Name = "RUBRIC_LEVEL";
            RUBRIC_LEVEL.Size = new Size(298, 34);
            RUBRIC_LEVEL.TabIndex = 8;
            RUBRIC_LEVEL.Text = "Go  To Rubric Level Page";
            RUBRIC_LEVEL.UseVisualStyleBackColor = false;
            RUBRIC_LEVEL.Click += RUBRIC_LEVEL_Click;
            // 
            // RUBRICSGRID
            // 
            RUBRICSGRID.BackgroundColor = SystemColors.ButtonHighlight;
            RUBRICSGRID.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RUBRICSGRID.Location = new Point(387, 34);
            RUBRICSGRID.Margin = new Padding(2);
            RUBRICSGRID.Name = "RUBRICSGRID";
            RUBRICSGRID.RowHeadersWidth = 62;
            RUBRICSGRID.Size = new Size(430, 338);
            RUBRICSGRID.TabIndex = 10;
            RUBRICSGRID.CellClick += DataGridView1_CellClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(200, 139);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(142, 23);
            comboBox1.TabIndex = 11;
            // 
            // RUBRICS
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 565);
            Controls.Add(comboBox1);
            Controls.Add(RUBRICSGRID);
            Controls.Add(RUBRIC_LEVEL);
            Controls.Add(DELETECLO);
            Controls.Add(UPDATECLO);
            Controls.Add(CLONAME);
            Controls.Add(ADD);
            Controls.Add(textBox1);
            Controls.Add(CLOID);
            Margin = new Padding(2);
            Name = "RUBRICS";
            Text = "RUBRICS";
            ((System.ComponentModel.ISupportInitialize)RUBRICSGRID).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CLOID;
        private TextBox textBox1;
        private Button ADD;
        private Label CLONAME;
        private Button UPDATECLO;
        private Button DELETECLO;
        private Button RUBRIC_LEVEL;
        private DataGridView RUBRICSGRID;
        private ComboBox comboBox1;
    }
}