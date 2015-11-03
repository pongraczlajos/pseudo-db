using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;
using System;
using PseudoDb.Interfaces.Metadata;
using PseudoDb.Engine;
using System.Resources;
using System.Reflection;
using PseudoDb.ClientDesktop.Properties;

namespace PseudoDb.ClientDesktop.Forms
{
    public partial class TableDesignForm : Form
    {
        private Table table;

        private Database database;

        private DatabaseContext dbContext;

        private TableDesignForm()
        {
        }

        public Table GetTable()
        {
            return table;
        }

        public TableDesignForm(DatabaseContext dbContext, Database database, Table table = null)
        {
            InitializeComponent();

            this.dbContext = dbContext;
            this.database = database;
            DialogResult = DialogResult.Cancel;
            TableDataGridView.CellValueChanged += new DataGridViewCellEventHandler(CreateTableDataGridView_CellValueChanged);
            TableDataGridView.DataError += CreateTableDataGridView_DataError;

            if (table != null)
            {
                TableNameTextBox.Text = table.Name;
                TableNameTextBox.Enabled = false;
                TableDataGridView.Rows.Add(table.Columns.Count);

                int index = 0;
                foreach (var column in table.Columns)
                {
                    TableDataGridView.Rows[index].Cells[0].Value = column.Name;
                    TableDataGridView.Rows[index].Cells[1].Value = DataTypeConverter.ToComboType(column.Type);
                    TableDataGridView.Rows[index].Cells[2].Value = column.Size;

                    if (table.PrimaryKey.Contains(column.Name))
                    {
                        TableDataGridView.Rows[index].Cells[3].Value = true;
                    }
                    else
                    {
                        TableDataGridView.Rows[index].Cells[3].Value = false;
                    }

                    if (column.Nullable)
                    {
                        TableDataGridView.Rows[index].Cells[4].Value = true;
                    }
                    else
                    {
                        TableDataGridView.Rows[index].Cells[4].Value = false;
                    }

                    index++;
                }
            }
            else
            {
                relationshipsButton.Enabled = false;
            }
        }

        private void CreateTableDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //0,4->table cb, 0,5->references cb
            /*if(e.ColumnIndex == 3)//FK cell
            {
                CreateTableDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].ReadOnly = !CreateTableDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].ReadOnly;
                CreateTableDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].ReadOnly = !CreateTableDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].ReadOnly;
                CreateTableDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = "";
                CreateTableDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex + 2].Value = "";

            }
            else
            if(e.ColumnIndex == 4)//table cb cell
            {
                DataGridViewComboBoxCell cbCell = (DataGridViewComboBoxCell)CreateTableDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex+1];
                var value = CreateTableDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                cbCell.Items.Clear();
                cbCell.Items.Add(value+".alma");
                cbCell.Items.Add(value+".korte");
            }*/
        }

        private void CreateTableDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
        }

        private void SaveTableButton_Click(object sender, System.EventArgs e)
        {
            //TODO: validate inputs
                       
            var tableName = TableNameTextBox.Text.ToString();
            if (string.IsNullOrEmpty(tableName))
            {
                MessageBox.Show(Resources.ResourceManager.GetString("MissingTableName"));
                return;
            }

            var result = database.Tables.Find(t => t.Name.Equals(tableName));
            if(result != null)
            {
                MessageBox.Show(Resources.ResourceManager.GetString("TableNameTaked"));
                return;
            }


            table = new Table();
            table.Name = tableName;

            try
            {
                for (int i = 0; i < TableDataGridView.Rows.Count - 1; i++)
                {

                    Column column = new Column();
                    column.Name = TableDataGridView.Rows[i].Cells[0].Value.ToString();
                    column.Type = DataTypeConverter.ToDataType(TableDataGridView.Rows[i].Cells[1].Value.ToString());
                    column.Size = Int32.Parse(TableDataGridView.Rows[i].Cells[2].Value.ToString());
                    bool isPrimaryKey = (bool) ((DataGridViewCheckBoxCell) TableDataGridView.Rows[i].Cells[3]).FormattedValue;
                    column.Nullable = (bool) ((DataGridViewCheckBoxCell) TableDataGridView.Rows[i].Cells[4]).FormattedValue;

                    if (isPrimaryKey)
                    {
                        table.PrimaryKey.Add(column.Name);
                    }

                    table.Columns.Add(column);
                }

                if (database.GetTable(table.Name) != null)
                {
                    database.RemoveTable(table.Name);
                }

                database.Tables.Add(table);
            }
            catch (NullReferenceException exception)
            {
                MessageBox.Show("Complete all cells!\n!" + exception.Message);
            }

            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, System.EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void relationshipsButton_Click(object sender, EventArgs e)
        {
            var relationshipsForm = new RelationshipsForm(dbContext, database, TableNameTextBox.Text);
            relationshipsForm.ShowDialog(this);

            switch (relationshipsForm.DialogResult)
            {
                case DialogResult.OK:
                    dbContext.SchemaQuery.UpdateDatabase(database.Name);
                    break;
                default:
                    break;
            }
        }
    }
}
