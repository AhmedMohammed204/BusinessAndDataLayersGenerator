﻿namespace BuisnessAndDataLayer_Code_Generator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblLayer = new System.Windows.Forms.Label();
            this.btnDataLayer = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.txtGeneratedCode = new System.Windows.Forms.TextBox();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddColumn = new System.Windows.Forms.Button();
            this.rbNotNull = new System.Windows.Forms.RadioButton();
            this.rbPK = new System.Windows.Forms.RadioButton();
            this.lvColumns = new System.Windows.Forms.ListView();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblLayer
            // 
            this.lblLayer.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLayer.AutoSize = true;
            this.lblLayer.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLayer.ForeColor = System.Drawing.Color.Orange;
            this.lblLayer.Location = new System.Drawing.Point(828, 25);
            this.lblLayer.Name = "lblLayer";
            this.lblLayer.Size = new System.Drawing.Size(91, 21);
            this.lblLayer.TabIndex = 33;
            this.lblLayer.Text = "Data Layer";
            this.lblLayer.Visible = false;
            // 
            // btnDataLayer
            // 
            this.btnDataLayer.BackColor = System.Drawing.Color.White;
            this.btnDataLayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDataLayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDataLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataLayer.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataLayer.Location = new System.Drawing.Point(770, 56);
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
            this.btnGenerate.Location = new System.Drawing.Point(697, 456);
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
            this.txtGeneratedCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGeneratedCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtGeneratedCode.Font = new System.Drawing.Font("Microsoft New Tai Lue", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneratedCode.Location = new System.Drawing.Point(770, 96);
            this.txtGeneratedCode.MaxLength = 20;
            this.txtGeneratedCode.Multiline = true;
            this.txtGeneratedCode.Name = "txtGeneratedCode";
            this.txtGeneratedCode.ReadOnly = true;
            this.txtGeneratedCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtGeneratedCode.Size = new System.Drawing.Size(226, 394);
            this.txtGeneratedCode.TabIndex = 30;
            this.txtGeneratedCode.TabStop = false;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "IsPK";
            this.columnHeader4.Width = 52;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "IsNull";
            this.columnHeader3.Width = 70;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Data Type";
            this.columnHeader2.Width = 106;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 160;
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
            // lvColumns
            // 
            this.lvColumns.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvColumns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lvColumns.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvColumns.HideSelection = false;
            this.lvColumns.LabelEdit = true;
            this.lvColumns.Location = new System.Drawing.Point(17, 263);
            this.lvColumns.Name = "lvColumns";
            this.lvColumns.Size = new System.Drawing.Size(392, 227);
            this.lvColumns.TabIndex = 28;
            this.lvColumns.TabStop = false;
            this.lvColumns.UseCompatibleStateImageBehavior = false;
            this.lvColumns.View = System.Windows.Forms.View.Details;
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
            this.txtColumnName.MaxLength = 20;
            this.txtColumnName.Name = "txtColumnName";
            this.txtColumnName.Size = new System.Drawing.Size(162, 20);
            this.txtColumnName.TabIndex = 2;
            // 
            // btnBusinessLayer
            // 
            this.btnBusinessLayer.BackColor = System.Drawing.Color.White;
            this.btnBusinessLayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnBusinessLayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBusinessLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusinessLayer.Font = new System.Drawing.Font("Microsoft New Tai Lue", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusinessLayer.Location = new System.Drawing.Point(884, 56);
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
            this.groupBox1.Location = new System.Drawing.Point(432, 263);
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
            "char",
            "DateTime",
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
            this.txtTableSingleName.MaxLength = 20;
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
            this.txtTableName.MaxLength = 20;
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(160, 20);
            this.txtTableName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(543, 43);
            this.label1.TabIndex = 21;
            this.label1.Text = "Generate Business And Data Layers";
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnAddColumn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 501);
            this.Controls.Add(this.lblLayer);
            this.Controls.Add(this.btnDataLayer);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.txtGeneratedCode);
            this.Controls.Add(this.lvColumns);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLayer;
        private System.Windows.Forms.Button btnDataLayer;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtGeneratedCode;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddColumn;
        private System.Windows.Forms.RadioButton rbNotNull;
        private System.Windows.Forms.RadioButton rbPK;
        private System.Windows.Forms.ListView lvColumns;
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
    }
}
