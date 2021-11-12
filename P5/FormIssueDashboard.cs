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
        FakeIssueRepository _IssueRepository = new FakeIssueRepository();
        public FormIssueDashboard() {
            InitializeComponent();
        }

        private void FormIssueDashboard_Load(object sender, EventArgs e) {
            CenterToScreen();
            
        }
    }
}
