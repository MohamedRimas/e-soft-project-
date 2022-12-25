namespace HRS
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.table1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotel1DataSet = new HRS.hotel1DataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoteal_newDataSet = new HRS.hoteal_newDataSet();
            this.table_1TableAdapter = new HRS.hotel1DataSetTableAdapters.Table_1TableAdapter();
            this.tableTableAdapter = new HRS.hoteal_newDataSetTableAdapters.TableTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hotealnewDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomrateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noofdayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalpaymentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteal_newDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotealnewDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // table1BindingSource
            // 
            this.table1BindingSource.DataMember = "Table_1";
            this.table1BindingSource.DataSource = this.hotel1DataSet;
            // 
            // hotel1DataSet
            // 
            this.hotel1DataSet.DataSetName = "hotel1DataSet";
            this.hotel1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.hoteal_newDataSet;
            // 
            // hoteal_newDataSet
            // 
            this.hoteal_newDataSet.DataSetName = "hoteal_newDataSet";
            this.hoteal_newDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_1TableAdapter
            // 
            this.table_1TableAdapter.ClearBeforeFill = true;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.guestnameDataGridViewTextBoxColumn,
            this.roomnoDataGridViewTextBoxColumn,
            this.roomtypeDataGridViewTextBoxColumn,
            this.roomrateDataGridViewTextBoxColumn,
            this.noofdayDataGridViewTextBoxColumn,
            this.subtotalDataGridViewTextBoxColumn,
            this.totalpaymentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // hotealnewDataSetBindingSource
            // 
            this.hotealnewDataSetBindingSource.DataSource = this.hoteal_newDataSet;
            this.hotealnewDataSetBindingSource.Position = 0;
            // 
            // tableBindingSource1
            // 
            this.tableBindingSource1.DataMember = "Table";
            this.tableBindingSource1.DataSource = this.hoteal_newDataSet;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // guestnameDataGridViewTextBoxColumn
            // 
            this.guestnameDataGridViewTextBoxColumn.DataPropertyName = "guest_name";
            this.guestnameDataGridViewTextBoxColumn.HeaderText = "guest_name";
            this.guestnameDataGridViewTextBoxColumn.Name = "guestnameDataGridViewTextBoxColumn";
            // 
            // roomnoDataGridViewTextBoxColumn
            // 
            this.roomnoDataGridViewTextBoxColumn.DataPropertyName = "room_no";
            this.roomnoDataGridViewTextBoxColumn.HeaderText = "room_no";
            this.roomnoDataGridViewTextBoxColumn.Name = "roomnoDataGridViewTextBoxColumn";
            // 
            // roomtypeDataGridViewTextBoxColumn
            // 
            this.roomtypeDataGridViewTextBoxColumn.DataPropertyName = "room_type";
            this.roomtypeDataGridViewTextBoxColumn.HeaderText = "room_type";
            this.roomtypeDataGridViewTextBoxColumn.Name = "roomtypeDataGridViewTextBoxColumn";
            // 
            // roomrateDataGridViewTextBoxColumn
            // 
            this.roomrateDataGridViewTextBoxColumn.DataPropertyName = "room_rate";
            this.roomrateDataGridViewTextBoxColumn.HeaderText = "room_rate";
            this.roomrateDataGridViewTextBoxColumn.Name = "roomrateDataGridViewTextBoxColumn";
            // 
            // noofdayDataGridViewTextBoxColumn
            // 
            this.noofdayDataGridViewTextBoxColumn.DataPropertyName = "no_of_day";
            this.noofdayDataGridViewTextBoxColumn.HeaderText = "no_of_day";
            this.noofdayDataGridViewTextBoxColumn.Name = "noofdayDataGridViewTextBoxColumn";
            // 
            // subtotalDataGridViewTextBoxColumn
            // 
            this.subtotalDataGridViewTextBoxColumn.DataPropertyName = "sub_total";
            this.subtotalDataGridViewTextBoxColumn.HeaderText = "sub_total";
            this.subtotalDataGridViewTextBoxColumn.Name = "subtotalDataGridViewTextBoxColumn";
            // 
            // totalpaymentDataGridViewTextBoxColumn
            // 
            this.totalpaymentDataGridViewTextBoxColumn.DataPropertyName = "total_payment";
            this.totalpaymentDataGridViewTextBoxColumn.HeaderText = "total_payment";
            this.totalpaymentDataGridViewTextBoxColumn.Name = "totalpaymentDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 357);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form4";
            this.Text = "chekin_form-list";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotel1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoteal_newDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotealnewDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private hotel1DataSet hotel1DataSet;
        private System.Windows.Forms.BindingSource table1BindingSource;
        private hotel1DataSetTableAdapters.Table_1TableAdapter table_1TableAdapter;
        private hoteal_newDataSet hoteal_newDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private hoteal_newDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomrateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noofdayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalpaymentDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tableBindingSource1;
        private System.Windows.Forms.BindingSource hotealnewDataSetBindingSource;
    }
}