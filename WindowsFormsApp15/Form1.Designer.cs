
namespace WindowsFormsApp15
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.деканатDataSet = new WindowsFormsApp15.ДеканатDataSet();
            this.деканатDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.группыTableAdapter = new WindowsFormsApp15.ДеканатDataSetTableAdapters.ГруппыTableAdapter();
            this.дисциплиныBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.дисциплиныTableAdapter = new WindowsFormsApp15.ДеканатDataSetTableAdapters.ДисциплиныTableAdapter();
            this.преподавателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.преподавателиTableAdapter = new WindowsFormsApp15.ДеканатDataSetTableAdapters.ПреподавателиTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.деканатDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.деканатDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.дисциплиныBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // деканатDataSet
            // 
            this.деканатDataSet.DataSetName = "ДеканатDataSet";
            this.деканатDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // деканатDataSetBindingSource
            // 
            this.деканатDataSetBindingSource.DataSource = this.деканатDataSet;
            this.деканатDataSetBindingSource.Position = 0;
            // 
            // группыBindingSource
            // 
            this.группыBindingSource.DataMember = "Группы";
            this.группыBindingSource.DataSource = this.деканатDataSetBindingSource;
            // 
            // группыTableAdapter
            // 
            this.группыTableAdapter.ClearBeforeFill = true;
            // 
            // дисциплиныBindingSource
            // 
            this.дисциплиныBindingSource.DataMember = "Дисциплины";
            this.дисциплиныBindingSource.DataSource = this.деканатDataSetBindingSource;
            // 
            // дисциплиныTableAdapter
            // 
            this.дисциплиныTableAdapter.ClearBeforeFill = true;
            // 
            // преподавателиBindingSource
            // 
            this.преподавателиBindingSource.DataMember = "Преподаватели";
            this.преподавателиBindingSource.DataSource = this.деканатDataSetBindingSource;
            // 
            // преподавателиTableAdapter
            // 
            this.преподавателиTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Группы";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(284, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 32);
            this.button2.TabIndex = 1;
            this.button2.Text = "Дисциплинны";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(506, 218);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(169, 31);
            this.button3.TabIndex = 2;
            this.button3.Text = "Преподаватели";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(139, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(426, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Открыть таблицу";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(260, 381);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(189, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Выход";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.деканатDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.деканатDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.группыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.дисциплиныBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.преподавателиBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource деканатDataSetBindingSource;
        private ДеканатDataSet деканатDataSet;
        private System.Windows.Forms.BindingSource группыBindingSource;
        private ДеканатDataSetTableAdapters.ГруппыTableAdapter группыTableAdapter;
        private System.Windows.Forms.BindingSource дисциплиныBindingSource;
        private ДеканатDataSetTableAdapters.ДисциплиныTableAdapter дисциплиныTableAdapter;
        private System.Windows.Forms.BindingSource преподавателиBindingSource;
        private ДеканатDataSetTableAdapters.ПреподавателиTableAdapter преподавателиTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
    }
}

