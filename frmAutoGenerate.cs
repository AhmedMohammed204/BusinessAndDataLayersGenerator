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
        
        void FindDatabase()
        {

            List<string> list = clsDatabaseData.GetAllDatabases(txtUsername.Text, txtPassword.Text);
            if (list == null)
                return;
            clsDatabaseData.Fill_CB(list, cbDatabase);

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
        void PerformColumnsList(string TableName, List<string> FilesNames)
        {
            ColumnsList = new List<clsColumn>();
            clsDatabaseData.ColumnsListAutoFill(new clsDatabaseData(cbDatabase.Text, TableName, txtUsername.Text, txtPassword.Text), ColumnsList);

            clsColumn PKColumn = null;


            if (clsColumn.GetPrimaryKeyColumn(ColumnsList) == null)
            {
                PKColumn = ColumnsList[0];
                PKColumn.IsPK = true;
            }else
            {
                PKColumn = clsColumn.GetPrimaryKeyColumn(ColumnsList);
            }


            TableSingleName = PKColumn.ColumnName.Substring(0, PKColumn.ColumnName.Length - 2);
            int FileNameReptedTimes = FilesNames.Count(F => F == TableSingleName);
            if (FileNameReptedTimes > 0)
            {
                TableSingleName = TableName;
            }

            FilesNames.Add(TableSingleName);

        } 
        void CreateAllFiles()
        {
            List<string> Tables = clsDatabaseData.GetAllTables(cbDatabase.Text, txtUsername.Text, txtPassword.Text);
            List<string> FilesNames = new List<string>();
            int TotalFiles = 0;
            foreach (string Table in Tables)
            {
                TotalFiles++;
                PerformColumnsList(Table, FilesNames);
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


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
