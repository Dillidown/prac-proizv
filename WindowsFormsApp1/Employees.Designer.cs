namespace WindowsFormsApp1
{
    partial class Employees
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
            this.closeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.labelExpirience = new System.Windows.Forms.Label();
            this.comboBoxExpirience = new System.Windows.Forms.ComboBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.labelCompany = new System.Windows.Forms.Label();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.textBoxUpdate = new System.Windows.Forms.TextBox();
            this.groupBoxEmployee.SuspendLayout();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("Bookman Old Style", 12.25F);
            this.closeButton.Location = new System.Drawing.Point(652, 387);
            this.closeButton.Margin = new System.Windows.Forms.Padding(4);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(136, 37);
            this.closeButton.TabIndex = 20;
            this.closeButton.Text = "Закрыть";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Bookman Old Style", 12.25F);
            this.addButton.Location = new System.Drawing.Point(564, 227);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(224, 56);
            this.addButton.TabIndex = 19;
            this.addButton.Text = "Добавить сотрудника";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.Controls.Add(this.labelExpirience);
            this.groupBoxEmployee.Controls.Add(this.comboBoxExpirience);
            this.groupBoxEmployee.Controls.Add(this.labelPosition);
            this.groupBoxEmployee.Controls.Add(this.comboBoxPosition);
            this.groupBoxEmployee.Controls.Add(this.labelCompany);
            this.groupBoxEmployee.Controls.Add(this.comboBoxCompany);
            this.groupBoxEmployee.Font = new System.Drawing.Font("Bookman Old Style", 10.25F);
            this.groupBoxEmployee.Location = new System.Drawing.Point(13, 27);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Size = new System.Drawing.Size(510, 337);
            this.groupBoxEmployee.TabIndex = 18;
            this.groupBoxEmployee.TabStop = false;
            this.groupBoxEmployee.Text = "Окно добавления сотрудника";
            // 
            // labelExpirience
            // 
            this.labelExpirience.AutoSize = true;
            this.labelExpirience.Font = new System.Drawing.Font("Bookman Old Style", 10.25F);
            this.labelExpirience.Location = new System.Drawing.Point(6, 218);
            this.labelExpirience.Name = "labelExpirience";
            this.labelExpirience.Size = new System.Drawing.Size(269, 20);
            this.labelExpirience.TabIndex = 11;
            this.labelExpirience.Text = "Выберите стаж сотрудника:";
            // 
            // comboBoxExpirience
            // 
            this.comboBoxExpirience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExpirience.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.comboBoxExpirience.FormattingEnabled = true;
            this.comboBoxExpirience.Items.AddRange(new object[] {
            "Меньше 1 года",
            "От 1 до 3 лет",
            "От 3 до 5 лет",
            "От 5 до 10 лет",
            "От 10 лет"});
            this.comboBoxExpirience.Location = new System.Drawing.Point(10, 253);
            this.comboBoxExpirience.Name = "comboBoxExpirience";
            this.comboBoxExpirience.Size = new System.Drawing.Size(176, 27);
            this.comboBoxExpirience.TabIndex = 10;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Bookman Old Style", 10.25F);
            this.labelPosition.Location = new System.Drawing.Point(6, 134);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(321, 20);
            this.labelPosition.TabIndex = 9;
            this.labelPosition.Text = "Выберите должность сотрудника:";
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPosition.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Items.AddRange(new object[] {
            "Core-программист",
            "Backend-программист",
            "Frontend-программист",
            "Дизайнер",
            "Инженер",
            "Наладчик",
            "Продуктонер",
            "Скрам-Мастер"});
            this.comboBoxPosition.Location = new System.Drawing.Point(10, 169);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(176, 27);
            this.comboBoxPosition.TabIndex = 8;
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Font = new System.Drawing.Font("Bookman Old Style", 10.25F);
            this.labelCompany.Location = new System.Drawing.Point(6, 50);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(494, 20);
            this.labelCompany.TabIndex = 7;
            this.labelCompany.Text = "Выберите компанию в которой работает сотрудник:";
            // 
            // comboBoxCompany
            // 
            this.comboBoxCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompany.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.comboBoxCompany.FormattingEnabled = true;
            this.comboBoxCompany.Items.AddRange(new object[] {
            "Sedmax",
            "Satec",
            "En-Pro"});
            this.comboBoxCompany.Location = new System.Drawing.Point(10, 85);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(176, 27);
            this.comboBoxCompany.TabIndex = 6;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Bookman Old Style", 12.25F);
            this.buttonUpdate.Location = new System.Drawing.Point(564, 291);
            this.buttonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(224, 56);
            this.buttonUpdate.TabIndex = 21;
            this.buttonUpdate.Text = "Добавить сотрудника";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // textBoxUpdate
            // 
            this.textBoxUpdate.Location = new System.Drawing.Point(623, 116);
            this.textBoxUpdate.Name = "textBoxUpdate";
            this.textBoxUpdate.Size = new System.Drawing.Size(100, 22);
            this.textBoxUpdate.TabIndex = 22;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxUpdate);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBoxEmployee);
            this.Name = "Employees";
            this.Text = "Emloyees";
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxEmployee.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox groupBoxEmployee;
        private System.Windows.Forms.Label labelExpirience;
        private System.Windows.Forms.ComboBox comboBoxExpirience;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.TextBox textBoxUpdate;
    }
}