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
    public partial class FormIssueDashboard : Form {
        private int projectId;
        public FormIssueDashboard(int Id) {
            InitializeComponent();
            projectId = Id;
        }

        private void FormIssueDashboard_Load(object sender, EventArgs e) {
            CenterToScreen();
            FakeIssueRepository issueRepository = new FakeIssueRepository();
            LabelIssueNumber.Text = issueRepository.GetTotalNumberOfIssues(projectId).ToString();
            foreach (string issue in issueRepository.GetIssuesByMonth(projectId)) {
                ListBoxIssuesByMonth.Items.Add(issue);
            }
            foreach (string issue in issueRepository.GetIssuesByDiscoverer(projectId)) {
                ListBoxIssuesByDiscoverer.Items.Add(issue);
            }
        }
    }
}
