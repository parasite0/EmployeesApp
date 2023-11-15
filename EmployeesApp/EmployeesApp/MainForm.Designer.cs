
namespace EmployeesApp
{
    partial class MainForm
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
            this.btnList = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.labelSearch = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesDbDataSet = new EmployeesApp.EmployeesDbDataSet();
            this.btnNewEmployee = new System.Windows.Forms.Button();
            this.btnDismissal = new System.Windows.Forms.Button();
            this.btnStat = new System.Windows.Forms.Button();
            this.btnUnloading = new System.Windows.Forms.Button();
            this.employeesTableAdapter = new EmployeesApp.EmployeesDbDataSetTableAdapters.EmployeesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDbDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnList.Location = new System.Drawing.Point(13, 13);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(184, 64);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "Отобразить список сотрудников";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxSearch.Location = new System.Drawing.Point(574, 13);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(202, 26);
            this.txtBoxSearch.TabIndex = 1;
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSearch.Location = new System.Drawing.Point(410, 15);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(158, 21);
            this.labelSearch.TabIndex = 2;
            this.labelSearch.Text = "Поиск сотрудника";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearch.Location = new System.Drawing.Point(701, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(763, 216);
            this.dataGridView1.TabIndex = 4;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.employeesDbDataSet;
            // 
            // employeesDbDataSet
            // 
            this.employeesDbDataSet.DataSetName = "EmployeesDbDataSet";
            this.employeesDbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnNewEmployee
            // 
            this.btnNewEmployee.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNewEmployee.Location = new System.Drawing.Point(13, 348);
            this.btnNewEmployee.Name = "btnNewEmployee";
            this.btnNewEmployee.Size = new System.Drawing.Size(184, 31);
            this.btnNewEmployee.TabIndex = 5;
            this.btnNewEmployee.Text = "Новый сотрудник";
            this.btnNewEmployee.UseVisualStyleBackColor = true;
            this.btnNewEmployee.Click += new System.EventHandler(this.btnNewEmployee_Click);
            // 
            // btnDismissal
            // 
            this.btnDismissal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDismissal.Location = new System.Drawing.Point(13, 395);
            this.btnDismissal.Name = "btnDismissal";
            this.btnDismissal.Size = new System.Drawing.Size(184, 30);
            this.btnDismissal.TabIndex = 6;
            this.btnDismissal.Text = "Увольнение сотрудника";
            this.btnDismissal.UseVisualStyleBackColor = true;
            this.btnDismissal.Click += new System.EventHandler(this.btnDismissal_Click);
            // 
            // btnStat
            // 
            this.btnStat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStat.Location = new System.Drawing.Point(346, 348);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(103, 31);
            this.btnStat.TabIndex = 7;
            this.btnStat.Text = "Статистика";
            this.btnStat.UseVisualStyleBackColor = true;
            this.btnStat.Click += new System.EventHandler(this.btnStat_Click);
            // 
            // btnUnloading
            // 
            this.btnUnloading.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnUnloading.Location = new System.Drawing.Point(591, 348);
            this.btnUnloading.Name = "btnUnloading";
            this.btnUnloading.Size = new System.Drawing.Size(186, 31);
            this.btnUnloading.TabIndex = 8;
            this.btnUnloading.Text = "Выгрузка списка в xml";
            this.btnUnloading.UseVisualStyleBackColor = true;
            this.btnUnloading.Click += new System.EventHandler(this.btnUnloading_Click);
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 450);
            this.Controls.Add(this.btnUnloading);
            this.Controls.Add(this.btnStat);
            this.Controls.Add(this.btnDismissal);
            this.Controls.Add(this.btnNewEmployee);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.txtBoxSearch);
            this.Controls.Add(this.btnList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Учёт сотрудников";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDbDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNewEmployee;
        private System.Windows.Forms.Button btnDismissal;
        private System.Windows.Forms.Button btnStat;
        private System.Windows.Forms.Button btnUnloading;
        private EmployeesDbDataSet employeesDbDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private EmployeesDbDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
    }
}

