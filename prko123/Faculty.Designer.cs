﻿namespace prko123
{
    partial class Faculty
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pRKODataSet = new prko123.PRKODataSet();
            this.facultiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facultiesTableAdapter = new prko123.PRKODataSetTableAdapters.FacultiesTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.facultyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRKODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.facultyDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.facultiesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(35, 119);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 298);
            this.dataGridView1.TabIndex = 0;
            // 
            // pRKODataSet
            // 
            this.pRKODataSet.DataSetName = "PRKODataSet";
            this.pRKODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facultiesBindingSource
            // 
            this.facultiesBindingSource.DataMember = "Faculties";
            this.facultiesBindingSource.DataSource = this.pRKODataSet;
            // 
            // facultiesTableAdapter
            // 
            this.facultiesTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // facultyDataGridViewTextBoxColumn
            // 
            this.facultyDataGridViewTextBoxColumn.DataPropertyName = "Faculty";
            this.facultyDataGridViewTextBoxColumn.HeaderText = "Faculty";
            this.facultyDataGridViewTextBoxColumn.Name = "facultyDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Удалить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Faculty";
            this.Text = "Faculty";
            this.Load += new System.EventHandler(this.Faculty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRKODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facultiesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private PRKODataSet pRKODataSet;
        private System.Windows.Forms.BindingSource facultiesBindingSource;
        private PRKODataSetTableAdapters.FacultiesTableAdapter facultiesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn facultyDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}