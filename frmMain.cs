using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Generator;
namespace BuisnessAndDataLayer_Code_Generator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public string TableName { get; set; }
        public string TableSinglName { get; set; }
        List<clsColumn> ColumnsList { get; set; }

        private bool HasPK { get; set; }

        private string strDataLayer { get; set; }
        private string strBusinessLayer { get; set; }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cbColumnDataType.SelectedItem = "int";
            rbPK.Select();
            txtTableName.Select();
            HasPK = false;
            ColumnsList = new List<clsColumn>();
        }

        private void AddToColumnsList(string ColumnName, string ColumnDataType, string strIsNull)
        {
            bool isNull = string.IsNullOrEmpty(strIsNull) ? false : true;
            bool isPK = rbPK.Checked;
            if (isPK) HasPK = true;
            ColumnsList.Add(new clsColumn(ColumnName, ColumnDataType, isNull, isPK));
        }
        private bool _IsValidColumn()
        {
            return !(string.IsNullOrEmpty(txtColumnName.Text));
        }
        private string _CheckRadioButton()
        {
            if (rbNull.Checked) { return "null"; }
            return "";
        }
        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            if (!_IsValidColumn())
            {
                MessageBox.Show("Sorry but you can't add an Empty column", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string strIsNull = _CheckRadioButton();
            dataGridView1.Rows.Add(txtColumnName.Text, cbColumnDataType.Text, strIsNull, rbPK.Checked ? "PK" : null);
            
            txtColumnName.Text = string.Empty;

            rbNotNull.Select();

            txtColumnName.Select();
        }


        private bool _IsValidToGenerate()
        {
            if (!HasPK)
            {
                MessageBox.Show("You can't Generate Without adding Primary Key!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTableName.Text == string.Empty)
            {
                MessageBox.Show("You can't Generate Without adding Table Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txtTableSingleName.Text == string.Empty)
            {
                MessageBox.Show("You can't Generate Without adding Table Single Name!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (dataGridView1.Rows.Count <= 1 )
            {
                MessageBox.Show("You can't Generate Without adding columns!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            

            return true;
        }
        private string GetDataLayer(string TableName, string TableSingleName, List<clsColumn> ColumnsList)
        {
            return clsGenerateDataLayer.Generate(TableName, TableSingleName, ColumnsList, cbDataAccess.Checked).ToString();
        }
        private string GetBusinessLayer(string TableName, string TableSingleName, List<clsColumn> ColumnsList)
        {
            return clsGenerateBusinessLayer.Generate(TableName, TableSingleName, ColumnsList).ToString();
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            
            TableName = txtTableName.Text;
            TableSinglName = txtTableSingleName.Text;

            foreach (DataGridViewRow Row in dataGridView1.Rows)
            {
                if (Row.Cells[0].Value == null)
                    continue;
                string ColumnName = Row.Cells[0].Value.ToString();
                string DataType = Row.Cells[1].Value.ToString();
                bool IsNull = string.IsNullOrEmpty(Row.Cells[2].Value.ToString());
                bool IsPK = Row.Cells[3].Value != null;
                if (IsNull) HasPK = true;
                ColumnsList.Add(new clsColumn(ColumnName, DataType, IsNull, IsPK)); ;
            }

            if (!_IsValidToGenerate())
            {
                ColumnsList.Clear();
                return;
            }

            strBusinessLayer = GetBusinessLayer(TableName, TableSinglName, ColumnsList);
            strDataLayer = GetDataLayer(TableName, TableSinglName, ColumnsList);

            txtGeneratedCode.Text = strDataLayer;

            btnBusinessLayer.Visible = true;
            btnDataLayer.Visible = true;
            lblLayer.Visible = true;
            ColumnsList.Clear();
        }

        private void btnDataLayer_Click(object sender, EventArgs e)
        {
            lblLayer.Text = "Data Layer";
            txtGeneratedCode.Text = strDataLayer;
        }

        private void btnBusinessLayer_Click(object sender, EventArgs e)
        {
            lblLayer.Text = "Business Layer";
            txtGeneratedCode.Text = strBusinessLayer;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            txtColumnName.Clear();
            txtTableName.Clear();
            txtTableSingleName.Clear();
            ColumnsList.Clear();

            txtGeneratedCode.Clear();
            txtTableName.Select();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
        }
    }
}
