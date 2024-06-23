namespace TimerApp2
{
    partial class KitchenTimer
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KitchenTimer));
            this.StartButton = new System.Windows.Forms.Button();
            this.AddMinute = new System.Windows.Forms.Button();
            this.AddSec = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.AddHour = new System.Windows.Forms.Button();
            this.TimerLabel = new System.Windows.Forms.TextBox();
            this.SetTimer = new System.Windows.Forms.Timer(this.components);
            this.ResetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("メイリオ", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StartButton.Location = new System.Drawing.Point(244, 392);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(185, 95);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // AddMinute
            // 
            this.AddMinute.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddMinute.Location = new System.Drawing.Point(469, 318);
            this.AddMinute.Name = "AddMinute";
            this.AddMinute.Size = new System.Drawing.Size(185, 52);
            this.AddMinute.TabIndex = 1;
            this.AddMinute.Text = "1分追加";
            this.AddMinute.UseVisualStyleBackColor = true;
            this.AddMinute.Click += new System.EventHandler(this.AddMinute_Click);
            // 
            // AddSec
            // 
            this.AddSec.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddSec.Location = new System.Drawing.Point(692, 318);
            this.AddSec.Name = "AddSec";
            this.AddSec.Size = new System.Drawing.Size(185, 52);
            this.AddSec.TabIndex = 2;
            this.AddSec.Text = "10秒追加";
            this.AddSec.UseVisualStyleBackColor = true;
            this.AddSec.Click += new System.EventHandler(this.AddSec_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("メイリオ", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.StopButton.ForeColor = System.Drawing.Color.Blue;
            this.StopButton.Location = new System.Drawing.Point(469, 392);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(185, 95);
            this.StopButton.TabIndex = 3;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // AddHour
            // 
            this.AddHour.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AddHour.Location = new System.Drawing.Point(244, 318);
            this.AddHour.Name = "AddHour";
            this.AddHour.Size = new System.Drawing.Size(185, 52);
            this.AddHour.TabIndex = 4;
            this.AddHour.Text = "1時間追加";
            this.AddHour.UseVisualStyleBackColor = true;
            this.AddHour.Click += new System.EventHandler(this.AddHour_Click);
            // 
            // TimerLabel
            // 
            this.TimerLabel.BackColor = System.Drawing.SystemColors.Window;
            this.TimerLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.TimerLabel.Font = new System.Drawing.Font("Times New Roman", 100.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.Location = new System.Drawing.Point(66, 41);
            this.TimerLabel.Multiline = true;
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TimerLabel.Size = new System.Drawing.Size(800, 250);
            this.TimerLabel.TabIndex = 5;
            this.TimerLabel.Text = "00:00:00";
            this.TimerLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetTimer
            // 
            this.SetTimer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ResetButton
            // 
            this.ResetButton.Font = new System.Drawing.Font("メイリオ", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResetButton.ForeColor = System.Drawing.Color.Red;
            this.ResetButton.Location = new System.Drawing.Point(692, 392);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(185, 95);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // KitchenTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 517);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.TimerLabel);
            this.Controls.Add(this.AddHour);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.AddSec);
            this.Controls.Add(this.AddMinute);
            this.Controls.Add(this.StartButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KitchenTimer";
            this.Text = "KitchenTimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button AddMinute;
        private System.Windows.Forms.Button AddSec;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button AddHour;
        private System.Windows.Forms.TextBox TimerLabel;
        private System.Windows.Forms.Timer SetTimer;
        private System.Windows.Forms.Button ResetButton;
    }
}

