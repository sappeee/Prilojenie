
namespace WindowsFormsApp15
{
    partial class Form2
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
            this.группыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группыTableAdapter = new WindowsFormsApp15.ДеканатDataSetTableAdapters.ГруппыTableAdapter();
            this.кодгруппыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.курсDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествостудентовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.объемчасовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.началосессииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.окончаниесессииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.дисциплиныBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дисциплиныTableAdapter = new WindowsFormsApp15.ДеканатDataSetTableAdapters.ДисциплиныTableAdapter();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.деканатDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дисциплиныBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодгруппыDataGridViewTextBoxColumn,
            this.курсDataGridViewTextBoxColumn,
            this.количествостудентовDataGridViewTextBoxColumn,
            this.объемчасовDataGridViewTextBoxColumn,
            this.началосессииDataGridViewTextBoxColumn,
            this.окончаниесессииDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.группыBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(43, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // деканатDataSet
            // 
            this.деканатDataSet.DataSetName = "ДеканатDataSet";
            this.деканатDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // группыBindingSource
            // 
            this.группыBindingSource.DataMember = "Группы";
            this.группыBindingSource.DataSource = this.деканатDataSet;
            // 
            // группыTableAdapter
            // 
            this.группыTableAdapter.ClearBeforeFill = true;
            // 
            // кодгруппыDataGridViewTextBoxColumn
            // 
            this.кодгруппыDataGridViewTextBoxColumn.DataPropertyName = "Кодгруппы";
            this.кодгруппыDataGridViewTextBoxColumn.HeaderText = "Кодгруппы";
            this.кодгруппыDataGridViewTextBoxColumn.Name = "кодгруппыDataGridViewTextBoxColumn";
            // 
            // курсDataGridViewTextBoxColumn
            // 
            this.курсDataGridViewTextBoxColumn.DataPropertyName = "Курс";
            this.курсDataGridViewTextBoxColumn.HeaderText = "Курс";
            this.курсDataGridViewTextBoxColumn.Name = "курсDataGridViewTextBoxColumn";
            // 
            // количествостудентовDataGridViewTextBoxColumn
            // 
            this.количествостудентовDataGridViewTextBoxColumn.DataPropertyName = "Количествостудентов";
            this.количествостудентовDataGridViewTextBoxColumn.HeaderText = "Количествостудентов";
            this.количествостудентовDataGridViewTextBoxColumn.Name = "количествостудентовDataGridViewTextBoxColumn";
            // 
            // объемчасовDataGridViewTextBoxColumn
            // 
            this.объемчасовDataGridViewTextBoxColumn.DataPropertyName = "объемчасов";
            this.объемчасовDataGridViewTextBoxColumn.HeaderText = "объемчасов";
            this.объемчасовDataGridViewTextBoxColumn.Name = "объемчасовDataGridViewTextBoxColumn";
            // 
            // началосессииDataGridViewTextBoxColumn
            // 
            this.началосессииDataGridViewTextBoxColumn.DataPropertyName = "Началосессии";
            this.началосессииDataGridViewTextBoxColumn.HeaderText = "Началосессии";
            this.началосессииDataGridViewTextBoxColumn.Name = "началосессииDataGridViewTextBoxColumn";
            // 
            // окончаниесессииDataGridViewTextBoxColumn
            // 
            this.окончаниесессииDataGridViewTextBoxColumn.DataPropertyName = "Окончаниесессии";
            this.окончаниесессииDataGridViewTextBoxColumn.HeaderText = "Окончаниесессии";
            this.окончаниесессииDataGridViewTextBoxColumn.Name = "окончаниесессииDataGridViewTextBoxColumn";
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
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.деканатDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дисциплиныBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ДеканатDataSet деканатDataSet;
        private System.Windows.Forms.BindingSource группыBindingSource;
        private ДеканатDataSetTableAdapters.ГруппыTableAdapter группыTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодгруппыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn курсDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествостудентовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn объемчасовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn началосессииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn окончаниесессииDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource дисциплиныBindingSource;
        private ДеканатDataSetTableAdapters.ДисциплиныTableAdapter дисциплиныTableAdapter;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}