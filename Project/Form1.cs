using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Threading;

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
                    MessageBox.Show("ROW�� COLUMN�� ���� �������� �Է� �����մϴ�.", "�����߻�", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    MessageBox.Show(fullfilepath + "�� ������ ���������� ����Ǿ����ϴ�.");
                }
            }

            catch (Exception er)
            {
                Console.WriteLine("Exception: " + er.Message);
            }

        }

    }
}
