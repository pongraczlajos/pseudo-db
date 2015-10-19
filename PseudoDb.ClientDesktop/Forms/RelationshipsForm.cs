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
        private RelationshipsForm()
        {
        }

        public RelationshipsForm(string tableName)
        {
            InitializeComponent();
        }
    }
}
