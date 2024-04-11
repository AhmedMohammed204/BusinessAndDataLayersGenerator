using BuisnessAndDataLayer_Code_Generator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessAndDataLayersGenerator
{
    public partial class frmParent : Form
    {
        public frmParent()
        {
            InitializeComponent();
        }
        Form activeForm = null;
        private void _OpenForm(Form ChildForm)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = ChildForm;
            ChildForm.TopLevel = false;
            ChildForm.FormBorderStyle = FormBorderStyle.None;
            ChildForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(ChildForm);
            ChildForm.BringToFront();
            ChildForm.Show();




        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAutoCreation_Click(object sender, EventArgs e)
        {
            frmAutoGenerate frm = new frmAutoGenerate();
            _OpenForm(frm);
        }

        private void btnByHand_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            _OpenForm(frm); 
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
