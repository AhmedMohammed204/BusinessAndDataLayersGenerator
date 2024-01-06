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
            cbColumnDataType.SelectedIndex = 3;
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
            ListViewItem item = new ListViewItem(txtColumnName.Text);
            item.SubItems.Add(cbColumnDataType.Text);
            item.SubItems.Add(strIsNull);
            item.SubItems.Add(rbPK.Checked ? "PK" : " ");
            lvColumns.Items.Add(item);
            AddToColumnsList(txtColumnName.Text, cbColumnDataType.Text, strIsNull);

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

            if (lvColumns.Items.Count == 0)
            {
                MessageBox.Show("You can't Generate Without adding any column!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (!_IsValidToGenerate())
            {
                return;
            }
            TableName = txtTableName.Text;
            TableSinglName = txtTableSingleName.Text;

            strBusinessLayer = GetBusinessLayer(TableName, TableSinglName, ColumnsList);
            strDataLayer = GetDataLayer(TableName, TableSinglName, ColumnsList);

            txtGeneratedCode.Text = strDataLayer;

            btnBusinessLayer.Visible = true;
            btnDataLayer.Visible = true;
            lblLayer.Visible = true;
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
            lvColumns.Items.Clear();
            txtColumnName.Clear();
            txtTableName.Clear();
            txtTableSingleName.Clear();

            txtGeneratedCode.Clear();
            txtTableName.Select();
        }
    }
}
