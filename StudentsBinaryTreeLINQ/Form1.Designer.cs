namespace StudentsBinaryTreeLINQ
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_Data = new System.Windows.Forms.DataGridView();
            this.bt_LoadData = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbFiltration = new System.Windows.Forms.GroupBox();
            this.btAddFilter = new System.Windows.Forms.Button();
            this.dgFiltration = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameFilter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TestFilter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFilter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarkFilter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btFilter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).BeginInit();
            this.gbFiltration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFiltration)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Data
            // 
            this.dgv_Data.AllowUserToAddRows = false;
            this.dgv_Data.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Data.Location = new System.Drawing.Point(12, 61);
            this.dgv_Data.Name = "dgv_Data";
            this.dgv_Data.Size = new System.Drawing.Size(477, 289);
            this.dgv_Data.TabIndex = 2;
            this.dgv_Data.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_Data_ColumnHeaderMouseClick);
            // 
            // bt_LoadData
            // 
            this.bt_LoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_LoadData.Location = new System.Drawing.Point(12, 12);
            this.bt_LoadData.Name = "bt_LoadData";
            this.bt_LoadData.Size = new System.Drawing.Size(113, 29);
            this.bt_LoadData.TabIndex = 3;
            this.bt_LoadData.Text = "Load Data";
            this.bt_LoadData.UseVisualStyleBackColor = true;
            this.bt_LoadData.Click += new System.EventHandler(this.bt_LoadData_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gbFiltration
            // 
            this.gbFiltration.Controls.Add(this.btAddFilter);
            this.gbFiltration.Controls.Add(this.dgFiltration);
            this.gbFiltration.Controls.Add(this.btFilter);
            this.gbFiltration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbFiltration.Location = new System.Drawing.Point(495, 61);
            this.gbFiltration.Name = "gbFiltration";
            this.gbFiltration.Size = new System.Drawing.Size(341, 289);
            this.gbFiltration.TabIndex = 7;
            this.gbFiltration.TabStop = false;
            this.gbFiltration.Text = "Filtration";
            // 
            // btAddFilter
            // 
            this.btAddFilter.Location = new System.Drawing.Point(18, 21);
            this.btAddFilter.Name = "btAddFilter";
            this.btAddFilter.Size = new System.Drawing.Size(57, 22);
            this.btAddFilter.TabIndex = 5;
            this.btAddFilter.Text = "ADD";
            this.btAddFilter.UseVisualStyleBackColor = true;
            // 
            // dgFiltration
            // 
            this.dgFiltration.AllowUserToAddRows = false;
            this.dgFiltration.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFiltration.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.NameFilter,
            this.TestFilter,
            this.DateFilter,
            this.MarkFilter});
            this.dgFiltration.Location = new System.Drawing.Point(7, 50);
            this.dgFiltration.Name = "dgFiltration";
            this.dgFiltration.Size = new System.Drawing.Size(324, 215);
            this.dgFiltration.TabIndex = 4;
            // 
            // Number
            // 
            this.Number.HeaderText = "";
            this.Number.Name = "Number";
            this.Number.Width = 80;
            // 
            // NameFilter
            // 
            this.NameFilter.HeaderText = "Name";
            this.NameFilter.Name = "NameFilter";
            this.NameFilter.Width = 50;
            // 
            // TestFilter
            // 
            this.TestFilter.HeaderText = "Test";
            this.TestFilter.Name = "TestFilter";
            this.TestFilter.Width = 50;
            // 
            // DateFilter
            // 
            this.DateFilter.HeaderText = "Date";
            this.DateFilter.Name = "DateFilter";
            this.DateFilter.Width = 50;
            // 
            // MarkFilter
            // 
            this.MarkFilter.HeaderText = "Mark";
            this.MarkFilter.Name = "MarkFilter";
            this.MarkFilter.Width = 50;
            // 
            // btFilter
            // 
            this.btFilter.Location = new System.Drawing.Point(253, 21);
            this.btFilter.Name = "btFilter";
            this.btFilter.Size = new System.Drawing.Size(78, 23);
            this.btFilter.TabIndex = 3;
            this.btFilter.Text = "FILTER";
            this.btFilter.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "click on column header for sorting";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 362);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbFiltration);
            this.Controls.Add(this.bt_LoadData);
            this.Controls.Add(this.dgv_Data);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Data)).EndInit();
            this.gbFiltration.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgFiltration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_Data;
        private System.Windows.Forms.Button bt_LoadData;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox gbFiltration;
        private System.Windows.Forms.Button btFilter;
        private System.Windows.Forms.DataGridView dgFiltration;
        private System.Windows.Forms.Button btAddFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TestFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarkFilter;
        private System.Windows.Forms.Label label1;
    }
}

