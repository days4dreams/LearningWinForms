namespace LearningWinForms
{
    partial class ApplicationForm
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
            this.LabelFirstName = new System.Windows.Forms.Label();
            this.TextBoxFirstName = new System.Windows.Forms.TextBox();
            this.TextBoxMiddleName = new System.Windows.Forms.TextBox();
            this.TextBoxLastName = new System.Windows.Forms.TextBox();
            this.LabelMiddleName = new System.Windows.Forms.Label();
            this.LabelLastName = new System.Windows.Forms.Label();
            this.groupBoxAddress = new System.Windows.Forms.GroupBox();
            this.labelAddressLine6 = new System.Windows.Forms.Label();
            this.labelAddressLine5 = new System.Windows.Forms.Label();
            this.textBoxAddressLine6 = new System.Windows.Forms.TextBox();
            this.labelAddressLine3 = new System.Windows.Forms.Label();
            this.textBoxAddressLine5 = new System.Windows.Forms.TextBox();
            this.textBoxAddressLine3 = new System.Windows.Forms.TextBox();
            this.labelAddressLine2 = new System.Windows.Forms.Label();
            this.textBoxAddressLine2 = new System.Windows.Forms.TextBox();
            this.labelAddressLine4 = new System.Windows.Forms.Label();
            this.textBoxAddressLine4 = new System.Windows.Forms.TextBox();
            this.labelAddressLine1 = new System.Windows.Forms.Label();
            this.textBoxAddressLine1 = new System.Windows.Forms.TextBox();
            this.labelDOB = new System.Windows.Forms.Label();
            this.labelNationalInsurance = new System.Windows.Forms.Label();
            this.textBoxNationalInsurance = new System.Windows.Forms.TextBox();
            this.groupBoxPersonal = new System.Windows.Forms.GroupBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.comboBoxDOBYear = new System.Windows.Forms.ComboBox();
            this.comboBoxDOBMonth = new System.Windows.Forms.ComboBox();
            this.comboBoxDOBDay = new System.Windows.Forms.ComboBox();
            this.groupBoxExperience = new System.Windows.Forms.GroupBox();
            this.buttonCVUpload = new System.Windows.Forms.Button();
            this.buttonCVBrowse = new System.Windows.Forms.Button();
            this.labelCV = new System.Windows.Forms.Label();
            this.textBoxCV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSkills = new System.Windows.Forms.TextBox();
            this.labelWhy = new System.Windows.Forms.Label();
            this.labelJobTitle = new System.Windows.Forms.Label();
            this.textBoxWhy = new System.Windows.Forms.TextBox();
            this.textBoxJobTitle = new System.Windows.Forms.TextBox();
            this.labelSalary = new System.Windows.Forms.Label();
            this.textBoxSalary = new System.Windows.Forms.TextBox();
            this.toolTipWhy = new System.Windows.Forms.ToolTip(this.components);
            this.openFileDialogCV = new System.Windows.Forms.OpenFileDialog();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.labelAgreement1 = new System.Windows.Forms.Label();
            this.linkLabelAgreement = new System.Windows.Forms.LinkLabel();
            this.checkBoxAgreement = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBoxAddress.SuspendLayout();
            this.groupBoxPersonal.SuspendLayout();
            this.groupBoxExperience.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelFirstName
            // 
            this.LabelFirstName.AutoSize = true;
            this.LabelFirstName.Location = new System.Drawing.Point(23, 26);
            this.LabelFirstName.Name = "LabelFirstName";
            this.LabelFirstName.Size = new System.Drawing.Size(57, 13);
            this.LabelFirstName.TabIndex = 0;
            this.LabelFirstName.Text = "First Name";
            // 
            // TextBoxFirstName
            // 
            this.TextBoxFirstName.Location = new System.Drawing.Point(19, 44);
            this.TextBoxFirstName.Name = "TextBoxFirstName";
            this.TextBoxFirstName.Size = new System.Drawing.Size(175, 20);
            this.TextBoxFirstName.TabIndex = 1;
            // 
            // TextBoxMiddleName
            // 
            this.TextBoxMiddleName.Location = new System.Drawing.Point(203, 44);
            this.TextBoxMiddleName.Name = "TextBoxMiddleName";
            this.TextBoxMiddleName.Size = new System.Drawing.Size(175, 20);
            this.TextBoxMiddleName.TabIndex = 9;
            // 
            // TextBoxLastName
            // 
            this.TextBoxLastName.Location = new System.Drawing.Point(389, 44);
            this.TextBoxLastName.Name = "TextBoxLastName";
            this.TextBoxLastName.Size = new System.Drawing.Size(175, 20);
            this.TextBoxLastName.TabIndex = 10;
            // 
            // LabelMiddleName
            // 
            this.LabelMiddleName.AutoSize = true;
            this.LabelMiddleName.Location = new System.Drawing.Point(206, 26);
            this.LabelMiddleName.Name = "LabelMiddleName";
            this.LabelMiddleName.Size = new System.Drawing.Size(69, 13);
            this.LabelMiddleName.TabIndex = 11;
            this.LabelMiddleName.Text = "Middle Name";
            this.LabelMiddleName.Click += new System.EventHandler(this.label1_Click);
            // 
            // LabelLastName
            // 
            this.LabelLastName.AutoSize = true;
            this.LabelLastName.Location = new System.Drawing.Point(392, 26);
            this.LabelLastName.Name = "LabelLastName";
            this.LabelLastName.Size = new System.Drawing.Size(58, 13);
            this.LabelLastName.TabIndex = 13;
            this.LabelLastName.Text = "Last Name";
            // 
            // groupBoxAddress
            // 
            this.groupBoxAddress.Controls.Add(this.labelAddressLine6);
            this.groupBoxAddress.Controls.Add(this.labelAddressLine5);
            this.groupBoxAddress.Controls.Add(this.textBoxAddressLine6);
            this.groupBoxAddress.Controls.Add(this.labelAddressLine3);
            this.groupBoxAddress.Controls.Add(this.textBoxAddressLine5);
            this.groupBoxAddress.Controls.Add(this.textBoxAddressLine3);
            this.groupBoxAddress.Controls.Add(this.labelAddressLine2);
            this.groupBoxAddress.Controls.Add(this.textBoxAddressLine2);
            this.groupBoxAddress.Controls.Add(this.labelAddressLine4);
            this.groupBoxAddress.Controls.Add(this.textBoxAddressLine4);
            this.groupBoxAddress.Controls.Add(this.labelAddressLine1);
            this.groupBoxAddress.Controls.Add(this.textBoxAddressLine1);
            this.groupBoxAddress.Location = new System.Drawing.Point(26, 202);
            this.groupBoxAddress.Name = "groupBoxAddress";
            this.groupBoxAddress.Size = new System.Drawing.Size(583, 178);
            this.groupBoxAddress.TabIndex = 14;
            this.groupBoxAddress.TabStop = false;
            this.groupBoxAddress.Text = "Address";
            this.groupBoxAddress.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // labelAddressLine6
            // 
            this.labelAddressLine6.AutoSize = true;
            this.labelAddressLine6.Location = new System.Drawing.Point(306, 124);
            this.labelAddressLine6.Name = "labelAddressLine6";
            this.labelAddressLine6.Size = new System.Drawing.Size(43, 13);
            this.labelAddressLine6.TabIndex = 18;
            this.labelAddressLine6.Text = "Country";
            // 
            // labelAddressLine5
            // 
            this.labelAddressLine5.AutoSize = true;
            this.labelAddressLine5.Location = new System.Drawing.Point(305, 75);
            this.labelAddressLine5.Name = "labelAddressLine5";
            this.labelAddressLine5.Size = new System.Drawing.Size(78, 13);
            this.labelAddressLine5.TabIndex = 7;
            this.labelAddressLine5.Text = "Postcode / Zip";
            // 
            // textBoxAddressLine6
            // 
            this.textBoxAddressLine6.Location = new System.Drawing.Point(303, 140);
            this.textBoxAddressLine6.Name = "textBoxAddressLine6";
            this.textBoxAddressLine6.Size = new System.Drawing.Size(262, 20);
            this.textBoxAddressLine6.TabIndex = 17;
            // 
            // labelAddressLine3
            // 
            this.labelAddressLine3.AutoSize = true;
            this.labelAddressLine3.Location = new System.Drawing.Point(22, 124);
            this.labelAddressLine3.Name = "labelAddressLine3";
            this.labelAddressLine3.Size = new System.Drawing.Size(60, 13);
            this.labelAddressLine3.TabIndex = 16;
            this.labelAddressLine3.Text = "City / State";
            // 
            // textBoxAddressLine5
            // 
            this.textBoxAddressLine5.Location = new System.Drawing.Point(302, 91);
            this.textBoxAddressLine5.Name = "textBoxAddressLine5";
            this.textBoxAddressLine5.Size = new System.Drawing.Size(262, 20);
            this.textBoxAddressLine5.TabIndex = 6;
            // 
            // textBoxAddressLine3
            // 
            this.textBoxAddressLine3.Location = new System.Drawing.Point(19, 140);
            this.textBoxAddressLine3.Name = "textBoxAddressLine3";
            this.textBoxAddressLine3.Size = new System.Drawing.Size(262, 20);
            this.textBoxAddressLine3.TabIndex = 15;
            // 
            // labelAddressLine2
            // 
            this.labelAddressLine2.AutoSize = true;
            this.labelAddressLine2.Location = new System.Drawing.Point(21, 75);
            this.labelAddressLine2.Name = "labelAddressLine2";
            this.labelAddressLine2.Size = new System.Drawing.Size(35, 13);
            this.labelAddressLine2.TabIndex = 5;
            this.labelAddressLine2.Text = "Street";
            this.labelAddressLine2.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxAddressLine2
            // 
            this.textBoxAddressLine2.Location = new System.Drawing.Point(18, 91);
            this.textBoxAddressLine2.Name = "textBoxAddressLine2";
            this.textBoxAddressLine2.Size = new System.Drawing.Size(262, 20);
            this.textBoxAddressLine2.TabIndex = 4;
            // 
            // labelAddressLine4
            // 
            this.labelAddressLine4.AutoSize = true;
            this.labelAddressLine4.Location = new System.Drawing.Point(306, 29);
            this.labelAddressLine4.Name = "labelAddressLine4";
            this.labelAddressLine4.Size = new System.Drawing.Size(40, 13);
            this.labelAddressLine4.TabIndex = 3;
            this.labelAddressLine4.Text = "County";
            // 
            // textBoxAddressLine4
            // 
            this.textBoxAddressLine4.Location = new System.Drawing.Point(303, 45);
            this.textBoxAddressLine4.Name = "textBoxAddressLine4";
            this.textBoxAddressLine4.Size = new System.Drawing.Size(262, 20);
            this.textBoxAddressLine4.TabIndex = 2;
            // 
            // labelAddressLine1
            // 
            this.labelAddressLine1.AutoSize = true;
            this.labelAddressLine1.Location = new System.Drawing.Point(22, 29);
            this.labelAddressLine1.Name = "labelAddressLine1";
            this.labelAddressLine1.Size = new System.Drawing.Size(151, 13);
            this.labelAddressLine1.TabIndex = 1;
            this.labelAddressLine1.Text = "House Name / House Number";
            // 
            // textBoxAddressLine1
            // 
            this.textBoxAddressLine1.Location = new System.Drawing.Point(19, 45);
            this.textBoxAddressLine1.Name = "textBoxAddressLine1";
            this.textBoxAddressLine1.Size = new System.Drawing.Size(262, 20);
            this.textBoxAddressLine1.TabIndex = 0;
            // 
            // labelDOB
            // 
            this.labelDOB.AutoSize = true;
            this.labelDOB.Location = new System.Drawing.Point(23, 76);
            this.labelDOB.Name = "labelDOB";
            this.labelDOB.Size = new System.Drawing.Size(66, 13);
            this.labelDOB.TabIndex = 17;
            this.labelDOB.Text = "Date of Birth";
            // 
            // labelNationalInsurance
            // 
            this.labelNationalInsurance.AutoSize = true;
            this.labelNationalInsurance.Location = new System.Drawing.Point(305, 76);
            this.labelNationalInsurance.Name = "labelNationalInsurance";
            this.labelNationalInsurance.Size = new System.Drawing.Size(136, 13);
            this.labelNationalInsurance.TabIndex = 18;
            this.labelNationalInsurance.Text = "National Insurance Number";
            // 
            // textBoxNationalInsurance
            // 
            this.textBoxNationalInsurance.Location = new System.Drawing.Point(303, 95);
            this.textBoxNationalInsurance.Name = "textBoxNationalInsurance";
            this.textBoxNationalInsurance.Size = new System.Drawing.Size(261, 20);
            this.textBoxNationalInsurance.TabIndex = 19;
            // 
            // groupBoxPersonal
            // 
            this.groupBoxPersonal.Controls.Add(this.textBoxEmail);
            this.groupBoxPersonal.Controls.Add(this.labelEmail);
            this.groupBoxPersonal.Controls.Add(this.comboBoxDOBYear);
            this.groupBoxPersonal.Controls.Add(this.comboBoxDOBMonth);
            this.groupBoxPersonal.Controls.Add(this.comboBoxDOBDay);
            this.groupBoxPersonal.Controls.Add(this.labelNationalInsurance);
            this.groupBoxPersonal.Controls.Add(this.textBoxNationalInsurance);
            this.groupBoxPersonal.Controls.Add(this.LabelMiddleName);
            this.groupBoxPersonal.Controls.Add(this.TextBoxFirstName);
            this.groupBoxPersonal.Controls.Add(this.TextBoxMiddleName);
            this.groupBoxPersonal.Controls.Add(this.LabelFirstName);
            this.groupBoxPersonal.Controls.Add(this.labelDOB);
            this.groupBoxPersonal.Controls.Add(this.TextBoxLastName);
            this.groupBoxPersonal.Controls.Add(this.LabelLastName);
            this.groupBoxPersonal.Location = new System.Drawing.Point(26, 12);
            this.groupBoxPersonal.Name = "groupBoxPersonal";
            this.groupBoxPersonal.Size = new System.Drawing.Size(583, 175);
            this.groupBoxPersonal.TabIndex = 20;
            this.groupBoxPersonal.TabStop = false;
            this.groupBoxPersonal.Text = "Personal Information";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(19, 143);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(359, 20);
            this.textBoxEmail.TabIndex = 24;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(23, 124);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(73, 13);
            this.labelEmail.TabIndex = 23;
            this.labelEmail.Text = "Email Address";
            // 
            // comboBoxDOBYear
            // 
            this.comboBoxDOBYear.FormattingEnabled = true;
            this.comboBoxDOBYear.Items.AddRange(new object[] {
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
            "2017"});
            this.comboBoxDOBYear.Location = new System.Drawing.Point(203, 94);
            this.comboBoxDOBYear.MaxDropDownItems = 12;
            this.comboBoxDOBYear.Name = "comboBoxDOBYear";
            this.comboBoxDOBYear.Size = new System.Drawing.Size(77, 21);
            this.comboBoxDOBYear.Sorted = true;
            this.comboBoxDOBYear.TabIndex = 22;
            this.comboBoxDOBYear.Text = "Year";
            // 
            // comboBoxDOBMonth
            // 
            this.comboBoxDOBMonth.FormattingEnabled = true;
            this.comboBoxDOBMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.comboBoxDOBMonth.Location = new System.Drawing.Point(116, 94);
            this.comboBoxDOBMonth.MaxDropDownItems = 12;
            this.comboBoxDOBMonth.Name = "comboBoxDOBMonth";
            this.comboBoxDOBMonth.Size = new System.Drawing.Size(78, 21);
            this.comboBoxDOBMonth.TabIndex = 21;
            this.comboBoxDOBMonth.Text = "Month";
            // 
            // comboBoxDOBDay
            // 
            this.comboBoxDOBDay.FormattingEnabled = true;
            this.comboBoxDOBDay.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.comboBoxDOBDay.Location = new System.Drawing.Point(19, 94);
            this.comboBoxDOBDay.MaxDropDownItems = 31;
            this.comboBoxDOBDay.Name = "comboBoxDOBDay";
            this.comboBoxDOBDay.Size = new System.Drawing.Size(83, 21);
            this.comboBoxDOBDay.TabIndex = 20;
            this.comboBoxDOBDay.Text = "Day";
            // 
            // groupBoxExperience
            // 
            this.groupBoxExperience.Controls.Add(this.buttonCVUpload);
            this.groupBoxExperience.Controls.Add(this.buttonCVBrowse);
            this.groupBoxExperience.Controls.Add(this.labelCV);
            this.groupBoxExperience.Controls.Add(this.textBoxCV);
            this.groupBoxExperience.Controls.Add(this.label4);
            this.groupBoxExperience.Controls.Add(this.textBoxSkills);
            this.groupBoxExperience.Controls.Add(this.labelWhy);
            this.groupBoxExperience.Controls.Add(this.labelJobTitle);
            this.groupBoxExperience.Controls.Add(this.textBoxWhy);
            this.groupBoxExperience.Controls.Add(this.textBoxJobTitle);
            this.groupBoxExperience.Controls.Add(this.labelSalary);
            this.groupBoxExperience.Controls.Add(this.textBoxSalary);
            this.groupBoxExperience.Location = new System.Drawing.Point(26, 403);
            this.groupBoxExperience.Name = "groupBoxExperience";
            this.groupBoxExperience.Size = new System.Drawing.Size(583, 311);
            this.groupBoxExperience.TabIndex = 19;
            this.groupBoxExperience.TabStop = false;
            this.groupBoxExperience.Text = "Experience and Expectations";
            this.groupBoxExperience.Enter += new System.EventHandler(this.groupBoxExperience_Enter);
            // 
            // buttonCVUpload
            // 
            this.buttonCVUpload.Location = new System.Drawing.Point(13, 276);
            this.buttonCVUpload.Name = "buttonCVUpload";
            this.buttonCVUpload.Size = new System.Drawing.Size(176, 23);
            this.buttonCVUpload.TabIndex = 30;
            this.buttonCVUpload.Text = "Upload ";
            this.buttonCVUpload.UseVisualStyleBackColor = true;
            this.buttonCVUpload.Click += new System.EventHandler(this.buttonCVUpload_Click);
            // 
            // buttonCVBrowse
            // 
            this.buttonCVBrowse.Location = new System.Drawing.Point(384, 248);
            this.buttonCVBrowse.Name = "buttonCVBrowse";
            this.buttonCVBrowse.Size = new System.Drawing.Size(175, 23);
            this.buttonCVBrowse.TabIndex = 29;
            this.buttonCVBrowse.Text = "Browse";
            this.buttonCVBrowse.UseVisualStyleBackColor = true;
            this.buttonCVBrowse.Click += new System.EventHandler(this.buttonCVBrowse_Click);
            // 
            // labelCV
            // 
            this.labelCV.AutoSize = true;
            this.labelCV.Location = new System.Drawing.Point(16, 234);
            this.labelCV.Name = "labelCV";
            this.labelCV.Size = new System.Drawing.Size(83, 13);
            this.labelCV.TabIndex = 28;
            this.labelCV.Text = "Curriculum Vitae";
            // 
            // textBoxCV
            // 
            this.textBoxCV.Location = new System.Drawing.Point(13, 250);
            this.textBoxCV.Name = "textBoxCV";
            this.textBoxCV.Size = new System.Drawing.Size(360, 20);
            this.textBoxCV.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "What skills do you have for this job?";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBoxSkills
            // 
            this.textBoxSkills.Location = new System.Drawing.Point(12, 176);
            this.textBoxSkills.Multiline = true;
            this.textBoxSkills.Name = "textBoxSkills";
            this.textBoxSkills.Size = new System.Drawing.Size(547, 46);
            this.textBoxSkills.TabIndex = 25;
            this.toolTipWhy.SetToolTip(this.textBoxSkills, "Please refer to the Job Specification for relevant skills, experience and capabil" +
        "ities.");
            // 
            // labelWhy
            // 
            this.labelWhy.AutoSize = true;
            this.labelWhy.Location = new System.Drawing.Point(12, 80);
            this.labelWhy.Name = "labelWhy";
            this.labelWhy.Size = new System.Drawing.Size(170, 13);
            this.labelWhy.TabIndex = 24;
            this.labelWhy.Text = "Why have you applied for this job?";
            this.toolTipWhy.SetToolTip(this.labelWhy, "Please refer to the job specification for expectations of skills and experience");
            // 
            // labelJobTitle
            // 
            this.labelJobTitle.AutoSize = true;
            this.labelJobTitle.Location = new System.Drawing.Point(16, 31);
            this.labelJobTitle.Name = "labelJobTitle";
            this.labelJobTitle.Size = new System.Drawing.Size(84, 13);
            this.labelJobTitle.TabIndex = 20;
            this.labelJobTitle.Text = "Current Job Title";
            this.labelJobTitle.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // textBoxWhy
            // 
            this.textBoxWhy.Location = new System.Drawing.Point(12, 99);
            this.textBoxWhy.Multiline = true;
            this.textBoxWhy.Name = "textBoxWhy";
            this.textBoxWhy.Size = new System.Drawing.Size(547, 47);
            this.textBoxWhy.TabIndex = 23;
            // 
            // textBoxJobTitle
            // 
            this.textBoxJobTitle.Location = new System.Drawing.Point(13, 47);
            this.textBoxJobTitle.Name = "textBoxJobTitle";
            this.textBoxJobTitle.Size = new System.Drawing.Size(262, 20);
            this.textBoxJobTitle.TabIndex = 19;
            this.textBoxJobTitle.TextChanged += new System.EventHandler(this.textBoxJobTitle_TextChanged);
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Location = new System.Drawing.Point(300, 31);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(95, 13);
            this.labelSalary.TabIndex = 22;
            this.labelSalary.Text = "Salary Expectation";
            // 
            // textBoxSalary
            // 
            this.textBoxSalary.Location = new System.Drawing.Point(297, 47);
            this.textBoxSalary.Name = "textBoxSalary";
            this.textBoxSalary.Size = new System.Drawing.Size(262, 20);
            this.textBoxSalary.TabIndex = 21;
            // 
            // toolTipWhy
            // 
            this.toolTipWhy.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipWhy.ToolTipTitle = "Experience and Expectations";
            // 
            // openFileDialogCV
            // 
            this.openFileDialogCV.FileName = "CV";
            this.openFileDialogCV.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogCV_FileOk);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(410, 793);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(175, 23);
            this.buttonSubmit.TabIndex = 21;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // labelAgreement1
            // 
            this.labelAgreement1.AutoSize = true;
            this.labelAgreement1.Location = new System.Drawing.Point(40, 741);
            this.labelAgreement1.Name = "labelAgreement1";
            this.labelAgreement1.Size = new System.Drawing.Size(296, 13);
            this.labelAgreement1.TabIndex = 23;
            this.labelAgreement1.Text = "By continuing, you agree to the conditions outlined within the ";
            // 
            // linkLabelAgreement
            // 
            this.linkLabelAgreement.AutoSize = true;
            this.linkLabelAgreement.Location = new System.Drawing.Point(329, 741);
            this.linkLabelAgreement.Name = "linkLabelAgreement";
            this.linkLabelAgreement.Size = new System.Drawing.Size(101, 13);
            this.linkLabelAgreement.TabIndex = 24;
            this.linkLabelAgreement.TabStop = true;
            this.linkLabelAgreement.Text = "Sage Privacy Policy";
            this.linkLabelAgreement.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAgreement_LinkClicked);
            // 
            // checkBoxAgreement
            // 
            this.checkBoxAgreement.AutoSize = true;
            this.checkBoxAgreement.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBoxAgreement.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.checkBoxAgreement.Location = new System.Drawing.Point(43, 765);
            this.checkBoxAgreement.Name = "checkBoxAgreement";
            this.checkBoxAgreement.Size = new System.Drawing.Size(434, 17);
            this.checkBoxAgreement.TabIndex = 25;
            this.checkBoxAgreement.Text = "I agree to my data being used for the purpose of expressing an interest in this v" +
    "acancy.";
            this.checkBoxAgreement.UseVisualStyleBackColor = true;
            this.checkBoxAgreement.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ApplicationForm
            // 
            this.AcceptButton = this.buttonSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(659, 422);
            this.Controls.Add(this.checkBoxAgreement);
            this.Controls.Add(this.linkLabelAgreement);
            this.Controls.Add(this.labelAgreement1);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.groupBoxExperience);
            this.Controls.Add(this.groupBoxAddress);
            this.Controls.Add(this.groupBoxPersonal);
            this.MaximumSize = new System.Drawing.Size(675, 600);
            this.Name = "ApplicationForm";
            this.Text = "Sage UK Job Application Form";
            this.Load += new System.EventHandler(this.ApplicationForm_Load);
            this.groupBoxAddress.ResumeLayout(false);
            this.groupBoxAddress.PerformLayout();
            this.groupBoxPersonal.ResumeLayout(false);
            this.groupBoxPersonal.PerformLayout();
            this.groupBoxExperience.ResumeLayout(false);
            this.groupBoxExperience.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelFirstName;
        private System.Windows.Forms.TextBox TextBoxFirstName;
        private System.Windows.Forms.TextBox TextBoxMiddleName;
        private System.Windows.Forms.TextBox TextBoxLastName;
        private System.Windows.Forms.Label LabelMiddleName;
        private System.Windows.Forms.Label LabelLastName;
        private System.Windows.Forms.GroupBox groupBoxAddress;
        private System.Windows.Forms.Label labelAddressLine6;
        private System.Windows.Forms.Label labelAddressLine5;
        private System.Windows.Forms.TextBox textBoxAddressLine6;
        private System.Windows.Forms.Label labelAddressLine3;
        private System.Windows.Forms.TextBox textBoxAddressLine5;
        private System.Windows.Forms.TextBox textBoxAddressLine3;
        private System.Windows.Forms.Label labelAddressLine2;
        private System.Windows.Forms.TextBox textBoxAddressLine2;
        private System.Windows.Forms.Label labelAddressLine4;
        private System.Windows.Forms.TextBox textBoxAddressLine4;
        private System.Windows.Forms.Label labelAddressLine1;
        private System.Windows.Forms.TextBox textBoxAddressLine1;
        private System.Windows.Forms.Label labelDOB;
        private System.Windows.Forms.Label labelNationalInsurance;
        private System.Windows.Forms.TextBox textBoxNationalInsurance;
        private System.Windows.Forms.GroupBox groupBoxPersonal;
        private System.Windows.Forms.GroupBox groupBoxExperience;
        private System.Windows.Forms.ComboBox comboBoxDOBYear;
        private System.Windows.Forms.ComboBox comboBoxDOBMonth;
        private System.Windows.Forms.ComboBox comboBoxDOBDay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSkills;
        private System.Windows.Forms.Label labelWhy;
        private System.Windows.Forms.Label labelJobTitle;
        private System.Windows.Forms.TextBox textBoxWhy;
        private System.Windows.Forms.TextBox textBoxJobTitle;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.TextBox textBoxSalary;
        private System.Windows.Forms.ToolTip toolTipWhy;
        private System.Windows.Forms.Button buttonCVUpload;
        private System.Windows.Forms.Button buttonCVBrowse;
        private System.Windows.Forms.Label labelCV;
        private System.Windows.Forms.TextBox textBoxCV;
        private System.Windows.Forms.OpenFileDialog openFileDialogCV;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.Label labelAgreement1;
        private System.Windows.Forms.LinkLabel linkLabelAgreement;
        private System.Windows.Forms.CheckBox checkBoxAgreement;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        public System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

