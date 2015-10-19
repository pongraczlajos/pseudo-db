using System.Collections.Generic;
using System.Windows.Forms;
using System.Collections;
using System;
using PseudoDb.Interfaces.Metadata;

namespace PseudoDb.ClientDesktop.Forms
{
    public partial class TableDesignForm : Form
    {
        private Table table { get; set; }

        private String DatabaseName;

        private TableDesignForm()
        {
        }

        public Table GetTable()
        {
            return table;
        }

        public TableDesignForm(string DatabaseName)
        {
            InitializeComponent();

            this.DatabaseName = DatabaseName;
            DialogResult = DialogResult.Cancel;
            CreateTableDataGridView.CellValueChanged += new DataGridViewCellEventHandler(CreateTableDataGridView_CellValueChanged);
            CreateTableDataGridView.DataError += CreateTableDataGridView_DataError;
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

            table = new Table();
            table.Name = TableNameTextBox.Text.ToString();

            try
            {
                for (int i = 0; i < CreateTableDataGridView.Rows.Count - 1; i++)
                {

                    Column column = new Column();
                    column.Name = CreateTableDataGridView.Rows[i].Cells[0].Value.ToString();
                    column.Type = DataTypeConverter.ToDataType(CreateTableDataGridView.Rows[i].Cells[1].Value.ToString());
                    column.Size = Int32.Parse(CreateTableDataGridView.Rows[i].Cells[2].Value.ToString());
                    bool pk = (bool)((DataGridViewCheckBoxCell)CreateTableDataGridView.Rows[i].Cells[3]).FormattedValue;
                    column.Nullable = (bool)((DataGridViewCheckBoxCell)CreateTableDataGridView.Rows[i].Cells[4]).FormattedValue;

                    if (pk)
                    {
                        table.PrimaryKey.Add(column.Name);
                    }

                    table.Columns.Add(column);

                }
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
            var relationshipsForm = new RelationshipsForm("table name");
        }
    }
}
