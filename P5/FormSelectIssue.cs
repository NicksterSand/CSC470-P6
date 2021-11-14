using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace P6 {
    public partial class FormSelectIssue : Form {
        public Issue _SelectedIssue;
        private FakeIssueRepository issueRepository;
        private FakeIssueStatusRepository statusRepository;
        private int projectId;
        public FormSelectIssue(int id) {
            InitializeComponent();
            projectId = id;
        }

        private void FormSelectIssue_Load(object sender, EventArgs e) {
            CenterToScreen();
            issueRepository = new FakeIssueRepository();
            statusRepository = new FakeIssueStatusRepository();
            dataGridViewSelector.Rows.Clear();
            List<Issue> issues = issueRepository.GetAll(projectId);
            foreach (Issue issue in issues) {
                string[] row = new string[] { issue.Id.ToString(), issue.Title, issue.DiscoveryDate.ToString(), issue.Discoverer, issue.InitialDescription, issue.Component, statusRepository.GetValueById(issue.IssueStatusId) };
                dataGridViewSelector.Rows.Add(row);
            }
        }

        private void buttonSelectIssue_Click(object sender, EventArgs e) {
            if(dataGridViewSelector.SelectedRows.Count > 0) {
                _SelectedIssue = issueRepository.GetIssueById(Int32.Parse(dataGridViewSelector.SelectedRows[0].Cells[0].Value.ToString()));
                DialogResult = DialogResult.OK;
                Close();
            } else {
                MessageBox.Show("Please select a row.");
            }
        }
    }
}
