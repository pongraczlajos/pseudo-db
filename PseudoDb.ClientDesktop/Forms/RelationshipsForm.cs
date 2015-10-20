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
    public partial class RelationshipsForm : Form
    {
        private DatabaseContext dbContext;

        private Database database;

        private string tableName;

        private List<string> tableNames;

        private RelationshipsForm()
        {
        }

        public RelationshipsForm(DatabaseContext dbContext, Database database, string tableName)
        {
            InitializeComponent();

            this.dbContext = dbContext;
            this.tableName = tableName;
            this.database = database;

            removeButton.Enabled = false;

            tableNames = new List<string>();
            foreach (var table in database.Tables)
            {
                tableNames.Add(table.Name);
            }

            parentComboBox.Items.AddRange(tableNames.ToArray());
            childComboBox.Items.AddRange(tableNames.ToArray());

            relationshipsListBox.Items.AddRange(database.GetAssociationsWhereTableIsParent(tableName).Select(a => a.Name).ToArray());
            relationshipsListBox.Items.AddRange(database.GetAssociationsWhereTableIsChild(tableName).Select(a => a.Name).ToArray());
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                var association = new Association();
                association.Name = relNameTextBox.Text;
                association.Parent = parentComboBox.SelectedItem.ToString();
                association.Child = childComboBox.SelectedItem.ToString();

                for (int i = 0; i < relDataGridView.Rows.Count - 1; i++)
                {
                    association.ColumnMappings[relDataGridView.Rows[i].Cells[0].Value.ToString()] = relDataGridView.Rows[i].Cells[1].Value.ToString();
                }

                database.Associations.Add(association);
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("Complete all cells!\n!" + exception.Message);
            }

            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            removeButton.Enabled = false;

            relNameTextBox.Enabled = true;
            relNameTextBox.Text = string.Empty;

            parentComboBox.Enabled = true;
            parentComboBox.Items.Clear();
            parentComboBox.Items.AddRange(tableNames.ToArray());

            childComboBox.Enabled = true;
            childComboBox.Items.Clear();
            childComboBox.Items.AddRange(tableNames.ToArray());

            relDataGridView.Rows.Clear();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            removeButton.Enabled = false;

            database.RemoveAssociation(relationshipsListBox.SelectedItem.ToString());
            dbContext.SchemaQuery.UpdateDatabase(database.Name);

            relationshipsListBox.Items.Clear();
            relationshipsListBox.Items.AddRange(database.GetAssociationsWhereTableIsParent(tableName).Select(a => a.Name).ToArray());
            relationshipsListBox.Items.AddRange(database.GetAssociationsWhereTableIsChild(tableName).Select(a => a.Name).ToArray());
        }

        private void parentComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTable = parentComboBox.SelectedItem.ToString();
            relDataGridView.Rows.Clear();

            ((DataGridViewComboBoxColumn)relDataGridView.Columns["Parent"]).Items.Clear();
            ((DataGridViewComboBoxColumn)relDataGridView.Columns["Parent"]).Items.AddRange(database.GetTable(selectedTable).Columns.Select(c => c.Name).ToArray());
        }

        private void childComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedTable = childComboBox.SelectedItem.ToString();
            relDataGridView.Rows.Clear();

            ((DataGridViewComboBoxColumn)relDataGridView.Columns["Child"]).Items.Clear();
            ((DataGridViewComboBoxColumn)relDataGridView.Columns["Child"]).Items.AddRange(database.GetTable(selectedTable).Columns.Select(c => c.Name).ToArray());
        }

        private void relationshipsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var association = database.GetAssociation(relationshipsListBox.SelectedItem.ToString());
            removeButton.Enabled = true;

            relNameTextBox.Enabled = false;
            relNameTextBox.Text = association.Name;

            parentComboBox.Enabled = false;
            parentComboBox.SelectedItem = association.Parent;

            childComboBox.Enabled = false;
            childComboBox.SelectedItem = association.Child;

            relDataGridView.Rows.Clear();
            relDataGridView.Rows.Add(association.ColumnMappings.Count);

            int index = 0;
            foreach (var mapping in association.ColumnMappings)
            {
                relDataGridView.Rows[index].Cells[0].Value = mapping.Key;
                relDataGridView.Rows[index].Cells[1].Value = mapping.Value;

                index++;
            }
        }
    }
}
