namespace PseudoDb.ClientDesktop.Forms
{
    partial class TableDesignForm
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
            this.TableNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CreateTableDataGridView = new System.Windows.Forms.DataGridView();
            this.FieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIeldType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Nullable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CreateTableButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.CreateTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TableNameTextBox
            // 
            this.TableNameTextBox.Location = new System.Drawing.Point(82, 21);
            this.TableNameTextBox.Name = "TableNameTextBox";
            this.TableNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.TableNameTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Table name";
            // 
            // CreateTableDataGridView
            // 
            this.CreateTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CreateTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FieldName,
            this.FIeldType,
            this.Size,
            this.PK,
            this.Nullable});
            this.CreateTableDataGridView.Location = new System.Drawing.Point(15, 50);
            this.CreateTableDataGridView.Name = "CreateTableDataGridView";
            this.CreateTableDataGridView.Size = new System.Drawing.Size(560, 281);
            this.CreateTableDataGridView.TabIndex = 2;
            // 
            // FieldName
            // 
            this.FieldName.HeaderText = "Field name";
            this.FieldName.Name = "FieldName";
            // 
            // FIeldType
            // 
            this.FIeldType.HeaderText = "Type";
            this.FIeldType.Items.AddRange(new object[] {
            "Int",
            "String"});
            this.FIeldType.Name = "FIeldType";
            // 
            // Size
            // 
            this.Size.HeaderText = "Size";
            this.Size.Name = "Size";
            // 
            // PK
            // 
            this.PK.HeaderText = "PK";
            this.PK.Name = "PK";
            // 
            // Nullable
            // 
            this.Nullable.HeaderText = "Nullable";
            this.Nullable.Name = "Nullable";
            // 
            // CreateTableButton
            // 
            this.CreateTableButton.Location = new System.Drawing.Point(497, 337);
            this.CreateTableButton.Name = "CreateTableButton";
            this.CreateTableButton.Size = new System.Drawing.Size(75, 23);
            this.CreateTableButton.TabIndex = 3;
            this.CreateTableButton.Text = "Create";
            this.CreateTableButton.UseVisualStyleBackColor = true;
            this.CreateTableButton.Click += new System.EventHandler(this.CreateTableButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(405, 337);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // TableDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CreateTableButton);
            this.Controls.Add(this.CreateTableDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableNameTextBox);
            this.Name = "TableDesignForm";
            this.Text = "Table Design";
            ((System.ComponentModel.ISupportInitialize)(this.CreateTableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TableNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView CreateTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldName;
        private System.Windows.Forms.DataGridViewComboBoxColumn FIeldType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Nullable;
        private System.Windows.Forms.Button CreateTableButton;
        private System.Windows.Forms.Button CancelButton;
    }
}