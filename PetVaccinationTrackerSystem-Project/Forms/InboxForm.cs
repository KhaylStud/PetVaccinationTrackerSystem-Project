﻿using Microsoft.EntityFrameworkCore;
using PetVaccinationTrackerSystem_Project.Classes;
using PetVaccinationTrackerSystem_Project.Data;
using PetVaccinationTrackerSystem_Project.Data.Entities;
using PetVaccinationTrackerSystem_Project.Data.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetVaccinationTrackerSystem_Project.Forms
{
    public partial class InboxForm : Form
    {

        private User _currentUser;

        private void FormatDataGridView()
        {
            dgvEmails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEmails.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvEmails.Columns["Body"].Visible = false;
            dgvEmails.Columns["WrittenByUserID"].Visible = false;
            dgvEmails.Columns["UserID"].Visible = false;
            dgvEmails.Columns["User"].Visible = false;

            dgvEmails.Columns["EmailID"].HeaderText = "ID";
            dgvEmails.Columns["Title"].HeaderText = "Email Subject";
            dgvEmails.Columns["DateAndTimeEmailSent"].HeaderText = "Date and Time Sent";
            dgvEmails.Columns["FromUser"].HeaderText = "From";

            if (_currentUser.VetID != null)
            {
                dgvEmails.Columns["IsRead"].HeaderText = "Is Read by Recipient";
                dgvEmails.Columns["IsDeleted"].HeaderText = "Is Deleted by Recipient";
            }
            else
            {
                dgvEmails.Columns["IsRead"].HeaderText = "Is Read";
                dgvEmails.Columns["IsDeleted"].Visible = false;
            }
        }

        private void LoadData()
        {

            var emailService = new EmailService();

            var emails = emailService.GetInboxEmails(_currentUser);

            dgvEmails.DataSource = emails;

            FormatDataGridView();

        }

        private void LoadFilterBox()
        {
            cmbFilters.Items.Add("All Emails");
            cmbFilters.Items.Add("Read");
            cmbFilters.Items.Add("Not Read");
            cmbFilters.SelectedIndex = 0; // Default to "All Emails"
        }

        public InboxForm(User inUserRef)
        {
            InitializeComponent();

            // Set the current user
            _currentUser = inUserRef;

            // Load the emails for the current user
            LoadData();
            LoadFilterBox();
        }

        private void dgvEmails_DoubleClick(object sender, EventArgs e)
        {
            if (dgvEmails.CurrentRow?.DataBoundItem is Email selectedEmail)
            {
                EmailForm emailForm = new EmailForm(selectedEmail, _currentUser);

                // Subscribe to the FormClosed event to reload data when the email form is closed
                emailForm.FormClosed += (s, args) =>
                {
                    // Reload the data after the email form is closed
                    LoadData();
                };

                // Always make this last since this freezes the current window.
                emailForm.ShowDialog();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // Read and Store in the values
            string selectedFilterOption = cmbFilters.SelectedItem?.ToString();
            string keywordQuery = txtSearchBox.Text.Trim();

            var emailService = new EmailService();
            var filteredEmails = emailService.SearchEmails(_currentUser, keywordQuery, selectedFilterOption);
            dgvEmails.DataSource = filteredEmails;
        }

        private void btnWriteEmail_Click(object sender, EventArgs e)
        {
            ReadWriteEmailSystemForm writeEmailForm = new ReadWriteEmailSystemForm(_currentUser);

            // Subscribe to Form Closed event
            writeEmailForm.FormClosed += (s, args) =>
            {
                LoadData();
            };

            writeEmailForm.ShowDialog();
        }

        private void InboxForm_Load(object sender, EventArgs e)
        {
            if (_currentUser.VetID == null)
            {
                btnWriteEmail.Enabled = false;
                btnWriteEmail.Visible = false;
            }
        }

        private void mainFormVButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
