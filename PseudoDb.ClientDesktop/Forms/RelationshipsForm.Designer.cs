namespace PseudoDb.ClientDesktop.Forms
{
    partial class RelationshipsForm
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
            this.relationshipsListBox = new System.Windows.Forms.ListBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.relNameLabel = new System.Windows.Forms.Label();
            this.relNameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.parentLabel = new System.Windows.Forms.Label();
            this.ChildLabel = new System.Windows.Forms.Label();
            this.relDataGridView = new System.Windows.Forms.DataGridView();
            this.Parent = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Child = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.parentComboBox = new System.Windows.Forms.ComboBox();
            this.childComboBox = new System.Windows.Forms.ComboBox();
            this.removeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.relDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // relationshipsListBox
            // 
            this.relationshipsListBox.FormattingEnabled = true;
            this.relationshipsListBox.Location = new System.Drawing.Point(9, 10);
            this.relationshipsListBox.Name = "relationshipsListBox";
            this.relationshipsListBox.Size = new System.Drawing.Size(150, 342);
            this.relationshipsListBox.TabIndex = 0;
            this.relationshipsListBox.SelectedIndexChanged += new System.EventHandler(this.relationshipsListBox_SelectedIndexChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(497, 328);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 1;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(416, 328);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // relNameLabel
            // 
            this.relNameLabel.AutoSize = true;
            this.relNameLabel.Location = new System.Drawing.Point(178, 13);
            this.relNameLabel.Name = "relNameLabel";
            this.relNameLabel.Size = new System.Drawing.Size(96, 13);
            this.relNameLabel.TabIndex = 3;
            this.relNameLabel.Text = "Relationship Name";
            // 
            // relNameTextBox
            // 
            this.relNameTextBox.Location = new System.Drawing.Point(280, 10);
            this.relNameTextBox.Name = "relNameTextBox";
            this.relNameTextBox.Size = new System.Drawing.Size(140, 20);
            this.relNameTextBox.TabIndex = 4;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(497, 8);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // parentLabel
            // 
            this.parentLabel.AutoSize = true;
            this.parentLabel.Location = new System.Drawing.Point(178, 39);
            this.parentLabel.Name = "parentLabel";
            this.parentLabel.Size = new System.Drawing.Size(38, 13);
            this.parentLabel.TabIndex = 6;
            this.parentLabel.Text = "Parent";
            // 
            // ChildLabel
            // 
            this.ChildLabel.AutoSize = true;
            this.ChildLabel.Location = new System.Drawing.Point(178, 65);
            this.ChildLabel.Name = "ChildLabel";
            this.ChildLabel.Size = new System.Drawing.Size(30, 13);
            this.ChildLabel.TabIndex = 7;
            this.ChildLabel.Text = "Child";
            // 
            // relDataGridView
            // 
            this.relDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.relDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Parent,
            this.Child});
            this.relDataGridView.Location = new System.Drawing.Point(181, 94);
            this.relDataGridView.Name = "relDataGridView";
            this.relDataGridView.Size = new System.Drawing.Size(391, 228);
            this.relDataGridView.TabIndex = 8;
            // 
            // Parent
            // 
            this.Parent.HeaderText = "Parent";
            this.Parent.Name = "Parent";
            // 
            // Child
            // 
            this.Child.HeaderText = "Child";
            this.Child.Name = "Child";
            // 
            // parentComboBox
            // 
            this.parentComboBox.FormattingEnabled = true;
            this.parentComboBox.Location = new System.Drawing.Point(280, 36);
            this.parentComboBox.Name = "parentComboBox";
            this.parentComboBox.Size = new System.Drawing.Size(141, 21);
            this.parentComboBox.TabIndex = 9;
            this.parentComboBox.SelectedIndexChanged += new System.EventHandler(this.parentComboBox_SelectedIndexChanged);
            // 
            // childComboBox
            // 
            this.childComboBox.FormattingEnabled = true;
            this.childComboBox.Location = new System.Drawing.Point(280, 62);
            this.childComboBox.Name = "childComboBox";
            this.childComboBox.Size = new System.Drawing.Size(141, 21);
            this.childComboBox.TabIndex = 10;
            this.childComboBox.SelectedIndexChanged += new System.EventHandler(this.childComboBox_SelectedIndexChanged);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(497, 34);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 11;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // RelationshipsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 362);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.childComboBox);
            this.Controls.Add(this.parentComboBox);
            this.Controls.Add(this.relDataGridView);
            this.Controls.Add(this.ChildLabel);
            this.Controls.Add(this.parentLabel);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.relNameTextBox);
            this.Controls.Add(this.relNameLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.relationshipsListBox);
            this.Name = "RelationshipsForm";
            this.Text = "Relationships";
            ((System.ComponentModel.ISupportInitialize)(this.relDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox relationshipsListBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label relNameLabel;
        private System.Windows.Forms.TextBox relNameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label parentLabel;
        private System.Windows.Forms.Label ChildLabel;
        private System.Windows.Forms.DataGridView relDataGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn Parent;
        private System.Windows.Forms.DataGridViewComboBoxColumn Child;
        private System.Windows.Forms.ComboBox parentComboBox;
        private System.Windows.Forms.ComboBox childComboBox;
        private System.Windows.Forms.Button removeButton;
    }
}