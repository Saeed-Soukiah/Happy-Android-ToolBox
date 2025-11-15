namespace android_toolkit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Reboot = new Button();
            openFileDialog1 = new OpenFileDialog();
            textBox1 = new TextBox();
            ChooseAPK = new Button();
            InstallApk = new Button();
            Recovery = new Button();
            Downloadmode = new Button();
            Format = new Button();
            RefreshDevices = new Button();
            DevicesListBox = new ListBox();
            CloseButton = new Button();
            PushFileBtn = new Button();
            PullFileBtn = new Button();
            BatchInstallBtn = new Button();
            BatchUninstallBtn = new Button();
            ShowDeviceInfoBtn = new Button();
            LogTextBox = new TextBox();
            OperationProgressBar = new ProgressBar();
            SelectedDeviceLabel = new Label();
            SuspendLayout();
            // 
            // Reboot
            // 
            Reboot.Location = new Point(16, 322);
            Reboot.Margin = new Padding(4);
            Reboot.Name = "Reboot";
            Reboot.Size = new Size(129, 33);
            Reboot.TabIndex = 0;
            Reboot.Text = "Reboot";
            Reboot.UseVisualStyleBackColor = true;
            Reboot.Click += button1_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(154, 244);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 31);
            textBox1.TabIndex = 1;
            textBox1.Text = "APK Path";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // ChooseAPK
            // 
            ChooseAPK.Location = new Point(16, 242);
            ChooseAPK.Margin = new Padding(4);
            ChooseAPK.Name = "ChooseAPK";
            ChooseAPK.Size = new Size(129, 33);
            ChooseAPK.TabIndex = 2;
            ChooseAPK.Text = "Choose APK";
            ChooseAPK.UseVisualStyleBackColor = true;
            ChooseAPK.Click += button2_Click;
            // 
            // InstallApk
            // 
            InstallApk.Location = new Point(16, 281);
            InstallApk.Margin = new Padding(4);
            InstallApk.Name = "InstallApk";
            InstallApk.Size = new Size(129, 33);
            InstallApk.TabIndex = 3;
            InstallApk.Text = "Install APK";
            InstallApk.UseVisualStyleBackColor = true;
            InstallApk.Click += button3_Click;
            // 
            // Recovery
            // 
            Recovery.Location = new Point(154, 322);
            Recovery.Margin = new Padding(4);
            Recovery.Name = "Recovery";
            Recovery.Size = new Size(129, 33);
            Recovery.TabIndex = 4;
            Recovery.Text = "Recovery";
            Recovery.UseVisualStyleBackColor = true;
            Recovery.Click += Recovery_Click;
            // 
            // Downloadmode
            // 
            Downloadmode.Location = new Point(292, 322);
            Downloadmode.Margin = new Padding(4);
            Downloadmode.Name = "Downloadmode";
            Downloadmode.Size = new Size(126, 33);
            Downloadmode.TabIndex = 5;
            Downloadmode.Text = "Download";
            Downloadmode.UseVisualStyleBackColor = true;
            Downloadmode.Click += Downloadmode_Click;
            // 
            // Format
            // 
            Format.Location = new Point(16, 363);
            Format.Margin = new Padding(4);
            Format.Name = "Format";
            Format.Size = new Size(129, 33);
            Format.TabIndex = 6;
            Format.Text = "Format";
            Format.UseVisualStyleBackColor = true;
            Format.Click += Format_Click;
            // 
            // RefreshDevices
            // 
            RefreshDevices.Location = new Point(16, 14);
            RefreshDevices.Margin = new Padding(4);
            RefreshDevices.Name = "RefreshDevices";
            RefreshDevices.Size = new Size(129, 61);
            RefreshDevices.TabIndex = 7;
            RefreshDevices.Text = "Refresh Devices";
            RefreshDevices.UseVisualStyleBackColor = true;
            RefreshDevices.Click += RefreshDevices_Click;
            // 
            // DevicesListBox
            // 
            DevicesListBox.FormattingEnabled = true;
            DevicesListBox.ItemHeight = 23;
            DevicesListBox.Location = new Point(154, 14);
            DevicesListBox.Margin = new Padding(4);
            DevicesListBox.Name = "DevicesListBox";
            DevicesListBox.Size = new Size(328, 211);
            DevicesListBox.TabIndex = 8;
            DevicesListBox.SelectedIndexChanged += DevicesListBox_SelectedIndexChanged;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(810, 363);
            CloseButton.Margin = new Padding(4);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(129, 33);
            CloseButton.TabIndex = 9;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // PushFileBtn
            // 
            PushFileBtn.Location = new Point(509, 87);
            PushFileBtn.Margin = new Padding(4);
            PushFileBtn.Name = "PushFileBtn";
            PushFileBtn.Size = new Size(188, 33);
            PushFileBtn.TabIndex = 10;
            PushFileBtn.Text = "PushFile";
            PushFileBtn.UseVisualStyleBackColor = true;
            PushFileBtn.Click += PushFileBtn_Click;
            // 
            // PullFileBtn
            // 
            PullFileBtn.Location = new Point(509, 126);
            PullFileBtn.Margin = new Padding(4);
            PullFileBtn.Name = "PullFileBtn";
            PullFileBtn.Size = new Size(129, 33);
            PullFileBtn.TabIndex = 11;
            PullFileBtn.Text = "Backup";
            PullFileBtn.UseVisualStyleBackColor = true;
            PullFileBtn.Click += PullFileBtn_Click;
            // 
            // BatchInstallBtn
            // 
            BatchInstallBtn.Location = new Point(509, 166);
            BatchInstallBtn.Margin = new Padding(4);
            BatchInstallBtn.Name = "BatchInstallBtn";
            BatchInstallBtn.Size = new Size(129, 59);
            BatchInstallBtn.TabIndex = 12;
            BatchInstallBtn.Text = "Batch Install";
            BatchInstallBtn.UseVisualStyleBackColor = true;
            BatchInstallBtn.Click += BatchInstallBtn_Click;
            // 
            // BatchUninstallBtn
            // 
            BatchUninstallBtn.Location = new Point(509, 233);
            BatchUninstallBtn.Margin = new Padding(4);
            BatchUninstallBtn.Name = "BatchUninstallBtn";
            BatchUninstallBtn.Size = new Size(129, 68);
            BatchUninstallBtn.TabIndex = 13;
            BatchUninstallBtn.Text = "Batch Uninstall";
            BatchUninstallBtn.UseVisualStyleBackColor = true;
            BatchUninstallBtn.Click += BatchUninstallBtn_Click;
            // 
            // ShowDeviceInfoBtn
            // 
            ShowDeviceInfoBtn.Location = new Point(509, 46);
            ShowDeviceInfoBtn.Margin = new Padding(4);
            ShowDeviceInfoBtn.Name = "ShowDeviceInfoBtn";
            ShowDeviceInfoBtn.Size = new Size(198, 33);
            ShowDeviceInfoBtn.TabIndex = 14;
            ShowDeviceInfoBtn.Text = "Show Device Info";
            ShowDeviceInfoBtn.UseVisualStyleBackColor = true;
            ShowDeviceInfoBtn.Click += ShowDeviceInfoBtn_Click;
            // 
            // LogTextBox
            // 
            LogTextBox.Location = new Point(705, 87);
            LogTextBox.Margin = new Padding(4);
            LogTextBox.Multiline = true;
            LogTextBox.Name = "LogTextBox";
            LogTextBox.ScrollBars = ScrollBars.Both;
            LogTextBox.Size = new Size(236, 121);
            LogTextBox.TabIndex = 15;
            LogTextBox.TextChanged += LogTextBox_TextChanged;
            // 
            // OperationProgressBar
            // 
            OperationProgressBar.Location = new Point(646, 216);
            OperationProgressBar.Margin = new Padding(4);
            OperationProgressBar.Name = "OperationProgressBar";
            OperationProgressBar.Size = new Size(297, 33);
            OperationProgressBar.TabIndex = 16;
            OperationProgressBar.Click += OperationProgressBar_Click;
            // 
            // SelectedDeviceLabel
            // 
            SelectedDeviceLabel.AutoSize = true;
            SelectedDeviceLabel.BackColor = Color.AliceBlue;
            SelectedDeviceLabel.Location = new Point(564, 14);
            SelectedDeviceLabel.Margin = new Padding(4, 0, 4, 0);
            SelectedDeviceLabel.Name = "SelectedDeviceLabel";
            SelectedDeviceLabel.Size = new Size(76, 23);
            SelectedDeviceLabel.TabIndex = 17;
            SelectedDeviceLabel.Text = "Device";
            SelectedDeviceLabel.Click += SelectedDeviceLabel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Blue;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            CancelButton = CloseButton;
            ClientSize = new Size(956, 404);
            Controls.Add(SelectedDeviceLabel);
            Controls.Add(OperationProgressBar);
            Controls.Add(LogTextBox);
            Controls.Add(ShowDeviceInfoBtn);
            Controls.Add(BatchUninstallBtn);
            Controls.Add(BatchInstallBtn);
            Controls.Add(PullFileBtn);
            Controls.Add(PushFileBtn);
            Controls.Add(CloseButton);
            Controls.Add(DevicesListBox);
            Controls.Add(RefreshDevices);
            Controls.Add(Format);
            Controls.Add(Downloadmode);
            Controls.Add(Recovery);
            Controls.Add(InstallApk);
            Controls.Add(ChooseAPK);
            Controls.Add(textBox1);
            Controls.Add(Reboot);
            Cursor = Cursors.PanNW;
            Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Happy ToolBox";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Reboot;
        private OpenFileDialog openFileDialog1;
        private TextBox textBox1;
        private Button ChooseAPK;
        private Button InstallApk;
        private Button Recovery;
        private Button Downloadmode;
        private Button Format;
        private Button RefreshDevices;
        private ListBox DevicesListBox;
        private Button CloseButton;
        private Button PushFileBtn;
        private Button PullFileBtn;
        private Button BatchInstallBtn;
        private Button BatchUninstallBtn;
        private Button ShowDeviceInfoBtn;
        private TextBox LogTextBox;
        private ProgressBar OperationProgressBar;
        private Label SelectedDeviceLabel;
    }
}
