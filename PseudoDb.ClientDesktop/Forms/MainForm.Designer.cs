namespace PseudoDb.ClientDesktop.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolStripContainer = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.objectExplorerGroupBox = new System.Windows.Forms.GroupBox();
            this.DatabaseTreeView = new System.Windows.Forms.TreeView();
            this.queryDesignerGroupBox = new System.Windows.Forms.GroupBox();
            this.queryDesignerSplitContainer = new System.Windows.Forms.SplitContainer();
            this.queryDesignerTabControl = new System.Windows.Forms.TabControl();
            this.SelectTabPage = new System.Windows.Forms.TabPage();
            this.selectDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectTable = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SelectField = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.FilterTabPage = new System.Windows.Forms.TabPage();
            this.filterDataGridView = new System.Windows.Forms.DataGridView();
            this.Table = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.joinTabPage = new System.Windows.Forms.TabPage();
            this.joinDataGridView = new System.Windows.Forms.DataGridView();
            this.queryGroupBox = new System.Windows.Forms.GroupBox();
            this.queryTabControl = new System.Windows.Forms.TabControl();
            this.sqlQueryTabPage = new System.Windows.Forms.TabPage();
            this.sqlQueryTextBox = new System.Windows.Forms.TextBox();
            this.resultsTabPage = new System.Windows.Forms.TabPage();
            this.resultDataGridView = new System.Windows.Forms.DataGridView();
            this.messagesTabPage = new System.Windows.Forms.TabPage();
            this.messagesTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.executeToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.cancelToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.LeftTable = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.LeftColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.RightTable = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.RightColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.JoinOperator = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.toolStripContainer.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer.ContentPanel.SuspendLayout();
            this.toolStripContainer.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.objectExplorerGroupBox.SuspendLayout();
            this.queryDesignerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.queryDesignerSplitContainer)).BeginInit();
            this.queryDesignerSplitContainer.Panel1.SuspendLayout();
            this.queryDesignerSplitContainer.Panel2.SuspendLayout();
            this.queryDesignerSplitContainer.SuspendLayout();
            this.queryDesignerTabControl.SuspendLayout();
            this.SelectTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.selectDataGridView)).BeginInit();
            this.FilterTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filterDataGridView)).BeginInit();
            this.joinTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.joinDataGridView)).BeginInit();
            this.queryGroupBox.SuspendLayout();
            this.queryTabControl.SuspendLayout();
            this.sqlQueryTabPage.SuspendLayout();
            this.resultsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            this.messagesTabPage.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer
            // 
            // 
            // toolStripContainer.BottomToolStripPanel
            // 
            this.toolStripContainer.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer.ContentPanel
            // 
            this.toolStripContainer.ContentPanel.Controls.Add(this.splitContainer);
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(984, 518);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(984, 565);
            this.toolStripContainer.TabIndex = 0;
            // 
            // toolStripContainer.TopToolStripPanel
            // 
            this.toolStripContainer.TopToolStripPanel.Controls.Add(this.toolStrip);
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(984, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.objectExplorerGroupBox);
            this.splitContainer.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.queryDesignerGroupBox);
            this.splitContainer.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer.Size = new System.Drawing.Size(984, 518);
            this.splitContainer.SplitterDistance = 318;
            this.splitContainer.TabIndex = 0;
            // 
            // objectExplorerGroupBox
            // 
            this.objectExplorerGroupBox.Controls.Add(this.DatabaseTreeView);
            this.objectExplorerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectExplorerGroupBox.Location = new System.Drawing.Point(3, 3);
            this.objectExplorerGroupBox.Name = "objectExplorerGroupBox";
            this.objectExplorerGroupBox.Size = new System.Drawing.Size(312, 512);
            this.objectExplorerGroupBox.TabIndex = 0;
            this.objectExplorerGroupBox.TabStop = false;
            this.objectExplorerGroupBox.Text = "Object Explorer";
            // 
            // DatabaseTreeView
            // 
            this.DatabaseTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatabaseTreeView.Location = new System.Drawing.Point(3, 16);
            this.DatabaseTreeView.Name = "DatabaseTreeView";
            this.DatabaseTreeView.Size = new System.Drawing.Size(306, 493);
            this.DatabaseTreeView.TabIndex = 2;
            // 
            // queryDesignerGroupBox
            // 
            this.queryDesignerGroupBox.Controls.Add(this.queryDesignerSplitContainer);
            this.queryDesignerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryDesignerGroupBox.Location = new System.Drawing.Point(3, 3);
            this.queryDesignerGroupBox.Name = "queryDesignerGroupBox";
            this.queryDesignerGroupBox.Size = new System.Drawing.Size(656, 512);
            this.queryDesignerGroupBox.TabIndex = 0;
            this.queryDesignerGroupBox.TabStop = false;
            this.queryDesignerGroupBox.Text = "Visual Query Designer";
            // 
            // queryDesignerSplitContainer
            // 
            this.queryDesignerSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryDesignerSplitContainer.Location = new System.Drawing.Point(3, 16);
            this.queryDesignerSplitContainer.Name = "queryDesignerSplitContainer";
            this.queryDesignerSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // queryDesignerSplitContainer.Panel1
            // 
            this.queryDesignerSplitContainer.Panel1.Controls.Add(this.queryDesignerTabControl);
            // 
            // queryDesignerSplitContainer.Panel2
            // 
            this.queryDesignerSplitContainer.Panel2.Controls.Add(this.queryGroupBox);
            this.queryDesignerSplitContainer.Size = new System.Drawing.Size(650, 493);
            this.queryDesignerSplitContainer.SplitterDistance = 281;
            this.queryDesignerSplitContainer.TabIndex = 0;
            // 
            // queryDesignerTabControl
            // 
            this.queryDesignerTabControl.Controls.Add(this.SelectTabPage);
            this.queryDesignerTabControl.Controls.Add(this.FilterTabPage);
            this.queryDesignerTabControl.Controls.Add(this.joinTabPage);
            this.queryDesignerTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryDesignerTabControl.Location = new System.Drawing.Point(0, 0);
            this.queryDesignerTabControl.Name = "queryDesignerTabControl";
            this.queryDesignerTabControl.SelectedIndex = 0;
            this.queryDesignerTabControl.Size = new System.Drawing.Size(650, 281);
            this.queryDesignerTabControl.TabIndex = 0;
            // 
            // SelectTabPage
            // 
            this.SelectTabPage.Controls.Add(this.selectDataGridView);
            this.SelectTabPage.Location = new System.Drawing.Point(4, 22);
            this.SelectTabPage.Name = "SelectTabPage";
            this.SelectTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SelectTabPage.Size = new System.Drawing.Size(642, 255);
            this.SelectTabPage.TabIndex = 0;
            this.SelectTabPage.Text = "Select";
            this.SelectTabPage.UseVisualStyleBackColor = true;
            // 
            // selectDataGridView
            // 
            this.selectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SelectTable,
            this.SelectField});
            this.selectDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectDataGridView.Location = new System.Drawing.Point(3, 3);
            this.selectDataGridView.Name = "selectDataGridView";
            this.selectDataGridView.Size = new System.Drawing.Size(636, 249);
            this.selectDataGridView.TabIndex = 0;
            // 
            // SelectTable
            // 
            this.SelectTable.HeaderText = "Table";
            this.SelectTable.Name = "SelectTable";
            // 
            // SelectField
            // 
            this.SelectField.HeaderText = "Column";
            this.SelectField.Name = "SelectField";
            // 
            // FilterTabPage
            // 
            this.FilterTabPage.Controls.Add(this.filterDataGridView);
            this.FilterTabPage.Location = new System.Drawing.Point(4, 22);
            this.FilterTabPage.Name = "FilterTabPage";
            this.FilterTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FilterTabPage.Size = new System.Drawing.Size(642, 255);
            this.FilterTabPage.TabIndex = 1;
            this.FilterTabPage.Text = "Filter";
            this.FilterTabPage.UseVisualStyleBackColor = true;
            // 
            // filterDataGridView
            // 
            this.filterDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filterDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Table,
            this.Column,
            this.Operator,
            this.Value});
            this.filterDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.filterDataGridView.Location = new System.Drawing.Point(3, 3);
            this.filterDataGridView.Name = "filterDataGridView";
            this.filterDataGridView.Size = new System.Drawing.Size(636, 249);
            this.filterDataGridView.TabIndex = 0;
            // 
            // Table
            // 
            this.Table.HeaderText = "Table";
            this.Table.Name = "Table";
            // 
            // Column
            // 
            this.Column.HeaderText = "Column";
            this.Column.Name = "Column";
            // 
            // Operator
            // 
            this.Operator.HeaderText = "Operator";
            this.Operator.Items.AddRange(new object[] {
            "=",
            "<>",
            "<",
            ">",
            "<=",
            ">="});
            this.Operator.Name = "Operator";
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            // 
            // joinTabPage
            // 
            this.joinTabPage.Controls.Add(this.joinDataGridView);
            this.joinTabPage.Location = new System.Drawing.Point(4, 22);
            this.joinTabPage.Name = "joinTabPage";
            this.joinTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.joinTabPage.Size = new System.Drawing.Size(642, 255);
            this.joinTabPage.TabIndex = 2;
            this.joinTabPage.Text = "Join";
            this.joinTabPage.UseVisualStyleBackColor = true;
            // 
            // joinDataGridView
            // 
            this.joinDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.joinDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LeftTable,
            this.LeftColumn,
            this.RightTable,
            this.RightColumn,
            this.JoinOperator});
            this.joinDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.joinDataGridView.Location = new System.Drawing.Point(3, 3);
            this.joinDataGridView.Name = "joinDataGridView";
            this.joinDataGridView.Size = new System.Drawing.Size(636, 249);
            this.joinDataGridView.TabIndex = 0;
            // 
            // queryGroupBox
            // 
            this.queryGroupBox.Controls.Add(this.queryTabControl);
            this.queryGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryGroupBox.Location = new System.Drawing.Point(0, 0);
            this.queryGroupBox.Name = "queryGroupBox";
            this.queryGroupBox.Size = new System.Drawing.Size(650, 208);
            this.queryGroupBox.TabIndex = 0;
            this.queryGroupBox.TabStop = false;
            this.queryGroupBox.Text = "Query";
            // 
            // queryTabControl
            // 
            this.queryTabControl.Controls.Add(this.sqlQueryTabPage);
            this.queryTabControl.Controls.Add(this.resultsTabPage);
            this.queryTabControl.Controls.Add(this.messagesTabPage);
            this.queryTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryTabControl.Location = new System.Drawing.Point(3, 16);
            this.queryTabControl.Name = "queryTabControl";
            this.queryTabControl.SelectedIndex = 0;
            this.queryTabControl.Size = new System.Drawing.Size(644, 189);
            this.queryTabControl.TabIndex = 0;
            // 
            // sqlQueryTabPage
            // 
            this.sqlQueryTabPage.Controls.Add(this.sqlQueryTextBox);
            this.sqlQueryTabPage.Location = new System.Drawing.Point(4, 22);
            this.sqlQueryTabPage.Name = "sqlQueryTabPage";
            this.sqlQueryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sqlQueryTabPage.Size = new System.Drawing.Size(636, 163);
            this.sqlQueryTabPage.TabIndex = 0;
            this.sqlQueryTabPage.Text = "SQL Query";
            this.sqlQueryTabPage.UseVisualStyleBackColor = true;
            // 
            // sqlQueryTextBox
            // 
            this.sqlQueryTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.sqlQueryTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sqlQueryTextBox.Location = new System.Drawing.Point(3, 3);
            this.sqlQueryTextBox.Multiline = true;
            this.sqlQueryTextBox.Name = "sqlQueryTextBox";
            this.sqlQueryTextBox.ReadOnly = true;
            this.sqlQueryTextBox.Size = new System.Drawing.Size(630, 157);
            this.sqlQueryTextBox.TabIndex = 0;
            // 
            // resultsTabPage
            // 
            this.resultsTabPage.Controls.Add(this.resultDataGridView);
            this.resultsTabPage.Location = new System.Drawing.Point(4, 22);
            this.resultsTabPage.Name = "resultsTabPage";
            this.resultsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.resultsTabPage.Size = new System.Drawing.Size(636, 163);
            this.resultsTabPage.TabIndex = 1;
            this.resultsTabPage.Text = "Results";
            this.resultsTabPage.UseVisualStyleBackColor = true;
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.AllowUserToAddRows = false;
            this.resultDataGridView.AllowUserToDeleteRows = false;
            this.resultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultDataGridView.Location = new System.Drawing.Point(3, 3);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.ReadOnly = true;
            this.resultDataGridView.Size = new System.Drawing.Size(630, 157);
            this.resultDataGridView.TabIndex = 0;
            // 
            // messagesTabPage
            // 
            this.messagesTabPage.Controls.Add(this.messagesTextBox);
            this.messagesTabPage.Location = new System.Drawing.Point(4, 22);
            this.messagesTabPage.Name = "messagesTabPage";
            this.messagesTabPage.Size = new System.Drawing.Size(636, 163);
            this.messagesTabPage.TabIndex = 2;
            this.messagesTabPage.Text = "Messages";
            this.messagesTabPage.UseVisualStyleBackColor = true;
            // 
            // messagesTextBox
            // 
            this.messagesTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.messagesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesTextBox.Location = new System.Drawing.Point(0, 0);
            this.messagesTextBox.Multiline = true;
            this.messagesTextBox.Name = "messagesTextBox";
            this.messagesTextBox.ReadOnly = true;
            this.messagesTextBox.Size = new System.Drawing.Size(636, 163);
            this.messagesTextBox.TabIndex = 0;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.executeToolStripButton,
            this.cancelToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(3, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(87, 25);
            this.toolStrip.TabIndex = 0;
            // 
            // executeToolStripButton
            // 
            this.executeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.executeToolStripButton.Enabled = false;
            this.executeToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("executeToolStripButton.Image")));
            this.executeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.executeToolStripButton.Name = "executeToolStripButton";
            this.executeToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.executeToolStripButton.Text = "Execute";
            this.executeToolStripButton.ToolTipText = "Execute current command.";
            this.executeToolStripButton.Click += new System.EventHandler(this.executeToolStripButton_Click);
            // 
            // cancelToolStripButton
            // 
            this.cancelToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cancelToolStripButton.Enabled = false;
            this.cancelToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cancelToolStripButton.Image")));
            this.cancelToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cancelToolStripButton.Name = "cancelToolStripButton";
            this.cancelToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cancelToolStripButton.Text = "Cancel";
            this.cancelToolStripButton.ToolTipText = "Cancel the current execution of a command.";
            this.cancelToolStripButton.Click += new System.EventHandler(this.cancelToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // LeftTable
            // 
            this.LeftTable.HeaderText = "Left Table";
            this.LeftTable.Name = "LeftTable";
            // 
            // LeftColumn
            // 
            this.LeftColumn.HeaderText = "Left Table Column";
            this.LeftColumn.Name = "LeftColumn";
            this.LeftColumn.Width = 130;
            // 
            // RightTable
            // 
            this.RightTable.HeaderText = "Right Table";
            this.RightTable.Name = "RightTable";
            // 
            // RightColumn
            // 
            this.RightColumn.HeaderText = "Right Table Column";
            this.RightColumn.Name = "RightColumn";
            this.RightColumn.Width = 130;
            // 
            // JoinOperator
            // 
            this.JoinOperator.HeaderText = "Operator";
            this.JoinOperator.Items.AddRange(new object[] {
            "=",
            "<>",
            "<",
            ">",
            "<=",
            ">="});
            this.JoinOperator.Name = "JoinOperator";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 565);
            this.Controls.Add(this.toolStripContainer);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.Text = "PseudoDB Development Studio";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.toolStripContainer.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer.ContentPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer.TopToolStripPanel.PerformLayout();
            this.toolStripContainer.ResumeLayout(false);
            this.toolStripContainer.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.objectExplorerGroupBox.ResumeLayout(false);
            this.queryDesignerGroupBox.ResumeLayout(false);
            this.queryDesignerSplitContainer.Panel1.ResumeLayout(false);
            this.queryDesignerSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.queryDesignerSplitContainer)).EndInit();
            this.queryDesignerSplitContainer.ResumeLayout(false);
            this.queryDesignerTabControl.ResumeLayout(false);
            this.SelectTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.selectDataGridView)).EndInit();
            this.FilterTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filterDataGridView)).EndInit();
            this.joinTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.joinDataGridView)).EndInit();
            this.queryGroupBox.ResumeLayout(false);
            this.queryTabControl.ResumeLayout(false);
            this.sqlQueryTabPage.ResumeLayout(false);
            this.sqlQueryTabPage.PerformLayout();
            this.resultsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            this.messagesTabPage.ResumeLayout(false);
            this.messagesTabPage.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox objectExplorerGroupBox;
        private System.Windows.Forms.TreeView DatabaseTreeView;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.GroupBox queryDesignerGroupBox;
        private System.Windows.Forms.SplitContainer queryDesignerSplitContainer;
        private System.Windows.Forms.GroupBox queryGroupBox;
        private System.Windows.Forms.TabControl queryTabControl;
        private System.Windows.Forms.TabPage sqlQueryTabPage;
        private System.Windows.Forms.TabPage resultsTabPage;
        private System.Windows.Forms.TextBox sqlQueryTextBox;
        private System.Windows.Forms.TabPage messagesTabPage;
        private System.Windows.Forms.TextBox messagesTextBox;
        private System.Windows.Forms.TabControl queryDesignerTabControl;
        private System.Windows.Forms.TabPage SelectTabPage;
        private System.Windows.Forms.TabPage FilterTabPage;
        private System.Windows.Forms.DataGridView filterDataGridView;
        private System.Windows.Forms.DataGridView resultDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn Table;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column;
        private System.Windows.Forms.DataGridViewComboBoxColumn Operator;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.ToolStripButton executeToolStripButton;
        private System.Windows.Forms.ToolStripButton cancelToolStripButton;
        private System.Windows.Forms.TabPage joinTabPage;
        private System.Windows.Forms.DataGridView selectDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn SelectTable;
        private System.Windows.Forms.DataGridViewComboBoxColumn SelectField;
        private System.Windows.Forms.DataGridView joinDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn JoinOperator;
        private System.Windows.Forms.DataGridViewComboBoxColumn RightColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn RightTable;
        private System.Windows.Forms.DataGridViewComboBoxColumn LeftColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn LeftTable;
    }
}

