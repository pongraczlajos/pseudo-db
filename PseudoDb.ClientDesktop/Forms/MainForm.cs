using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PseudoDb.Engine;
using PseudoDb.Interfaces.Metadata;

namespace PseudoDb.ClientDesktop.Forms
{
    public partial class MainForm : Form 
    {
        private TreeNode DatabaseTree;
        private List<Database> databases;
        private DbEngine Engine = new DbEngine();


        public MainForm()
        {
            InitializeComponent();
            databases = Engine.GetDatabases();//db_engine call
            BuildDatabaseTree();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void BuildDatabaseTree()
        {
            DatabaseTree = new TreeNode("Databases");

            foreach(var db in databases)
            {
                TreeNode dbNode = new TreeNode(db.Name);
                foreach(var table in db.Tables)
                {
                    TreeNode tbNode = new TreeNode(table.Name);
                    dbNode.Nodes.Add(tbNode);
                }
                DatabaseTree.Nodes.Add(dbNode);
            }

            DatabaseTreeView.Nodes.Add(DatabaseTree);
            DatabaseTreeView.Refresh();

            //Add event handlers
            DatabaseTreeView.NodeMouseClick += DatabaseTreeView_NodeMouseClick;

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
            //select the currently clicked item in the view
            DatabaseTreeView.SelectedNode = e.Node;

            if (e.Button == MouseButtons.Right)
            {
                //determine on which level was clicked
                int clickLevel = e.Node.Level;
                ContextMenuStrip rightClickMenu = new ContextMenuStrip();
                switch(clickLevel)
                {
                    case 0://the root node
                        ToolStripMenuItem item1 = new ToolStripMenuItem("Create new database");
                        item1.Click += OnCreateNewDbMenuItemClick;
                        rightClickMenu.Items.Add(item1);
                        break;
                    case 1://database node
                        ToolStripMenuItem item2 = new ToolStripMenuItem("Create new table");
                        item2.Click += OnCreateNewTableMenuItemClick;
                        rightClickMenu.Items.Add(item2);
                        break;
                    case 2://table node
                        break;
                }
                if(rightClickMenu.Items.Count > 0)
                {
                    rightClickMenu.Show(this, e.X, e.Y+30);
                }
            }
        }

        private void OnCreateNewTableMenuItemClick(object sender, EventArgs e)
        {
            var newTableForm = new TableDesignForm(DatabaseTreeView.SelectedNode.Text.ToString());
            newTableForm.ShowDialog(this);
            switch (newTableForm.DialogResult) {
                case DialogResult.OK:
                    PseudoDb.Interfaces.Metadata.Table tb = newTableForm.GetTable();
                    //TODO: test if this table can be created, and add to this db
                    databases.Find(a => a.Name == DatabaseTreeView.SelectedNode.Text.ToString()).Tables.Add(tb);
                    
                    foreach(TreeNode node in DatabaseTree.Nodes)
                    {
                        if (node.Text.Equals(DatabaseTreeView.SelectedNode.Text.ToString()))
                        {
                            node.Nodes.Add(new TreeNode(tb.Name));
                            break;//foreach
                        }
                    }
                    break;//switch
                default:
                    break;
            }

        }

        private void OnCreateNewDbMenuItemClick(object sender, EventArgs e)
        {
            NewDatabaseForm newDatabaseForm = new NewDatabaseForm();
            newDatabaseForm.ShowDialog(this);
            switch (newDatabaseForm.DialogResult)
            {
                case DialogResult.OK:
                    //TODO: Test if this database can be create!
                    DatabaseTree.Nodes.Add(new TreeNode(newDatabaseForm.DatabaseName));
                    databases.Add(new Interfaces.Metadata.Database(newDatabaseForm.DatabaseName));
                    break;
                case DialogResult.Cancel:
                    MessageBox.Show("Cancel");
                    break;
            }
        }
    }
}
