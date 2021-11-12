
namespace P6 {
    partial class FormIssueDashboard {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.LabelIssueNumberText = new System.Windows.Forms.Label();
            this.LabelIssueNumber = new System.Windows.Forms.Label();
            this.LabelIssuesByMonth = new System.Windows.Forms.Label();
            this.ListBoxIssuesByMonth = new System.Windows.Forms.ListBox();
            this.LabelIssuesByDiscoverer = new System.Windows.Forms.Label();
            this.ListBoxIssuesByDiscoverer = new System.Windows.Forms.ListBox();
            this.ButtonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelIssueNumberText
            // 
            this.LabelIssueNumberText.AutoSize = true;
            this.LabelIssueNumberText.Location = new System.Drawing.Point(35, 52);
            this.LabelIssueNumberText.Name = "LabelIssueNumberText";
            this.LabelIssueNumberText.Size = new System.Drawing.Size(158, 17);
            this.LabelIssueNumberText.TabIndex = 0;
            this.LabelIssueNumberText.Text = "Total Number of Issues:";
            // 
            // LabelIssueNumber
            // 
            this.LabelIssueNumber.AutoSize = true;
            this.LabelIssueNumber.Location = new System.Drawing.Point(200, 52);
            this.LabelIssueNumber.Name = "LabelIssueNumber";
            this.LabelIssueNumber.Size = new System.Drawing.Size(16, 17);
            this.LabelIssueNumber.TabIndex = 1;
            this.LabelIssueNumber.Text = "0";
            // 
            // LabelIssuesByMonth
            // 
            this.LabelIssuesByMonth.AutoSize = true;
            this.LabelIssuesByMonth.Location = new System.Drawing.Point(38, 95);
            this.LabelIssuesByMonth.Name = "LabelIssuesByMonth";
            this.LabelIssuesByMonth.Size = new System.Drawing.Size(110, 17);
            this.LabelIssuesByMonth.TabIndex = 2;
            this.LabelIssuesByMonth.Text = "Issues by Month";
            // 
            // ListBoxIssuesByMonth
            // 
            this.ListBoxIssuesByMonth.FormattingEnabled = true;
            this.ListBoxIssuesByMonth.ItemHeight = 16;
            this.ListBoxIssuesByMonth.Location = new System.Drawing.Point(38, 115);
            this.ListBoxIssuesByMonth.Name = "ListBoxIssuesByMonth";
            this.ListBoxIssuesByMonth.Size = new System.Drawing.Size(276, 132);
            this.ListBoxIssuesByMonth.TabIndex = 3;
            // 
            // LabelIssuesByDiscoverer
            // 
            this.LabelIssuesByDiscoverer.AutoSize = true;
            this.LabelIssuesByDiscoverer.Location = new System.Drawing.Point(41, 284);
            this.LabelIssuesByDiscoverer.Name = "LabelIssuesByDiscoverer";
            this.LabelIssuesByDiscoverer.Size = new System.Drawing.Size(139, 17);
            this.LabelIssuesByDiscoverer.TabIndex = 4;
            this.LabelIssuesByDiscoverer.Text = "Issues by Discoverer";
            // 
            // ListBoxIssuesByDiscoverer
            // 
            this.ListBoxIssuesByDiscoverer.FormattingEnabled = true;
            this.ListBoxIssuesByDiscoverer.ItemHeight = 16;
            this.ListBoxIssuesByDiscoverer.Location = new System.Drawing.Point(38, 305);
            this.ListBoxIssuesByDiscoverer.Name = "ListBoxIssuesByDiscoverer";
            this.ListBoxIssuesByDiscoverer.Size = new System.Drawing.Size(276, 132);
            this.ListBoxIssuesByDiscoverer.TabIndex = 5;
            // 
            // ButtonClose
            // 
            this.ButtonClose.Location = new System.Drawing.Point(239, 473);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(75, 23);
            this.ButtonClose.TabIndex = 6;
            this.ButtonClose.Text = "Close";
            this.ButtonClose.UseVisualStyleBackColor = true;
            // 
            // FormIssueDashboard
            // 
            this.AcceptButton = this.ButtonClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonClose;
            this.ClientSize = new System.Drawing.Size(356, 535);
            this.Controls.Add(this.ButtonClose);
            this.Controls.Add(this.ListBoxIssuesByDiscoverer);
            this.Controls.Add(this.LabelIssuesByDiscoverer);
            this.Controls.Add(this.ListBoxIssuesByMonth);
            this.Controls.Add(this.LabelIssuesByMonth);
            this.Controls.Add(this.LabelIssueNumber);
            this.Controls.Add(this.LabelIssueNumberText);
            this.Name = "FormIssueDashboard";
            this.Text = "Issue Dashboard";
            this.Load += new System.EventHandler(this.FormIssueDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelIssueNumberText;
        private System.Windows.Forms.Label LabelIssueNumber;
        private System.Windows.Forms.Label LabelIssuesByMonth;
        private System.Windows.Forms.ListBox ListBoxIssuesByMonth;
        private System.Windows.Forms.Label LabelIssuesByDiscoverer;
        private System.Windows.Forms.ListBox ListBoxIssuesByDiscoverer;
        private System.Windows.Forms.Button ButtonClose;
    }
}