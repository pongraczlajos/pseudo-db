namespace PseudoDb.ClientDesktop.Forms
{
    partial class NewIndexForm
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
            this.IndexDataGridView = new System.Windows.Forms.DataGridView();
            this.createIndexButton = new System.Windows.Forms.Button();
            this.Column = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.uniqueCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.IndexDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // IndexDataGridView
            // 
            this.IndexDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.IndexDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column});
            this.IndexDataGridView.Location = new System.Drawing.Point(12, 12);
            this.IndexDataGridView.Name = "IndexDataGridView";
            this.IndexDataGridView.Size = new System.Drawing.Size(260, 309);
            this.IndexDataGridView.TabIndex = 0;
            // 
            // createIndexButton
            // 
            this.createIndexButton.Location = new System.Drawing.Point(196, 327);
            this.createIndexButton.Name = "createIndexButton";
            this.createIndexButton.Size = new System.Drawing.Size(75, 23);
            this.createIndexButton.TabIndex = 1;
            this.createIndexButton.Text = "Create";
            this.createIndexButton.UseVisualStyleBackColor = true;
            this.createIndexButton.Click += new System.EventHandler(this.createIndexButton_Click);
            // 
            // Column
            // 
            this.Column.HeaderText = "Column";
            this.Column.Name = "Column";
            // 
            // uniqueCheckBox
            // 
            this.uniqueCheckBox.AutoSize = true;
            this.uniqueCheckBox.Location = new System.Drawing.Point(13, 332);
            this.uniqueCheckBox.Name = "uniqueCheckBox";
            this.uniqueCheckBox.Size = new System.Drawing.Size(60, 17);
            this.uniqueCheckBox.TabIndex = 2;
            this.uniqueCheckBox.Text = "Unique";
            this.uniqueCheckBox.UseVisualStyleBackColor = true;
            // 
            // NewIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 362);
            this.Controls.Add(this.uniqueCheckBox);
            this.Controls.Add(this.createIndexButton);
            this.Controls.Add(this.IndexDataGridView);
            this.Name = "NewIndexForm";
            this.Text = "New Index";
            ((System.ComponentModel.ISupportInitialize)(this.IndexDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView IndexDataGridView;
        private System.Windows.Forms.Button createIndexButton;
        private System.Windows.Forms.DataGridViewComboBoxColumn Column;
        private System.Windows.Forms.CheckBox uniqueCheckBox;
    }
}