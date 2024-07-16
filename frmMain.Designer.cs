namespace BuisnessAndDataLayer_Code_Generator
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblLayer = new System.Windows.Forms.Label();
            this.btnDataLayer = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtGeneratedCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.rbNotNull = new System.Windows.Forms.RadioButton();
            this.rbPK = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removePKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbNull = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.txtColumnName = new System.Windows.Forms.TextBox();
            this.btnBusinessLayer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbColumnDataType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTableSingleName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDataAccess = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsNull = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsPK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAutoFill = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLayer
            // 
            this.lblLayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLayer.AutoSize = true;
            this.lblLayer.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLayer.ForeColor = System.Drawing.Color.Orange;
            this.lblLayer.Location = new System.Drawing.Point(929, 108);
            this.lblLayer.Name = "lblLayer";
            this.lblLayer.Size = new System.Drawing.Size(91, 21);
            this.lblLayer.TabIndex = 33;
            this.lblLayer.Text = "Data Layer";
            this.lblLayer.Visible = false;
            // 
            // btnDataLayer
            // 
            this.btnDataLayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDataLayer.BackColor = System.Drawing.Color.White;
            this.btnDataLayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDataLayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDataLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataLayer.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataLayer.Location = new System.Drawing.Point(872, 139);
            this.btnDataLayer.MaximumSize = new System.Drawing.Size(97, 34);
            this.btnDataLayer.MinimumSize = new System.Drawing.Size(97, 34);
            this.btnDataLayer.Name = "btnDataLayer";
            this.btnDataLayer.Size = new System.Drawing.Size(97, 34);
            this.btnDataLayer.TabIndex = 31;
            this.btnDataLayer.TabStop = false;
            this.btnDataLayer.Text = "Data Layer";
            this.btnDataLayer.UseVisualStyleBackColor = false;
            this.btnDataLayer.Visible = false;
            this.btnDataLayer.Click += new System.EventHandler(this.btnDataLayer_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.White;
            this.btnGenerate.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnGenerate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(750, 455);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(67, 34);
            this.btnGenerate.TabIndex = 29;
            this.btnGenerate.TabStop = false;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // txtGeneratedCode
            // 
            this.txtGeneratedCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGeneratedCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGeneratedCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGeneratedCode.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneratedCode.Location = new System.Drawing.Point(874, 179);
            this.txtGeneratedCode.MaxLength = 20;
            this.txtGeneratedCode.Multiline = true;
            this.txtGeneratedCode.Name = "txtGeneratedCode";
            this.txtGeneratedCode.ReadOnly = true;
            this.txtGeneratedCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGeneratedCode.Size = new System.Drawing.Size(226, 311);
            this.txtGeneratedCode.TabIndex = 30;
            this.txtGeneratedCode.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(6, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Data Type";
            // 
            // btnAddColumn
            // 
            this.btnAddColumn.BackColor = System.Drawing.Color.White;
            this.btnAddColumn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAddColumn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddColumn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F);
            this.btnAddColumn.Location = new System.Drawing.Point(55, 187);
            this.btnAddColumn.Name = "btnAddColumn";
            this.btnAddColumn.Size = new System.Drawing.Size(143, 34);
            this.btnAddColumn.TabIndex = 14;
            this.btnAddColumn.TabStop = false;
            this.btnAddColumn.Text = "Add";
            this.btnAddColumn.UseVisualStyleBackColor = false;
            this.btnAddColumn.Click += new System.EventHandler(this.btnAddColumn_Click);
            // 
            // rbNotNull
            // 
            this.rbNotNull.AutoSize = true;
            this.rbNotNull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbNotNull.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNotNull.Location = new System.Drawing.Point(22, 160);
            this.rbNotNull.Name = "rbNotNull";
            this.rbNotNull.Size = new System.Drawing.Size(74, 21);
            this.rbNotNull.TabIndex = 4;
            this.rbNotNull.TabStop = true;
            this.rbNotNull.Text = "Not Null";
            this.rbNotNull.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbNotNull.UseVisualStyleBackColor = true;
            // 
            // rbPK
            // 
            this.rbPK.AutoSize = true;
            this.rbPK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbPK.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPK.Location = new System.Drawing.Point(123, 160);
            this.rbPK.Name = "rbPK";
            this.rbPK.Size = new System.Drawing.Size(40, 21);
            this.rbPK.TabIndex = 5;
            this.rbPK.TabStop = true;
            this.rbPK.Text = "PK";
            this.rbPK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPK.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.setPKToolStripMenuItem,
            this.removePKToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 70);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = global::BusinessAndDataLayersGenerator.Properties.Resources.CloseForm;
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // setPKToolStripMenuItem
            // 
            this.setPKToolStripMenuItem.Name = "setPKToolStripMenuItem";
            this.setPKToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.setPKToolStripMenuItem.Text = "Set PK";
            this.setPKToolStripMenuItem.Click += new System.EventHandler(this.setPKToolStripMenuItem_Click);
            // 
            // removePKToolStripMenuItem
            // 
            this.removePKToolStripMenuItem.Name = "removePKToolStripMenuItem";
            this.removePKToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.removePKToolStripMenuItem.Text = "Remove PK";
            this.removePKToolStripMenuItem.Click += new System.EventHandler(this.removePKToolStripMenuItem_Click);
            // 
            // rbNull
            // 
            this.rbNull.AutoSize = true;
            this.rbNull.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbNull.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNull.Location = new System.Drawing.Point(193, 160);
            this.rbNull.Name = "rbNull";
            this.rbNull.Size = new System.Drawing.Size(48, 21);
            this.rbNull.TabIndex = 6;
            this.rbNull.TabStop = true;
            this.rbNull.Text = "Null";
            this.rbNull.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbNull.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(6, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Name";
            // 
            // txtColumnName
            // 
            this.txtColumnName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtColumnName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumnName.Location = new System.Drawing.Point(79, 61);
            this.txtColumnName.MaxLength = 500;
            this.txtColumnName.Name = "txtColumnName";
            this.txtColumnName.Size = new System.Drawing.Size(162, 20);
            this.txtColumnName.TabIndex = 2;
            // 
            // btnBusinessLayer
            // 
            this.btnBusinessLayer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBusinessLayer.BackColor = System.Drawing.Color.White;
            this.btnBusinessLayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBusinessLayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBusinessLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusinessLayer.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusinessLayer.Location = new System.Drawing.Point(986, 139);
            this.btnBusinessLayer.MaximumSize = new System.Drawing.Size(97, 34);
            this.btnBusinessLayer.MinimumSize = new System.Drawing.Size(97, 34);
            this.btnBusinessLayer.Name = "btnBusinessLayer";
            this.btnBusinessLayer.Size = new System.Drawing.Size(97, 34);
            this.btnBusinessLayer.TabIndex = 32;
            this.btnBusinessLayer.TabStop = false;
            this.btnBusinessLayer.Text = "Business Layer";
            this.btnBusinessLayer.UseVisualStyleBackColor = false;
            this.btnBusinessLayer.Visible = false;
            this.btnBusinessLayer.Click += new System.EventHandler(this.btnBusinessLayer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAddColumn);
            this.groupBox1.Controls.Add(this.rbNotNull);
            this.groupBox1.Controls.Add(this.rbPK);
            this.groupBox1.Controls.Add(this.rbNull);
            this.groupBox1.Controls.Add(this.cbColumnDataType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtColumnName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(498, 262);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(247, 227);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Column";
            // 
            // cbColumnDataType
            // 
            this.cbColumnDataType.DropDownHeight = 100;
            this.cbColumnDataType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbColumnDataType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbColumnDataType.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbColumnDataType.FormattingEnabled = true;
            this.cbColumnDataType.IntegralHeight = false;
            this.cbColumnDataType.Items.AddRange(new object[] {
            "bool",
            "byte",
            "char",
            "DateTime",
            "decimal",
            "float",
            "int",
            "string"});
            this.cbColumnDataType.Location = new System.Drawing.Point(79, 108);
            this.cbColumnDataType.Name = "cbColumnDataType";
            this.cbColumnDataType.Size = new System.Drawing.Size(162, 28);
            this.cbColumnDataType.Sorted = true;
            this.cbColumnDataType.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(304, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 15);
            this.label4.TabIndex = 26;
            this.label4.Text = "(* Person, Contact..etc)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Table Single Name";
            // 
            // txtTableSingleName
            // 
            this.txtTableSingleName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTableSingleName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableSingleName.Location = new System.Drawing.Point(136, 179);
            this.txtTableSingleName.MaxLength = 500;
            this.txtTableSingleName.Name = "txtTableSingleName";
            this.txtTableSingleName.Size = new System.Drawing.Size(160, 20);
            this.txtTableSingleName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(304, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "(* People, Contacts..etc)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Table Name";
            // 
            // txtTableName
            // 
            this.txtTableName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTableName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTableName.Location = new System.Drawing.Point(136, 128);
            this.txtTableName.MaxLength = 500;
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(160, 20);
            this.txtTableName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 43);
            this.label1.TabIndex = 21;
            this.label1.Text = "Generate Business And Data Layers";
            // 
            // cbDataAccess
            // 
            this.cbDataAccess.AutoSize = true;
            this.cbDataAccess.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbDataAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbDataAccess.Location = new System.Drawing.Point(751, 370);
            this.cbDataAccess.Name = "cbDataAccess";
            this.cbDataAccess.Size = new System.Drawing.Size(113, 19);
            this.cbDataAccess.TabIndex = 34;
            this.cbDataAccess.Text = "Data Access Class";
            this.cbDataAccess.UseVisualStyleBackColor = true;
            this.cbDataAccess.CheckedChanged += new System.EventHandler(this.cbDataAccess_CheckedChanged);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.White;
            this.btnReset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnReset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(751, 409);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(67, 34);
            this.btnReset.TabIndex = 35;
            this.btnReset.TabStop = false;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnName,
            this.DataType,
            this.IsNull,
            this.IsPK});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(12, 276);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(480, 213);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.TabStop = false;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "ColumnName";
            this.ColumnName.Name = "ColumnName";
            // 
            // DataType
            // 
            this.DataType.HeaderText = "DataType";
            this.DataType.Name = "DataType";
            // 
            // IsNull
            // 
            this.IsNull.HeaderText = "IsNull";
            this.IsNull.Name = "IsNull";
            // 
            // IsPK
            // 
            this.IsPK.HeaderText = "IsPK";
            this.IsPK.Name = "IsPK";
            // 
            // btnAutoFill
            // 
            this.btnAutoFill.BackColor = System.Drawing.Color.White;
            this.btnAutoFill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAutoFill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAutoFill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAutoFill.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoFill.Location = new System.Drawing.Point(17, 73);
            this.btnAutoFill.Name = "btnAutoFill";
            this.btnAutoFill.Size = new System.Drawing.Size(238, 34);
            this.btnAutoFill.TabIndex = 37;
            this.btnAutoFill.TabStop = false;
            this.btnAutoFill.Text = "Auto Fill";
            this.btnAutoFill.UseVisualStyleBackColor = false;
            this.btnAutoFill.Click += new System.EventHandler(this.btnAutoFill_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(989, 10);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(152, 42);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDatabaseName.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatabaseName.Location = new System.Drawing.Point(136, 221);
            this.txtDatabaseName.MaxLength = 500;
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(160, 20);
            this.txtDatabaseName.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(14, 224);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 40;
            this.label8.Text = "Database Name";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnAddColumn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 501);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtDatabaseName);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnAutoFill);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cbDataAccess);
            this.Controls.Add(this.lblLayer);
            this.Controls.Add(this.btnDataLayer);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtGeneratedCode);
            this.Controls.Add(this.btnBusinessLayer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTableSingleName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmMain";
            this.Text = "Generator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLayer;
        private System.Windows.Forms.Button btnDataLayer;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtGeneratedCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.RadioButton rbNotNull;
        private System.Windows.Forms.RadioButton rbPK;
        private System.Windows.Forms.RadioButton rbNull;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtColumnName;
        private System.Windows.Forms.Button btnBusinessLayer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbColumnDataType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTableSingleName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbDataAccess;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsNull;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsPK;
        private System.Windows.Forms.Button btnAutoFill;
        private System.Windows.Forms.ToolStripMenuItem setPKToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removePKToolStripMenuItem;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label label8;
    }
}

