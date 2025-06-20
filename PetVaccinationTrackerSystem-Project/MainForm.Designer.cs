﻿namespace PetVaccinationTrackerSystem_Project
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            mainFormTopB = new Panel();
            mainFormButtonAlerts = new Button();
            mainFormButtonSettings = new Button();
            mainFormButtonExit = new Button();
            panel3 = new Panel();

            vaccineRecordsPanel1 = new VaccineRecordsPanelVet();
            homePanel1 = new homePanel();
            mainFormSideB = new Panel();
            mainFormSideBHighlight = new Panel();
            mainFormButtonAboutUs = new Button();
            mainFormButtonLO = new ReaLTaiizor.Controls.HopeRoundButton();
            mainFormButtonVRTS = new Button();
            mainFormButtonVRDS = new Button();
            mainFormButtonPetP = new Button();
            mainFormButtonHome = new Button();
            mainFormUserPB = new Panel();
            pictureBox1 = new PictureBox();
            vaccineReportsPanel1 = new vaccineReportsPanel();
            mainFormTopB.SuspendLayout();
            panel3.SuspendLayout();
            mainFormSideB.SuspendLayout();
            mainFormUserPB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mainFormTopB
            // 
            mainFormTopB.BackColor = Color.FromArgb(89, 85, 84);
            mainFormTopB.Controls.Add(mainFormButtonAlerts);
            mainFormTopB.Controls.Add(mainFormButtonSettings);
            mainFormTopB.Controls.Add(mainFormButtonExit);
            mainFormTopB.Dock = DockStyle.Top;
            mainFormTopB.Location = new Point(0, 0);
            mainFormTopB.Name = "mainFormTopB";
            mainFormTopB.Size = new Size(1000, 50);
            mainFormTopB.TabIndex = 1;
            // 
            // mainFormButtonAlerts
            // 
            mainFormButtonAlerts.BackColor = Color.FromArgb(89, 85, 84);
            mainFormButtonAlerts.BackgroundImage = (Image)resources.GetObject("mainFormButtonAlerts.BackgroundImage");
            mainFormButtonAlerts.BackgroundImageLayout = ImageLayout.Zoom;
            mainFormButtonAlerts.FlatAppearance.BorderSize = 0;
            mainFormButtonAlerts.FlatStyle = FlatStyle.Flat;
            mainFormButtonAlerts.Location = new Point(881, 12);
            mainFormButtonAlerts.Name = "mainFormButtonAlerts";
            mainFormButtonAlerts.Size = new Size(25, 25);
            mainFormButtonAlerts.TabIndex = 2;
            mainFormButtonAlerts.UseVisualStyleBackColor = false;
            // 
            // mainFormButtonSettings
            // 
            mainFormButtonSettings.BackColor = Color.FromArgb(89, 85, 84);
            mainFormButtonSettings.BackgroundImage = (Image)resources.GetObject("mainFormButtonSettings.BackgroundImage");
            mainFormButtonSettings.BackgroundImageLayout = ImageLayout.Zoom;
            mainFormButtonSettings.FlatAppearance.BorderSize = 0;
            mainFormButtonSettings.FlatStyle = FlatStyle.Flat;
            mainFormButtonSettings.Location = new Point(922, 12);
            mainFormButtonSettings.Name = "mainFormButtonSettings";
            mainFormButtonSettings.Size = new Size(25, 25);
            mainFormButtonSettings.TabIndex = 1;
            mainFormButtonSettings.UseVisualStyleBackColor = false;
            // 
            // mainFormButtonExit
            // 
            mainFormButtonExit.BackColor = Color.FromArgb(89, 85, 84);
            mainFormButtonExit.BackgroundImage = (Image)resources.GetObject("mainFormButtonExit.BackgroundImage");
            mainFormButtonExit.BackgroundImageLayout = ImageLayout.Zoom;
            mainFormButtonExit.FlatAppearance.BorderSize = 0;
            mainFormButtonExit.FlatStyle = FlatStyle.Flat;
            mainFormButtonExit.Location = new Point(963, 12);
            mainFormButtonExit.Name = "mainFormButtonExit";
            mainFormButtonExit.Size = new Size(25, 25);
            mainFormButtonExit.TabIndex = 0;
            mainFormButtonExit.UseVisualStyleBackColor = false;
            mainFormButtonExit.Click += mainFormButtonExit_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(vaccineReportsPanel1);

            panel3.Controls.Add(vaccineRecordsPanel1);
            panel3.Controls.Add(homePanel1);
            panel3.Controls.Add(mainFormSideB);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 50);
            panel3.Name = "panel3";
            panel3.Size = new Size(1000, 590);
            panel3.TabIndex = 2;
            // 
      
            // vaccineRecordsPanel1
            // 
            vaccineRecordsPanel1.BackColor = Color.White;
            vaccineRecordsPanel1.Dock = DockStyle.Fill;
            vaccineRecordsPanel1.Location = new Point(200, 0);
            vaccineRecordsPanel1.Name = "vaccineRecordsPanel1";
            vaccineRecordsPanel1.Size = new Size(800, 590);
            vaccineRecordsPanel1.TabIndex = 2;
            // 
            // homePanel1
            // 
            homePanel1.BackColor = Color.White;
            homePanel1.Dock = DockStyle.Fill;
            homePanel1.Location = new Point(200, 0);
            homePanel1.Name = "homePanel1";
            homePanel1.Size = new Size(800, 590);
            homePanel1.TabIndex = 1;
            // 
            // mainFormSideB
            // 
            mainFormSideB.BackColor = Color.FromArgb(249, 249, 249);
            mainFormSideB.Controls.Add(mainFormSideBHighlight);
            mainFormSideB.Controls.Add(mainFormButtonAboutUs);
            mainFormSideB.Controls.Add(mainFormButtonLO);
            mainFormSideB.Controls.Add(mainFormButtonVRTS);
            mainFormSideB.Controls.Add(mainFormButtonVRDS);
            mainFormSideB.Controls.Add(mainFormButtonPetP);
            mainFormSideB.Controls.Add(mainFormButtonHome);
            mainFormSideB.Controls.Add(mainFormUserPB);
            mainFormSideB.Dock = DockStyle.Left;
            mainFormSideB.Location = new Point(0, 0);
            mainFormSideB.Name = "mainFormSideB";
            mainFormSideB.Size = new Size(200, 590);
            mainFormSideB.TabIndex = 0;
            // 
            // mainFormSideBHighlight
            // 
            mainFormSideBHighlight.BackColor = Color.FromArgb(168, 130, 95);
            mainFormSideBHighlight.Location = new Point(0, 175);
            mainFormSideBHighlight.Name = "mainFormSideBHighlight";
            mainFormSideBHighlight.Size = new Size(10, 50);
            mainFormSideBHighlight.TabIndex = 2;
            // 
            // mainFormButtonAboutUs
            // 
            mainFormButtonAboutUs.Dock = DockStyle.Top;
            mainFormButtonAboutUs.FlatAppearance.BorderSize = 0;
            mainFormButtonAboutUs.FlatStyle = FlatStyle.Flat;
            mainFormButtonAboutUs.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainFormButtonAboutUs.ForeColor = Color.FromArgb(89, 85, 84);
            mainFormButtonAboutUs.Location = new Point(0, 375);
            mainFormButtonAboutUs.Name = "mainFormButtonAboutUs";
            mainFormButtonAboutUs.Size = new Size(200, 50);
            mainFormButtonAboutUs.TabIndex = 6;
            mainFormButtonAboutUs.Text = "        About Us";
            mainFormButtonAboutUs.TextAlign = ContentAlignment.MiddleLeft;
            mainFormButtonAboutUs.UseVisualStyleBackColor = true;
            // 
            // mainFormButtonLO
            // 
            mainFormButtonLO.BackColor = Color.FromArgb(89, 85, 84);
            mainFormButtonLO.BorderColor = Color.FromArgb(220, 223, 230);
            mainFormButtonLO.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            mainFormButtonLO.DangerColor = Color.FromArgb(245, 108, 108);
            mainFormButtonLO.DefaultColor = Color.FromArgb(255, 255, 255);
            mainFormButtonLO.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainFormButtonLO.HoverTextColor = Color.FromArgb(48, 49, 51);
            mainFormButtonLO.InfoColor = Color.FromArgb(144, 147, 153);
            mainFormButtonLO.Location = new Point(38, 535);
            mainFormButtonLO.Name = "mainFormButtonLO";
            mainFormButtonLO.PrimaryColor = Color.FromArgb(89, 85, 84);
            mainFormButtonLO.Size = new Size(125, 40);
            mainFormButtonLO.SuccessColor = Color.FromArgb(103, 194, 58);
            mainFormButtonLO.TabIndex = 5;
            mainFormButtonLO.Text = "Log Out";
            mainFormButtonLO.TextColor = Color.White;
            mainFormButtonLO.WarningColor = Color.FromArgb(230, 162, 60);
            // 
            // mainFormButtonVRTS
            // 
            mainFormButtonVRTS.Dock = DockStyle.Top;
            mainFormButtonVRTS.FlatAppearance.BorderSize = 0;
            mainFormButtonVRTS.FlatStyle = FlatStyle.Flat;
            mainFormButtonVRTS.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainFormButtonVRTS.ForeColor = Color.FromArgb(89, 85, 84);
            mainFormButtonVRTS.Location = new Point(0, 325);
            mainFormButtonVRTS.Name = "mainFormButtonVRTS";
            mainFormButtonVRTS.Size = new Size(200, 50);
            mainFormButtonVRTS.TabIndex = 4;
            mainFormButtonVRTS.Text = "        Vaccine Reports";
            mainFormButtonVRTS.TextAlign = ContentAlignment.MiddleLeft;
            mainFormButtonVRTS.UseVisualStyleBackColor = true;
            mainFormButtonVRTS.Click += mainFormButtonVRTS_Click;
            // 
            // mainFormButtonVRDS
            // 
            mainFormButtonVRDS.Dock = DockStyle.Top;
            mainFormButtonVRDS.FlatAppearance.BorderSize = 0;
            mainFormButtonVRDS.FlatStyle = FlatStyle.Flat;
            mainFormButtonVRDS.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainFormButtonVRDS.ForeColor = Color.FromArgb(89, 85, 84);
            mainFormButtonVRDS.Location = new Point(0, 275);
            mainFormButtonVRDS.Name = "mainFormButtonVRDS";
            mainFormButtonVRDS.Size = new Size(200, 50);
            mainFormButtonVRDS.TabIndex = 3;
            mainFormButtonVRDS.Text = "        Vaccine Records";
            mainFormButtonVRDS.TextAlign = ContentAlignment.MiddleLeft;
            mainFormButtonVRDS.UseVisualStyleBackColor = true;
            mainFormButtonVRDS.Click += mainFormButtonVRDS_Click;
            // 
            // mainFormButtonPetP
            // 
            mainFormButtonPetP.Dock = DockStyle.Top;
            mainFormButtonPetP.FlatAppearance.BorderSize = 0;
            mainFormButtonPetP.FlatStyle = FlatStyle.Flat;
            mainFormButtonPetP.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainFormButtonPetP.ForeColor = Color.FromArgb(89, 85, 84);
            mainFormButtonPetP.Location = new Point(0, 225);
            mainFormButtonPetP.Name = "mainFormButtonPetP";
            mainFormButtonPetP.Size = new Size(200, 50);
            mainFormButtonPetP.TabIndex = 2;
            mainFormButtonPetP.Text = "        Pet Profile";
            mainFormButtonPetP.TextAlign = ContentAlignment.MiddleLeft;
            mainFormButtonPetP.UseVisualStyleBackColor = true;
            mainFormButtonPetP.Click += mainFormButtonPetP_Click;
            // 
            // mainFormButtonHome
            // 
            mainFormButtonHome.Dock = DockStyle.Top;
            mainFormButtonHome.FlatAppearance.BorderSize = 0;
            mainFormButtonHome.FlatStyle = FlatStyle.Flat;
            mainFormButtonHome.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            mainFormButtonHome.ForeColor = Color.FromArgb(89, 85, 84);
            mainFormButtonHome.Location = new Point(0, 175);
            mainFormButtonHome.Name = "mainFormButtonHome";
            mainFormButtonHome.Size = new Size(200, 50);
            mainFormButtonHome.TabIndex = 1;
            mainFormButtonHome.Text = "        Home";
            mainFormButtonHome.TextAlign = ContentAlignment.MiddleLeft;
            mainFormButtonHome.UseVisualStyleBackColor = true;
            mainFormButtonHome.Click += mainFormButtonHome_Click;
            // 
            // mainFormUserPB
            // 
            mainFormUserPB.Controls.Add(pictureBox1);
            mainFormUserPB.Dock = DockStyle.Top;
            mainFormUserPB.Location = new Point(0, 0);
            mainFormUserPB.Name = "mainFormUserPB";
            mainFormUserPB.Size = new Size(200, 175);
            mainFormUserPB.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 150);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // vaccineReportsPanel1
            // 
            vaccineReportsPanel1.BackColor = Color.White;
            vaccineReportsPanel1.Dock = DockStyle.Fill;
            vaccineReportsPanel1.Location = new Point(200, 0);
            vaccineReportsPanel1.Name = "vaccineReportsPanel1";
            vaccineReportsPanel1.Size = new Size(800, 590);
            vaccineReportsPanel1.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1000, 640);
            Controls.Add(panel3);
            Controls.Add(mainFormTopB);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            mainFormTopB.ResumeLayout(false);
            panel3.ResumeLayout(false);
            mainFormSideB.ResumeLayout(false);
            mainFormUserPB.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel mainFormTopB;
        private Button mainFormButtonAlerts;
        private Panel panel3;
        private Panel mainFormSideB;
        private Panel mainFormSideBHighlight;
        private Button mainFormButtonVRDS;
        private Button mainFormButtonPetP;
        private Button mainFormButtonHome;
        private Panel mainFormUserPB;
        private PictureBox pictureBox1;
        private Button mainFormButtonVRTS;
        private ReaLTaiizor.Controls.HopeRoundButton mainFormButtonLO;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button5;
        private Button mainFormButtonSettings;
        private Button mainFormButtonExit;
        private Button mainFormButtonAboutUs;
        private homePanel homePanel1;
        private VaccineRecordsPanelVet vaccineRecordsPanel1;
        private petProfilePanel petProfilePanel1;
        private vaccineReportsPanel vaccineReportsPanel1;
    }
}