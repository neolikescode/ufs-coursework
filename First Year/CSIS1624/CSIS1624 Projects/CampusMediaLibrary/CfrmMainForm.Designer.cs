namespace SemesterTest2
{
    partial class CfrmMainForm
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
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDisplayInfo = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.lblFormat = new System.Windows.Forms.Label();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.grpEBook = new System.Windows.Forms.GroupBox();
            this.lblRegion = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            this.grpDvd = new System.Windows.Forms.GroupBox();
            this.lblPages = new System.Windows.Forms.Label();
            this.radEBook = new System.Windows.Forms.RadioButton();
            this.nudPages = new System.Windows.Forms.NumericUpDown();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.radBook = new System.Windows.Forms.RadioButton();
            this.radDvd = new System.Windows.Forms.RadioButton();
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.grpCommon = new System.Windows.Forms.GroupBox();
            this.grpEBook.SuspendLayout();
            this.grpDvd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPages)).BeginInit();
            this.grpBook.SuspendLayout();
            this.grpCommon.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.ItemHeight = 20;
            this.lstItems.Location = new System.Drawing.Point(18, 343);
            this.lstItems.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(1192, 424);
            this.lstItems.TabIndex = 5;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(396, 277);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 46);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDisplayInfo
            // 
            this.btnDisplayInfo.Location = new System.Drawing.Point(207, 277);
            this.btnDisplayInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDisplayInfo.Name = "btnDisplayInfo";
            this.btnDisplayInfo.Size = new System.Drawing.Size(180, 46);
            this.btnDisplayInfo.TabIndex = 11;
            this.btnDisplayInfo.Text = "Display Info";
            this.btnDisplayInfo.UseVisualStyleBackColor = true;
            this.btnDisplayInfo.Click += new System.EventHandler(this.btnDisplayInfo_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(18, 277);
            this.btnAddItem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(180, 46);
            this.btnAddItem.TabIndex = 13;
            this.btnAddItem.Text = "Add Item";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(24, 35);
            this.lblFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(64, 20);
            this.lblFormat.TabIndex = 0;
            this.lblFormat.Text = "Format:";
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(150, 31);
            this.txtFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(178, 26);
            this.txtFormat.TabIndex = 1;
            // 
            // grpEBook
            // 
            this.grpEBook.Controls.Add(this.lblFormat);
            this.grpEBook.Controls.Add(this.txtFormat);
            this.grpEBook.Location = new System.Drawing.Point(822, 186);
            this.grpEBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEBook.Name = "grpEBook";
            this.grpEBook.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpEBook.Size = new System.Drawing.Size(390, 82);
            this.grpEBook.TabIndex = 12;
            this.grpEBook.TabStop = false;
            this.grpEBook.Text = "E-Book";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Location = new System.Drawing.Point(24, 34);
            this.lblRegion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(64, 20);
            this.lblRegion.TabIndex = 0;
            this.lblRegion.Text = "Region:";
            // 
            // txtRegion
            // 
            this.txtRegion.Location = new System.Drawing.Point(150, 29);
            this.txtRegion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(178, 26);
            this.txtRegion.TabIndex = 1;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(600, 289);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(105, 20);
            this.lblCount.TabIndex = 7;
            this.lblCount.Text = "Total Items: 0";
            // 
            // grpDvd
            // 
            this.grpDvd.Controls.Add(this.lblRegion);
            this.grpDvd.Controls.Add(this.txtRegion);
            this.grpDvd.Location = new System.Drawing.Point(822, 94);
            this.grpDvd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDvd.Name = "grpDvd";
            this.grpDvd.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpDvd.Size = new System.Drawing.Size(390, 83);
            this.grpDvd.TabIndex = 10;
            this.grpDvd.TabStop = false;
            this.grpDvd.Text = "DVD";
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.Location = new System.Drawing.Point(24, 29);
            this.lblPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(58, 20);
            this.lblPages.TabIndex = 0;
            this.lblPages.Text = "Pages:";
            // 
            // radEBook
            // 
            this.radEBook.AutoSize = true;
            this.radEBook.Location = new System.Drawing.Point(360, 194);
            this.radEBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radEBook.Name = "radEBook";
            this.radEBook.Size = new System.Drawing.Size(87, 24);
            this.radEBook.TabIndex = 9;
            this.radEBook.Text = "E-Book";
            this.radEBook.CheckedChanged += new System.EventHandler(this.radEBook_CheckedChanged);
            // 
            // nudPages
            // 
            this.nudPages.Location = new System.Drawing.Point(150, 26);
            this.nudPages.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudPages.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.nudPages.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPages.Name = "nudPages";
            this.nudPages.Size = new System.Drawing.Size(180, 26);
            this.nudPages.TabIndex = 1;
            this.nudPages.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(24, 46);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(150, 42);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(568, 26);
            this.txtTitle.TabIndex = 1;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(24, 95);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(61, 20);
            this.lblAuthor.TabIndex = 2;
            this.lblAuthor.Text = "Author:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(150, 91);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(568, 26);
            this.txtAuthor.TabIndex = 3;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(24, 145);
            this.lblYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(47, 20);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year:";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.Items.AddRange(new object[] {
            "1900",
            "1901",
            "1902",
            "1903",
            "1904",
            "1905",
            "1906",
            "1907",
            "1908",
            "1909",
            "1910",
            "1911",
            "1912",
            "1913",
            "1914",
            "1915",
            "1916",
            "1917",
            "1918",
            "1919",
            "1920",
            "1921",
            "1922",
            "1923",
            "1924",
            "1925",
            "1926",
            "1927",
            "1928",
            "1929",
            "1930",
            "1931",
            "1932",
            "1933",
            "1934",
            "1935",
            "1936",
            "1937",
            "1938",
            "1939",
            "1940",
            "1941",
            "1942",
            "1943",
            "1944",
            "1945",
            "1946",
            "1947",
            "1948",
            "1949",
            "1950",
            "1951",
            "1952",
            "1953",
            "1954",
            "1955",
            "1956",
            "1957",
            "1958",
            "1959",
            "1960",
            "1961",
            "1962",
            "1963",
            "1964",
            "1965",
            "1966",
            "1967",
            "1968",
            "1969",
            "1970",
            "1971",
            "1972",
            "1973",
            "1974",
            "1975",
            "1976",
            "1977",
            "1978",
            "1979",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cmbYear.Location = new System.Drawing.Point(150, 140);
            this.cmbYear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(178, 28);
            this.cmbYear.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(24, 197);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(47, 20);
            this.lblType.TabIndex = 6;
            this.lblType.Text = "Type:";
            // 
            // radBook
            // 
            this.radBook.AutoSize = true;
            this.radBook.Checked = true;
            this.radBook.Location = new System.Drawing.Point(150, 194);
            this.radBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radBook.Name = "radBook";
            this.radBook.Size = new System.Drawing.Size(71, 24);
            this.radBook.TabIndex = 7;
            this.radBook.TabStop = true;
            this.radBook.Text = "Book";
            this.radBook.CheckedChanged += new System.EventHandler(this.radBook_CheckedChanged);
            // 
            // radDvd
            // 
            this.radDvd.AutoSize = true;
            this.radDvd.Location = new System.Drawing.Point(255, 194);
            this.radDvd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.radDvd.Name = "radDvd";
            this.radDvd.Size = new System.Drawing.Size(69, 24);
            this.radDvd.TabIndex = 8;
            this.radDvd.Text = "DVD";
            this.radDvd.CheckedChanged += new System.EventHandler(this.radDvd_CheckedChanged);
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.lblPages);
            this.grpBook.Controls.Add(this.nudPages);
            this.grpBook.Location = new System.Drawing.Point(822, 12);
            this.grpBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBook.Name = "grpBook";
            this.grpBook.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpBook.Size = new System.Drawing.Size(390, 72);
            this.grpBook.TabIndex = 8;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Book";
            // 
            // grpCommon
            // 
            this.grpCommon.Controls.Add(this.lblTitle);
            this.grpCommon.Controls.Add(this.txtTitle);
            this.grpCommon.Controls.Add(this.lblAuthor);
            this.grpCommon.Controls.Add(this.txtAuthor);
            this.grpCommon.Controls.Add(this.lblYear);
            this.grpCommon.Controls.Add(this.cmbYear);
            this.grpCommon.Controls.Add(this.lblType);
            this.grpCommon.Controls.Add(this.radBook);
            this.grpCommon.Controls.Add(this.radDvd);
            this.grpCommon.Controls.Add(this.radEBook);
            this.grpCommon.Location = new System.Drawing.Point(18, 12);
            this.grpCommon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCommon.Name = "grpCommon";
            this.grpCommon.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grpCommon.Size = new System.Drawing.Size(780, 255);
            this.grpCommon.TabIndex = 6;
            this.grpCommon.TabStop = false;
            this.grpCommon.Text = "Common";
            // 
            // CfrmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 778);
            this.Controls.Add(this.lstItems);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDisplayInfo);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.grpEBook);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.grpDvd);
            this.Controls.Add(this.grpBook);
            this.Controls.Add(this.grpCommon);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CfrmMainForm";
            this.Text = "CfrmMainForm";
            this.grpEBook.ResumeLayout(false);
            this.grpEBook.PerformLayout();
            this.grpDvd.ResumeLayout(false);
            this.grpDvd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPages)).EndInit();
            this.grpBook.ResumeLayout(false);
            this.grpBook.PerformLayout();
            this.grpCommon.ResumeLayout(false);
            this.grpCommon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDisplayInfo;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.GroupBox grpEBook;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.GroupBox grpDvd;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.RadioButton radEBook;
        private System.Windows.Forms.NumericUpDown nudPages;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.RadioButton radBook;
        private System.Windows.Forms.RadioButton radDvd;
        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.GroupBox grpCommon;
    }
}

