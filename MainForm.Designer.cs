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
            System.Windows.Forms.SplitContainer splitContainer;
            System.Windows.Forms.GroupBox groupBoxGroupMode;
            this.groupBoxContactFilter = new System.Windows.Forms.GroupBox();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.radioButtonOnlySelected = new System.Windows.Forms.RadioButton();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.radioButtonButSelected = new System.Windows.Forms.RadioButton();
            this.groupBoxExclude = new System.Windows.Forms.GroupBox();
            this.radioButtonExcludeWithoutPhone = new System.Windows.Forms.RadioButton();
            this.radioButtonExcludeWithoutAddress = new System.Windows.Forms.RadioButton();
            this.radioButtonExcludeWithoutAddressNorPhone = new System.Windows.Forms.RadioButton();
            this.radioButtonExcludeNone = new System.Windows.Forms.RadioButton();
            this.groupBoxContacts = new System.Windows.Forms.GroupBox();
            this.listBoxContacts = new System.Windows.Forms.ListBox();
            this.buttonReport = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSaveToXml = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialogXml = new System.Windows.Forms.SaveFileDialog();
            splitContainer = new System.Windows.Forms.SplitContainer();
            groupBoxGroupMode = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(splitContainer)).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            this.groupBoxContactFilter.SuspendLayout();
            groupBoxGroupMode.SuspendLayout();
            this.groupBoxExclude.SuspendLayout();
            this.groupBoxContacts.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // groupBoxContactFilter
            // 
            this.groupBoxContactFilter.Controls.Add(groupBoxGroupMode);
            this.groupBoxContactFilter.Controls.Add(this.groupBoxExclude);
            this.groupBoxContactFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxContactFilter.Location = new System.Drawing.Point(0, 0);
            this.groupBoxContactFilter.Name = "groupBoxContactFilter";
            this.groupBoxContactFilter.Size = new System.Drawing.Size(709, 169);
            this.groupBoxContactFilter.TabIndex = 9;
            this.groupBoxContactFilter.TabStop = false;
            this.groupBoxContactFilter.Text = "Filter...";
            // 
            // groupBoxGroupMode
            // 
            groupBoxGroupMode.Controls.Add(this.radioButtonAll);
            groupBoxGroupMode.Controls.Add(this.radioButtonOnlySelected);
            groupBoxGroupMode.Controls.Add(this.listBoxGroups);
            groupBoxGroupMode.Controls.Add(this.radioButtonButSelected);
            groupBoxGroupMode.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBoxGroupMode.Location = new System.Drawing.Point(3, 16);
            groupBoxGroupMode.Name = "groupBoxGroupMode";
            groupBoxGroupMode.Size = new System.Drawing.Size(537, 150);
            groupBoxGroupMode.TabIndex = 13;
            groupBoxGroupMode.TabStop = false;
            groupBoxGroupMode.Text = "Group mode...";
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
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.updateFilter);
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
            this.radioButtonOnlySelected.CheckedChanged += new System.EventHandler(this.updateFilter);
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(101, 15);
            this.listBoxGroups.MultiColumn = true;
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxGroups.Size = new System.Drawing.Size(430, 121);
            this.listBoxGroups.TabIndex = 8;
            this.listBoxGroups.SelectedIndexChanged += new System.EventHandler(this.updateFilter);
            this.listBoxGroups.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.checkedListBox_FormatGroupEntry);
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
            this.radioButtonButSelected.CheckedChanged += new System.EventHandler(this.updateFilter);
            // 
            // groupBoxExclude
            // 
            this.groupBoxExclude.Controls.Add(this.radioButtonExcludeWithoutPhone);
            this.groupBoxExclude.Controls.Add(this.radioButtonExcludeWithoutAddress);
            this.groupBoxExclude.Controls.Add(this.radioButtonExcludeWithoutAddressNorPhone);
            this.groupBoxExclude.Controls.Add(this.radioButtonExcludeNone);
            this.groupBoxExclude.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxExclude.Location = new System.Drawing.Point(540, 16);
            this.groupBoxExclude.Name = "groupBoxExclude";
            this.groupBoxExclude.Size = new System.Drawing.Size(166, 150);
            this.groupBoxExclude.TabIndex = 14;
            this.groupBoxExclude.TabStop = false;
            this.groupBoxExclude.Text = "Exclude contacts ...";
            // 
            // radioButtonExcludeWithoutPhone
            // 
            this.radioButtonExcludeWithoutPhone.AutoSize = true;
            this.radioButtonExcludeWithoutPhone.Location = new System.Drawing.Point(6, 88);
            this.radioButtonExcludeWithoutPhone.Name = "radioButtonExcludeWithoutPhone";
            this.radioButtonExcludeWithoutPhone.Size = new System.Drawing.Size(92, 17);
            this.radioButtonExcludeWithoutPhone.TabIndex = 3;
            this.radioButtonExcludeWithoutPhone.Text = "without phone";
            this.radioButtonExcludeWithoutPhone.UseVisualStyleBackColor = true;
            this.radioButtonExcludeWithoutPhone.CheckedChanged += new System.EventHandler(this.updateFilter);
            // 
            // radioButtonExcludeWithoutAddress
            // 
            this.radioButtonExcludeWithoutAddress.AutoSize = true;
            this.radioButtonExcludeWithoutAddress.Location = new System.Drawing.Point(6, 65);
            this.radioButtonExcludeWithoutAddress.Name = "radioButtonExcludeWithoutAddress";
            this.radioButtonExcludeWithoutAddress.Size = new System.Drawing.Size(99, 17);
            this.radioButtonExcludeWithoutAddress.TabIndex = 2;
            this.radioButtonExcludeWithoutAddress.Text = "without address";
            this.radioButtonExcludeWithoutAddress.UseVisualStyleBackColor = true;
            this.radioButtonExcludeWithoutAddress.CheckedChanged += new System.EventHandler(this.updateFilter);
            // 
            // radioButtonExcludeWithoutAddressNorPhone
            // 
            this.radioButtonExcludeWithoutAddressNorPhone.AutoSize = true;
            this.radioButtonExcludeWithoutAddressNorPhone.Checked = true;
            this.radioButtonExcludeWithoutAddressNorPhone.Location = new System.Drawing.Point(6, 42);
            this.radioButtonExcludeWithoutAddressNorPhone.Name = "radioButtonExcludeWithoutAddressNorPhone";
            this.radioButtonExcludeWithoutAddressNorPhone.Size = new System.Drawing.Size(153, 17);
            this.radioButtonExcludeWithoutAddressNorPhone.TabIndex = 1;
            this.radioButtonExcludeWithoutAddressNorPhone.TabStop = true;
            this.radioButtonExcludeWithoutAddressNorPhone.Text = "without address and phone";
            this.radioButtonExcludeWithoutAddressNorPhone.UseVisualStyleBackColor = true;
            this.radioButtonExcludeWithoutAddressNorPhone.CheckedChanged += new System.EventHandler(this.updateFilter);
            // 
            // radioButtonExcludeNone
            // 
            this.radioButtonExcludeNone.AutoSize = true;
            this.radioButtonExcludeNone.Location = new System.Drawing.Point(6, 19);
            this.radioButtonExcludeNone.Name = "radioButtonExcludeNone";
            this.radioButtonExcludeNone.Size = new System.Drawing.Size(49, 17);
            this.radioButtonExcludeNone.TabIndex = 0;
            this.radioButtonExcludeNone.Text = "none";
            this.radioButtonExcludeNone.UseVisualStyleBackColor = true;
            this.radioButtonExcludeNone.CheckedChanged += new System.EventHandler(this.updateFilter);
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
            // listBoxContacts
            // 
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
            this.buttonReport.Location = new System.Drawing.Point(9, 7);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(125, 28);
            this.buttonReport.TabIndex = 7;
            this.buttonReport.Text = "create && show report";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSaveToXml);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.buttonReport);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 520);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(709, 47);
            this.panel1.TabIndex = 11;
            // 
            // buttonSaveToXml
            // 
            this.buttonSaveToXml.Location = new System.Drawing.Point(443, 7);
            this.buttonSaveToXml.Name = "buttonSaveToXml";
            this.buttonSaveToXml.Size = new System.Drawing.Size(125, 28);
            this.buttonSaveToXml.TabIndex = 9;
            this.buttonSaveToXml.Text = "Save to XML...";
            this.buttonSaveToXml.UseVisualStyleBackColor = true;
            this.buttonSaveToXml.Click += new System.EventHandler(this.buttonSaveToXml_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(574, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 28);
            this.button1.TabIndex = 8;
            this.button1.Text = "E&xit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // saveFileDialogXml
            // 
            this.saveFileDialogXml.DefaultExt = "xml";
            this.saveFileDialogXml.Filter = "Xml Files (*.xml)|*.xml|All files (*.*)|*.*";
            this.saveFileDialogXml.Title = "Save contact data to XML...";
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
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(splitContainer)).EndInit();
            splitContainer.ResumeLayout(false);
            this.groupBoxContactFilter.ResumeLayout(false);
            groupBoxGroupMode.ResumeLayout(false);
            groupBoxGroupMode.PerformLayout();
            this.groupBoxExclude.ResumeLayout(false);
            this.groupBoxExclude.PerformLayout();
            this.groupBoxContacts.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxContacts;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.ListBox listBoxGroups;
        private System.Windows.Forms.GroupBox groupBoxContactFilter;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.RadioButton radioButtonButSelected;
        private System.Windows.Forms.RadioButton radioButtonOnlySelected;
        private System.Windows.Forms.GroupBox groupBoxContacts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBoxExclude;
        private System.Windows.Forms.RadioButton radioButtonExcludeWithoutPhone;
        private System.Windows.Forms.RadioButton radioButtonExcludeWithoutAddress;
        private System.Windows.Forms.RadioButton radioButtonExcludeWithoutAddressNorPhone;
        private System.Windows.Forms.RadioButton radioButtonExcludeNone;
        private System.Windows.Forms.Button buttonSaveToXml;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialogXml;
    }
}