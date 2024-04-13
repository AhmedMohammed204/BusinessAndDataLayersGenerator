using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BusinessAndDataLayersGenerator
{
    
    public partial class frmAutoFill : Form
    {
        clsDatabaseData dbData;

        public frmAutoFill()
        {
            InitializeComponent();
        }
        

        void _LoadData()
        {

            List<string> list = clsDatabaseData.GetAllTables(cbDatabase.Text,txtUsername.Text, txtPassword.Text);
            clsDatabaseData.Fill_CB(list, cbTable);
        }

        private void frmAutoFill_Load(object sender, EventArgs e)
        {

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            _LoadData();
        }
        public delegate void TableFoundEventHandler(bool IsFound, clsDatabaseData dbData = null);
        public event TableFoundEventHandler TableSelected;
        private void button2_Click(object sender, EventArgs e)
        {
            TableSelected?.Invoke(false);
            this.Close();
        }
        bool IsValidToSave()
        {
            if (string.IsNullOrEmpty(cbTable.Text))
            {
                MessageBox.Show("Make sure that check a table");
                return false;

            }

            if (string.IsNullOrEmpty(cbDatabase.Text))
            {
                MessageBox.Show("You have to write a database name");
                return false;
            }

            if (string.IsNullOrEmpty(txtTableSingleName.Text))
            {
                MessageBox.Show("You have to write a single name for your table");
                return false;
            }

            return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsValidToSave())
                return;

            dbData = new clsDatabaseData();
            dbData.TableName = cbTable.Text;
            dbData.DataBaseName = cbDatabase.Text;
            dbData.TableSingleName = txtTableSingleName.Text;
            dbData.Username = txtUsername.Text;
            dbData.Password = txtPassword.Text;


            TableSelected?.Invoke(true, dbData);
            this.Close();
        }

        private void btnFindDatabase_Click(object sender, EventArgs e)
        {
            List<string> list = clsDatabaseData.GetAllDatabases(txtUsername.Text, txtPassword.Text);
            clsDatabaseData.Fill_CB(list, cbDatabase);
        }
    }
}
