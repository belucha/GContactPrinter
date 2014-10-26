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
            this.checkedListBoxInclude = new System.Windows.Forms.CheckedListBox();
            this.checkedListBoxExclude = new System.Windows.Forms.CheckedListBox();
            this.listBoxContacts = new System.Windows.Forms.ListBox();
            this.buttonReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBoxInclude
            // 
            this.checkedListBoxInclude.FormattingEnabled = true;
            this.checkedListBoxInclude.Location = new System.Drawing.Point(12, 12);
            this.checkedListBoxInclude.Name = "checkedListBoxInclude";
            this.checkedListBoxInclude.Size = new System.Drawing.Size(328, 274);
            this.checkedListBoxInclude.TabIndex = 4;
            this.checkedListBoxInclude.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxIncludeExclude_ItemCheck);
            this.checkedListBoxInclude.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.checkedListBox_FormatGroupEntry);
            // 
            // checkedListBoxExclude
            // 
            this.checkedListBoxExclude.FormattingEnabled = true;
            this.checkedListBoxExclude.Location = new System.Drawing.Point(346, 12);
            this.checkedListBoxExclude.Name = "checkedListBoxExclude";
            this.checkedListBoxExclude.Size = new System.Drawing.Size(351, 274);
            this.checkedListBoxExclude.TabIndex = 5;
            this.checkedListBoxExclude.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxIncludeExclude_ItemCheck);
            this.checkedListBoxExclude.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.checkedListBox_FormatGroupEntry);
            // 
            // listBoxContacts
            // 
            this.listBoxContacts.FormattingEnabled = true;
            this.listBoxContacts.Location = new System.Drawing.Point(12, 292);
            this.listBoxContacts.Name = "listBoxContacts";
            this.listBoxContacts.Size = new System.Drawing.Size(685, 225);
            this.listBoxContacts.TabIndex = 6;
            this.listBoxContacts.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.checkedListBoxContacts_Format);
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(572, 527);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(125, 28);
            this.buttonReport.TabIndex = 7;
            this.buttonReport.Text = "report";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 567);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.listBoxContacts);
            this.Controls.Add(this.checkedListBoxExclude);
            this.Controls.Add(this.checkedListBoxInclude);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxInclude;
        private System.Windows.Forms.CheckedListBox checkedListBoxExclude;
        private System.Windows.Forms.ListBox listBoxContacts;
        private System.Windows.Forms.Button buttonReport;
    }
}