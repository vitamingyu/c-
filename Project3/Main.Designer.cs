namespace Project3
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPrjname = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.lblCol = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.txtRow = new System.Windows.Forms.TextBox();
            this.txtCol = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.lblpro = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.percentageLabel = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::Project3.Properties.Resources.BTS로고;
            this.pictureBox1.Location = new System.Drawing.Point(34, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblPrjname
            // 
            this.lblPrjname.AutoSize = true;
            this.lblPrjname.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPrjname.Location = new System.Drawing.Point(517, 68);
            this.lblPrjname.Name = "lblPrjname";
            this.lblPrjname.Size = new System.Drawing.Size(550, 30);
            this.lblPrjname.TabIndex = 1;
            this.lblPrjname.Text = "BTS Technologies INC. CSV Converter";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPath.Location = new System.Drawing.Point(70, 196);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(194, 30);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "Export Path :";
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRow.Location = new System.Drawing.Point(70, 322);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(94, 30);
            this.lblRow.TabIndex = 2;
            this.lblRow.Text = "Row :";
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCol.Location = new System.Drawing.Point(517, 322);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(130, 30);
            this.lblCol.TabIndex = 2;
            this.lblCol.Text = "Column:";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProgress.Location = new System.Drawing.Point(70, 451);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(157, 30);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.Text = "Progress :";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(213, 452);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(557, 29);
            this.progressBar1.TabIndex = 3;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(257, 200);
            this.txtPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(461, 25);
            this.txtPath.TabIndex = 4;
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(171, 326);
            this.txtRow.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(157, 25);
            this.txtRow.TabIndex = 4;
            // 
            // txtCol
            // 
            this.txtCol.Location = new System.Drawing.Point(642, 326);
            this.txtCol.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCol.Name = "txtCol";
            this.txtCol.Size = new System.Drawing.Size(128, 25);
            this.txtCol.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(878, 444);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 45);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnPath
            // 
            this.btnPath.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPath.Location = new System.Drawing.Point(743, 200);
            this.btnPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(104, 45);
            this.btnPath.TabIndex = 5;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExport.Location = new System.Drawing.Point(878, 200);
            this.btnExport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(104, 45);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // lblpro
            // 
            this.lblpro.AutoSize = true;
            this.lblpro.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblpro.Location = new System.Drawing.Point(791, 452);
            this.lblpro.Name = "lblpro";
            this.lblpro.Size = new System.Drawing.Size(66, 30);
            this.lblpro.TabIndex = 6;
            this.lblpro.Text = "0 %";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // percentageLabel
            // 
            this.percentageLabel.AutoSize = true;
            this.percentageLabel.Location = new System.Drawing.Point(868, 335);
            this.percentageLabel.Name = "percentageLabel";
            this.percentageLabel.Size = new System.Drawing.Size(114, 15);
            this.percentageLabel.TabIndex = 7;
            this.percentageLabel.Text = "percentageLabel";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(914, 395);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(75, 23);
            this.startBtn.TabIndex = 8;
            this.startBtn.Text = "button1";
            this.startBtn.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1023, 572);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.percentageLabel);
            this.Controls.Add(this.lblpro);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtCol);
            this.Controls.Add(this.txtRow);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblCol);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblPrjname);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPrjname;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Label lblCol;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtRow;
        private System.Windows.Forms.TextBox txtCol;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Label lblpro;
        private System.Windows.Forms.Label percentageLabel;
        private System.Windows.Forms.Button startBtn;
    }
}

