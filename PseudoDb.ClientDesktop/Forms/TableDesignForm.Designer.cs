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
            this.TableDataGridView = new System.Windows.Forms.DataGridView();
            this.SaveTableButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.relationshipsButton = new System.Windows.Forms.Button();
            this.FieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FIeldType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PK = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Unique = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Nullable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TableDataGridView)).BeginInit();
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
            // TableDataGridView
            // 
            this.TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FieldName,
            this.FIeldType,
            this.Size,
            this.PK,
            this.Unique,
            this.Nullable});
            this.TableDataGridView.Location = new System.Drawing.Point(15, 50);
            this.TableDataGridView.Name = "TableDataGridView";
            this.TableDataGridView.Size = new System.Drawing.Size(647, 281);
            this.TableDataGridView.TabIndex = 2;
            // 
            // SaveTableButton
            // 
            this.SaveTableButton.Location = new System.Drawing.Point(587, 337);
            this.SaveTableButton.Name = "SaveTableButton";
            this.SaveTableButton.Size = new System.Drawing.Size(75, 23);
            this.SaveTableButton.TabIndex = 3;
            this.SaveTableButton.Text = "Save";
            this.SaveTableButton.UseVisualStyleBackColor = true;
            this.SaveTableButton.Click += new System.EventHandler(this.SaveTableButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(506, 337);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // relationshipsButton
            // 
            this.relationshipsButton.Location = new System.Drawing.Point(576, 19);
            this.relationshipsButton.Name = "relationshipsButton";
            this.relationshipsButton.Size = new System.Drawing.Size(86, 23);
            this.relationshipsButton.TabIndex = 5;
            this.relationshipsButton.Text = "Relationships";
            this.relationshipsButton.UseVisualStyleBackColor = true;
            this.relationshipsButton.Click += new System.EventHandler(this.relationshipsButton_Click);
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
            // Unique
            // 
            this.Unique.HeaderText = "Unique";
            this.Unique.Name = "Unique";
            // 
            // Nullable
            // 
            this.Nullable.HeaderText = "Nullable";
            this.Nullable.Name = "Nullable";
            // 
            // TableDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 364);
            this.Controls.Add(this.relationshipsButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveTableButton);
            this.Controls.Add(this.TableDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableNameTextBox);
            this.Name = "TableDesignForm";
            this.Text = "Table Design";
            ((System.ComponentModel.ISupportInitialize)(this.TableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TableNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TableDataGridView;
        private System.Windows.Forms.Button SaveTableButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button relationshipsButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldName;
        private System.Windows.Forms.DataGridViewComboBoxColumn FIeldType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PK;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Unique;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Nullable;
    }
}