namespace ScalarFunctions
{
    partial class Load
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Load));
            this.label1 = new System.Windows.Forms.Label();
            this.CB_TableName = new System.Windows.Forms.ComboBox();
            this.GridView_Table = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_fnType = new System.Windows.Forms.ComboBox();
            this.selectBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Table)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Name";
            // 
            // CB_TableName
            // 
            this.CB_TableName.FormattingEnabled = true;
            this.CB_TableName.Items.AddRange(new object[] {
            "Products",
            "Company"});
            this.CB_TableName.Location = new System.Drawing.Point(344, 23);
            this.CB_TableName.Margin = new System.Windows.Forms.Padding(4);
            this.CB_TableName.Name = "CB_TableName";
            this.CB_TableName.Size = new System.Drawing.Size(121, 21);
            this.CB_TableName.TabIndex = 1;
            this.CB_TableName.SelectedIndexChanged += new System.EventHandler(this.CB_TableName_SelectedIndexChanged);
            // 
            // GridView_Table
            // 
            this.GridView_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Table.Location = new System.Drawing.Point(208, 53);
            this.GridView_Table.Margin = new System.Windows.Forms.Padding(4);
            this.GridView_Table.Name = "GridView_Table";
            this.GridView_Table.ReadOnly = true;
            this.GridView_Table.Size = new System.Drawing.Size(361, 214);
            this.GridView_Table.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CB_fnType);
            this.panel1.Controls.Add(this.selectBtn);
            this.panel1.Controls.Add(this.CB_TableName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-23, -7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 119);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(233, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Function Type";
            // 
            // CB_fnType
            // 
            this.CB_fnType.FormattingEnabled = true;
            this.CB_fnType.Items.AddRange(new object[] {
            "Single Valued",
            "Table Valued"});
            this.CB_fnType.Location = new System.Drawing.Point(344, 51);
            this.CB_fnType.Name = "CB_fnType";
            this.CB_fnType.Size = new System.Drawing.Size(121, 21);
            this.CB_fnType.TabIndex = 4;
            this.CB_fnType.SelectedIndexChanged += new System.EventHandler(this.CB_fnType_SelectedIndexChanged);
            // 
            // selectBtn
            // 
            this.selectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectBtn.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectBtn.ForeColor = System.Drawing.Color.SteelBlue;
            this.selectBtn.Location = new System.Drawing.Point(299, 77);
            this.selectBtn.Margin = new System.Windows.Forms.Padding(2);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(142, 28);
            this.selectBtn.TabIndex = 3;
            this.selectBtn.Text = "Select Function";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Visible = false;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.GridView_Table);
            this.panel2.Location = new System.Drawing.Point(-50, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 519);
            this.panel2.TabIndex = 4;
            // 
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 434);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Load";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Load";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Load_FormClosed);
            this.Load += new System.EventHandler(this.Load_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Table)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_TableName;
        private System.Windows.Forms.DataGridView GridView_Table;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button selectBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_fnType;
    }
}

