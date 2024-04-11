using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAndDataLayersGenerator;
using Generator;
namespace BuisnessAndDataLayer_Code_Generator
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private bool AutoFillMode = false;
        public string TableName { get; set; }
        public string TableSinglName { get; set; }
        List<clsColumn> ColumnsList { get; set; }

        private bool HasPK { get; set; }

        private string strDataLayer { get; set; }
        private string strBusinessLayer { get; set; }
        void _LoadData()
        {
            cbColumnDataType.SelectedItem = "int";
            rbPK.Select();
            txtTableName.Select();
            HasPK = false;
            ColumnsList = new List<clsColumn>();
            
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            _LoadData();
        }

        
        private bool _IsValidColumn()
        {
            return !(string.IsNullOrEmpty(txtColumnName.Text));
        }
        private string _CheckRadioButton()
        {
            if (rbNull.Checked) { return "null"; }
            return null;
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
            if(AutoFillMode)
            {
                return true;
            }
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
            if(ColumnsList.Count == 0)
            {

                foreach (DataGridViewRow Row in dataGridView1.Rows)
                {
                    if (Row.Cells[0].Value == null)
                        continue;
                    string ColumnName = Row.Cells[0].Value.ToString();
                    string DataType = Row.Cells[1].Value.ToString();
                    bool IsNull = Row.Cells[2].Value != null;
                    bool IsPK = Row.Cells[3].Value != null;
                    if (IsPK) HasPK = true;
                    ColumnsList.Add(new clsColumn(ColumnName, DataType, IsNull, IsPK)); ;
                }

            }
            if (!_IsValidToGenerate())
            {
                ColumnsList.Clear();
                return;
            }
            if(clsColumn.GetPrimaryKeyColumn(ColumnsList) == null)
            {
                MessageBox.Show("Please put a PK");
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
            AutoFillMode = false;
            dataGridView1.Rows.Clear();
            txtColumnName.Clear();
            txtTableName.Clear();
            txtTableSingleName.Clear();
            ColumnsList.Clear();

            txtGeneratedCode.Clear();
            txtTableName.Select();
        }

        

        void FillDataGrid()
        {
            dataGridView1.Rows.Clear();
            string IsPK = default;
            string IsNull = default;
            foreach (clsColumn Column in ColumnsList)
            {
                IsPK   = Column.IsPK ? "PK" : "";
                IsNull = Column.AllowNull ? "null" : "";
                dataGridView1.Rows.Add(Column.ColumnName, Column.ColumnDataType, IsNull, IsPK);
            }
            
        }
        void PerformTableSelected(bool IsFound, clsDatabaseData dbData)
        {
            if (!IsFound)
            {
                AutoFillMode = false;
                return;
            }
            dataGridView1.Rows.Clear();
            AutoFillMode = true;
            txtTableName.Text = dbData.TableName;
            txtTableSingleName.Text = dbData.TableSingleName;
            clsDatabaseData.ColumnsListAutoFill(dbData, ColumnsList);
            FillDataGrid();

        }
        private void btnAutoFill_Click(object sender, EventArgs e)
        {
            frmAutoFill frm = new frmAutoFill();
            frm.TableSelected += PerformTableSelected;
            frm.ShowDialog();
        }

        
        void DisabilAllToolStrips()
        {
            deleteToolStripMenuItem.Enabled = false;
            setPKToolStripMenuItem.Enabled = false;
            removePKToolStripMenuItem.Enabled = false;
        }
        void LoadContextMenuStrip()
        {
            if(!IsDataGridHasRows())
            {
                DisabilAllToolStrips();
                return;
            }
            deleteToolStripMenuItem.Enabled = true;
            DataGridViewRow dataRow = dataGridView1.CurrentRow;
            
            if (string.IsNullOrEmpty(dataRow?.Cells[dataRow.Cells.Count - 1]?.Value.ToString()))
            {
                setPKToolStripMenuItem.Enabled = true;
                removePKToolStripMenuItem.Enabled = false;
                return;
            }
            setPKToolStripMenuItem.Enabled = false;
            removePKToolStripMenuItem.Enabled = true;

        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            LoadContextMenuStrip();
        }

        bool IsDataGridHasRows()
        {
            if (dataGridView1.Rows.Count <= 1)
                return false; 
            return true;
        }
        private void removePKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsDataGridHasRows())
                return;
            dataGridView1.CurrentRow.Cells[dataGridView1.Rows[0].Cells.Count - 1].Value = "";
            clsColumn.SetRemovePKColumn(ColumnsList, dataGridView1.CurrentRow.Cells[0].Value.ToString(), false);

        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (!IsDataGridHasRows())
                return;
            string ColumnName = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            ColumnsList.Remove(clsColumn.Find(ColumnsList, ColumnName));
            FillDataGrid();
        }

        private void setPKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!IsDataGridHasRows())
                return;
            dataGridView1.CurrentRow.Cells[dataGridView1.Rows[0].Cells.Count - 1].Value = "PK";
            clsColumn.SetRemovePKColumn(ColumnsList, dataGridView1.CurrentRow.Cells[0].Value.ToString());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbDataAccess_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
