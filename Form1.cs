using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerApp2
{
    public partial class KitchenTimer : Form
    {
        public KitchenTimer()
        {
            InitializeComponent();
        }

        // 計測時間
        int sec = 0;
        private void ViewTime()
        {
            TimerLabel.Text = "" + sec / 36000 % 10 + sec / 3600 % 10 +
                              ":" + sec / 600 % 6 + sec / 60 % 10 +
                              ":" + sec / 10 % 6 + sec % 10;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec--;
            if (0 == sec)
            {
                // タイマー終了時に警告音を鳴らす
                SetTimer.Enabled = false;
                System.Media.SystemSounds.Asterisk.Play();
                this.Activate();
            }
            ViewTime();
        }

        // タイマーに1時間追加する
        private void AddHour_Click(object sender, EventArgs e)
        {
            sec += 3600;
            if (sec >= 360000) sec = 0;
            ViewTime();
        }

        // タイマーに1分追加する
        private void AddMinute_Click(object sender, EventArgs e)
        {
            sec += 60;
            ViewTime();
        }

        // タイマーに10秒追加する
        private void AddSec_Click(object sender, EventArgs e)
        {
            sec += 10;
            ViewTime();
        }

        // スタートボタンをクリック時
        private void StartButton_Click(object sender, EventArgs e)
        {
            if (0 == sec) return;
            SetTimer.Enabled = true;
            this.StopButton.Enabled = true;
            this.StartButton.Enabled = false;
            this.AddHour.Enabled = false;
            this.AddMinute.Enabled = false;
            this.AddSec.Enabled = false;
            this.ResetButton.Enabled = false;
        }

        // ストップボタンをクリック時
        private void StopButton_Click(object sender, EventArgs e)
        {
            SetTimer.Enabled = false;
            this.StopButton.Enabled = false;
            this.StartButton.Enabled = true;
            this.AddHour.Enabled = true;
            this.AddMinute.Enabled = true;
            this.AddSec.Enabled = true;
            this.ResetButton.Enabled = true;
        }

        // リセットボタンをクリック時、カウントを0に戻す
        private void ResetButton_Click(object sender, EventArgs e)
        {
            TimerLabel.Text = "00:00:00";
            sec = 0;
        }
    }
}
