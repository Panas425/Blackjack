namespace Assignment1
{
    partial class HomesForSale
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.searchButton = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SearchBox = new System.Windows.Forms.GroupBox();
            this.ResetSearchButton = new System.Windows.Forms.Button();
            this.searchTypeLabel = new System.Windows.Forms.Label();
            this.searchTypeComboBox = new System.Windows.Forms.ComboBox();
            this.searchCityTextBox = new System.Windows.Forms.TextBox();
            this.searchCityLabel = new System.Windows.Forms.Label();
            this.localTable = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStreet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnZipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnLegalType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressBox = new System.Windows.Forms.GroupBox();
            this.CountryLabel = new System.Windows.Forms.Label();
            this.countriesComboBox = new System.Windows.Forms.ComboBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetLabel = new System.Windows.Forms.Label();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.zipCodeLabel = new System.Windows.Forms.Label();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.categoryBox = new System.Windows.Forms.GroupBox();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.typeBox = new System.Windows.Forms.GroupBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.legalBox = new System.Windows.Forms.GroupBox();
            this.legalLabel = new System.Windows.Forms.Label();
            this.legalComboBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SearchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localTable)).BeginInit();
            this.AddressBox.SuspendLayout();
            this.categoryBox.SuspendLayout();
            this.typeBox.SuspendLayout();
            this.legalBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(126, 75);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(136, 24);
            this.searchButton.TabIndex = 25;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(1160, 24);
            this.menuStrip.TabIndex = 26;
            this.menuStrip.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(37, 20);
            this.menuFile.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.saveAsToolStripMenuItem.Text = "Save as";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToXMLToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // exportToXMLToolStripMenuItem
            // 
            this.exportToXMLToolStripMenuItem.Name = "exportToXMLToolStripMenuItem";
            this.exportToXMLToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.exportToXMLToolStripMenuItem.Text = "Export to XML File";
            this.exportToXMLToolStripMenuItem.Click += new System.EventHandler(this.exportToXMLToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.Controls.Add(this.ResetSearchButton);
            this.SearchBox.Controls.Add(this.searchTypeLabel);
            this.SearchBox.Controls.Add(this.searchTypeComboBox);
            this.SearchBox.Controls.Add(this.searchCityTextBox);
            this.SearchBox.Controls.Add(this.searchButton);
            this.SearchBox.Controls.Add(this.searchCityLabel);
            this.SearchBox.Location = new System.Drawing.Point(880, 412);
            this.SearchBox.Margin = new System.Windows.Forms.Padding(2);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Padding = new System.Windows.Forms.Padding(2);
            this.SearchBox.Size = new System.Drawing.Size(263, 110);
            this.SearchBox.TabIndex = 29;
            this.SearchBox.TabStop = false;
            this.SearchBox.Text = "Search";
            // 
            // ResetSearchButton
            // 
            this.ResetSearchButton.Location = new System.Drawing.Point(4, 75);
            this.ResetSearchButton.Margin = new System.Windows.Forms.Padding(2);
            this.ResetSearchButton.Name = "ResetSearchButton";
            this.ResetSearchButton.Size = new System.Drawing.Size(110, 24);
            this.ResetSearchButton.TabIndex = 26;
            this.ResetSearchButton.Text = "Reset Search";
            this.ResetSearchButton.UseVisualStyleBackColor = true;
            this.ResetSearchButton.Click += new System.EventHandler(this.btnResetSearch_Click);
            // 
            // searchTypeLabel
            // 
            this.searchTypeLabel.AutoSize = true;
            this.searchTypeLabel.Location = new System.Drawing.Point(9, 53);
            this.searchTypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchTypeLabel.Name = "searchTypeLabel";
            this.searchTypeLabel.Size = new System.Drawing.Size(34, 13);
            this.searchTypeLabel.TabIndex = 23;
            this.searchTypeLabel.Text = "Type:";
            // 
            // searchTypeComboBox
            // 
            this.searchTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.searchTypeComboBox.FormattingEnabled = true;
            this.searchTypeComboBox.Location = new System.Drawing.Point(72, 50);
            this.searchTypeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTypeComboBox.Name = "searchTypeComboBox";
            this.searchTypeComboBox.Size = new System.Drawing.Size(191, 21);
            this.searchTypeComboBox.TabIndex = 23;
            // 
            // searchCityTextBox
            // 
            this.searchCityTextBox.Location = new System.Drawing.Point(72, 26);
            this.searchCityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchCityTextBox.MaxLength = 30;
            this.searchCityTextBox.Name = "searchCityTextBox";
            this.searchCityTextBox.Size = new System.Drawing.Size(191, 20);
            this.searchCityTextBox.TabIndex = 24;
            // 
            // searchCityLabel
            // 
            this.searchCityLabel.AutoSize = true;
            this.searchCityLabel.Location = new System.Drawing.Point(9, 26);
            this.searchCityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchCityLabel.Name = "searchCityLabel";
            this.searchCityLabel.Size = new System.Drawing.Size(27, 13);
            this.searchCityLabel.TabIndex = 23;
            this.searchCityLabel.Text = "City:";
            // 
            // localTable
            // 
            this.localTable.AllowUserToAddRows = false;
            this.localTable.AllowUserToDeleteRows = false;
            this.localTable.AllowUserToResizeColumns = false;
            this.localTable.AllowUserToResizeRows = false;
            this.localTable.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.localTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.localTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.localTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.columnCountry,
            this.ColumnCity,
            this.ColumnStreet,
            this.ColumnZipCode,
            this.ColumnCategory,
            this.ColumnType,
            this.ColumnLegalType});
            this.localTable.Location = new System.Drawing.Point(285, 26);
            this.localTable.Margin = new System.Windows.Forms.Padding(2);
            this.localTable.MultiSelect = false;
            this.localTable.Name = "localTable";
            this.localTable.ReadOnly = true;
            this.localTable.RowHeadersVisible = false;
            this.localTable.RowHeadersWidth = 20;
            this.localTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.localTable.RowTemplate.Height = 64;
            this.localTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.localTable.Size = new System.Drawing.Size(858, 382);
            this.localTable.TabIndex = 17;
            this.localTable.SelectionChanged += new System.EventHandler(this.localTable_SelectionChanged);
            // 
            // ColumnID
            // 
            this.ColumnID.FillWeight = 35F;
            this.ColumnID.Frozen = true;
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MaxInputLength = 100;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnID.Width = 40;
            // 
            // columnCountry
            // 
            this.columnCountry.FillWeight = 35F;
            this.columnCountry.Frozen = true;
            this.columnCountry.HeaderText = "Country";
            this.columnCountry.MaxInputLength = 200;
            this.columnCountry.Name = "columnCountry";
            this.columnCountry.ReadOnly = true;
            this.columnCountry.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.columnCountry.Width = 175;
            // 
            // ColumnCity
            // 
            this.ColumnCity.Frozen = true;
            this.ColumnCity.HeaderText = "City";
            this.ColumnCity.Name = "ColumnCity";
            this.ColumnCity.ReadOnly = true;
            this.ColumnCity.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnCity.Width = 150;
            // 
            // ColumnStreet
            // 
            this.ColumnStreet.Frozen = true;
            this.ColumnStreet.HeaderText = "Street";
            this.ColumnStreet.Name = "ColumnStreet";
            this.ColumnStreet.ReadOnly = true;
            this.ColumnStreet.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnStreet.Width = 175;
            // 
            // ColumnZipCode
            // 
            this.ColumnZipCode.Frozen = true;
            this.ColumnZipCode.HeaderText = "Zip Code";
            this.ColumnZipCode.Name = "ColumnZipCode";
            this.ColumnZipCode.ReadOnly = true;
            this.ColumnZipCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnZipCode.Width = 60;
            // 
            // ColumnCategory
            // 
            this.ColumnCategory.FillWeight = 35F;
            this.ColumnCategory.Frozen = true;
            this.ColumnCategory.HeaderText = "Building Category";
            this.ColumnCategory.Name = "ColumnCategory";
            this.ColumnCategory.ReadOnly = true;
            this.ColumnCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnCategory.Width = 95;
            // 
            // ColumnType
            // 
            this.ColumnType.FillWeight = 35F;
            this.ColumnType.Frozen = true;
            this.ColumnType.HeaderText = "Building Type";
            this.ColumnType.Name = "ColumnType";
            this.ColumnType.ReadOnly = true;
            this.ColumnType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnType.Width = 80;
            // 
            // ColumnLegalType
            // 
            this.ColumnLegalType.FillWeight = 35F;
            this.ColumnLegalType.Frozen = true;
            this.ColumnLegalType.HeaderText = "Legal Form";
            this.ColumnLegalType.Name = "ColumnLegalType";
            this.ColumnLegalType.ReadOnly = true;
            this.ColumnLegalType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColumnLegalType.Width = 80;
            // 
            // AddressBox
            // 
            this.AddressBox.Controls.Add(this.zipCodeTextBox);
            this.AddressBox.Controls.Add(this.zipCodeLabel);
            this.AddressBox.Controls.Add(this.streetTextBox);
            this.AddressBox.Controls.Add(this.streetLabel);
            this.AddressBox.Controls.Add(this.cityTextBox);
            this.AddressBox.Controls.Add(this.cityLabel);
            this.AddressBox.Controls.Add(this.countriesComboBox);
            this.AddressBox.Controls.Add(this.CountryLabel);
            this.AddressBox.Location = new System.Drawing.Point(11, 197);
            this.AddressBox.Margin = new System.Windows.Forms.Padding(2);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Padding = new System.Windows.Forms.Padding(2);
            this.AddressBox.Size = new System.Drawing.Size(262, 127);
            this.AddressBox.TabIndex = 23;
            this.AddressBox.TabStop = false;
            this.AddressBox.Text = "Address";
            // 
            // CountryLabel
            // 
            this.CountryLabel.AutoSize = true;
            this.CountryLabel.Location = new System.Drawing.Point(4, 26);
            this.CountryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CountryLabel.Name = "CountryLabel";
            this.CountryLabel.Size = new System.Drawing.Size(46, 13);
            this.CountryLabel.TabIndex = 21;
            this.CountryLabel.Text = "Country:";
            // 
            // countriesComboBox
            // 
            this.countriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.countriesComboBox.FormattingEnabled = true;
            this.countriesComboBox.Location = new System.Drawing.Point(70, 20);
            this.countriesComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.countriesComboBox.Name = "countriesComboBox";
            this.countriesComboBox.Size = new System.Drawing.Size(188, 21);
            this.countriesComboBox.TabIndex = 22;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(4, 57);
            this.cityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 23;
            this.cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(70, 51);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cityTextBox.MaxLength = 30;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(188, 20);
            this.cityTextBox.TabIndex = 24;
            // 
            // streetLabel
            // 
            this.streetLabel.AutoSize = true;
            this.streetLabel.Location = new System.Drawing.Point(4, 80);
            this.streetLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.streetLabel.Name = "streetLabel";
            this.streetLabel.Size = new System.Drawing.Size(38, 13);
            this.streetLabel.TabIndex = 25;
            this.streetLabel.Text = "Street:";
            // 
            // streetTextBox
            // 
            this.streetTextBox.Location = new System.Drawing.Point(70, 74);
            this.streetTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.streetTextBox.MaxLength = 30;
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(188, 20);
            this.streetTextBox.TabIndex = 26;
            // 
            // zipCodeLabel
            // 
            this.zipCodeLabel.AutoSize = true;
            this.zipCodeLabel.Location = new System.Drawing.Point(4, 102);
            this.zipCodeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.zipCodeLabel.Name = "zipCodeLabel";
            this.zipCodeLabel.Size = new System.Drawing.Size(53, 13);
            this.zipCodeLabel.TabIndex = 27;
            this.zipCodeLabel.Text = "Zip Code:";
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(70, 97);
            this.zipCodeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.zipCodeTextBox.MaxLength = 5;
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(188, 20);
            this.zipCodeTextBox.TabIndex = 28;
            this.zipCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.zipCodeTextBox_KeyPress);
            // 
            // categoryBox
            // 
            this.categoryBox.Controls.Add(this.categoryComboBox);
            this.categoryBox.Controls.Add(this.categoryLabel);
            this.categoryBox.Location = new System.Drawing.Point(11, 26);
            this.categoryBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Padding = new System.Windows.Forms.Padding(2);
            this.categoryBox.Size = new System.Drawing.Size(262, 57);
            this.categoryBox.TabIndex = 29;
            this.categoryBox.TabStop = false;
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.Location = new System.Drawing.Point(4, 26);
            this.categoryLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(52, 13);
            this.categoryLabel.TabIndex = 21;
            this.categoryLabel.Text = "Category:";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(70, 23);
            this.categoryComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(188, 21);
            this.categoryComboBox.TabIndex = 22;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // typeBox
            // 
            this.typeBox.Controls.Add(this.typeComboBox);
            this.typeBox.Controls.Add(this.typeLabel);
            this.typeBox.Location = new System.Drawing.Point(11, 87);
            this.typeBox.Margin = new System.Windows.Forms.Padding(2);
            this.typeBox.Name = "typeBox";
            this.typeBox.Padding = new System.Windows.Forms.Padding(2);
            this.typeBox.Size = new System.Drawing.Size(262, 51);
            this.typeBox.TabIndex = 30;
            this.typeBox.TabStop = false;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(4, 26);
            this.typeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(34, 13);
            this.typeLabel.TabIndex = 21;
            this.typeLabel.Text = "Type:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(70, 24);
            this.typeComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(188, 21);
            this.typeComboBox.TabIndex = 22;
            // 
            // legalBox
            // 
            this.legalBox.Controls.Add(this.legalComboBox);
            this.legalBox.Controls.Add(this.legalLabel);
            this.legalBox.Location = new System.Drawing.Point(11, 142);
            this.legalBox.Margin = new System.Windows.Forms.Padding(2);
            this.legalBox.Name = "legalBox";
            this.legalBox.Padding = new System.Windows.Forms.Padding(2);
            this.legalBox.Size = new System.Drawing.Size(262, 51);
            this.legalBox.TabIndex = 31;
            this.legalBox.TabStop = false;
            // 
            // legalLabel
            // 
            this.legalLabel.AutoSize = true;
            this.legalLabel.Location = new System.Drawing.Point(4, 26);
            this.legalLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.legalLabel.Name = "legalLabel";
            this.legalLabel.Size = new System.Drawing.Size(62, 13);
            this.legalLabel.TabIndex = 21;
            this.legalLabel.Text = "Legal Form:";
            // 
            // legalComboBox
            // 
            this.legalComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.legalComboBox.FormattingEnabled = true;
            this.legalComboBox.Location = new System.Drawing.Point(70, 24);
            this.legalComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.legalComboBox.Name = "legalComboBox";
            this.legalComboBox.Size = new System.Drawing.Size(188, 21);
            this.legalComboBox.TabIndex = 22;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(11, 349);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(122, 24);
            this.addButton.TabIndex = 19;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(137, 349);
            this.editButton.Margin = new System.Windows.Forms.Padding(2);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(136, 24);
            this.editButton.TabIndex = 33;
            this.editButton.Text = "Edit Selected";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(11, 377);
            this.removeButton.Margin = new System.Windows.Forms.Padding(2);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(262, 31);
            this.removeButton.TabIndex = 18;
            this.removeButton.Text = "Remove Selected";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // HomesForSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1160, 530);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.localTable);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.legalBox);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.typeBox);
            this.Controls.Add(this.AddressBox);
            this.Controls.Add(this.categoryBox);
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomesForSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home For Sale";
            this.Load += new System.EventHandler(this.HomesForSale_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.SearchBox.ResumeLayout(false);
            this.SearchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.localTable)).EndInit();
            this.AddressBox.ResumeLayout(false);
            this.AddressBox.PerformLayout();
            this.categoryBox.ResumeLayout(false);
            this.categoryBox.PerformLayout();
            this.typeBox.ResumeLayout(false);
            this.typeBox.PerformLayout();
            this.legalBox.ResumeLayout(false);
            this.legalBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToXMLToolStripMenuItem;
        private System.Windows.Forms.GroupBox SearchBox;
        private System.Windows.Forms.TextBox searchCityTextBox;
        private System.Windows.Forms.Label searchCityLabel;
        private System.Windows.Forms.ComboBox searchTypeComboBox;
        private System.Windows.Forms.Label searchTypeLabel;
        private System.Windows.Forms.Button ResetSearchButton;
        private System.Windows.Forms.DataGridView localTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCountry;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStreet;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnZipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnLegalType;
        private System.Windows.Forms.GroupBox AddressBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.Label zipCodeLabel;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label streetLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.ComboBox countriesComboBox;
        private System.Windows.Forms.Label CountryLabel;
        private System.Windows.Forms.GroupBox categoryBox;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.GroupBox typeBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.GroupBox legalBox;
        private System.Windows.Forms.ComboBox legalComboBox;
        private System.Windows.Forms.Label legalLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button removeButton;
    }
}

