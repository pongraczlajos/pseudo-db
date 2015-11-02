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
            this.FilterTabPage = new System.Windows.Forms.TabPage();
            this.queryGroupBox = new System.Windows.Forms.GroupBox();
            this.queryTabControl = new System.Windows.Forms.TabControl();
            this.sqlQueryTabPage = new System.Windows.Forms.TabPage();
            this.sqlQueryTextBox = new System.Windows.Forms.TextBox();
            this.resultsTabPage = new System.Windows.Forms.TabPage();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.messagesTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TableColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Column = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Operator = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.messagesTextBox = new System.Windows.Forms.TextBox();
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
            this.FilterTabPage.SuspendLayout();
            this.queryGroupBox.SuspendLayout();
            this.queryTabControl.SuspendLayout();
            this.sqlQueryTabPage.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.messagesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.toolStripContainer.ContentPanel.Size = new System.Drawing.Size(984, 515);
            this.toolStripContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer.Name = "toolStripContainer";
            this.toolStripContainer.Size = new System.Drawing.Size(984, 562);
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
            this.splitContainer.Size = new System.Drawing.Size(984, 515);
            this.splitContainer.SplitterDistance = 318;
            this.splitContainer.TabIndex = 0;
            // 
            // objectExplorerGroupBox
            // 
            this.objectExplorerGroupBox.Controls.Add(this.DatabaseTreeView);
            this.objectExplorerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.objectExplorerGroupBox.Location = new System.Drawing.Point(3, 3);
            this.objectExplorerGroupBox.Name = "objectExplorerGroupBox";
            this.objectExplorerGroupBox.Size = new System.Drawing.Size(312, 509);
            this.objectExplorerGroupBox.TabIndex = 0;
            this.objectExplorerGroupBox.TabStop = false;
            this.objectExplorerGroupBox.Text = "Object Explorer";
            // 
            // DatabaseTreeView
            // 
            this.DatabaseTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatabaseTreeView.Location = new System.Drawing.Point(3, 16);
            this.DatabaseTreeView.Name = "DatabaseTreeView";
            this.DatabaseTreeView.Size = new System.Drawing.Size(306, 490);
            this.DatabaseTreeView.TabIndex = 2;
            // 
            // queryDesignerGroupBox
            // 
            this.queryDesignerGroupBox.Controls.Add(this.queryDesignerSplitContainer);
            this.queryDesignerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryDesignerGroupBox.Location = new System.Drawing.Point(3, 3);
            this.queryDesignerGroupBox.Name = "queryDesignerGroupBox";
            this.queryDesignerGroupBox.Size = new System.Drawing.Size(656, 509);
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
            this.queryDesignerSplitContainer.Size = new System.Drawing.Size(650, 490);
            this.queryDesignerSplitContainer.SplitterDistance = 280;
            this.queryDesignerSplitContainer.TabIndex = 0;
            // 
            // queryDesignerTabControl
            // 
            this.queryDesignerTabControl.Controls.Add(this.SelectTabPage);
            this.queryDesignerTabControl.Controls.Add(this.FilterTabPage);
            this.queryDesignerTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryDesignerTabControl.Location = new System.Drawing.Point(0, 0);
            this.queryDesignerTabControl.Name = "queryDesignerTabControl";
            this.queryDesignerTabControl.SelectedIndex = 0;
            this.queryDesignerTabControl.Size = new System.Drawing.Size(650, 280);
            this.queryDesignerTabControl.TabIndex = 0;
            // 
            // SelectTabPage
            // 
            this.SelectTabPage.Location = new System.Drawing.Point(4, 22);
            this.SelectTabPage.Name = "SelectTabPage";
            this.SelectTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SelectTabPage.Size = new System.Drawing.Size(642, 254);
            this.SelectTabPage.TabIndex = 0;
            this.SelectTabPage.Text = "Select";
            this.SelectTabPage.UseVisualStyleBackColor = true;
            // 
            // FilterTabPage
            // 
            this.FilterTabPage.Controls.Add(this.dataGridView1);
            this.FilterTabPage.Location = new System.Drawing.Point(4, 22);
            this.FilterTabPage.Name = "FilterTabPage";
            this.FilterTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.FilterTabPage.Size = new System.Drawing.Size(642, 254);
            this.FilterTabPage.TabIndex = 1;
            this.FilterTabPage.Text = "Filter";
            this.FilterTabPage.UseVisualStyleBackColor = true;
            // 
            // queryGroupBox
            // 
            this.queryGroupBox.Controls.Add(this.queryTabControl);
            this.queryGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.queryGroupBox.Location = new System.Drawing.Point(0, 0);
            this.queryGroupBox.Name = "queryGroupBox";
            this.queryGroupBox.Size = new System.Drawing.Size(650, 206);
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
            this.queryTabControl.Size = new System.Drawing.Size(644, 187);
            this.queryTabControl.TabIndex = 0;
            // 
            // sqlQueryTabPage
            // 
            this.sqlQueryTabPage.Controls.Add(this.sqlQueryTextBox);
            this.sqlQueryTabPage.Location = new System.Drawing.Point(4, 22);
            this.sqlQueryTabPage.Name = "sqlQueryTabPage";
            this.sqlQueryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.sqlQueryTabPage.Size = new System.Drawing.Size(636, 161);
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
            this.sqlQueryTextBox.Size = new System.Drawing.Size(630, 155);
            this.sqlQueryTextBox.TabIndex = 0;
            // 
            // resultsTabPage
            // 
            this.resultsTabPage.Location = new System.Drawing.Point(4, 22);
            this.resultsTabPage.Name = "resultsTabPage";
            this.resultsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.resultsTabPage.Size = new System.Drawing.Size(636, 161);
            this.resultsTabPage.TabIndex = 1;
            this.resultsTabPage.Text = "Results";
            this.resultsTabPage.UseVisualStyleBackColor = true;
            // 
            // toolStrip
            // 
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(3, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(208, 25);
            this.toolStrip.TabIndex = 0;
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
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
            // messagesTabPage
            // 
            this.messagesTabPage.Controls.Add(this.messagesTextBox);
            this.messagesTabPage.Location = new System.Drawing.Point(4, 22);
            this.messagesTabPage.Name = "messagesTabPage";
            this.messagesTabPage.Size = new System.Drawing.Size(636, 161);
            this.messagesTabPage.TabIndex = 2;
            this.messagesTabPage.Text = "Messages";
            this.messagesTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TableColumn,
            this.Column,
            this.Operator});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(636, 248);
            this.dataGridView1.TabIndex = 0;
            // 
            // TableColumn
            // 
            this.TableColumn.HeaderText = "Table";
            this.TableColumn.Name = "TableColumn";
            // 
            // Column
            // 
            this.Column.HeaderText = "Column";
            this.Column.Name = "Column";
            // 
            // Operator
            // 
            this.Operator.HeaderText = "Operator";
            this.Operator.Name = "Operator";
            // 
            // messagesTextBox
            // 
            this.messagesTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.messagesTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messagesTextBox.Location = new System.Drawing.Point(0, 0);
            this.messagesTextBox.Multiline = true;
            this.messagesTextBox.Name = "messagesTextBox";
            this.messagesTextBox.ReadOnly = true;
            this.messagesTextBox.Size = new System.Drawing.Size(636, 161);
            this.messagesTextBox.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 562);
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
            this.FilterTabPage.ResumeLayout(false);
            this.queryGroupBox.ResumeLayout(false);
            this.queryTabControl.ResumeLayout(false);
            this.sqlQueryTabPage.ResumeLayout(false);
            this.sqlQueryTabPage.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.messagesTabPage.ResumeLayout(false);
            this.messagesTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox objectExplorerGroupBox;
        private System.Windows.Forms.TreeView DatabaseTreeView;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.GroupBox queryDesignerGroupBox;
        private System.Windows.Forms.SplitContainer queryDesignerSplitContainer;
        private System.Windows.Forms.TabControl queryDesignerTabControl;
        private System.Windows.Forms.TabPage SelectTabPage;
        private System.Windows.Forms.TabPage FilterTabPage;
        private System.Windows.Forms.GroupBox queryGroupBox;
        private System.Windows.Forms.TabControl queryTabControl;
        private System.Windows.Forms.TabPage sqlQueryTabPage;
        private System.Windows.Forms.TabPage resultsTabPage;
        private System.Windows.Forms.TextBox sqlQueryTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewComboBoxColumn TableColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column;
        private System.Windows.Forms.DataGridViewComboBoxColumn Operator;
        private System.Windows.Forms.TabPage messagesTabPage;
        private System.Windows.Forms.TextBox messagesTextBox;
    }
}

