namespace Stilinksi_Project
{
    partial class form_enroll
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
            this.txt_Fname = new System.Windows.Forms.TextBox();
            this.txt_Sname = new System.Windows.Forms.TextBox();
            this.txt_Uname = new System.Windows.Forms.TextBox();
            this.txt_Pword1 = new System.Windows.Forms.TextBox();
            this.txt_Pword2 = new System.Windows.Forms.TextBox();
            this.box_Gender = new System.Windows.Forms.ComboBox();
            this.box_Country = new System.Windows.Forms.ComboBox();
            this.date_bday = new System.Windows.Forms.DateTimePicker();
            this.uname_Warning = new System.Windows.Forms.Label();
            this.pword_Warning = new System.Windows.Forms.Label();
            this.btn_Register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Fname
            // 
            this.txt_Fname.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Fname.Location = new System.Drawing.Point(117, 290);
            this.txt_Fname.Name = "txt_Fname";
            this.txt_Fname.Size = new System.Drawing.Size(355, 34);
            this.txt_Fname.TabIndex = 0;
            // 
            // txt_Sname
            // 
            this.txt_Sname.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sname.Location = new System.Drawing.Point(117, 370);
            this.txt_Sname.Name = "txt_Sname";
            this.txt_Sname.Size = new System.Drawing.Size(355, 34);
            this.txt_Sname.TabIndex = 1;
            // 
            // txt_Uname
            // 
            this.txt_Uname.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Uname.Location = new System.Drawing.Point(605, 332);
            this.txt_Uname.Name = "txt_Uname";
            this.txt_Uname.Size = new System.Drawing.Size(355, 34);
            this.txt_Uname.TabIndex = 2;
            this.txt_Uname.Leave += new System.EventHandler(this.txt_Uname_Leave);
            // 
            // txt_Pword1
            // 
            this.txt_Pword1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pword1.Location = new System.Drawing.Point(605, 418);
            this.txt_Pword1.Name = "txt_Pword1";
            this.txt_Pword1.Size = new System.Drawing.Size(355, 34);
            this.txt_Pword1.TabIndex = 3;
            this.txt_Pword1.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.txt_Pword1.Leave += new System.EventHandler(this.txt_Pword1_Leave);
            // 
            // txt_Pword2
            // 
            this.txt_Pword2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Pword2.Location = new System.Drawing.Point(605, 496);
            this.txt_Pword2.Name = "txt_Pword2";
            this.txt_Pword2.Size = new System.Drawing.Size(355, 34);
            this.txt_Pword2.TabIndex = 4;
            this.txt_Pword2.Leave += new System.EventHandler(this.txt_Pword2_Leave);
            // 
            // box_Gender
            // 
            this.box_Gender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.box_Gender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.box_Gender.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Gender.FormattingEnabled = true;
            this.box_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.box_Gender.Location = new System.Drawing.Point(117, 452);
            this.box_Gender.Name = "box_Gender";
            this.box_Gender.Size = new System.Drawing.Size(355, 36);
            this.box_Gender.TabIndex = 6;
            this.box_Gender.Leave += new System.EventHandler(this.box_Gender_Leave);
            // 
            // box_Country
            // 
            this.box_Country.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.box_Country.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.box_Country.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_Country.FormattingEnabled = true;
            this.box_Country.Items.AddRange(new object[] {
            "Afghanistan",
            "Akrotiri",
            "Albania",
            "Algeria",
            "American Samoa",
            "Andorra",
            "Angola",
            "Anguilla",
            "Antarctica",
            "Antigua and Barbuda",
            "Argentina",
            "Armenia",
            "Aruba",
            "Ashmore and Cartier Islands",
            "Australia",
            "Austria",
            "Azerbaijan",
            "Bahamas, The",
            "Bahrain",
            "Bangladesh",
            "Barbados",
            "Bassas da India",
            "Belarus",
            "Belgium",
            "Belize",
            "Benin",
            "Bermuda",
            "Bhutan",
            "Bolivia",
            "Bosnia and Herzegovina",
            "Botswana",
            "Bouvet Island",
            "Brazil",
            "British Indian Ocean Territory",
            "British Virgin Islands",
            "Brunei",
            "Bulgaria",
            "Burkina Faso",
            "Burma",
            "Burundi",
            "Cambodia",
            "Cameroon",
            "Canada",
            "Cape Verde",
            "Cayman Islands",
            "Central African Republic",
            "Chad",
            "Chile",
            "China",
            "Christmas Island",
            "Clipperton Island",
            "Cocos (Keeling) Islands",
            "Colombia",
            "Comoros",
            "Congo, Democratic Republic of the",
            "Congo, Republic of the",
            "Cook Islands",
            "Coral Sea Islands",
            "Costa Rica",
            "Cote d\'Ivoire",
            "Croatia",
            "Cuba",
            "Cyprus",
            "Czech Republic",
            "Denmark",
            "Dhekelia",
            "Djibouti",
            "Dominica",
            "Dominican Republic",
            "Ecuador",
            "Egypt",
            "El Salvador",
            "Equatorial Guinea",
            "Eritrea",
            "Estonia",
            "Ethiopia",
            "Europa Island",
            "Falkland Islands (Islas Malvinas)",
            "Faroe Islands",
            "Fiji",
            "Finland",
            "France",
            "French Guiana",
            "French Polynesia",
            "French Southern and Antarctic Lands",
            "Gabon",
            "Gambia, The",
            "Gaza Strip",
            "Georgia",
            "Germany",
            "Ghana",
            "Gibraltar",
            "Glorioso Islands",
            "Greece",
            "Greenland",
            "Grenada",
            "Guadeloupe",
            "Guam",
            "Guatemala",
            "Guernsey",
            "Guinea",
            "Guinea-Bissau",
            "Guyana",
            "Haiti",
            "Heard Island and McDonald Islands",
            "Holy See (Vatican City)",
            "Honduras",
            "Hong Kong",
            "Hungary",
            "Iceland",
            "India",
            "Indonesia",
            "Iran",
            "Iraq",
            "Ireland",
            "Isle of Man",
            "Israel",
            "Italy",
            "Jamaica",
            "Jan Mayen",
            "Japan",
            "Jersey",
            "Jordan",
            "Juan de Nova Island",
            "Kazakhstan",
            "Kenya",
            "Kiribati",
            "Korea, North",
            "Korea, South",
            "Kuwait",
            "Kyrgyzstan",
            "Laos",
            "Latvia",
            "Lebanon",
            "Lesotho",
            "Liberia",
            "Libya",
            "Liechtenstein",
            "Lithuania",
            "Luxembourg",
            "Macau",
            "Macedonia",
            "Madagascar",
            "Malawi",
            "Malaysia",
            "Maldives",
            "Mali",
            "Malta",
            "Marshall Islands",
            "Martinique",
            "Mauritania",
            "Mauritius",
            "Mayotte",
            "Mexico",
            "Micronesia, Federated States of",
            "Moldova",
            "Monaco",
            "Mongolia",
            "Montserrat",
            "Morocco",
            "Mozambique",
            "Namibia",
            "Nauru",
            "Navassa Island",
            "Nepal",
            "Netherlands",
            "Netherlands Antilles",
            "New Caledonia",
            "New Zealand",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Niue",
            "Norfolk Island",
            "Northern Mariana Islands",
            "Norway",
            "Oman",
            "Pakistan",
            "Palau",
            "Panama",
            "Papua New Guinea",
            "Paracel Islands",
            "Paraguay",
            "Peru",
            "Philippines",
            "Pitcairn Islands",
            "Poland",
            "Portugal",
            "Puerto Rico",
            "Qatar",
            "Reunion",
            "Romania",
            "Russia",
            "Rwanda",
            "Saint Helena",
            "Saint Kitts and Nevis",
            "Saint Lucia",
            "Saint Pierre and Miquelon",
            "Saint Vincent and the Grenadines",
            "Samoa",
            "San Marino",
            "Sao Tome and Principe",
            "Saudi Arabia",
            "Senegal",
            "Serbia and Montenegro",
            "Seychelles",
            "Sierra Leone",
            "Singapore",
            "Slovakia",
            "Slovenia",
            "Solomon Islands",
            "Somalia",
            "South Africa",
            "South Georgia and the South Sandwich Islands",
            "Spain",
            "Spratly Islands",
            "Sri Lanka",
            "Sudan",
            "Suriname",
            "Svalbard",
            "Swaziland",
            "Sweden",
            "Switzerland",
            "Syria",
            "Taiwan",
            "Tajikistan",
            "Tanzania",
            "Thailand",
            "Timor-Leste",
            "Togo",
            "Tokelau",
            "Tonga",
            "Trinidad and Tobago",
            "Tromelin Island",
            "Tunisia",
            "Turkey",
            "Turkmenistan",
            "Turks and Caicos Islands",
            "Tuvalu",
            "Uganda",
            "Ukraine",
            "United Arab Emirates",
            "United Kingdom",
            "United States",
            "Uruguay",
            "Uzbekistan",
            "Vanuatu",
            "Venezuela",
            "Vietnam",
            "Virgin Islands",
            "Wake Island",
            "Wallis and Futuna",
            "West Bank",
            "Western Sahara",
            "Yemen",
            "Zambia",
            "Zimbabwe"});
            this.box_Country.Location = new System.Drawing.Point(117, 609);
            this.box_Country.Name = "box_Country";
            this.box_Country.Size = new System.Drawing.Size(355, 36);
            this.box_Country.TabIndex = 7;
            // 
            // date_bday
            // 
            this.date_bday.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_bday.Location = new System.Drawing.Point(117, 525);
            this.date_bday.Name = "date_bday";
            this.date_bday.Size = new System.Drawing.Size(355, 34);
            this.date_bday.TabIndex = 8;
            // 
            // uname_Warning
            // 
            this.uname_Warning.AutoSize = true;
            this.uname_Warning.BackColor = System.Drawing.Color.Transparent;
            this.uname_Warning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uname_Warning.ForeColor = System.Drawing.Color.Red;
            this.uname_Warning.Location = new System.Drawing.Point(724, 303);
            this.uname_Warning.Name = "uname_Warning";
            this.uname_Warning.Size = new System.Drawing.Size(180, 21);
            this.uname_Warning.TabIndex = 9;
            this.uname_Warning.Text = "Username not available. ";
            this.uname_Warning.Visible = false;
            // 
            // pword_Warning
            // 
            this.pword_Warning.AutoSize = true;
            this.pword_Warning.BackColor = System.Drawing.Color.Transparent;
            this.pword_Warning.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pword_Warning.ForeColor = System.Drawing.Color.Red;
            this.pword_Warning.Location = new System.Drawing.Point(809, 467);
            this.pword_Warning.Name = "pword_Warning";
            this.pword_Warning.Size = new System.Drawing.Size(174, 21);
            this.pword_Warning.TabIndex = 10;
            this.pword_Warning.Text = "Passwords don\'t match.";
            this.pword_Warning.Visible = false;
            // 
            // btn_Register
            // 
            this.btn_Register.BackgroundImage = global::Stilinksi_Project.Properties.Resources.btn_enroll;
            this.btn_Register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Register.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.Location = new System.Drawing.Point(783, 575);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(177, 47);
            this.btn_Register.TabIndex = 11;
            this.btn_Register.UseVisualStyleBackColor = true;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // Frm_Enroll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Stilinksi_Project.Properties.Resources.registration_bkg;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.btn_Register);
            this.Controls.Add(this.pword_Warning);
            this.Controls.Add(this.uname_Warning);
            this.Controls.Add(this.date_bday);
            this.Controls.Add(this.box_Country);
            this.Controls.Add(this.box_Gender);
            this.Controls.Add(this.txt_Pword2);
            this.Controls.Add(this.txt_Pword1);
            this.Controls.Add(this.txt_Uname);
            this.Controls.Add(this.txt_Sname);
            this.Controls.Add(this.txt_Fname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Enroll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Enroll";
            this.Load += new System.EventHandler(this.Frm_Enroll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Fname;
        private System.Windows.Forms.TextBox txt_Sname;
        private System.Windows.Forms.TextBox txt_Uname;
        private System.Windows.Forms.TextBox txt_Pword1;
        private System.Windows.Forms.TextBox txt_Pword2;
        private System.Windows.Forms.ComboBox box_Gender;
        private System.Windows.Forms.ComboBox box_Country;
        private System.Windows.Forms.DateTimePicker date_bday;
        private System.Windows.Forms.Label uname_Warning;
        private System.Windows.Forms.Label pword_Warning;
        private System.Windows.Forms.Button btn_Register;
    }
}