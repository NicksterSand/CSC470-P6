using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P6 {
    public partial class FormRecordIssue : Form {
        FakeIssueRepository issueRepository;
        FakeIssueStatusRepository issueStatusRepository;
        private int projectId;
        public FormRecordIssue(int id) {
            InitializeComponent();
            projectId = id;
        }

        private void FormRecordIssue_Load(object sender, EventArgs e) {
            CenterToScreen();
            issueRepository = new FakeIssueRepository();
            issueStatusRepository = new FakeIssueStatusRepository();
            FakeAppUserRepository appUserRepository = new FakeAppUserRepository();
            int Id = issueRepository.GetNextId();
            textBoxId.Text = Id.ToString();
            comboBoxDiscoverer.Items.Clear();
            List<AppUser> appUsers = appUserRepository.GetAll();
            foreach(AppUser appUser in appUsers) {
                comboBoxDiscoverer.Items.Add(appUser.UserName);
            }
            comboBoxDiscoverer.SelectedIndex = 0;
            comboBoxStatus.SelectedIndex = 0;
        }

        private void buttonCreate_Click(object sender, EventArgs e) {
            Issue issue = new Issue();
            issue.Id = Int32.Parse(textBoxId.Text);
            issue.Title = textBoxTitle.Text;
            issue.DiscoveryDate = dateTimeDiscoveryDate.Value;
            issue.Discoverer = (string)comboBoxDiscoverer.SelectedItem;
            issue.Component = textBoxComponent.Text;
            issue.IssueStatusId = issueStatusRepository.GetIdByStatus(comboBoxStatus.Text);
            issue.InitialDescription = textBoxInitialDescription.Text;
            issue.ProjectId = projectId;

            string error = issueRepository.Add(issue);
            if(error == issueRepository.NO_ERROR) {
                Close();
            } else {
                MessageBox.Show("Error: " + error);
            }
        }
    }
}
