﻿namespace ScalarFunctions
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
            this.selectBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Table Name";
            // 
            // CB_TableName
            // 
            this.CB_TableName.FormattingEnabled = true;
            this.CB_TableName.Items.AddRange(new object[] {
            "Products"});
            this.CB_TableName.Location = new System.Drawing.Point(281, 29);
            this.CB_TableName.Name = "CB_TableName";
            this.CB_TableName.Size = new System.Drawing.Size(121, 21);
            this.CB_TableName.TabIndex = 1;
            this.CB_TableName.SelectedIndexChanged += new System.EventHandler(this.CB_TableName_SelectedIndexChanged);
            // 
            // GridView_Table
            // 
            this.GridView_Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridView_Table.Location = new System.Drawing.Point(12, 75);
            this.GridView_Table.Name = "GridView_Table";
            this.GridView_Table.ReadOnly = true;
            this.GridView_Table.Size = new System.Drawing.Size(302, 214);
            this.GridView_Table.TabIndex = 2;
            // 
            // selectBtn
            // 
            this.selectBtn.Location = new System.Drawing.Point(375, 75);
            this.selectBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selectBtn.Name = "selectBtn";
            this.selectBtn.Size = new System.Drawing.Size(82, 19);
            this.selectBtn.TabIndex = 3;
            this.selectBtn.Text = "Select Function";
            this.selectBtn.UseVisualStyleBackColor = true;
            this.selectBtn.Visible = false;
            this.selectBtn.Click += new System.EventHandler(this.selectBtn_Click);
            // 
            // Load
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 353);
            this.Controls.Add(this.selectBtn);
            this.Controls.Add(this.GridView_Table);
            this.Controls.Add(this.CB_TableName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Load";
            this.Text = "Load";
            this.Load += new System.EventHandler(this.Load_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridView_Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_TableName;
        private System.Windows.Forms.DataGridView GridView_Table;
        private System.Windows.Forms.Button selectBtn;
    }
}

