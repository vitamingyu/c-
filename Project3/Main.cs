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
        public enum Alphabet
        {
            A,
            B,
            C,
            D,
            E,
            F,
            G,
            H,
            I,
            J,
            K,
            L,
            M,
            N,
            O,
            P,
            Q,
            R,
            S,
            T,
            U,
            V,
            W,
            X,
            Y,
            Z,
        }

        Thread _thread = null;

        public Main()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            //btnExport.Enabled = false;
            progressBar1.Value = 0;
            lblpro.Text = "0%";
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
            StreamWriter sw = null;
            try
            {
                string filepath = txtPath.Text;

                ulong rowNumber, colNumber;
                string row = txtRow.Text;
                string col = txtCol.Text;

                bool rowResult = ulong.TryParse(row, out rowNumber);
                bool colResult = ulong.TryParse(col, out colNumber);
                // row와 col의 숫자값이 커도 실행되도록 ulong타입으로 선언했습니다

                if (!rowResult || !colResult)
                {
                    DialogResult result = MessageBox.Show("ROW와 COLUMN은 양의 정수값만 입력 가능합니다.", "오류발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else
                {
                    sw = new StreamWriter(filepath);

                    for (ulong i = 1; i <= rowNumber; i++)
                    {
                        for (ulong j = 1; j <= colNumber; j++)
                        {
                            string cell = Excelformat(j,i);
                            sw.Write("{0},", cell);
                        }
                        sw.WriteLine();
                    }

                    sw.Close();

                    DialogResult result = MessageBox.Show(filepath + "에 파일이 성공적으로 저장되었습니다.", "성공", MessageBoxButtons.OK);
                }
            }
            catch (ThreadAbortException abe)
            {
                sw.Close();
                abe.ToString();
            }
        }

        private string Excelformat(ulong col, ulong row)
        {
            int mok = (int)(col - 1) / 26;
            int index = (int)(col - 1) % 26;
            Alphabet letter1 = (Alphabet)index;

            //if (mok >= 676)
            //{
            //    int mok2 = mok - 27;
            //    Alphabet letter2 = (Alphabet)mok2;
            //    Alphabet letter3 = (Alphabet)(mok / 26 - 1);
            //    Alphabet letter4 = (Alphabet)((mok/26)/26 - 1);
            //    string cell = letter4.ToString() + letter3.ToString() + letter2.ToString() + letter1.ToString() + row;
            //    return cell;
            //}

            if (mok >= 27)
            {
                int mok2 = mok - 27;
                Alphabet letter2 = (Alphabet)mok2;
                Alphabet letter3 = (Alphabet)(mok  / 26 - 1);
                string cell = letter3.ToString() + letter2.ToString() + letter1.ToString() + row;
                return cell;
            }
            else if (mok >= 1)
            {
                mok = mok - 1;
                Alphabet letter2 = (Alphabet)mok;
                string cell = letter2.ToString() + letter1.ToString() + row;
                return cell;
            }
            else
            {
                string cell = letter1.ToString() + row;
                return cell;
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