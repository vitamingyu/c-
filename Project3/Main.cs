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
    public partial class Main : Form
    {
        Thread _thread = null;

        public Main()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        //export 버튼 클릭
        {
            //btnExport.Enabled = false;
            ThreadStart();
        }

        public void ThreadStart()
        // export버튼 클릭시 스레드를 실행합니다
        {
            _thread = new Thread(Run);
            _thread.Start();
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
                // row와 col의 숫자값이 커도 실행되도록 ulong타입으로 선언했습니다

                string filepath = txtPath.Text;

                if (!rowResult || !colResult)
                {
                    DialogResult result = MessageBox.Show("ROW와 COLUMN은 양의 정수값만 입력 가능합니다.", "오류발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //if(result == DialogResult.OK){
                    //    btnExport.Enabled = true;
                    //}
                }
                else
                {
                    StreamWriter sw = new StreamWriter(filepath);
                    // 양의 정수값 유효성 검사 후 파일 생성을 시작합니다

                    sw.WriteLine("Hello World!!");
                    sw.WriteLine("csvFile. time 5sec");
                    Thread.Sleep(5000);
                    sw.Close();

                    DialogResult result = MessageBox.Show(filepath + "에 파일이 성공적으로 저장되었습니다.", "성공", MessageBoxButtons.OK);
                    //if(result == DialogResult.Yes){
                    //    btnExport.Enabled = true;
                    //}
                }
            }

            catch (ThreadAbortException abe)
            {
                abe.ToString();
            }
        }


        private void btnPath_Click(object sender, EventArgs e)
        // ...버튼 클릭시 csv파일을 저장하기 위한 다이얼로그가 실행됩니다
        {
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


        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (_thread != null && _thread.IsAlive)
            //스레드가 실행중일 때만 중지하도록 구현했습니다
            {
                _thread.Abort();
            }

            System.IO.FileInfo file_info = new System.IO.FileInfo(txtPath.Text);
            // 파일 생성이 끝나고 cancel버튼을 해당 파일을 삭제합니다.
            // 파일 생성 중 cancel버튼을 누를시 스레드만 중단되고 삭제는 되지 않습니다(수정 예정)
            try
            {
                file_info.Delete();
            }
            catch (Exception ee)
            {
                ee.ToString();
            }
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            for(int i=0; i<=100;i++)
            {
                if(backgroundWorker1.CancellationPending)
                {
                    e.Cancel = true;
                }
                else
                {
                     simulateHeavyWork();
                    backgroundWorker1.ReportProgress(i);
                }
               
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            percentageLabel.Text = e.ProgressPercentage.ToString() + " %";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if(e.Cancelled)
            {
                display("Work Cancelled");
            }
            else
            {
                display("work complete");
            }
            
        }
        private void simulateHeavyWork()
        {
            Thread.Sleep(100);
        }

        public void display(string text)
        {
            MessageBox.Show(text);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            backgroundWorker1.RunWorkerAsync();
        }
    }
}