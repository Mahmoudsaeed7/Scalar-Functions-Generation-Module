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
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Table)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Name";
            // 
            // CB_TableName
            // 
            this.CB_TableName.FormattingEnabled = true;
            this.CB_TableName.Items.AddRange(new object[] {
            "Products"});
            this.CB_TableName.Location = new System.Drawing.Point(408, 88);
            this.CB_TableName.Margin = new System.Windows.Forms.Padding(4);
            this.CB_TableName.Name = "CB_TableName";
            this.CB_TableName.Size = new System.Drawing.Size(160, 24);
            this.CB_TableName.TabIndex = 1;
            this.CB_TableName.SelectedIndexChanged += new System.EventHandler(this.CB_TableName_SelectedIndexChanged);
            // 
            // GridView_Table
            // 
            this.GridView_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Table.Location = new System.Drawing.Point(196, 20);
            this.GridView_Table.Margin = new System.Windows.Forms.Padding(4);
            this.GridView_Table.Name = "GridView_Table";
            this.GridView_Table.Size = new System.Drawing.Size(536, 325);
            this.GridView_Table.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.CB_TableName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-16, -34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 160);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.GridView_Table);
            this.panel2.Location = new System.Drawing.Point(-27, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(971, 437);
            this.panel2.TabIndex = 4;
            // 
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 534);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Load";
            this.Text = "Load";
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
    }
}

