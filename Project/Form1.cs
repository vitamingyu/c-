using System;
using System.IO;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void pathbtn_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
            if (directchoosedlg.ShowDialog() == DialogResult.OK)
            {
                folderPath = directchoosedlg.SelectedPath;
                txtPath.Text = folderPath;
            }

        }

        private void Export_Click(object sender, EventArgs e)
        {
            try
            {
                ulong i = 0;
                string row = txtRow.Text;
                string col = txtCol.Text;

                bool result = ulong.TryParse(row, out i) && ulong.TryParse(col, out i);
                if (result == false ) { 
                MessageBox.Show("ROW와 COLUMN은 양의 정수값만 입력 가능합니다.","오류발생",MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
            }

            catch 
            {
                
            }


        }

    }
}
