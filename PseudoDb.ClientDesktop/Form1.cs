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
    public partial class MainForm : Form 
    {
        private TreeNode DatabaseTree;
        public MainForm()
        {
            InitializeComponent();
            LoadDatabaseTree();
        }

        private void LoadDatabaseTree()
        {
            DatabaseTree = new TreeNode("Databases");
            TreeNode[] Databases = new TreeNode[5];

            for (int i = 0; i < Databases.Length; ++i)
            {
                Databases[i] = new TreeNode();
                Databases[i].Text = "DB "+i;
                TreeNode[] Tables = new TreeNode[3];
                for (int j = 0; j < Tables.Length; ++j)
                {
                    Tables[j] = new TreeNode();
                    Tables[j].Text = "Table " + j;
                }
                Databases[i].Nodes.AddRange(Tables);
            }
            DatabaseTree.Nodes.AddRange(Databases);

            //add the created treeNodes to the databaseTreeView
            DatabaseTreeView.Nodes.Add(DatabaseTree);
            DatabaseTreeView.Refresh();

            //Add event handlers
            DatabaseTreeView.NodeMouseClick += DatabaseTreeView_NodeMouseClick;
        }

        private void DatabaseTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode sendeNode = ((TreeView)sender).SelectedNode;
            if (e.Button == MouseButtons.Right)
            {
                //determine on which level was clicked
                int clickLevel = e.Node.Level;
                MessageBox.Show("Right clicked "+clickLevel);
                switch(clickLevel)
                {
                    case 0://the root node
                        //TODO implement the right click pop up menu with the create new db option
                        break;
                    case 1://database node
                        //TODO implement the right click pop up menu with the crate new table option
                        break;
                    case 2://table node
                        break;
                }
            }
            //select the currently clicked item in the view
            DatabaseTreeView.SelectedNode = e.Node;
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
