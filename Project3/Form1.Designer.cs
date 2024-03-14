namespace Project3
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::Project3.Properties.Resources.BTS로고;
            this.pictureBox1.Location = new System.Drawing.Point(30, 23);
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
            this.lblPrjname.Location = new System.Drawing.Point(452, 54);
            this.lblPrjname.Name = "lblPrjname";
            this.lblPrjname.Size = new System.Drawing.Size(407, 24);
            this.lblPrjname.TabIndex = 1;
            this.lblPrjname.Text = "BTS Technologies INC. CSV Converter";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblPath.Location = new System.Drawing.Point(61, 157);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(149, 24);
            this.lblPath.TabIndex = 2;
            this.lblPath.Text = "Export Path :";
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblRow.Location = new System.Drawing.Point(61, 258);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(73, 24);
            this.lblRow.TabIndex = 2;
            this.lblRow.Text = "Row :";
            // 
            // lblCol
            // 
            this.lblCol.AutoSize = true;
            this.lblCol.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblCol.Location = new System.Drawing.Point(452, 258);
            this.lblCol.Name = "lblCol";
            this.lblCol.Size = new System.Drawing.Size(93, 24);
            this.lblCol.TabIndex = 2;
            this.lblCol.Text = "Column:";
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblProgress.Location = new System.Drawing.Point(61, 361);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(116, 24);
            this.lblProgress.TabIndex = 2;
            this.lblProgress.Text = "Progress :";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(225, 362);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(468, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(225, 160);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(404, 21);
            this.txtPath.TabIndex = 4;
            // 
            // txtRow
            // 
            this.txtRow.Location = new System.Drawing.Point(150, 261);
            this.txtRow.Name = "txtRow";
            this.txtRow.Size = new System.Drawing.Size(131, 21);
            this.txtRow.TabIndex = 4;
            // 
            // txtCol
            // 
            this.txtCol.Location = new System.Drawing.Point(562, 258);
            this.txtCol.Name = "txtCol";
            this.txtCol.Size = new System.Drawing.Size(131, 21);
            this.txtCol.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnCancel.Location = new System.Drawing.Point(735, 361);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 36);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPath
            // 
            this.btnPath.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnPath.Location = new System.Drawing.Point(650, 160);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(91, 36);
            this.btnPath.TabIndex = 5;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExport.Location = new System.Drawing.Point(768, 160);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(91, 36);
            this.btnExport.TabIndex = 5;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(895, 458);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
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
    }
}

