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
    public partial class NewTableForm : Form
    {
        public NewTableForm()
        {
            InitializeComponent();
            CreateTableDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.CreateTableDataGridView_CellValueChanged);
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
    }
}
