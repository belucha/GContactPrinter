namespace GContactPrinter
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.SplitContainer splitContainer;
            System.Windows.Forms.GroupBox groupBoxGroupMode;
            this.listBoxContacts = new System.Windows.Forms.ListBox();
            this.buttonReport = new System.Windows.Forms.Button();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.groupBoxContactFilter = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBoxContacts = new System.Windows.Forms.GroupBox();
            this.radioButtonOnlySelected = new System.Windows.Forms.RadioButton();
            this.radioButtonButSelected = new System.Windows.Forms.RadioButton();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.checkBoxMustHaveAddress = new System.Windows.Forms.CheckBox();
            this.groupEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactEntryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            splitContainer = new System.Windows.Forms.SplitContainer();
            groupBoxGroupMode = new System.Windows.Forms.GroupBox();
            this.groupBoxContactFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(splitContainer)).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBoxContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupEntryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactEntryBindingSource)).BeginInit();
            groupBoxGroupMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxContacts
            // 
            this.listBoxContacts.DataSource = this.contactEntryBindingSource;
            this.listBoxContacts.DisplayMember = "Title";
            this.listBoxContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxContacts.FormattingEnabled = true;
            this.listBoxContacts.Location = new System.Drawing.Point(3, 16);
            this.listBoxContacts.Name = "listBoxContacts";
            this.listBoxContacts.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBoxContacts.Size = new System.Drawing.Size(703, 324);
            this.listBoxContacts.TabIndex = 6;
            this.listBoxContacts.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.checkedListBoxContacts_Format);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(12, 7);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(125, 28);
            this.buttonReport.TabIndex = 7;
            this.buttonReport.Text = "report";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxGroups.DataSource = this.groupEntryBindingSource;
            this.listBoxGroups.DisplayMember = "Title";
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(165, 19);
            this.listBoxGroups.MultiColumn = true;
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxGroups.Size = new System.Drawing.Size(532, 134);
            this.listBoxGroups.TabIndex = 8;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.listBoxGroups_SelectedIndexChanged);
            // 
            // groupBoxContactFilter
            // 
            this.groupBoxContactFilter.Controls.Add(groupBoxGroupMode);
            this.groupBoxContactFilter.Controls.Add(this.checkBoxMustHaveAddress);
            this.groupBoxContactFilter.Controls.Add(this.listBoxGroups);
            this.groupBoxContactFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxContactFilter.Location = new System.Drawing.Point(0, 0);
            this.groupBoxContactFilter.Name = "groupBoxContactFilter";
            this.groupBoxContactFilter.Size = new System.Drawing.Size(709, 169);
            this.groupBoxContactFilter.TabIndex = 9;
            this.groupBoxContactFilter.TabStop = false;
            this.groupBoxContactFilter.Text = "Filter...";
            // 
            // splitContainer
            // 
            splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            splitContainer.Location = new System.Drawing.Point(0, 0);
            splitContainer.Name = "splitContainer";
            splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(this.groupBoxContactFilter);
            splitContainer.Panel1MinSize = 100;
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(this.groupBoxContacts);
            splitContainer.Panel2MinSize = 100;
            splitContainer.Size = new System.Drawing.Size(709, 520);
            splitContainer.SplitterDistance = 169;
            splitContainer.SplitterWidth = 8;
            splitContainer.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 47);
            this.panel1.TabIndex = 11;
            // 
            // groupBoxContacts
            // 
            this.groupBoxContacts.Controls.Add(this.listBoxContacts);
            this.groupBoxContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxContacts.Location = new System.Drawing.Point(0, 0);
            this.groupBoxContacts.Name = "groupBoxContacts";
            this.groupBoxContacts.Size = new System.Drawing.Size(709, 343);
            this.groupBoxContacts.TabIndex = 7;
            this.groupBoxContacts.TabStop = false;
            this.groupBoxContacts.Text = "Filtered contact list...";
            // 
            // radioButtonOnlySelected
            // 
            this.radioButtonOnlySelected.AutoSize = true;
            this.radioButtonOnlySelected.Location = new System.Drawing.Point(6, 42);
            this.radioButtonOnlySelected.Name = "radioButtonOnlySelected";
            this.radioButtonOnlySelected.Size = new System.Drawing.Size(89, 17);
            this.radioButtonOnlySelected.TabIndex = 9;
            this.radioButtonOnlySelected.TabStop = true;
            this.radioButtonOnlySelected.Text = "Only selected";
            this.radioButtonOnlySelected.UseVisualStyleBackColor = true;
            // 
            // radioButtonButSelected
            // 
            this.radioButtonButSelected.AutoSize = true;
            this.radioButtonButSelected.Location = new System.Drawing.Point(6, 65);
            this.radioButtonButSelected.Name = "radioButtonButSelected";
            this.radioButtonButSelected.Size = new System.Drawing.Size(84, 17);
            this.radioButtonButSelected.TabIndex = 10;
            this.radioButtonButSelected.TabStop = true;
            this.radioButtonButSelected.Text = "But selected";
            this.radioButtonButSelected.UseVisualStyleBackColor = true;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Location = new System.Drawing.Point(6, 19);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(36, 17);
            this.radioButtonAll.TabIndex = 11;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            // 
            // checkBoxMustHaveAddress
            // 
            this.checkBoxMustHaveAddress.AutoSize = true;
            this.checkBoxMustHaveAddress.Location = new System.Drawing.Point(18, 136);
            this.checkBoxMustHaveAddress.Name = "checkBoxMustHaveAddress";
            this.checkBoxMustHaveAddress.Size = new System.Drawing.Size(105, 17);
            this.checkBoxMustHaveAddress.TabIndex = 12;
            this.checkBoxMustHaveAddress.Text = "Address required";
            this.checkBoxMustHaveAddress.UseVisualStyleBackColor = true;
            // 
            // groupEntryBindingSource
            // 
            this.groupEntryBindingSource.DataSource = typeof(Google.GData.Contacts.GroupEntry);
            // 
            // contactEntryBindingSource
            // 
            this.contactEntryBindingSource.DataSource = typeof(Google.GData.Contacts.ContactEntry);
            // 
            // groupBoxGroupMode
            // 
            groupBoxGroupMode.Controls.Add(this.radioButtonAll);
            groupBoxGroupMode.Controls.Add(this.radioButtonOnlySelected);
            groupBoxGroupMode.Controls.Add(this.radioButtonButSelected);
            groupBoxGroupMode.Location = new System.Drawing.Point(12, 19);
            groupBoxGroupMode.Name = "groupBoxGroupMode";
            groupBoxGroupMode.Size = new System.Drawing.Size(147, 100);
            groupBoxGroupMode.TabIndex = 13;
            groupBoxGroupMode.TabStop = false;
            groupBoxGroupMode.Text = "Groups...";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 567);
            this.Controls.Add(splitContainer);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "GContactPrinter vX.Y";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.groupBoxContactFilter.ResumeLayout(false);
            this.groupBoxContactFilter.PerformLayout();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer)).EndInit();
            splitContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.groupBoxContacts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupEntryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactEntryBindingSource)).EndInit();
            groupBoxGroupMode.ResumeLayout(false);
            groupBoxGroupMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxContacts;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.GroupBox groupBoxContactFilter;
        private System.Windows.Forms.CheckBox checkBoxMustHaveAddress;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonButSelected;
        private System.Windows.Forms.RadioButton radioButtonOnlySelected;
        private System.Windows.Forms.GroupBox groupBoxContacts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource contactEntryBindingSource;
        private System.Windows.Forms.BindingSource groupEntryBindingSource;
    }
}