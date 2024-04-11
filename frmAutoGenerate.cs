using Generator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessAndDataLayersGenerator
{
    public partial class frmAutoGenerate : Form
    {
        public frmAutoGenerate()
        {
            InitializeComponent();
        }
        List<clsColumn> ColumnsList;
        string TableSingleName;
        bool UsingDataAccessClass = true;
        void FillcbDatabase(List<string> list)
        {
            cbDatabase.Items.Clear();
            foreach (string Database in list)
            {
                cbDatabase.Items.Add(Database);
            }
        }
        void FindDatabase()
        {

            List<string> list = new List<string>();
            list = clsDatabaseData.GetAllDatabases(txtUsername.Text, txtPassword.Text);
            if (list == null)
                return;
            FillcbDatabase(list);

        }
        private void btnFindDatabase_Click(object sender, EventArgs e)
        {
            FindDatabase();
        }
        void CreateBusinessLayerFile(string TableName)
        {
            string FilePath = $@"{txtBusinessLayer.Text}/cls{TableSingleName}.cs";
            string BusinessClassTxt = clsGenerateBusinessLayer.Generate(TableName, TableSingleName, ColumnsList);

            File.WriteAllText(FilePath, BusinessClassTxt);
        }
        void CreateDataAccessLayerFile(string TableName)
        {
            string FilePath = $@"{txtDataLayer.Text}/cls{TableSingleName}DataAccessLayer.cs";
            string DataAccessClassTxt = clsGenerateDataLayer.Generate(TableName, TableSingleName, ColumnsList, UsingDataAccessClass).ToString();
            UsingDataAccessClass = false;
            File.WriteAllText(FilePath, DataAccessClassTxt);
        }
        void PerformColumnsList(string TableName)
        {
            ColumnsList = new List<clsColumn>();
            clsDatabaseData.ColumnsListAutoFill(new clsDatabaseData(cbDatabase.Text, TableName, txtUsername.Text, txtPassword.Text), ColumnsList);
            if (clsColumn.GetPrimaryKeyColumn(ColumnsList) == null)
            {
                ColumnsList[0].IsPK = true;
            }
            clsColumn PKColumn = clsColumn.GetPrimaryKeyColumn(ColumnsList);
            TableSingleName = PKColumn.ColumnName.Substring(0, PKColumn.ColumnName.Length - 2);

        } 
        void CreateAllFiles()
        {
            List<string> Tables = clsDatabaseData.GetAllTables(cbDatabase.Text, txtUsername.Text, txtPassword.Text);

            int TotalFiles = 0;
            foreach (string Table in Tables)
            {
                TotalFiles++;
                PerformColumnsList(Table);
                CreateBusinessLayerFile(Table);
                CreateDataAccessLayerFile(Table);
            }
            MessageBox.Show($"{TotalFiles} Files created successfully!");
        }
        void Generate()
        {
            CreateAllFiles();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Generate();
        }
        void LoadData()
        {
            txtUsername.Text = "sa";
            txtPassword.Text = "sa123456";
            FindDatabase();
        }
        private void frmAutoGenerate_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
