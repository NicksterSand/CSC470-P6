
namespace P6 {
    partial class FormSelectIssue {
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
            this.dataGridViewSelector = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscoveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discoverer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitialDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSelectIssue = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelector)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewSelector
            // 
            this.dataGridViewSelector.AllowUserToAddRows = false;
            this.dataGridViewSelector.AllowUserToDeleteRows = false;
            this.dataGridViewSelector.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSelector.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.DiscoveryDate,
            this.Discoverer,
            this.InitialDescription,
            this.Component,
            this.Status});
            this.dataGridViewSelector.Location = new System.Drawing.Point(17, 20);
            this.dataGridViewSelector.Name = "dataGridViewSelector";
            this.dataGridViewSelector.ReadOnly = true;
            this.dataGridViewSelector.RowHeadersWidth = 51;
            this.dataGridViewSelector.RowTemplate.Height = 24;
            this.dataGridViewSelector.Size = new System.Drawing.Size(959, 416);
            this.dataGridViewSelector.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 200;
            // 
            // DiscoveryDate
            // 
            this.DiscoveryDate.HeaderText = "DiscoveryDate";
            this.DiscoveryDate.MinimumWidth = 6;
            this.DiscoveryDate.Name = "DiscoveryDate";
            this.DiscoveryDate.ReadOnly = true;
            this.DiscoveryDate.Width = 150;
            // 
            // Discoverer
            // 
            this.Discoverer.HeaderText = "Discoverer";
            this.Discoverer.MinimumWidth = 6;
            this.Discoverer.Name = "Discoverer";
            this.Discoverer.ReadOnly = true;
            this.Discoverer.Width = 125;
            // 
            // InitialDescription
            // 
            this.InitialDescription.HeaderText = "InitialDescription";
            this.InitialDescription.MinimumWidth = 6;
            this.InitialDescription.Name = "InitialDescription";
            this.InitialDescription.ReadOnly = true;
            this.InitialDescription.Width = 125;
            // 
            // Component
            // 
            this.Component.HeaderText = "Component";
            this.Component.MinimumWidth = 6;
            this.Component.Name = "Component";
            this.Component.ReadOnly = true;
            this.Component.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 125;
            // 
            // buttonSelectIssue
            // 
            this.buttonSelectIssue.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSelectIssue.Location = new System.Drawing.Point(826, 470);
            this.buttonSelectIssue.Name = "buttonSelectIssue";
            this.buttonSelectIssue.Size = new System.Drawing.Size(150, 37);
            this.buttonSelectIssue.TabIndex = 1;
            this.buttonSelectIssue.Text = "Select Issue";
            this.buttonSelectIssue.UseVisualStyleBackColor = true;
            this.buttonSelectIssue.Click += new System.EventHandler(this.buttonSelectIssue_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(649, 470);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(150, 37);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormSelectIssue
            // 
            this.AcceptButton = this.buttonSelectIssue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(995, 537);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSelectIssue);
            this.Controls.Add(this.dataGridViewSelector);
            this.Name = "FormSelectIssue";
            this.Text = "FormSelectIssue";
            this.Load += new System.EventHandler(this.FormSelectIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSelector)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewSelector;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscoveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discoverer;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitialDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Component;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button buttonSelectIssue;
        private System.Windows.Forms.Button buttonCancel;
    }
}