using PseudoDb.Engine;
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
        private DatabaseContext dbContext;

        private Database database;

        private Table tableSchema;

        private int count;

        private Label[] labels;

        private TextBox[] textBoxes;
        
        public InsertForm(DatabaseContext dbContext, Database database, Table tableSchema)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.database = database;
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

            count = tableSchema.Columns.Count;
            labels = new Label[count];
            textBoxes = new TextBox[count];

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
            var keyMembers = new List<string>();
            var values = new List<string>();

            foreach (var keyMember in tableSchema.PrimaryKey)
            {
                var index = 0;

                foreach (var label in labels)
                {
                    if (label.Text.Equals(keyMember))
                    {
                        break;
                    }

                    index++;
                }

                keyMembers.Add(textBoxes[index].Text);
            }

            foreach (var column in tableSchema.Columns)
            {
                if (!tableSchema.PrimaryKey.Contains(column.Name))
                {
                    var index = 0;

                    foreach (var label in labels)
                    {
                        if (label.Text.Equals(column.Name))
                        {
                            break;
                        }

                        index++;
                    }

                    values.Add(textBoxes[index].Text);
                }
            }

            dbContext.Query.Insert(database, tableSchema, keyMembers, values);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
