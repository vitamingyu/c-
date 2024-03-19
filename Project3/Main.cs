﻿using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using System.Threading;


namespace Project3
{
    public partial class Main : Form
    {
        BackgroundWorker backgroundWorker1 = new BackgroundWorker();

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


        public Main()
        {
            InitializeComponent();
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            progressBar1.Value = 0;
            lblpro.Text = "0%";
            backgroundWorker1.RunWorkerAsync();
            btnExport.Enabled = false;
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            StreamWriter sw = null;
            try
            {
                string filepath = txtPath.Text;

                ulong rowNumber, colNumber;
                string row = txtRow.Text;
                string col = txtCol.Text;

                bool rowResult = ulong.TryParse(row, out rowNumber);
                bool colResult = ulong.TryParse(col, out colNumber);

                if (!rowResult || !colResult)
                {
                    MessageBox.Show("ROW와 COLUMN은 양의 정수값만 입력 가능합니다.", "오류발생", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                sw = new StreamWriter(filepath);

                for (ulong i = 1; i <= rowNumber; i++)
                {
                    if (worker.CancellationPending) // 작업 중지 확인
                    {
                        e.Cancel = true;
                        return;
                    }

                    for (ulong j = 1; j <= colNumber; j++)
                    {
                        string cell = Excelformat(j, i);
                        sw.Write("{0},", cell);
                    }
                    int progressPercentage = (int)((double)i / rowNumber * 100);
                    worker.ReportProgress(progressPercentage);
                    sw.WriteLine();
                }

                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("파일 생성 중 오류가 발생했습니다: " + ex.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sw != null)
                    sw.Close();
            }
        }


        private string Excelformat(ulong col, ulong row)
        {
            int mok = (int)(col - 1) / 26;
            int index = (int)(col - 1) % 26;
            Alphabet letter1 = (Alphabet)index;

            if (mok >= 27)
            {
                int mok2 = mok - 27;

                while (mok2 >= 26)
                {
                    mok2 -= 26;
                }

                Alphabet letter2 = (Alphabet)mok2;
                Alphabet letter3 = (Alphabet)((mok - 1) / 26 - 1);
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
            backgroundWorker1.CancelAsync();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
            lblpro.Text = e.ProgressPercentage.ToString() + " %";
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("작업이 완료되지 못했습니다: " + e.Error.Message, "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (e.Cancelled)
            {
                MessageBox.Show("작업이 취소되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (File.Exists(txtPath.Text))
                {
                    try
                    {
                        File.Delete(txtPath.Text);
                    }
                    catch (Exception ee)
                    {
                        ee.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("작업이 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnExport.Enabled = true;
        }
    }




}