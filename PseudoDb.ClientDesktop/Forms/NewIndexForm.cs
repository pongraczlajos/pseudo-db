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
    public partial class NewIndexForm : Form
    {
        private DatabaseContext dbContext;

        private Database database;

        private Table tableSchema;

        private NewIndexForm()
        {
        }

        public NewIndexForm(DatabaseContext dbContext, Database database, Table tableSchema)
        {
            InitializeComponent();
            this.dbContext = dbContext;
            this.database = database;
            this.tableSchema = tableSchema;
            ((DataGridViewComboBoxColumn)IndexDataGridView.Columns["Column"]).Items.AddRange(tableSchema.Columns.Select(c => c.Name).ToArray());

            this.DialogResult = DialogResult.Cancel;
        }

        private void createIndexButton_Click(object sender, EventArgs e)
        {
            try
            {
                Index index = new Index();
                index.Name = string.Format("{0}_Index_{1}", tableSchema.Name, tableSchema.Indexes.Count + 1);

                for (int i = 0; i < IndexDataGridView.Rows.Count - 1; i++)
                {
                    index.IndexMembers.Add(IndexDataGridView.Rows[i].Cells[0].Value.ToString());
                }

                index.Unique = uniqueCheckBox.Checked;

                tableSchema.Indexes.Add(index);
                dbContext.SchemaQuery.UpdateDatabase(database.Name);
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("Complete all cells!\n" + exception.Message);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
