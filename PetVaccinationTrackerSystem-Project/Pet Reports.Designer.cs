﻿namespace PetVaccinationTrackerSystem_Project
{
    partial class Pet_Reports
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pet_Reports));
            pictureBox1 = new PictureBox();
            VRDSVaccineCard = new Panel();
            button1 = new ReaLTaiizor.Controls.HopeRoundButton();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            label1 = new Label();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            dateTimePicker1 = new DateTimePicker();
            cmbPetGender = new ComboBox();
            cmbVaccinenName = new ComboBox();
            cmbPettype = new ComboBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            VRDSVaccineCard.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 70);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // VRDSVaccineCard
            // 
            VRDSVaccineCard.BackColor = Color.White;
            VRDSVaccineCard.BorderStyle = BorderStyle.FixedSingle;
            VRDSVaccineCard.Controls.Add(button1);
            VRDSVaccineCard.Controls.Add(cartesianChart1);
            VRDSVaccineCard.Controls.Add(label1);
            VRDSVaccineCard.Controls.Add(pieChart1);
            VRDSVaccineCard.Controls.Add(dateTimePicker1);
            VRDSVaccineCard.Controls.Add(cmbPetGender);
            VRDSVaccineCard.Controls.Add(cmbVaccinenName);
            VRDSVaccineCard.Controls.Add(cmbPettype);
            VRDSVaccineCard.Controls.Add(label7);
            VRDSVaccineCard.Location = new Point(9, 78);
            VRDSVaccineCard.Margin = new Padding(20, 5, 0, 0);
            VRDSVaccineCard.Name = "VRDSVaccineCard";
            VRDSVaccineCard.Size = new Size(782, 500);
            VRDSVaccineCard.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(63, 59, 58);
            button1.BorderColor = Color.FromArgb(220, 223, 230);
            button1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            button1.DangerColor = Color.FromArgb(245, 108, 108);
            button1.DefaultColor = Color.FromArgb(255, 255, 255);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.HoverTextColor = Color.White;
            button1.InfoColor = Color.FromArgb(144, 147, 153);
            button1.Location = new Point(637, 33);
            button1.Name = "button1";
            button1.PrimaryColor = Color.FromArgb(63, 59, 58);
            button1.Size = new Size(130, 27);
            button1.SuccessColor = Color.FromArgb(103, 194, 58);
            button1.TabIndex = 40;
            button1.Text = "View Charts";
            button1.TextColor = Color.White;
            button1.WarningColor = Color.FromArgb(230, 162, 60);
            button1.Click += button1_Click;
            // 
            // cartesianChart1
            // 
            cartesianChart1.BackColor = Color.FromArgb(250, 250, 250);
            cartesianChart1.Location = new Point(425, 92);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(342, 390);
            cartesianChart1.TabIndex = 39;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(89, 85, 84);
            label1.Location = new Point(13, 70);
            label1.Name = "label1";
            label1.Size = new Size(124, 19);
            label1.TabIndex = 37;
            label1.Text = "Charts Overview:";
            // 
            // pieChart1
            // 
            pieChart1.BackColor = Color.FromArgb(250, 250, 250);
            pieChart1.InitialRotation = 0D;
            pieChart1.IsClockwise = true;
            pieChart1.Location = new Point(14, 93);
            pieChart1.MaxAngle = 360D;
            pieChart1.MaxValue = double.NaN;
            pieChart1.MinValue = 0D;
            pieChart1.Name = "pieChart1";
            pieChart1.Size = new Size(356, 389);
            pieChart1.TabIndex = 36;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 9F);
            dateTimePicker1.Font = new Font("Segoe UI", 9F);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(494, 36);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(135, 23);
            dateTimePicker1.TabIndex = 34;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // cmbPetGender
            // 
            cmbPetGender.BackColor = Color.White;
            cmbPetGender.ForeColor = Color.Black;
            cmbPetGender.FormattingEnabled = true;
            cmbPetGender.Items.AddRange(new object[] { "Male", "Female" });
            cmbPetGender.Location = new Point(175, 36);
            cmbPetGender.Name = "cmbPetGender";
            cmbPetGender.Size = new Size(158, 23);
            cmbPetGender.TabIndex = 4;
            // 
            // cmbVaccinenName
            // 
            cmbVaccinenName.BackColor = Color.White;
            cmbVaccinenName.ForeColor = Color.Black;
            cmbVaccinenName.FormattingEnabled = true;
            cmbVaccinenName.Items.AddRange(new object[] { "Rabies", "DHPP", "5-in-1", "6-in-1", "Canine Parvovirus", "Canine Distemper", "Canine Hepatitis", "Leptospirosis", "Bordetella", "Canine Influenza", "Lyme Disease", "Coronavirus (CCV)", "FVRCP", "FVR", "Calicivirus", "Panleukopenia", "FeLV (Feline Leukemia)", "FIV (Feline Immunodeficiency Virus)", "Chlamydia", "Myxomatosis (Rabbit)", "RHDV1 (Rabbit)", "RHDV2 (Rabbit)" });
            cmbVaccinenName.Location = new Point(339, 36);
            cmbVaccinenName.Name = "cmbVaccinenName";
            cmbVaccinenName.Size = new Size(145, 23);
            cmbVaccinenName.TabIndex = 3;
            // 
            // cmbPettype
            // 
            cmbPettype.BackColor = Color.White;
            cmbPettype.ForeColor = Color.Black;
            cmbPettype.FormattingEnabled = true;
            cmbPettype.Items.AddRange(new object[] { "Dog", "Cat" });
            cmbPettype.Location = new Point(13, 36);
            cmbPettype.Name = "cmbPettype";
            cmbPettype.Size = new Size(156, 23);
            cmbPettype.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(89, 85, 84);
            label7.Location = new Point(13, 11);
            label7.Name = "label7";
            label7.Size = new Size(93, 19);
            label7.TabIndex = 1;
            label7.Text = "Filter Charts:";
            // 
            // Pet_Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(VRDSVaccineCard);
            Controls.Add(pictureBox1);
            Name = "Pet_Reports";
            Size = new Size(800, 590);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            VRDSVaccineCard.ResumeLayout(false);
            VRDSVaccineCard.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel VRDSVaccineCard;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Label label1;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private DateTimePicker dateTimePicker1;
        private ComboBox cmbPetGender;
        private ComboBox cmbVaccinenName;
        private ComboBox cmbPettype;
        private Label label7;
        private ReaLTaiizor.Controls.HopeRoundButton button1;
    }
}
