namespace UsingControls
{
    partial class MainForm
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
            grpFont = new GroupBox();
            txtSampleText = new TextBox();
            chkItalic = new CheckBox();
            chkBold = new CheckBox();
            cboFont = new ComboBox();
            lblFont = new Label();
            grpFont.SuspendLayout();
            SuspendLayout();
            // 
            // grpFont
            // 
            grpFont.Controls.Add(txtSampleText);
            grpFont.Controls.Add(chkItalic);
            grpFont.Controls.Add(chkBold);
            grpFont.Controls.Add(cboFont);
            grpFont.Controls.Add(lblFont);
            grpFont.Location = new Point(33, 25);
            grpFont.Name = "grpFont";
            grpFont.Size = new Size(741, 257);
            grpFont.TabIndex = 0;
            grpFont.TabStop = false;
            grpFont.Text = "ComboBox,CheckBox,TextBox";
            // 
            // txtSampleText
            // 
            txtSampleText.Location = new Point(43, 118);
            txtSampleText.Name = "txtSampleText";
            txtSampleText.Size = new Size(125, 27);
            txtSampleText.TabIndex = 4;
            txtSampleText.Text = "Hello, C#";
            txtSampleText.TextChanged += txtSampleText_TextChanged;
            // 
            // chkItalic
            // 
            chkItalic.AutoSize = true;
            chkItalic.Font = new Font("맑은 고딕", 9F, FontStyle.Italic, GraphicsUnit.Point);
            chkItalic.Location = new Point(446, 63);
            chkItalic.Name = "chkItalic";
            chkItalic.Size = new Size(76, 24);
            chkItalic.TabIndex = 3;
            chkItalic.Text = "이탤릭";
            chkItalic.UseVisualStyleBackColor = true;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            chkBold.Location = new Point(359, 60);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(61, 24);
            chkBold.TabIndex = 2;
            chkBold.Text = "굵게";
            chkBold.UseVisualStyleBackColor = true;
            // 
            // cboFont
            // 
            cboFont.FormattingEnabled = true;
            cboFont.Location = new Point(99, 60);
            cboFont.Name = "cboFont";
            cboFont.Size = new Size(151, 28);
            cboFont.TabIndex = 1;
            // 
            // lblFont
            // 
            lblFont.AutoSize = true;
            lblFont.Location = new Point(31, 52);
            lblFont.Name = "lblFont";
            lblFont.Size = new Size(39, 20);
            lblFont.TabIndex = 0;
            lblFont.Text = "Font";
            lblFont.Click += label1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(grpFont);
            Name = "MainForm";
            Text = "Control Test";
            Load += MainForm_Load;
            grpFont.ResumeLayout(false);
            grpFont.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpFont;
        private Label lblFont;
        private CheckBox chkBold;
        private ComboBox cboFont;
        private TextBox txtSampleText;
        private CheckBox chkItalic;
    }
}
