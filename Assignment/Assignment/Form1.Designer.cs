namespace Assignment
{
    partial class Form1
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
            this.loadCsvFileLabel = new System.Windows.Forms.Label();
            this.loadFileButton = new System.Windows.Forms.Button();
            this.companyNamesListBox = new System.Windows.Forms.ListBox();
            this.listOfCompaniesLabel = new System.Windows.Forms.Label();
            this.heightOfTreeLabel = new System.Windows.Forms.Label();
            this.numOfCompaniesLabel = new System.Windows.Forms.Label();
            this.heightTextBox = new System.Windows.Forms.TextBox();
            this.numCompaniesTextBox = new System.Windows.Forms.TextBox();
            this.CompanyDetailsLabel = new System.Windows.Forms.Label();
            this.companyNameTextBox = new System.Windows.Forms.TextBox();
            this.companyNetIncomeTextBox = new System.Windows.Forms.TextBox();
            this.CompanyOperatingIncomeTextBox = new System.Windows.Forms.TextBox();
            this.companyTotalAssetsTextBox = new System.Windows.Forms.TextBox();
            this.companyNumEmployeesTextBox = new System.Windows.Forms.TextBox();
            this.companyBuyersTextBox = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.nameLabel = new System.Windows.Forms.Label();
            this.netIncomeLabel = new System.Windows.Forms.Label();
            this.operatingIncomeLabel = new System.Windows.Forms.Label();
            this.totalAssetsLabel = new System.Windows.Forms.Label();
            this.numEmployeesLabel = new System.Windows.Forms.Label();
            this.buyersLabel = new System.Windows.Forms.Label();
            this.removeButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.searchCompanyTextBox = new System.Windows.Forms.TextBox();
            this.searchCompanyNameLabel = new System.Windows.Forms.Label();
            this.filteredListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // loadCsvFileLabel
            // 
            this.loadCsvFileLabel.AutoSize = true;
            this.loadCsvFileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadCsvFileLabel.Location = new System.Drawing.Point(491, 34);
            this.loadCsvFileLabel.Name = "loadCsvFileLabel";
            this.loadCsvFileLabel.Size = new System.Drawing.Size(236, 42);
            this.loadCsvFileLabel.TabIndex = 0;
            this.loadCsvFileLabel.Text = "Load .csv file";
            this.loadCsvFileLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // loadFileButton
            // 
            this.loadFileButton.Location = new System.Drawing.Point(553, 104);
            this.loadFileButton.Name = "loadFileButton";
            this.loadFileButton.Size = new System.Drawing.Size(101, 35);
            this.loadFileButton.TabIndex = 2;
            this.loadFileButton.Text = "Load File";
            this.loadFileButton.UseVisualStyleBackColor = true;
            this.loadFileButton.Click += new System.EventHandler(this.loadFileButton_Click);
            // 
            // companyNamesListBox
            // 
            this.companyNamesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyNamesListBox.FormattingEnabled = true;
            this.companyNamesListBox.ItemHeight = 20;
            this.companyNamesListBox.Location = new System.Drawing.Point(204, 253);
            this.companyNamesListBox.Name = "companyNamesListBox";
            this.companyNamesListBox.Size = new System.Drawing.Size(310, 204);
            this.companyNamesListBox.TabIndex = 3;
            this.companyNamesListBox.SelectedIndexChanged += new System.EventHandler(this.companyNamesListBox_SelectedIndexChanged_1);
            // 
            // listOfCompaniesLabel
            // 
            this.listOfCompaniesLabel.AutoSize = true;
            this.listOfCompaniesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfCompaniesLabel.Location = new System.Drawing.Point(267, 213);
            this.listOfCompaniesLabel.Name = "listOfCompaniesLabel";
            this.listOfCompaniesLabel.Size = new System.Drawing.Size(184, 25);
            this.listOfCompaniesLabel.TabIndex = 4;
            this.listOfCompaniesLabel.Text = "List of Companies";
            // 
            // heightOfTreeLabel
            // 
            this.heightOfTreeLabel.AutoSize = true;
            this.heightOfTreeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heightOfTreeLabel.Location = new System.Drawing.Point(141, 466);
            this.heightOfTreeLabel.Name = "heightOfTreeLabel";
            this.heightOfTreeLabel.Size = new System.Drawing.Size(130, 24);
            this.heightOfTreeLabel.TabIndex = 5;
            this.heightOfTreeLabel.Text = "Height of Tree";
            // 
            // numOfCompaniesLabel
            // 
            this.numOfCompaniesLabel.AutoSize = true;
            this.numOfCompaniesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfCompaniesLabel.Location = new System.Drawing.Point(425, 466);
            this.numOfCompaniesLabel.Name = "numOfCompaniesLabel";
            this.numOfCompaniesLabel.Size = new System.Drawing.Size(200, 24);
            this.numOfCompaniesLabel.TabIndex = 6;
            this.numOfCompaniesLabel.Text = "Number of Companies";
            // 
            // heightTextBox
            // 
            this.heightTextBox.Location = new System.Drawing.Point(180, 497);
            this.heightTextBox.Name = "heightTextBox";
            this.heightTextBox.ReadOnly = true;
            this.heightTextBox.Size = new System.Drawing.Size(48, 20);
            this.heightTextBox.TabIndex = 7;
            this.heightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numCompaniesTextBox
            // 
            this.numCompaniesTextBox.Location = new System.Drawing.Point(505, 497);
            this.numCompaniesTextBox.Name = "numCompaniesTextBox";
            this.numCompaniesTextBox.ReadOnly = true;
            this.numCompaniesTextBox.Size = new System.Drawing.Size(48, 20);
            this.numCompaniesTextBox.TabIndex = 8;
            // 
            // CompanyDetailsLabel
            // 
            this.CompanyDetailsLabel.AutoSize = true;
            this.CompanyDetailsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CompanyDetailsLabel.Location = new System.Drawing.Point(720, 196);
            this.CompanyDetailsLabel.Name = "CompanyDetailsLabel";
            this.CompanyDetailsLabel.Size = new System.Drawing.Size(175, 25);
            this.CompanyDetailsLabel.TabIndex = 9;
            this.CompanyDetailsLabel.Text = "Company Details";
            // 
            // companyNameTextBox
            // 
            this.companyNameTextBox.Location = new System.Drawing.Point(793, 241);
            this.companyNameTextBox.Name = "companyNameTextBox";
            this.companyNameTextBox.Size = new System.Drawing.Size(102, 20);
            this.companyNameTextBox.TabIndex = 10;
            this.companyNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // companyNetIncomeTextBox
            // 
            this.companyNetIncomeTextBox.Location = new System.Drawing.Point(793, 286);
            this.companyNetIncomeTextBox.Name = "companyNetIncomeTextBox";
            this.companyNetIncomeTextBox.Size = new System.Drawing.Size(102, 20);
            this.companyNetIncomeTextBox.TabIndex = 11;
            this.companyNetIncomeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CompanyOperatingIncomeTextBox
            // 
            this.CompanyOperatingIncomeTextBox.Location = new System.Drawing.Point(793, 330);
            this.CompanyOperatingIncomeTextBox.Name = "CompanyOperatingIncomeTextBox";
            this.CompanyOperatingIncomeTextBox.Size = new System.Drawing.Size(102, 20);
            this.CompanyOperatingIncomeTextBox.TabIndex = 12;
            this.CompanyOperatingIncomeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // companyTotalAssetsTextBox
            // 
            this.companyTotalAssetsTextBox.Location = new System.Drawing.Point(793, 371);
            this.companyTotalAssetsTextBox.Name = "companyTotalAssetsTextBox";
            this.companyTotalAssetsTextBox.Size = new System.Drawing.Size(102, 20);
            this.companyTotalAssetsTextBox.TabIndex = 13;
            this.companyTotalAssetsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // companyNumEmployeesTextBox
            // 
            this.companyNumEmployeesTextBox.Location = new System.Drawing.Point(793, 409);
            this.companyNumEmployeesTextBox.Name = "companyNumEmployeesTextBox";
            this.companyNumEmployeesTextBox.Size = new System.Drawing.Size(102, 20);
            this.companyNumEmployeesTextBox.TabIndex = 14;
            this.companyNumEmployeesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // companyBuyersTextBox
            // 
            this.companyBuyersTextBox.Location = new System.Drawing.Point(793, 454);
            this.companyBuyersTextBox.Name = "companyBuyersTextBox";
            this.companyBuyersTextBox.Size = new System.Drawing.Size(102, 20);
            this.companyBuyersTextBox.TabIndex = 15;
            this.companyBuyersTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(727, 244);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 16;
            this.nameLabel.Text = "Name";
            // 
            // netIncomeLabel
            // 
            this.netIncomeLabel.AutoSize = true;
            this.netIncomeLabel.Location = new System.Drawing.Point(713, 289);
            this.netIncomeLabel.Name = "netIncomeLabel";
            this.netIncomeLabel.Size = new System.Drawing.Size(62, 13);
            this.netIncomeLabel.TabIndex = 17;
            this.netIncomeLabel.Text = "Net Income";
            // 
            // operatingIncomeLabel
            // 
            this.operatingIncomeLabel.AutoSize = true;
            this.operatingIncomeLabel.Location = new System.Drawing.Point(694, 333);
            this.operatingIncomeLabel.Name = "operatingIncomeLabel";
            this.operatingIncomeLabel.Size = new System.Drawing.Size(91, 13);
            this.operatingIncomeLabel.TabIndex = 18;
            this.operatingIncomeLabel.Text = "Operating Income";
            // 
            // totalAssetsLabel
            // 
            this.totalAssetsLabel.AutoSize = true;
            this.totalAssetsLabel.Location = new System.Drawing.Point(710, 374);
            this.totalAssetsLabel.Name = "totalAssetsLabel";
            this.totalAssetsLabel.Size = new System.Drawing.Size(65, 13);
            this.totalAssetsLabel.TabIndex = 19;
            this.totalAssetsLabel.Text = "Total Assets";
            // 
            // numEmployeesLabel
            // 
            this.numEmployeesLabel.AutoSize = true;
            this.numEmployeesLabel.Location = new System.Drawing.Point(694, 412);
            this.numEmployeesLabel.Name = "numEmployeesLabel";
            this.numEmployeesLabel.Size = new System.Drawing.Size(90, 13);
            this.numEmployeesLabel.TabIndex = 20;
            this.numEmployeesLabel.Text = "No. of Employees";
            // 
            // buyersLabel
            // 
            this.buyersLabel.AutoSize = true;
            this.buyersLabel.Location = new System.Drawing.Point(723, 457);
            this.buyersLabel.Name = "buyersLabel";
            this.buyersLabel.Size = new System.Drawing.Size(39, 13);
            this.buyersLabel.TabIndex = 21;
            this.buyersLabel.Text = "Buyers";
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.Red;
            this.removeButton.ForeColor = System.Drawing.SystemColors.Menu;
            this.removeButton.Location = new System.Drawing.Point(835, 518);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(78, 35);
            this.removeButton.TabIndex = 22;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.editButton.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.editButton.Location = new System.Drawing.Point(709, 518);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(78, 35);
            this.editButton.TabIndex = 23;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // searchCompanyTextBox
            // 
            this.searchCompanyTextBox.Location = new System.Drawing.Point(1123, 202);
            this.searchCompanyTextBox.Name = "searchCompanyTextBox";
            this.searchCompanyTextBox.Size = new System.Drawing.Size(168, 20);
            this.searchCompanyTextBox.TabIndex = 24;
            this.searchCompanyTextBox.TextChanged += new System.EventHandler(this.searchCompanyTextBox_TextChanged);
            // 
            // searchCompanyNameLabel
            // 
            this.searchCompanyNameLabel.AutoSize = true;
            this.searchCompanyNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCompanyNameLabel.Location = new System.Drawing.Point(1103, 179);
            this.searchCompanyNameLabel.Name = "searchCompanyNameLabel";
            this.searchCompanyNameLabel.Size = new System.Drawing.Size(199, 20);
            this.searchCompanyNameLabel.TabIndex = 25;
            this.searchCompanyNameLabel.Text = "Search Company By Name";
            // 
            // filteredListBox
            // 
            this.filteredListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filteredListBox.FormattingEnabled = true;
            this.filteredListBox.ItemHeight = 20;
            this.filteredListBox.Location = new System.Drawing.Point(1045, 253);
            this.filteredListBox.Name = "filteredListBox";
            this.filteredListBox.Size = new System.Drawing.Size(310, 204);
            this.filteredListBox.TabIndex = 26;
            this.filteredListBox.SelectedIndexChanged += new System.EventHandler(this.filteredListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 897);
            this.Controls.Add(this.filteredListBox);
            this.Controls.Add(this.searchCompanyNameLabel);
            this.Controls.Add(this.searchCompanyTextBox);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.buyersLabel);
            this.Controls.Add(this.numEmployeesLabel);
            this.Controls.Add(this.totalAssetsLabel);
            this.Controls.Add(this.operatingIncomeLabel);
            this.Controls.Add(this.netIncomeLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.companyBuyersTextBox);
            this.Controls.Add(this.companyNumEmployeesTextBox);
            this.Controls.Add(this.companyTotalAssetsTextBox);
            this.Controls.Add(this.CompanyOperatingIncomeTextBox);
            this.Controls.Add(this.companyNetIncomeTextBox);
            this.Controls.Add(this.companyNameTextBox);
            this.Controls.Add(this.CompanyDetailsLabel);
            this.Controls.Add(this.numCompaniesTextBox);
            this.Controls.Add(this.heightTextBox);
            this.Controls.Add(this.numOfCompaniesLabel);
            this.Controls.Add(this.heightOfTreeLabel);
            this.Controls.Add(this.listOfCompaniesLabel);
            this.Controls.Add(this.companyNamesListBox);
            this.Controls.Add(this.loadFileButton);
            this.Controls.Add(this.loadCsvFileLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loadCsvFileLabel;
        private System.Windows.Forms.Button loadFileButton;
        private System.Windows.Forms.ListBox companyNamesListBox;
        private System.Windows.Forms.Label listOfCompaniesLabel;
        private System.Windows.Forms.Label heightOfTreeLabel;
        private System.Windows.Forms.Label numOfCompaniesLabel;
        private System.Windows.Forms.TextBox heightTextBox;
        private System.Windows.Forms.TextBox numCompaniesTextBox;
        private System.Windows.Forms.Label CompanyDetailsLabel;
        private System.Windows.Forms.TextBox companyNameTextBox;
        private System.Windows.Forms.TextBox companyNetIncomeTextBox;
        private System.Windows.Forms.TextBox CompanyOperatingIncomeTextBox;
        private System.Windows.Forms.TextBox companyTotalAssetsTextBox;
        private System.Windows.Forms.TextBox companyNumEmployeesTextBox;
        private System.Windows.Forms.TextBox companyBuyersTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label netIncomeLabel;
        private System.Windows.Forms.Label operatingIncomeLabel;
        private System.Windows.Forms.Label totalAssetsLabel;
        private System.Windows.Forms.Label numEmployeesLabel;
        private System.Windows.Forms.Label buyersLabel;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox searchCompanyTextBox;
        private System.Windows.Forms.Label searchCompanyNameLabel;
        private System.Windows.Forms.ListBox filteredListBox;
    }
}

