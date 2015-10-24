using PseudoDb.Interfaces.Metadata;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PseudoDb.ClientDesktop.Forms
{
    public partial class InsertForm : Form
    {
        private Table tableSchema;
        
        public InsertForm(Table tableSchema)
        {
            InitializeComponent();
            this.tableSchema = tableSchema;
            BuildUpTheForm();
            this.DialogResult = DialogResult.Cancel;
        }

        private void BuildUpTheForm()
        {
            const int START_Y = 40;
            const int LABEL_START_X = 12;
            const int TB_START_X = 100;
            const int DIST_BETWEEN_ELEMENTS = 25;

            var nameLabel = new Label();
            nameLabel.Text = "Attributes";
            nameLabel.Location = new Point(0, 10);
            nameLabel.BackColor = Color.FromArgb(192, 192, 192);
            nameLabel.AutoSize = true;
            var fieldLabel = new Label();
            fieldLabel.Text = "Values";
            fieldLabel.Location = new Point(TB_START_X, 10);
            fieldLabel.AutoSize = true;
            fieldLabel.BackColor = Color.FromArgb(192, 192, 192); 

            var count = tableSchema.Columns.Count;
            var labels = new Label[count];
            var textBoxes = new TextBox[count];

            for(int i = 0; i < count; ++i)
            {
                labels[i] = new Label();
                labels[i].Text = tableSchema.Columns[i].Name;
                labels[i].AutoSize = true;
                labels[i].Location = new Point(LABEL_START_X, START_Y + DIST_BETWEEN_ELEMENTS * i);

                textBoxes[i] = new TextBox();
                textBoxes[i].Size = new Size(150, textBoxes[i].Height);
                textBoxes[i].Location = new Point(TB_START_X, START_Y + DIST_BETWEEN_ELEMENTS * i);
                switch (tableSchema.Columns[i].Type)
                {
                    case DataType.Integer:
                        textBoxes[i].KeyPress += OnlyIntegers;
                        break;
                    case DataType.String:
                        break;
                }
            }

            this.Controls.Add(nameLabel);
            this.Controls.Add(fieldLabel);
            this.Controls.AddRange(textBoxes);
            this.Controls.AddRange(labels);
            
        }

        private void OnlyIntegers(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)8;
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
