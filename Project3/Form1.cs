using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Project3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            string folderPath = "";
            FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
            if (directchoosedlg.ShowDialog() == DialogResult.OK)
            {
                folderPath = directchoosedlg.SelectedPath;
                txtPath.Text = folderPath;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                ulong rowNumber, colNumber;
                string row = txtRow.Text;
                string col = txtCol.Text;

                bool rowResult = ulong.TryParse(row, out rowNumber);
                bool colResult = ulong.TryParse(col, out colNumber);


                string filepath = txtPath.Text;
                string fullfilepath = Path.Combine(filepath, @"test.csv");

                StreamWriter sw = new StreamWriter(fullfilepath);
                sw.WriteLine("Hello World!!");
                sw.WriteLine("From the StreamWriter class");
                sw.Close();

                if (!rowResult || !colResult)

                {
                    MessageBox.Show("ROW와 COLUMN은 양의 정수값만 입력 가능합니다.", "오류발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show(fullfilepath + "에 파일이 성공적으로 저장되었습니다.");
                }
            }

            catch (Exception er)
            {
                Console.WriteLine("Exception: " + er.Message);
            }
        }
    }
}
