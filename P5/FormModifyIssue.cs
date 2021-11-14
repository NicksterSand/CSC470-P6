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
    public partial class FormModifyIssue : Form {
        FakeIssueRepository issueRepository;
        FakeIssueStatusRepository issueStatusRepository;
        private Issue issue;
        private int projectId;
        public FormModifyIssue(Issue selectedIssue) {
            InitializeComponent();
            issue = selectedIssue;
            projectId = selectedIssue.ProjectId;
        }

        private void FormModifyIssue_Load(object sender, EventArgs e) {
            CenterToScreen();
            issueRepository = new FakeIssueRepository();
            issueStatusRepository = new FakeIssueStatusRepository();
            FakeAppUserRepository appUserRepository = new FakeAppUserRepository();
            textBoxId.Text = issue.Id.ToString();
            textBoxTitle.Text = issue.Title;
            dateTimeDiscoveryDate.Value = issue.DiscoveryDate;
            comboBoxDiscoverer.Items.Clear();
            List<AppUser> appUsers = appUserRepository.GetAll();
            int selectedIndex = 0;            
            int i = 0;
            foreach (AppUser appUser in appUsers) {
                comboBoxDiscoverer.Items.Add(appUser.UserName);
                if (appUser.UserName == issue.Discoverer)
                    selectedIndex = i;
                i++;
            }
            comboBoxDiscoverer.SelectedIndex = selectedIndex;
            textBoxComponent.Text = issue.Component;
            comboBoxStatus.SelectedIndex = issue.IssueStatusId;
            textBoxInitialDescription.Text = issue.InitialDescription;
        }

        private void buttonModify_Click(object sender, EventArgs e) {
            Issue issue = new Issue();
            issue.Id = Int32.Parse(textBoxId.Text);
            issue.Title = textBoxTitle.Text;
            issue.DiscoveryDate = dateTimeDiscoveryDate.Value;
            issue.Discoverer = (string)comboBoxDiscoverer.SelectedItem;
            issue.Component = textBoxComponent.Text;
            issue.IssueStatusId = issueStatusRepository.GetIdByStatus(comboBoxStatus.Text);
            issue.InitialDescription = textBoxInitialDescription.Text;
            issue.ProjectId = projectId;

            string error = issueRepository.Modify(issue);
            if (error == issueRepository.NO_ERROR) {
                Close();
            } else {
                MessageBox.Show("Error: " + error);
            }
        }
    }
}
