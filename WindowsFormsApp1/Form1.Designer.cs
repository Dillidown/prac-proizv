namespace WindowsFormsApp1
{
    partial class Main
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabPageEmployees = new System.Windows.Forms.TabPage();
            this.labelExpirience = new System.Windows.Forms.Label();
            this.comboBoxExpirience = new System.Windows.Forms.ComboBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.labelCompany = new System.Windows.Forms.Label();
            this.comboBoxCompany = new System.Windows.Forms.ComboBox();
            this.dataGridViewEmployees = new System.Windows.Forms.DataGridView();
            this.idEmployeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expirienceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.sedmaxDataSet1 = new WindowsFormsApp1.sedmaxDataSet1();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.tabPageClients = new System.Windows.Forms.TabPage();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelCompanyClients = new System.Windows.Forms.Label();
            this.comboBoxCompanyClients = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.dataGridClients = new System.Windows.Forms.DataGridView();
            this.idClientsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectedCompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblClients = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.sedmaxDataSet = new WindowsFormsApp1.sedmaxDataSet();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter = new WindowsFormsApp1.sedmaxDataSetTableAdapters.EmployeesTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.employeesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeesTableAdapter1 = new WindowsFormsApp1.sedmaxDataSet1TableAdapters.EmployeesTableAdapter();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.labelDelete = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.textBoxSelect = new System.Windows.Forms.TextBox();
            this.labelFind = new System.Windows.Forms.Label();
            this.clientsTableAdapter = new WindowsFormsApp1.sedmaxDataSet1TableAdapters.ClientsTableAdapter();
            this.tabMain.SuspendLayout();
            this.tabPageEmployees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedmaxDataSet1)).BeginInit();
            this.tabPageClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedmaxDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabPageEmployees);
            this.tabMain.Controls.Add(this.tabPageClients);
            this.tabMain.Location = new System.Drawing.Point(9, 7);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(1373, 427);
            this.tabMain.TabIndex = 16;
            // 
            // tabPageEmployees
            // 
            this.tabPageEmployees.BackColor = System.Drawing.Color.NavajoWhite;
            this.tabPageEmployees.Controls.Add(this.labelExpirience);
            this.tabPageEmployees.Controls.Add(this.comboBoxExpirience);
            this.tabPageEmployees.Controls.Add(this.labelPosition);
            this.tabPageEmployees.Controls.Add(this.comboBoxPosition);
            this.tabPageEmployees.Controls.Add(this.labelCompany);
            this.tabPageEmployees.Controls.Add(this.comboBoxCompany);
            this.tabPageEmployees.Controls.Add(this.dataGridViewEmployees);
            this.tabPageEmployees.Controls.Add(this.lblEmployees);
            this.tabPageEmployees.Font = new System.Drawing.Font("Bookman Old Style", 9.25F);
            this.tabPageEmployees.Location = new System.Drawing.Point(4, 22);
            this.tabPageEmployees.Name = "tabPageEmployees";
            this.tabPageEmployees.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageEmployees.Size = new System.Drawing.Size(1365, 401);
            this.tabPageEmployees.TabIndex = 0;
            this.tabPageEmployees.Text = "Сотрудники";
            // 
            // labelExpirience
            // 
            this.labelExpirience.AutoSize = true;
            this.labelExpirience.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelExpirience.Location = new System.Drawing.Point(17, 348);
            this.labelExpirience.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExpirience.Name = "labelExpirience";
            this.labelExpirience.Size = new System.Drawing.Size(204, 22);
            this.labelExpirience.TabIndex = 17;
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
            this.comboBoxExpirience.Location = new System.Drawing.Point(229, 348);
            this.comboBoxExpirience.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxExpirience.Name = "comboBoxExpirience";
            this.comboBoxExpirience.Size = new System.Drawing.Size(133, 23);
            this.comboBoxExpirience.TabIndex = 16;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosition.Location = new System.Drawing.Point(17, 312);
            this.labelPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(248, 22);
            this.labelPosition.TabIndex = 15;
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
            this.comboBoxPosition.Location = new System.Drawing.Point(270, 312);
            this.comboBoxPosition.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(133, 23);
            this.comboBoxPosition.TabIndex = 14;
            // 
            // labelCompany
            // 
            this.labelCompany.AutoSize = true;
            this.labelCompany.Font = new System.Drawing.Font("Californian FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompany.Location = new System.Drawing.Point(17, 278);
            this.labelCompany.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompany.Name = "labelCompany";
            this.labelCompany.Size = new System.Drawing.Size(375, 22);
            this.labelCompany.TabIndex = 13;
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
            this.comboBoxCompany.Location = new System.Drawing.Point(400, 278);
            this.comboBoxCompany.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCompany.Name = "comboBoxCompany";
            this.comboBoxCompany.Size = new System.Drawing.Size(133, 23);
            this.comboBoxCompany.TabIndex = 12;
            // 
            // dataGridViewEmployees
            // 
            this.dataGridViewEmployees.AutoGenerateColumns = false;
            this.dataGridViewEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployees.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEmployeeDataGridViewTextBoxColumn,
            this.companyDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn,
            this.expirienceDataGridViewTextBoxColumn});
            this.dataGridViewEmployees.DataSource = this.employeesBindingSource2;
            this.dataGridViewEmployees.Location = new System.Drawing.Point(5, 50);
            this.dataGridViewEmployees.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewEmployees.Name = "dataGridViewEmployees";
            this.dataGridViewEmployees.RowHeadersWidth = 51;
            this.dataGridViewEmployees.RowTemplate.Height = 24;
            this.dataGridViewEmployees.Size = new System.Drawing.Size(1355, 224);
            this.dataGridViewEmployees.TabIndex = 2;
            // 
            // idEmployeeDataGridViewTextBoxColumn
            // 
            this.idEmployeeDataGridViewTextBoxColumn.DataPropertyName = "id_Employee";
            this.idEmployeeDataGridViewTextBoxColumn.HeaderText = "id";
            this.idEmployeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idEmployeeDataGridViewTextBoxColumn.Name = "idEmployeeDataGridViewTextBoxColumn";
            this.idEmployeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyDataGridViewTextBoxColumn
            // 
            this.companyDataGridViewTextBoxColumn.DataPropertyName = "Company";
            this.companyDataGridViewTextBoxColumn.HeaderText = "Компания";
            this.companyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyDataGridViewTextBoxColumn.Name = "companyDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Должность";
            this.positionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // expirienceDataGridViewTextBoxColumn
            // 
            this.expirienceDataGridViewTextBoxColumn.DataPropertyName = "Expirience";
            this.expirienceDataGridViewTextBoxColumn.HeaderText = "Стаж";
            this.expirienceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expirienceDataGridViewTextBoxColumn.Name = "expirienceDataGridViewTextBoxColumn";
            // 
            // employeesBindingSource2
            // 
            this.employeesBindingSource2.DataMember = "Employees";
            this.employeesBindingSource2.DataSource = this.sedmaxDataSet1;
            // 
            // sedmaxDataSet1
            // 
            this.sedmaxDataSet1.DataSetName = "sedmaxDataSet1";
            this.sedmaxDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Myanmar Text", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployees.Location = new System.Drawing.Point(625, 3);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(85, 34);
            this.lblEmployees.TabIndex = 1;
            this.lblEmployees.Text = "Workers";
            // 
            // tabPageClients
            // 
            this.tabPageClients.BackColor = System.Drawing.Color.RosyBrown;
            this.tabPageClients.Controls.Add(this.textBoxName);
            this.tabPageClients.Controls.Add(this.labelCompanyClients);
            this.tabPageClients.Controls.Add(this.comboBoxCompanyClients);
            this.tabPageClients.Controls.Add(this.labelName);
            this.tabPageClients.Controls.Add(this.dataGridClients);
            this.tabPageClients.Controls.Add(this.lblClients);
            this.tabPageClients.Font = new System.Drawing.Font("Bookman Old Style", 9.25F);
            this.tabPageClients.Location = new System.Drawing.Point(4, 22);
            this.tabPageClients.Name = "tabPageClients";
            this.tabPageClients.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tabPageClients.Size = new System.Drawing.Size(1365, 401);
            this.tabPageClients.TabIndex = 1;
            this.tabPageClients.Text = "Клиенты";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(196, 265);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(133, 22);
            this.textBoxName.TabIndex = 24;
            // 
            // labelCompanyClients
            // 
            this.labelCompanyClients.AutoSize = true;
            this.labelCompanyClients.Font = new System.Drawing.Font("Bodoni Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompanyClients.Location = new System.Drawing.Point(5, 298);
            this.labelCompanyClients.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompanyClients.Name = "labelCompanyClients";
            this.labelCompanyClients.Size = new System.Drawing.Size(394, 22);
            this.labelCompanyClients.TabIndex = 21;
            this.labelCompanyClients.Text = "Выберите компанию с которой работает клиент:";
            // 
            // comboBoxCompanyClients
            // 
            this.comboBoxCompanyClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompanyClients.Font = new System.Drawing.Font("Bookman Old Style", 8.25F);
            this.comboBoxCompanyClients.FormattingEnabled = true;
            this.comboBoxCompanyClients.Items.AddRange(new object[] {
            "Sedmax",
            "Satec",
            "En-Pro"});
            this.comboBoxCompanyClients.Location = new System.Drawing.Point(362, 298);
            this.comboBoxCompanyClients.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCompanyClients.Name = "comboBoxCompanyClients";
            this.comboBoxCompanyClients.Size = new System.Drawing.Size(133, 23);
            this.comboBoxCompanyClients.TabIndex = 20;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Bodoni Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(5, 262);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(187, 22);
            this.labelName.TabIndex = 19;
            this.labelName.Text = "Введите имя клиента:";
            // 
            // dataGridClients
            // 
            this.dataGridClients.AutoGenerateColumns = false;
            this.dataGridClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridClients.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dataGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClientsDataGridViewTextBoxColumn,
            this.clientsNameDataGridViewTextBoxColumn,
            this.selectedCompanyDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridClients.DataSource = this.clientsBindingSource;
            this.dataGridClients.Location = new System.Drawing.Point(5, 50);
            this.dataGridClients.Name = "dataGridClients";
            this.dataGridClients.RowHeadersWidth = 51;
            this.dataGridClients.Size = new System.Drawing.Size(1354, 209);
            this.dataGridClients.TabIndex = 3;
            // 
            // idClientsDataGridViewTextBoxColumn
            // 
            this.idClientsDataGridViewTextBoxColumn.DataPropertyName = "id_Clients";
            this.idClientsDataGridViewTextBoxColumn.HeaderText = "id";
            this.idClientsDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idClientsDataGridViewTextBoxColumn.Name = "idClientsDataGridViewTextBoxColumn";
            this.idClientsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientsNameDataGridViewTextBoxColumn
            // 
            this.clientsNameDataGridViewTextBoxColumn.DataPropertyName = "Clients_Name";
            this.clientsNameDataGridViewTextBoxColumn.HeaderText = "Клиент";
            this.clientsNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientsNameDataGridViewTextBoxColumn.Name = "clientsNameDataGridViewTextBoxColumn";
            // 
            // selectedCompanyDataGridViewTextBoxColumn
            // 
            this.selectedCompanyDataGridViewTextBoxColumn.DataPropertyName = "Selected_Company";
            this.selectedCompanyDataGridViewTextBoxColumn.HeaderText = "Компания";
            this.selectedCompanyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.selectedCompanyDataGridViewTextBoxColumn.Name = "selectedCompanyDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "Comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "Комментарий";
            this.commentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.sedmaxDataSet1;
            // 
            // lblClients
            // 
            this.lblClients.AutoSize = true;
            this.lblClients.Font = new System.Drawing.Font("Bodoni Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClients.Location = new System.Drawing.Point(650, 3);
            this.lblClients.Name = "lblClients";
            this.lblClients.Size = new System.Drawing.Size(77, 22);
            this.lblClients.TabIndex = 2;
            this.lblClients.Text = "Клиенты";
            // 
            // buttonClose
            // 
            this.buttonClose.Font = new System.Drawing.Font("Bodoni Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.Location = new System.Drawing.Point(1257, 515);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(125, 31);
            this.buttonClose.TabIndex = 15;
            this.buttonClose.Text = "close";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Font = new System.Drawing.Font("Bodoni Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(1011, 436);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(371, 32);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "remove";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Font = new System.Drawing.Font("Bodoni Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEdit.Location = new System.Drawing.Point(903, 436);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(98, 32);
            this.buttonEdit.TabIndex = 13;
            this.buttonEdit.Text = "change";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Bodoni Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(9, 440);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(371, 35);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "add";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // sedmaxDataSet
            // 
            this.sedmaxDataSet.DataSetName = "sedmaxDataSet";
            this.sedmaxDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.sedmaxDataSet;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // employeesBindingSource1
            // 
            this.employeesBindingSource1.DataMember = "Employees";
            this.employeesBindingSource1.DataSource = this.sedmaxDataSet1;
            // 
            // employeesTableAdapter1
            // 
            this.employeesTableAdapter1.ClearBeforeFill = true;
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(833, 442);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.Size = new System.Drawing.Size(65, 20);
            this.textBoxId.TabIndex = 18;
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Font = new System.Drawing.Font("Bodoni Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelete.Location = new System.Drawing.Point(641, 441);
            this.labelDelete.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(188, 22);
            this.labelDelete.TabIndex = 19;
            this.labelDelete.Text = "id to remove / change";
            // 
            // buttonFind
            // 
            this.buttonFind.Font = new System.Drawing.Font("Bodoni Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFind.Location = new System.Drawing.Point(903, 470);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(98, 33);
            this.buttonFind.TabIndex = 20;
            this.buttonFind.Text = "find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // textBoxSelect
            // 
            this.textBoxSelect.Location = new System.Drawing.Point(719, 477);
            this.textBoxSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxSelect.Name = "textBoxSelect";
            this.textBoxSelect.Size = new System.Drawing.Size(179, 20);
            this.textBoxSelect.TabIndex = 21;
            // 
            // labelFind
            // 
            this.labelFind.AutoSize = true;
            this.labelFind.Font = new System.Drawing.Font("Bodoni Bd BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFind.Location = new System.Drawing.Point(641, 472);
            this.labelFind.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFind.Name = "labelFind";
            this.labelFind.Size = new System.Drawing.Size(62, 22);
            this.labelFind.TabIndex = 22;
            this.labelFind.Text = "search";
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1394, 558);
            this.Controls.Add(this.labelFind);
            this.Controls.Add(this.textBoxSelect);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.MaximumSize = new System.Drawing.Size(10000, 10000);
            this.MinimumSize = new System.Drawing.Size(951, 597);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabMain.ResumeLayout(false);
            this.tabPageEmployees.ResumeLayout(false);
            this.tabPageEmployees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedmaxDataSet1)).EndInit();
            this.tabPageClients.ResumeLayout(false);
            this.tabPageClients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedmaxDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabPageEmployees;
        private System.Windows.Forms.Label lblEmployees;
        private System.Windows.Forms.TabPage tabPageClients;
        private System.Windows.Forms.DataGridView dataGridClients;
        private System.Windows.Forms.Label lblClients;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridView dataGridViewEmployees;
        private sedmaxDataSet sedmaxDataSet;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private sedmaxDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private sedmaxDataSet1 sedmaxDataSet1;
        private System.Windows.Forms.BindingSource employeesBindingSource1;
        private sedmaxDataSet1TableAdapters.EmployeesTableAdapter employeesTableAdapter1;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.BindingSource employeesBindingSource2;
        private System.Windows.Forms.Label labelExpirience;
        private System.Windows.Forms.ComboBox comboBoxExpirience;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.Label labelCompany;
        private System.Windows.Forms.ComboBox comboBoxCompany;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxSelect;
        private System.Windows.Forms.Label labelFind;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private sedmaxDataSet1TableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.Label labelCompanyClients;
        private System.Windows.Forms.ComboBox comboBoxCompanyClients;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEmployeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expirienceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClientsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientsNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn selectedCompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
    }
}

