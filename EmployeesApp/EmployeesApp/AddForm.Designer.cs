
namespace EmployeesApp
{
    partial class AddForm
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
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.txtBoxJobTitle = new System.Windows.Forms.TextBox();
            this.dateTimePickerEmp = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownSalary = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddNewEmp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxName
            // 
            this.txtBoxName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxName.Location = new System.Drawing.Point(24, 41);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(100, 22);
            this.txtBoxName.TabIndex = 0;
            // 
            // txtBoxJobTitle
            // 
            this.txtBoxJobTitle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBoxJobTitle.Location = new System.Drawing.Point(160, 40);
            this.txtBoxJobTitle.Name = "txtBoxJobTitle";
            this.txtBoxJobTitle.Size = new System.Drawing.Size(100, 22);
            this.txtBoxJobTitle.TabIndex = 1;
            // 
            // dateTimePickerEmp
            // 
            this.dateTimePickerEmp.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerEmp.Location = new System.Drawing.Point(435, 41);
            this.dateTimePickerEmp.Name = "dateTimePickerEmp";
            this.dateTimePickerEmp.Size = new System.Drawing.Size(164, 22);
            this.dateTimePickerEmp.TabIndex = 3;
            this.dateTimePickerEmp.Value = new System.DateTime(2023, 11, 11, 0, 0, 0, 0);
            // 
            // numericUpDownSalary
            // 
            this.numericUpDownSalary.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownSalary.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSalary.Location = new System.Drawing.Point(303, 40);
            this.numericUpDownSalary.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownSalary.Name = "numericUpDownSalary";
            this.numericUpDownSalary.Size = new System.Drawing.Size(102, 22);
            this.numericUpDownSalary.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(20, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(156, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(299, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Оклад";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(431, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата приёма на работу";
            // 
            // btnAddNewEmp
            // 
            this.btnAddNewEmp.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAddNewEmp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAddNewEmp.Location = new System.Drawing.Point(470, 73);
            this.btnAddNewEmp.Name = "btnAddNewEmp";
            this.btnAddNewEmp.Size = new System.Drawing.Size(129, 49);
            this.btnAddNewEmp.TabIndex = 9;
            this.btnAddNewEmp.Text = "Добавить сотрудника";
            this.btnAddNewEmp.UseVisualStyleBackColor = true;
            this.btnAddNewEmp.Click += new System.EventHandler(this.btnAddNewEmp_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 134);
            this.Controls.Add(this.btnAddNewEmp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownSalary);
            this.Controls.Add(this.dateTimePickerEmp);
            this.Controls.Add(this.txtBoxJobTitle);
            this.Controls.Add(this.txtBoxName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddForm";
            this.ShowIcon = false;
            this.Text = "Добавление сотрудника";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddNewEmp;
        protected internal System.Windows.Forms.TextBox txtBoxName;
        protected internal System.Windows.Forms.TextBox txtBoxJobTitle;
        protected internal System.Windows.Forms.DateTimePicker dateTimePickerEmp;
        protected internal System.Windows.Forms.NumericUpDown numericUpDownSalary;
    }
}