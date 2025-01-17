﻿using System.Windows.Forms;
using System;

namespace P6
{
    public partial class FormMain : Form
    {
        private AppUser _CurrentAppUser = new AppUser();
        public FormMain()
        {
            InitializeComponent();
        }

        private void preferencesCreateProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormCreateProject form = new FormCreateProject();
            form.ShowDialog();
        }

        private void FormMain_Load(object sender, System.EventArgs e)
        {
            this.CenterToScreen();
            // Force the user to login successfully or abort the application
            DialogResult isOK = DialogResult.OK;
            while (!_CurrentAppUser.IsAuthenticated && isOK == DialogResult.OK)
            {
                FormLogin login = new FormLogin();
                isOK = login.ShowDialog();
                _CurrentAppUser = login._CurrentAppUser;
                login.Dispose();
            }
            if (isOK != DialogResult.OK)
            {
                Close();
                return;
            }
            this.Text = "Main - No Project Selected";
            while (selectAProject() == "")
            {
                DialogResult result = MessageBox.Show("A project must be selected.", "Attention", MessageBoxButtons.OKCancel);
                if (result == DialogResult.Cancel)
                {
                    Close();
                    return;
                }
            }
        }

        private void preferencesSelectProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            selectAProject();
        }

        private string selectAProject()
        {
            string selectedProject = "";
            FormSelectProject form = new FormSelectProject();
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
                preferenceRepository.SetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_NAME,
                                                   form._SelectedProjectName);
                int selectedProjectId = form._SelectedProjectId;
                preferenceRepository.SetPreference(_CurrentAppUser.UserName,
                                                   FakePreferenceRepository.PREFERENCE_PROJECT_ID,
                                                   selectedProjectId.ToString());
                this.Text = "Main - " + form._SelectedProjectName;
                selectedProject = form._SelectedProjectName;
            }
            form.Dispose();
            return selectedProject;
        }

        private void preferencesModifyProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormModifyProject form = new FormModifyProject(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void preferencesRemoveProjectToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            FormRemoveProject form = new FormRemoveProject(_CurrentAppUser);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesDashboardToolStripMenuItem_Click(object sender, System.EventArgs e) {
            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
            int projectId = Int32.Parse(preferenceRepository.GetPreference(_CurrentAppUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));
            FormIssueDashboard form = new FormIssueDashboard(projectId);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesRecordToolStripMenuItem_Click(object sender, EventArgs e) {
            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
            int projectId = Int32.Parse(preferenceRepository.GetPreference(_CurrentAppUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));
            FormRecordIssue form = new FormRecordIssue(projectId);
            form.ShowDialog();
            form.Dispose();
        }

        private void issuesRemoveToolStripMenuItem_Click(object sender, EventArgs e) {
            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
            FakeIssueRepository issueRepository = new FakeIssueRepository();
            int projectId = Int32.Parse(preferenceRepository.GetPreference(_CurrentAppUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));
            FormSelectIssue form = new FormSelectIssue(projectId);
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK) {
                Issue selectedIssue = form._SelectedIssue;
                DialogResult result = MessageBox.Show("Are you sure you want to remove: " + selectedIssue.Title + "?", "Confirmation", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes) {
                    issueRepository.Remove(selectedIssue);
                } else {
                    MessageBox.Show("Remove cancelled.");
                }
            }
            form.Dispose();
        }

        private void issuesModifyToolStripMenuItem_Click(object sender, EventArgs e) {
            FakePreferenceRepository preferenceRepository = new FakePreferenceRepository();
            FakeIssueRepository issueRepository = new FakeIssueRepository();
            int projectId = Int32.Parse(preferenceRepository.GetPreference(_CurrentAppUser.UserName, FakePreferenceRepository.PREFERENCE_PROJECT_ID));
            FormSelectIssue form = new FormSelectIssue(projectId);
            form.ShowDialog();
            if(form.DialogResult == DialogResult.OK) {
                Issue selectedIssue = form._SelectedIssue;
                FormModifyIssue modifyForm = new FormModifyIssue(selectedIssue);
                modifyForm.ShowDialog();
                modifyForm.Dispose();
            }
            form.Dispose();
        }
    }
}
