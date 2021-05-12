using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormThreadApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "진행중";
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 10000;

            // 스레드가 분리되지 않으면 오류 발생함
            /*for (int i = 0; i <= 100000; i++)
            {
                progressBar1.Value = i;
                Thread.Sleep(5); // 5ms 걸림
            }*/

            // 스레드로 분리 윈폼의 화면스레드, 처리스레드 분리
            Thread th = new Thread(() => {
                for (int i = 0; i <= 10000; i++)
                {
                    progressBar1.BeginInvoke(
                        new Action(() =>
                        {
                            progressBar1.Value = i;
                        })); // 크로스 스레드 문제 해결
                    Thread.Sleep(5); // 5ms 걸림
                }
            });
            th.IsBackground = true; // 백그라운드로 실행할지 여부
            th.Start();
        }
    }
}
