
namespace Builder {
    partial class FormRecordIssue {
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.dateTimeDiscoveryDate = new System.Windows.Forms.DateTimePicker();
            this.labelDiscoverer = new System.Windows.Forms.Label();
            this.comboBoxDiscoverer = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxComponent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxInitialDescription = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Discovery Date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title:";
            // 
            // textBoxId
            // 
            this.textBoxId.Enabled = false;
            this.textBoxId.Location = new System.Drawing.Point(126, 45);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(47, 22);
            this.textBoxId.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Id:";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(126, 74);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(383, 22);
            this.textBoxTitle.TabIndex = 4;
            // 
            // dateTimeDiscoveryDate
            // 
            this.dateTimeDiscoveryDate.Location = new System.Drawing.Point(126, 102);
            this.dateTimeDiscoveryDate.Name = "dateTimeDiscoveryDate";
            this.dateTimeDiscoveryDate.Size = new System.Drawing.Size(383, 22);
            this.dateTimeDiscoveryDate.TabIndex = 5;
            // 
            // labelDiscoverer
            // 
            this.labelDiscoverer.AutoSize = true;
            this.labelDiscoverer.Location = new System.Drawing.Point(40, 130);
            this.labelDiscoverer.Name = "labelDiscoverer";
            this.labelDiscoverer.Size = new System.Drawing.Size(80, 17);
            this.labelDiscoverer.TabIndex = 6;
            this.labelDiscoverer.Text = "Discoverer:";
            // 
            // comboBoxDiscoverer
            // 
            this.comboBoxDiscoverer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiscoverer.FormattingEnabled = true;
            this.comboBoxDiscoverer.Location = new System.Drawing.Point(126, 130);
            this.comboBoxDiscoverer.Name = "comboBoxDiscoverer";
            this.comboBoxDiscoverer.Size = new System.Drawing.Size(383, 24);
            this.comboBoxDiscoverer.TabIndex = 7;
            // 
            // textBoxComponent
            // 
            this.textBoxComponent.Location = new System.Drawing.Point(126, 161);
            this.textBoxComponent.Name = "textBoxComponent";
            this.textBoxComponent.Size = new System.Drawing.Size(383, 22);
            this.textBoxComponent.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Component:";
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Items.AddRange(new object[] {
            "Open",
            "Assigned",
            "Fixed",
            "Closed - Won\'t fix",
            "Closed - Fixed",
            "Closed - By design"});
            this.comboBoxStatus.Location = new System.Drawing.Point(126, 190);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(383, 24);
            this.comboBoxStatus.TabIndex = 10;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(68, 190);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(52, 17);
            this.labelStatus.TabIndex = 11;
            this.labelStatus.Text = "Status:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(123, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Initial Description";
            // 
            // textBoxInitialDescription
            // 
            this.textBoxInitialDescription.Location = new System.Drawing.Point(126, 249);
            this.textBoxInitialDescription.Multiline = true;
            this.textBoxInitialDescription.Name = "textBoxInitialDescription";
            this.textBoxInitialDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxInitialDescription.Size = new System.Drawing.Size(383, 260);
            this.textBoxInitialDescription.TabIndex = 13;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(396, 531);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(113, 32);
            this.buttonCreate.TabIndex = 14;
            this.buttonCreate.Text = "Create Issue";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(257, 531);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(113, 32);
            this.buttonCancel.TabIndex = 15;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormRecordIssue
            // 
            this.AcceptButton = this.buttonCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(578, 587);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxInitialDescription);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxComponent);
            this.Controls.Add(this.comboBoxDiscoverer);
            this.Controls.Add(this.labelDiscoverer);
            this.Controls.Add(this.dateTimeDiscoveryDate);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRecordIssue";
            this.Text = "FormRecordIssue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.DateTimePicker dateTimeDiscoveryDate;
        private System.Windows.Forms.Label labelDiscoverer;
        private System.Windows.Forms.ComboBox comboBoxDiscoverer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxComponent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxInitialDescription;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonCancel;
    }
}