namespace Weather_Application
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
            this.TBCity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.labCondition = new System.Windows.Forms.Label();
            this.labDetails = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labSunrise = new System.Windows.Forms.Label();
            this.labSunset = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labPressure = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labWindSpeed = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labTemp = new System.Windows.Forms.Label();
            this.labHumidity = new System.Windows.Forms.Label();
            this.labcountry = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.labSealevel = new System.Windows.Forms.Label();
            this.labTempmax = new System.Windows.Forms.Label();
            this.labTempmin = new System.Windows.Forms.Label();
            this.FLP = new System.Windows.Forms.FlowLayoutPanel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsettings = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PnlNav = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.btnhelp = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // TBCity
            // 
            this.TBCity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.TBCity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBCity.Font = new System.Drawing.Font("Myanmar Text", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCity.ForeColor = System.Drawing.Color.White;
            this.TBCity.Location = new System.Drawing.Point(193, 7);
            this.TBCity.Name = "TBCity";
            this.TBCity.Size = new System.Drawing.Size(280, 38);
            this.TBCity.TabIndex = 1;
            this.TBCity.Text = "Silahkan Cari Kota";
            this.TBCity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(498, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 35);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Cari Kota";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // labCondition
            // 
            this.labCondition.AutoSize = true;
            this.labCondition.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCondition.ForeColor = System.Drawing.Color.White;
            this.labCondition.Location = new System.Drawing.Point(230, 14);
            this.labCondition.Name = "labCondition";
            this.labCondition.Size = new System.Drawing.Size(72, 24);
            this.labCondition.TabIndex = 3;
            this.labCondition.Text = "Kondisi";
            // 
            // labDetails
            // 
            this.labDetails.AutoSize = true;
            this.labDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetails.ForeColor = System.Drawing.Color.White;
            this.labDetails.Location = new System.Drawing.Point(230, 45);
            this.labDetails.Name = "labDetails";
            this.labDetails.Size = new System.Drawing.Size(0, 24);
            this.labDetails.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(39, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Sunrise:";
            this.label2.Visible = false;
            // 
            // labSunrise
            // 
            this.labSunrise.AutoSize = true;
            this.labSunrise.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunrise.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labSunrise.Location = new System.Drawing.Point(138, 347);
            this.labSunrise.Name = "labSunrise";
            this.labSunrise.Size = new System.Drawing.Size(21, 24);
            this.labSunrise.TabIndex = 6;
            this.labSunrise.Text = "0";
            this.labSunrise.Visible = false;
            // 
            // labSunset
            // 
            this.labSunset.AutoSize = true;
            this.labSunset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSunset.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labSunset.Location = new System.Drawing.Point(138, 381);
            this.labSunset.Name = "labSunset";
            this.labSunset.Size = new System.Drawing.Size(21, 24);
            this.labSunset.TabIndex = 8;
            this.labSunset.Text = "0";
            this.labSunset.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(48, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Sunset:";
            this.label5.Visible = false;
            // 
            // labPressure
            // 
            this.labPressure.AutoSize = true;
            this.labPressure.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressure.ForeColor = System.Drawing.Color.White;
            this.labPressure.Location = new System.Drawing.Point(169, 300);
            this.labPressure.Name = "labPressure";
            this.labPressure.Size = new System.Drawing.Size(21, 24);
            this.labPressure.TabIndex = 12;
            this.labPressure.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 300);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tekanan:";
            // 
            // labWindSpeed
            // 
            this.labWindSpeed.AutoSize = true;
            this.labWindSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labWindSpeed.ForeColor = System.Drawing.Color.White;
            this.labWindSpeed.Location = new System.Drawing.Point(169, 251);
            this.labWindSpeed.Name = "labWindSpeed";
            this.labWindSpeed.Size = new System.Drawing.Size(21, 24);
            this.labWindSpeed.TabIndex = 10;
            this.labWindSpeed.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(160, 24);
            this.label7.TabIndex = 9;
            this.label7.Text = "Kecepatan Angin:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 24);
            this.label3.TabIndex = 14;
            this.label3.Text = "Kelembapan:";
            // 
            // labTemp
            // 
            this.labTemp.AutoSize = true;
            this.labTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTemp.ForeColor = System.Drawing.Color.White;
            this.labTemp.Location = new System.Drawing.Point(63, 55);
            this.labTemp.Name = "labTemp";
            this.labTemp.Size = new System.Drawing.Size(60, 42);
            this.labTemp.TabIndex = 16;
            this.labTemp.Text = "20";
            // 
            // labHumidity
            // 
            this.labHumidity.AutoSize = true;
            this.labHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labHumidity.ForeColor = System.Drawing.Color.White;
            this.labHumidity.Location = new System.Drawing.Point(169, 347);
            this.labHumidity.Name = "labHumidity";
            this.labHumidity.Size = new System.Drawing.Size(21, 24);
            this.labHumidity.TabIndex = 17;
            this.labHumidity.Text = "0";
            // 
            // labcountry
            // 
            this.labcountry.AutoSize = true;
            this.labcountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labcountry.ForeColor = System.Drawing.Color.White;
            this.labcountry.Location = new System.Drawing.Point(60, 10);
            this.labcountry.Name = "labcountry";
            this.labcountry.Size = new System.Drawing.Size(72, 24);
            this.labcountry.TabIndex = 18;
            this.labcountry.Text = "Negara";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label8.Location = new System.Drawing.Point(25, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 24);
            this.label8.TabIndex = 19;
            this.label8.Text = "Sea-level:";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 24);
            this.label9.TabIndex = 20;
            this.label9.Text = "Suhu Maksimum:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(16, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "Suhu Minimum:";
            // 
            // labSealevel
            // 
            this.labSealevel.AutoSize = true;
            this.labSealevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labSealevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labSealevel.Location = new System.Drawing.Point(138, 415);
            this.labSealevel.Name = "labSealevel";
            this.labSealevel.Size = new System.Drawing.Size(21, 24);
            this.labSealevel.TabIndex = 22;
            this.labSealevel.Text = "0";
            this.labSealevel.Visible = false;
            // 
            // labTempmax
            // 
            this.labTempmax.AutoSize = true;
            this.labTempmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTempmax.ForeColor = System.Drawing.Color.White;
            this.labTempmax.Location = new System.Drawing.Point(169, 201);
            this.labTempmax.Name = "labTempmax";
            this.labTempmax.Size = new System.Drawing.Size(21, 24);
            this.labTempmax.TabIndex = 23;
            this.labTempmax.Text = "0";
            this.labTempmax.Click += new System.EventHandler(this.labTempmax_Click);
            // 
            // labTempmin
            // 
            this.labTempmin.AutoSize = true;
            this.labTempmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTempmin.ForeColor = System.Drawing.Color.White;
            this.labTempmin.Location = new System.Drawing.Point(169, 153);
            this.labTempmin.Name = "labTempmin";
            this.labTempmin.Size = new System.Drawing.Size(21, 24);
            this.labTempmin.TabIndex = 24;
            this.labTempmin.Text = "0";
            // 
            // FLP
            // 
            this.FLP.AutoScroll = true;
            this.FLP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.FLP.Location = new System.Drawing.Point(498, 65);
            this.FLP.Name = "FLP";
            this.FLP.Size = new System.Drawing.Size(343, 461);
            this.FLP.TabIndex = 25;
            // 
            // btnClear
            // 
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnClear.Location = new System.Drawing.Point(768, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 1);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnexit
            // 
            this.btnexit.FlatAppearance.BorderSize = 0;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.White;
            this.btnexit.Location = new System.Drawing.Point(898, 7);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(25, 25);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Tutup\r\n";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnsettings);
            this.panel1.Controls.Add(this.btnhelp);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 538);
            this.panel1.TabIndex = 28;
            // 
            // btnsettings
            // 
            this.btnsettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnsettings.FlatAppearance.BorderSize = 0;
            this.btnsettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsettings.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnsettings.Location = new System.Drawing.Point(0, 496);
            this.btnsettings.Name = "btnsettings";
            this.btnsettings.Size = new System.Drawing.Size(1, 42);
            this.btnsettings.TabIndex = 1;
            this.btnsettings.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnsettings.UseVisualStyleBackColor = true;
            this.btnsettings.Click += new System.EventHandler(this.btnsettings_Click);
            this.btnsettings.Leave += new System.EventHandler(this.btnsettings_Leave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDashboard.Location = new System.Drawing.Point(0, 144);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(1, 42);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.Leave += new System.EventHandler(this.btnDashboard_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 144);
            this.panel2.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.label12.Location = new System.Drawing.Point(48, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 12);
            this.label12.TabIndex = 2;
            this.label12.Text = "Enriching The Life";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label11.Location = new System.Drawing.Point(61, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 18);
            this.label11.TabIndex = 1;
            this.label11.Text = "SkyMate";
            // 
            // PnlNav
            // 
            this.PnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.PnlNav.Location = new System.Drawing.Point(0, 193);
            this.PnlNav.Name = "PnlNav";
            this.PnlNav.Size = new System.Drawing.Size(3, 100);
            this.PnlNav.TabIndex = 29;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel3.Controls.Add(this.labcountry);
            this.panel3.Controls.Add(this.labCondition);
            this.panel3.Controls.Add(this.labDetails);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.labSealevel);
            this.panel3.Controls.Add(this.labTempmax);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.labTempmin);
            this.panel3.Controls.Add(this.labWindSpeed);
            this.panel3.Controls.Add(this.labPressure);
            this.panel3.Controls.Add(this.picIcon);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.labSunrise);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.labTemp);
            this.panel3.Controls.Add(this.labHumidity);
            this.panel3.Controls.Add(this.labSunset);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(77, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(396, 461);
            this.panel3.TabIndex = 30;
            // 
            // picIcon
            // 
            this.picIcon.ErrorImage = null;
            this.picIcon.InitialImage = null;
            this.picIcon.Location = new System.Drawing.Point(217, 121);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(111, 56);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 13;
            this.picIcon.TabStop = false;
            // 
            // btnhelp
            // 
            this.btnhelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnhelp.FlatAppearance.BorderSize = 0;
            this.btnhelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnhelp.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnhelp.Location = new System.Drawing.Point(0, 186);
            this.btnhelp.Name = "btnhelp";
            this.btnhelp.Size = new System.Drawing.Size(1, 42);
            this.btnhelp.TabIndex = 1;
            this.btnhelp.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnhelp.UseVisualStyleBackColor = true;
            this.btnhelp.Click += new System.EventHandler(this.btnhelp_Click);
            this.btnhelp.Leave += new System.EventHandler(this.btnhelp_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(935, 538);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PnlNav);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.FLP);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.TBCity);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TBCity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label labCondition;
        private System.Windows.Forms.Label labDetails;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labSunrise;
        private System.Windows.Forms.Label labSunset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labPressure;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labWindSpeed;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labTemp;
        private System.Windows.Forms.Label labHumidity;
        private System.Windows.Forms.Label labcountry;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labSealevel;
        private System.Windows.Forms.Label labTempmax;
        private System.Windows.Forms.Label labTempmin;
        private System.Windows.Forms.FlowLayoutPanel FLP;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnsettings;
        private System.Windows.Forms.Panel PnlNav;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnhelp;
    }
}

