
namespace EmployeesApp
{
    partial class DismissalForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnDismissalAgree = new System.Windows.Forms.Button();
            this.dateTimePickerDis = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownDisId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisId)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Введите Id сотрудника";
            // 
            // btnDismissalAgree
            // 
            this.btnDismissalAgree.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDismissalAgree.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDismissalAgree.Location = new System.Drawing.Point(157, 76);
            this.btnDismissalAgree.Name = "btnDismissalAgree";
            this.btnDismissalAgree.Size = new System.Drawing.Size(75, 25);
            this.btnDismissalAgree.TabIndex = 2;
            this.btnDismissalAgree.Text = "ОК";
            this.btnDismissalAgree.UseVisualStyleBackColor = true;
            this.btnDismissalAgree.Click += new System.EventHandler(this.btnDismissalAgree_Click);
            // 
            // dateTimePickerDis
            // 
            this.dateTimePickerDis.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerDis.Location = new System.Drawing.Point(218, 40);
            this.dateTimePickerDis.Name = "dateTimePickerDis";
            this.dateTimePickerDis.Size = new System.Drawing.Size(147, 22);
            this.dateTimePickerDis.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(214, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата увольнения";
            // 
            // numericUpDownDisId
            // 
            this.numericUpDownDisId.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDownDisId.Location = new System.Drawing.Point(16, 41);
            this.numericUpDownDisId.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownDisId.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDisId.Name = "numericUpDownDisId";
            this.numericUpDownDisId.Size = new System.Drawing.Size(158, 22);
            this.numericUpDownDisId.TabIndex = 5;
            this.numericUpDownDisId.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DismissalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 115);
            this.Controls.Add(this.numericUpDownDisId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerDis);
            this.Controls.Add(this.btnDismissalAgree);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DismissalForm";
            this.ShowIcon = false;
            this.Text = "Увольнение сотрудника";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDismissalAgree;
        private System.Windows.Forms.Label label2;
        protected internal System.Windows.Forms.DateTimePicker dateTimePickerDis;
        protected internal System.Windows.Forms.NumericUpDown numericUpDownDisId;
    }
}