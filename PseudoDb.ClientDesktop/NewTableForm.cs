using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PseudoDb.ClientDesktop
{
    public partial class NewTableForm : Form
    {
        public NewTableForm()
        {
            InitializeComponent();
            foreach(var col in CreateTableDataGridView.Columns)
            {
                
            }
        }
    }
}
