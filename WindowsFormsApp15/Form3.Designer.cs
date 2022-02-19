
namespace WindowsFormsApp15
{
    partial class Form3
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
            this.деканатDataSet = new WindowsFormsApp15.ДеканатDataSet();
            this.дисциплиныBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дисциплиныTableAdapter = new WindowsFormsApp15.ДеканатDataSetTableAdapters.ДисциплиныTableAdapter();
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.категорияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.объемчасовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.деканатDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дисциплиныBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.категорияDataGridViewTextBoxColumn,
            this.объемчасовDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.дисциплиныBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(151, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(445, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // деканатDataSet
            // 
            this.деканатDataSet.DataSetName = "ДеканатDataSet";
            this.деканатDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // дисциплиныBindingSource
            // 
            this.дисциплиныBindingSource.DataMember = "Дисциплины";
            this.дисциплиныBindingSource.DataSource = this.деканатDataSet;
            // 
            // дисциплиныTableAdapter
            // 
            this.дисциплиныTableAdapter.ClearBeforeFill = true;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // категорияDataGridViewTextBoxColumn
            // 
            this.категорияDataGridViewTextBoxColumn.DataPropertyName = "Категория";
            this.категорияDataGridViewTextBoxColumn.HeaderText = "Категория";
            this.категорияDataGridViewTextBoxColumn.Name = "категорияDataGridViewTextBoxColumn";
            // 
            // объемчасовDataGridViewTextBoxColumn
            // 
            this.объемчасовDataGridViewTextBoxColumn.DataPropertyName = "Объемчасов";
            this.объемчасовDataGridViewTextBoxColumn.HeaderText = "Объемчасов";
            this.объемчасовDataGridViewTextBoxColumn.Name = "объемчасовDataGridViewTextBoxColumn";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.деканатDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дисциплиныBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ДеканатDataSet деканатDataSet;
        private System.Windows.Forms.BindingSource дисциплиныBindingSource;
        private ДеканатDataSetTableAdapters.ДисциплиныTableAdapter дисциплиныTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn категорияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn объемчасовDataGridViewTextBoxColumn;
    }
}