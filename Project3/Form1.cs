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
        Thread _thread = null;

        //public void fThreadStart()
        //{
        //    _thread = new Thread(new ThreadStart(Run));  // ThreadStart 델리게이트 타입 객체를 생성 후 함수를 넘김
        //    _thread = new Thread(Run);   // 컴파일러에서 델리게이트 객체를 추론해서 생성 후 함수를 넘김 (new~생략)
         
        //    _thread.Start();
        //}

        //private void Run()
        //{

        //}

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

                /*
                 int ibar = 0;
                 if(bar.Value + ivar > 100)
                {
                bar.Value = 100;
                }else
                {
                bar.Value = var.Value + ivar
                 */
//            lblpro.Text = string.Format("{0}%", bar.value);
        }

        public void export()
        {
            
        }
    }
}
