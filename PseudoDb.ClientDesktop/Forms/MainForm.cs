using PseudoDb.Engine;
using PseudoDb.Interfaces.Metadata;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PseudoDb.ClientDesktop.Forms
{
    public partial class MainForm : Form 
    {
        private TreeNode DatabaseTree;

        private DatabaseContext dbContext;

        public MainForm()
        {
            InitializeComponent();

            dbContext = new DatabaseContext();

            BuildDatabaseTree();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void BuildDatabaseTree()
        {
            DatabaseTree = new TreeNode("Databases");

            foreach(var database in dbContext.SchemaQuery.GetDatabases())
            {
                TreeNode dbNode = new TreeNode(database.Name);

                foreach(var table in database.Tables)
                {
                    TreeNode tbNode = new TreeNode(table.Name);
                    dbNode.Nodes.Add(tbNode);
                }

                DatabaseTree.Nodes.Add(dbNode);
            }

            DatabaseTreeView.Nodes.Add(DatabaseTree);
            DatabaseTreeView.Refresh();

            // Add event handlers.
            DatabaseTreeView.NodeMouseClick += DatabaseTreeView_NodeMouseClick;
        }

        private void DatabaseTreeView_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Select the currently clicked item in the tree view.
            TreeNode sendeNode = ((TreeView)sender).SelectedNode;
            DatabaseTreeView.SelectedNode = e.Node;

            if (e.Button == MouseButtons.Right)
            {
                // Determine on which level was clicked.
                int clickLevel = e.Node.Level;
                ContextMenuStrip rightClickMenu = new ContextMenuStrip();

                switch(clickLevel)
                {
                    // Root node
                    case 0:
                        ToolStripMenuItem createDbItem = new ToolStripMenuItem("Create new database");
                        createDbItem.Click += OnCreateNewDbMenuItemClick;
                        rightClickMenu.Items.Add(createDbItem);
                        break;

                    // Database node
                    case 1:
                        ToolStripMenuItem createTableItem = new ToolStripMenuItem("Create new table");
                        createTableItem.Click += OnCreateNewTableMenuItemClick;
                        rightClickMenu.Items.Add(createTableItem);
                        break;

                    // Table node
                    case 2:
                        ToolStripMenuItem designTableItem = new ToolStripMenuItem("Design table");
                        designTableItem.Click += OnDesignTableMenuItemClick;
                        rightClickMenu.Items.Add(designTableItem);
                        break;
                }

                if (rightClickMenu.Items.Count > 0)
                {
                    rightClickMenu.Show(this, e.X, e.Y + 30);
                }
            }
        }

        private void OnCreateNewTableMenuItemClick(object sender, EventArgs e)
        {
            Database database = dbContext.SchemaQuery.GetDatabase(DatabaseTreeView.SelectedNode.Text.ToString());
            var newTableForm = new TableDesignForm(database);
            newTableForm.ShowDialog(this);

            switch (newTableForm.DialogResult) {
                case DialogResult.OK:
                    dbContext.SchemaQuery.UpdateDatabase(database.Name);
                    Table table = newTableForm.GetTable();

                    foreach(TreeNode node in DatabaseTree.Nodes)
                    {
                        if (node.Text.Equals(DatabaseTreeView.SelectedNode.Text.ToString()))
                        {
                            node.Nodes.Add(new TreeNode(table.Name));
                            break;
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void OnCreateNewDbMenuItemClick(object sender, EventArgs e)
        {
            NewDatabaseForm newDatabaseForm = new NewDatabaseForm(dbContext);
            newDatabaseForm.ShowDialog(this);

            switch (newDatabaseForm.DialogResult)
            {
                case DialogResult.OK:
                    // TODO: Test if this database can be created!
                    if (newDatabaseForm.Database != null)
                    {
                        DatabaseTree.Nodes.Add(new TreeNode(newDatabaseForm.Database.Name));
                    }
                    else
                    {
                        MessageBox.Show("Database creation failed!", "Database creation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case DialogResult.Cancel:
                    //MessageBox.Show("Cancel");
                    break;
            }
        }

        private void OnDesignTableMenuItemClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
