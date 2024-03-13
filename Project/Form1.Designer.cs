namespace Project
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
            pictureBox1 = new PictureBox();
            btnCancel = new Button();
            btnExport = new Button();
            PrjName = new Label();
            ExportPath = new Label();
            Column = new Label();
            Progress = new Label();
            Row = new Label();
            txtPath = new TextBox();
            btnPath = new Button();
            txtRow = new TextBox();
            txtCol = new TextBox();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.BTS로고;
            pictureBox1.Location = new Point(41, 27);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(400, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnCancel
            // 
            btnCancel.AutoSize = true;
            btnCancel.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(737, 329);
            btnCancel.Margin = new Padding(2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 42);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += button1_Click;
            // 
            // btnExport
            // 
            btnExport.AutoSize = true;
            btnExport.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnExport.Location = new Point(737, 159);
            btnExport.Margin = new Padding(2);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(91, 42);
            btnExport.TabIndex = 7;
            btnExport.Text = "Export";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += Export_Click;
            // 
            // PrjName
            // 
            PrjName.AutoSize = true;
            PrjName.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            PrjName.Location = new Point(445, 39);
            PrjName.Margin = new Padding(2, 0, 2, 0);
            PrjName.Name = "PrjName";
            PrjName.Size = new Size(420, 32);
            PrjName.TabIndex = 8;
            PrjName.Text = "BTS Technologies INC. CSV Converter";
            // 
            // ExportPath
            // 
            ExportPath.AutoSize = true;
            ExportPath.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            ExportPath.Location = new Point(42, 164);
            ExportPath.Name = "ExportPath";
            ExportPath.Size = new Size(150, 32);
            ExportPath.TabIndex = 9;
            ExportPath.Text = "Export Path :";
            // 
            // Column
            // 
            Column.AutoSize = true;
            Column.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Column.Location = new Point(413, 243);
            Column.Name = "Column";
            Column.Size = new Size(111, 32);
            Column.TabIndex = 9;
            Column.Text = "Column :";
            Column.Click += label1_Click;
            // 
            // Progress
            // 
            Progress.AutoSize = true;
            Progress.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Progress.Location = new Point(42, 329);
            Progress.Name = "Progress";
            Progress.Size = new Size(105, 32);
            Progress.TabIndex = 9;
            Progress.Text = "Progress";
            Progress.Click += label2_Click;
            // 
            // Row
            // 
            Row.AutoSize = true;
            Row.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            Row.Location = new Point(42, 243);
            Row.Name = "Row";
            Row.Size = new Size(74, 32);
            Row.TabIndex = 9;
            Row.Text = "Row :";
            Row.Click += label1_Click;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(213, 173);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(364, 23);
            txtPath.TabIndex = 10;
            // 
            // btnPath
            // 
            btnPath.AutoSize = true;
            btnPath.Font = new Font("맑은 고딕", 18F, FontStyle.Regular, GraphicsUnit.Point);
            btnPath.Location = new Point(611, 159);
            btnPath.Margin = new Padding(2);
            btnPath.Name = "btnPath";
            btnPath.Size = new Size(91, 42);
            btnPath.TabIndex = 7;
            btnPath.Text = "...";
            btnPath.UseVisualStyleBackColor = true;
            btnPath.Click += pathbtn_Click;
            // 
            // txtRow
            // 
            txtRow.Location = new Point(135, 254);
            txtRow.Name = "txtRow";
            txtRow.Size = new Size(106, 23);
            txtRow.TabIndex = 10;
            // 
            // txtCol
            // 
            txtCol.Location = new Point(530, 254);
            txtCol.Name = "txtCol";
            txtCol.Size = new Size(106, 23);
            txtCol.TabIndex = 10;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(174, 338);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(411, 23);
            progressBar1.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(898, 428);
            Controls.Add(progressBar1);
            Controls.Add(txtCol);
            Controls.Add(txtRow);
            Controls.Add(txtPath);
            Controls.Add(Progress);
            Controls.Add(Row);
            Controls.Add(Column);
            Controls.Add(ExportPath);
            Controls.Add(PrjName);
            Controls.Add(btnPath);
            Controls.Add(btnExport);
            Controls.Add(btnCancel);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnCancel;
        private Button btnExport;
        private Label PrjName;
        private Label ExportPath;
        private Label Column;
        private Label Progress;
        private Label Row;
        private TextBox txtPath;
        private Button btnPath;
        private TextBox txtRow;
        private TextBox txtCol;
        private ProgressBar progressBar1;
    }
}
