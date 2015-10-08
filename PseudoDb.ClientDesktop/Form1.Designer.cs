namespace PseudoDb.ClientDesktop
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
            this.DatabaseTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // DatabaseTreeView
            // 
            this.DatabaseTreeView.Location = new System.Drawing.Point(3, 24);
            this.DatabaseTreeView.Name = "DatabaseTreeView";
            this.DatabaseTreeView.Size = new System.Drawing.Size(163, 325);
            this.DatabaseTreeView.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 389);
            this.Controls.Add(this.DatabaseTreeView);
            this.Name = "MainForm";
            this.Text = "PseudoDBClient";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView DatabaseTreeView;
    }
}

