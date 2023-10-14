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
            Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            ClearBtn = new Button();
            imageList1 = new ImageList(components);
            DeleteBtn = new Button();
            alarmBox = new GroupBox();
            MeridiemBox = new ComboBox();
            MinuteBox = new ComboBox();
            HourBox = new ComboBox();
            alarmList = new GroupBox();
            AlarmListBox = new ListBox();
            CreateBtn = new Button();
            label2 = new Label();
            label3 = new Label();
            DescriptionBox = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage3.SuspendLayout();
            alarmBox.SuspendLayout();
            alarmList.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(275, 28);
            label1.Name = "label1";
            label1.Size = new Size(20, 31);
            label1.TabIndex = 1;
            label1.Text = ":";
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
            StopWatchLabel.BackColor = Color.Silver;
            StopWatchLabel.Font = new Font("Consolas", 50F, FontStyle.Italic, GraphicsUnit.Point);
            StopWatchLabel.ForeColor = Color.Black;
            StopWatchLabel.Location = new Point(248, 127);
            StopWatchLabel.Margin = new Padding(2, 0, 2, 0);
            StopWatchLabel.Name = "StopWatchLabel";
            StopWatchLabel.Size = new Size(330, 79);
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
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(867, 464);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "StopWatch";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.AliceBlue;
            ResetBtn.Location = new Point(576, 274);
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
            StopBtn.Location = new Point(347, 274);
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
            StartBtn.Location = new Point(115, 274);
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
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(867, 464);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "World Time";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(ClearBtn);
            tabPage3.Controls.Add(DeleteBtn);
            tabPage3.Controls.Add(alarmBox);
            tabPage3.Controls.Add(alarmList);
            tabPage3.Controls.Add(CreateBtn);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Margin = new Padding(2);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(2);
            tabPage3.Size = new Size(867, 464);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Alarm";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // ClearBtn
            // 
            ClearBtn.ImageAlign = ContentAlignment.MiddleLeft;
            ClearBtn.ImageIndex = 2;
            ClearBtn.ImageList = imageList1;
            ClearBtn.Location = new Point(629, 408);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(146, 51);
            ClearBtn.TabIndex = 5;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = true;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth16Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "button.png");
            imageList1.Images.SetKeyName(1, "delete.png");
            imageList1.Images.SetKeyName(2, "clear.png");
            // 
            // DeleteBtn
            // 
            DeleteBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DeleteBtn.ImageIndex = 1;
            DeleteBtn.ImageList = imageList1;
            DeleteBtn.Location = new Point(349, 406);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(132, 54);
            DeleteBtn.TabIndex = 4;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // alarmBox
            // 
            alarmBox.Controls.Add(DescriptionBox);
            alarmBox.Controls.Add(label3);
            alarmBox.Controls.Add(label2);
            alarmBox.Controls.Add(MeridiemBox);
            alarmBox.Controls.Add(MinuteBox);
            alarmBox.Controls.Add(label1);
            alarmBox.Controls.Add(HourBox);
            alarmBox.Location = new Point(26, 4);
            alarmBox.Name = "alarmBox";
            alarmBox.Size = new Size(805, 171);
            alarmBox.TabIndex = 3;
            alarmBox.TabStop = false;
            alarmBox.Text = "Alarm Time";
            // 
            // MeridiemBox
            // 
            MeridiemBox.DisplayMember = "AM";
            MeridiemBox.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            MeridiemBox.FormattingEnabled = true;
            MeridiemBox.Items.AddRange(new object[] { "AM", "PM" });
            MeridiemBox.Location = new Point(520, 28);
            MeridiemBox.MaxLength = 2;
            MeridiemBox.Name = "MeridiemBox";
            MeridiemBox.Size = new Size(93, 39);
            MeridiemBox.Sorted = true;
            MeridiemBox.TabIndex = 3;
            MeridiemBox.SelectedIndexChanged += MeridiemBox_SelectedIndexChanged;
            // 
            // MinuteBox
            // 
            MinuteBox.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            MinuteBox.FormattingEnabled = true;
            MinuteBox.Location = new Point(343, 28);
            MinuteBox.MaxLength = 2;
            MinuteBox.Name = "MinuteBox";
            MinuteBox.Size = new Size(101, 39);
            MinuteBox.Sorted = true;
            MinuteBox.TabIndex = 2;
            // 
            // HourBox
            // 
            HourBox.Font = new Font("Arial Narrow", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            HourBox.FormattingEnabled = true;
            HourBox.Location = new Point(142, 28);
            HourBox.MaxLength = 2;
            HourBox.Name = "HourBox";
            HourBox.Size = new Size(101, 39);
            HourBox.TabIndex = 0;
            // 
            // alarmList
            // 
            alarmList.Controls.Add(AlarmListBox);
            alarmList.Location = new Point(22, 196);
            alarmList.Name = "alarmList";
            alarmList.Size = new Size(818, 206);
            alarmList.TabIndex = 2;
            alarmList.TabStop = false;
            alarmList.Text = "alarmList";
            // 
            // AlarmListBox
            // 
            AlarmListBox.FormattingEnabled = true;
            AlarmListBox.ItemHeight = 15;
            AlarmListBox.Location = new Point(13, 19);
            AlarmListBox.Name = "AlarmListBox";
            AlarmListBox.Size = new Size(791, 169);
            AlarmListBox.TabIndex = 0;

            // 
            // CreateBtn
            // 
            CreateBtn.ImageAlign = ContentAlignment.MiddleLeft;
            CreateBtn.ImageIndex = 0;
            CreateBtn.ImageList = imageList1;
            CreateBtn.Location = new Point(82, 408);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(112, 51);
            CreateBtn.TabIndex = 0;
            CreateBtn.Text = "Create";
            CreateBtn.UseVisualStyleBackColor = true;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 37);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 4;
            label2.Text = "Time";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(29, 110);
            label3.Name = "label3";
            label3.Size = new Size(76, 20);
            label3.TabIndex = 4;
            label3.Text = "Description";
            // 
            // DescriptionBox
            // 
            DescriptionBox.Font = new Font("Arial Narrow", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            DescriptionBox.Location = new Point(142, 103);
            DescriptionBox.Name = "DescriptionBox";
            DescriptionBox.Size = new Size(509, 32);
            DescriptionBox.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1043, 497);
            Controls.Add(tabControl1);
            Controls.Add(CurTime);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            RightToLeftLayout = true;
            Text = "CalendarTimer";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage3.ResumeLayout(false);
            alarmBox.ResumeLayout(false);
            alarmBox.PerformLayout();
            alarmList.ResumeLayout(false);
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
        private Button CreateBtn;
        private ImageList imageList1;
        private GroupBox alarmList;
        private GroupBox alarmBox;
        private Button DeleteBtn;
        private ComboBox HourBox;
        private ComboBox MinuteBox;
        private ComboBox MeridiemBox;
        private ListBox AlarmListBox;
        private Button ClearBtn;
        private TextBox DescriptionBox;
        private Label label3;
        private Label label2;
    }
}