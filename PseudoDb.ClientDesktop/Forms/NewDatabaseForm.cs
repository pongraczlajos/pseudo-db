using PseudoDb.Engine;
using PseudoDb.Interfaces.Metadata;
using System;
using System.Windows.Forms;

namespace PseudoDb.ClientDesktop.Forms
{
    public partial class NewDatabaseForm : Form
    {
        private DatabaseContext dbContext;

        // TODO: handle wrong imputs.
        public Database Database { get; set; }

        private NewDatabaseForm()
        {
        }

        public NewDatabaseForm(DatabaseContext dbContext)
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Ignore;
            this.dbContext = dbContext;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            string databaseName = databaseNameTextBox.Text.ToString();

            dbContext.SchemaQuery.AddDatabase(databaseName);
            Database = dbContext.SchemaQuery.GetDatabase(databaseName);

            this.DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
