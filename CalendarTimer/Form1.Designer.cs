namespace CalendarTimer
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            timer1 = new System.Windows.Forms.Timer(components);
            CurTime = new Label();
            StopWatchLabel = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            ResetBtn = new Button();
            StopBtn = new Button();
            StartBtn = new Button();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += Timer1_tick;
            // 
            // CurTime
            // 
            CurTime.AutoSize = true;
            CurTime.BackColor = Color.Wheat;
            CurTime.BorderStyle = BorderStyle.FixedSingle;
            CurTime.Font = new Font("Arial", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            CurTime.Location = new Point(897, 24);
            CurTime.Margin = new Padding(2, 0, 2, 0);
            CurTime.Name = "CurTime";
            CurTime.Size = new Size(107, 42);
            CurTime.TabIndex = 0;
            CurTime.Text = "label1";
            CurTime.TextAlign = ContentAlignment.MiddleCenter;
            CurTime.Click += label1_Click;
            // 
            // StopWatchLabel
            // 
            StopWatchLabel.AutoSize = true;
            StopWatchLabel.BackColor = Color.White;
            StopWatchLabel.Font = new Font("맑은 고딕 Semilight", 28.2F, FontStyle.Italic, GraphicsUnit.Point);
            StopWatchLabel.ForeColor = Color.Black;
            StopWatchLabel.Location = new Point(246, 101);
            StopWatchLabel.Margin = new Padding(2, 0, 2, 0);
            StopWatchLabel.Name = "StopWatchLabel";
            StopWatchLabel.Size = new Size(160, 51);
            StopWatchLabel.TabIndex = 3;
            StopWatchLabel.Text = "00:00:00";
            StopWatchLabel.Click += StopWatchLabel_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(2, 0);
            tabControl1.Margin = new Padding(2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(875, 492);
            tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(ResetBtn);
            tabPage1.Controls.Add(StopBtn);
            tabPage1.Controls.Add(StartBtn);
            tabPage1.Controls.Add(StopWatchLabel);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "StopWatch";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(700, 409);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "StopWatch";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.AliceBlue;
            ResetBtn.Location = new Point(455, 228);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new Size(116, 67);
            ResetBtn.TabIndex = 6;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            ResetBtn.Click += ResetBtn_Click;
            // 
            // StopBtn
            // 
            StopBtn.BackColor = Color.PeachPuff;
            StopBtn.Location = new Point(246, 228);
            StopBtn.Margin = new Padding(2);
            StopBtn.Name = "StopBtn";
            StopBtn.Size = new Size(116, 67);
            StopBtn.TabIndex = 5;
            StopBtn.Text = "Stop";
            StopBtn.UseVisualStyleBackColor = false;
            StopBtn.Click += StopBtn_Click;
            // 
            // StartBtn
            // 
            StartBtn.BackColor = Color.LightCoral;
            StartBtn.Location = new Point(70, 228);
            StartBtn.Margin = new Padding(2);
            StartBtn.Name = "StartBtn";
            StartBtn.Size = new Size(116, 67);
            StartBtn.TabIndex = 4;
            StartBtn.Text = "Start";
            StartBtn.UseVisualStyleBackColor = false;
            StartBtn.Click += StartBtn_Click;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "WorldTime";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(867, 464);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "World Time";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "Alarm";
            tabPage3.Padding = new Padding(2);
            tabPage3.Size = new Size(700, 409);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Alarm";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1043, 521);
            Controls.Add(tabControl1);
            Controls.Add(CurTime);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "Form1";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label CurTime;
        private Label StopWatchLabel;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Button StartBtn;
        private Button StopBtn;
        private Button ResetBtn;
    }
}