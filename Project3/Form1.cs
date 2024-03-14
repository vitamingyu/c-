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
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms.VisualStyles;


namespace Project3
{
    public partial class Form1 : Form
    {
        Thread _thread = null;

        public void fThreadStart()
        {
            _thread = new Thread(Run);   // 컴파일러에서 델리게이트 객체를 추론해서 생성 후 함수를 넘김 (new~생략)
            _thread.Start();
            btnExport.Enabled = false;
        }

        private void Run()
        {
            try
            {
                ulong rowNumber, colNumber;
                string row = txtRow.Text;
                string col = txtCol.Text;

                bool rowResult = ulong.TryParse(row, out rowNumber);
                bool colResult = ulong.TryParse(col, out colNumber);

                string filepath = txtPath.Text;

                StreamWriter sw = new StreamWriter(filepath);

                sw.WriteLine("Hello World!!");
                sw.WriteLine("csvFile. time 3sec");
                Thread.Sleep(3000);
                sw.Close();


                if (!rowResult || !colResult)
                {
                    MessageBox.Show("ROW와 COLUMN은 양의 정수값만 입력 가능합니다.", "오류발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(filepath + "에 파일이 성공적으로 저장되었습니다.");
                }
            }

            catch (Exception er)
            {
                er.ToString();
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            //string folderPath = "";
            //FolderBrowserDialog directchoosedlg = new FolderBrowserDialog();
            //if (directchoosedlg.ShowDialog() == DialogResult.OK)
            //{
            //    folderPath = directchoosedlg.SelectedPath;
            //    txtPath.Text = folderPath;
            //}

            string folderPath = "";
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV File|*.csv";
            saveFileDialog.Title = "Save an csv file";
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = "csv";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;


            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                folderPath = saveFileDialog.FileName;
                txtPath.Text = folderPath;

            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            fThreadStart();
            /*
             int ibar = 0;
             if(bar.Value + ivar > 100)
             if(bar.Value + ivar > 100)
            {
            bar.Value = 100;
            }else
            {
            bar.Value = var.Value + ivar
             */
            //            lblpro.Text = string.Format("{0}%", bar.value);
        }

        public void ThreadAbort()
        {
            if (_thread != null && _thread.IsAlive)
            {
                _thread.Abort();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ThreadAbort();
        }
    }
}