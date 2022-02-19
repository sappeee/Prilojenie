
namespace WindowsFormsApp15
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.деканатDataSet = new WindowsFormsApp15.ДеканатDataSet();
            this.преподавателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.преподавателиTableAdapter = new WindowsFormsApp15.ДеканатDataSetTableAdapters.ПреподавателиTableAdapter();
            this.кодзаписиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.группаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фИОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дисциплинаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.контрольDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.деканатDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодзаписиDataGridViewTextBoxColumn,
            this.группаDataGridViewTextBoxColumn,
            this.фИОDataGridViewTextBoxColumn,
            this.дисциплинаDataGridViewTextBoxColumn,
            this.контрольDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.преподавателиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(53, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // деканатDataSet
            // 
            this.деканатDataSet.DataSetName = "ДеканатDataSet";
            this.деканатDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // преподавателиBindingSource
            // 
            this.преподавателиBindingSource.DataMember = "Преподаватели";
            this.преподавателиBindingSource.DataSource = this.деканатDataSet;
            // 
            // преподавателиTableAdapter
            // 
            this.преподавателиTableAdapter.ClearBeforeFill = true;
            // 
            // кодзаписиDataGridViewTextBoxColumn
            // 
            this.кодзаписиDataGridViewTextBoxColumn.DataPropertyName = "Код_записи";
            this.кодзаписиDataGridViewTextBoxColumn.HeaderText = "Код_записи";
            this.кодзаписиDataGridViewTextBoxColumn.Name = "кодзаписиDataGridViewTextBoxColumn";
            // 
            // группаDataGridViewTextBoxColumn
            // 
            this.группаDataGridViewTextBoxColumn.DataPropertyName = "Группа";
            this.группаDataGridViewTextBoxColumn.HeaderText = "Группа";
            this.группаDataGridViewTextBoxColumn.Name = "группаDataGridViewTextBoxColumn";
            // 
            // фИОDataGridViewTextBoxColumn
            // 
            this.фИОDataGridViewTextBoxColumn.DataPropertyName = "ФИО";
            this.фИОDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.фИОDataGridViewTextBoxColumn.Name = "фИОDataGridViewTextBoxColumn";
            // 
            // дисциплинаDataGridViewTextBoxColumn
            // 
            this.дисциплинаDataGridViewTextBoxColumn.DataPropertyName = "Дисциплина";
            this.дисциплинаDataGridViewTextBoxColumn.HeaderText = "Дисциплина";
            this.дисциплинаDataGridViewTextBoxColumn.Name = "дисциплинаDataGridViewTextBoxColumn";
            // 
            // контрольDataGridViewTextBoxColumn
            // 
            this.контрольDataGridViewTextBoxColumn.DataPropertyName = "Контроль";
            this.контрольDataGridViewTextBoxColumn.HeaderText = "Контроль";
            this.контрольDataGridViewTextBoxColumn.Name = "контрольDataGridViewTextBoxColumn";
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.деканатDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ДеканатDataSet деканатDataSet;
        private System.Windows.Forms.BindingSource преподавателиBindingSource;
        private ДеканатDataSetTableAdapters.ПреподавателиTableAdapter преподавателиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодзаписиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn группаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фИОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn дисциплинаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn контрольDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
    }
}