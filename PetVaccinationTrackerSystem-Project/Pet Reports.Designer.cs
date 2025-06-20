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
            pictureBox1 = new PictureBox();
            VRDSVaccineCard = new Panel();
            label7 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
            label1 = new Label();
            label2 = new Label();
            cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
            dataGridView1 = new DataGridView();
            AdministeredBy = new DataGridViewTextBoxColumn();
            NextDueDate = new DataGridViewTextBoxColumn();
            DateAdministered = new DataGridViewTextBoxColumn();
            OwnerName = new DataGridViewTextBoxColumn();
            Species = new DataGridViewTextBoxColumn();
            PetName = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            VRDSVaccineCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = Properties.Resources.vaccination_reports_banner1;
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
            VRDSVaccineCard.Controls.Add(dataGridView1);
            VRDSVaccineCard.Controls.Add(cartesianChart1);
            VRDSVaccineCard.Controls.Add(label2);
            VRDSVaccineCard.Controls.Add(label1);
            VRDSVaccineCard.Controls.Add(pieChart1);
            VRDSVaccineCard.Controls.Add(dateTimePicker1);
            VRDSVaccineCard.Controls.Add(button1);
            VRDSVaccineCard.Controls.Add(comboBox3);
            VRDSVaccineCard.Controls.Add(comboBox2);
            VRDSVaccineCard.Controls.Add(comboBox1);
            VRDSVaccineCard.Controls.Add(label7);
            VRDSVaccineCard.Location = new Point(9, 78);
            VRDSVaccineCard.Margin = new Padding(20, 5, 0, 0);
            VRDSVaccineCard.Name = "VRDSVaccineCard";
            VRDSVaccineCard.Size = new Size(782, 500);
            VRDSVaccineCard.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(13, 11);
            label7.Name = "label7";
            label7.Size = new Size(45, 19);
            label7.TabIndex = 1;
            label7.Text = "Filters";
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.FromArgb(249, 249, 249);
            comboBox1.ForeColor = Color.FromArgb(249, 249, 249);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(13, 36);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 2;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = Color.FromArgb(249, 249, 249);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(267, 36);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 3;
            // 
            // comboBox3
            // 
            comboBox3.BackColor = Color.FromArgb(249, 249, 249);
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(140, 36);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 4;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.FromArgb(89, 85, 84);
            button1.Location = new Point(667, 15);
            button1.Name = "button1";
            button1.Size = new Size(100, 31);
            button1.TabIndex = 33;
            button1.Text = "Filters";
            button1.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(535, 15);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(126, 29);
            dateTimePicker1.TabIndex = 34;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
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
            pieChart1.Size = new Size(356, 190);
            pieChart1.TabIndex = 36;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(14, 70);
            label1.Name = "label1";
            label1.Size = new Size(104, 19);
            label1.TabIndex = 37;
            label1.Text = "Chart Overview";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(14, 286);
            label2.Name = "label2";
            label2.Size = new Size(130, 19);
            label2.TabIndex = 38;
            label2.Text = "Vaccination History ";
            // 
            // cartesianChart1
            // 
            cartesianChart1.BackColor = Color.FromArgb(250, 250, 250);
            cartesianChart1.Location = new Point(425, 92);
            cartesianChart1.MatchAxesScreenDataRatio = false;
            cartesianChart1.Name = "cartesianChart1";
            cartesianChart1.Size = new Size(342, 191);
            cartesianChart1.TabIndex = 39;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.FromArgb(249, 249, 250);
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { PetName, Species, OwnerName, DateAdministered, NextDueDate, AdministeredBy });
            dataGridView1.GridColor = SystemColors.HighlightText;
            dataGridView1.Location = new Point(14, 308);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(753, 187);
            dataGridView1.TabIndex = 35;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // AdministeredBy
            // 
            AdministeredBy.HeaderText = "Column6";
            AdministeredBy.Name = "AdministeredBy";
            AdministeredBy.ReadOnly = true;
            // 
            // NextDueDate
            // 
            NextDueDate.HeaderText = "Column5";
            NextDueDate.Name = "NextDueDate";
            NextDueDate.ReadOnly = true;
            // 
            // DateAdministered
            // 
            DateAdministered.HeaderText = "Column4";
            DateAdministered.Name = "DateAdministered";
            DateAdministered.ReadOnly = true;
            // 
            // OwnerName
            // 
            OwnerName.HeaderText = "Column3";
            OwnerName.Name = "OwnerName";
            OwnerName.ReadOnly = true;
            // 
            // Species
            // 
            Species.HeaderText = "Column2";
            Species.Name = "Species";
            Species.ReadOnly = true;
            // 
            // PetName
            // 
            PetName.HeaderText = "Column1";
            PetName.Name = "PetName";
            PetName.ReadOnly = true;
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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel VRDSVaccineCard;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn PetName;
        private DataGridViewTextBoxColumn Species;
        private DataGridViewTextBoxColumn OwnerName;
        private DataGridViewTextBoxColumn DateAdministered;
        private DataGridViewTextBoxColumn NextDueDate;
        private DataGridViewTextBoxColumn AdministeredBy;
        private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
        private Label label2;
        private Label label1;
        private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label7;
    }
}
