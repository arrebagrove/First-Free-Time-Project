namespace Salary_Calculator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lstResult = new System.Windows.Forms.ListBox();
            this.lblListDate = new System.Windows.Forms.Label();
            this.lblListTimes = new System.Windows.Forms.Label();
            this.lblListHours = new System.Windows.Forms.Label();
            this.lblListSalary = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.txtOverTimeSalary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblMins = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtEndMinutes = new System.Windows.Forms.TextBox();
            this.txtStartMinutes = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.txtEndHours = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStartHours = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblPerfHours = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblSalaryDisplay = new System.Windows.Forms.Label();
            this.rbnChangeTime = new System.Windows.Forms.RadioButton();
            this.lblTotalHoursDisplay = new System.Windows.Forms.Label();
            this.lblPerfHoursDisplay = new System.Windows.Forms.Label();
            this.lblTotalHours = new System.Windows.Forms.Label();
            this.lblTotalSalaryPerfDisplay = new System.Windows.Forms.Label();
            this.lblTotalSalaryPerf = new System.Windows.Forms.Label();
            this.lblTotalSalary = new System.Windows.Forms.Label();
            this.lblTotalSalaryDisplay = new System.Windows.Forms.Label();
            this.lblNumberOfDays = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rbnFourthShift = new System.Windows.Forms.RadioButton();
            this.rbnThirdShift = new System.Windows.Forms.RadioButton();
            this.rbnSecondShift = new System.Windows.Forms.RadioButton();
            this.rbnFirstShift = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddWeek = new System.Windows.Forms.Button();
            this.lblTotalSalaryNet = new System.Windows.Forms.Label();
            this.lblTotalSalaryNetDisplay = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstResult
            // 
            this.lstResult.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResult.FormattingEnabled = true;
            this.lstResult.ItemHeight = 14;
            this.lstResult.Location = new System.Drawing.Point(16, 47);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(434, 466);
            this.lstResult.TabIndex = 0;
            // 
            // lblListDate
            // 
            this.lblListDate.AutoSize = true;
            this.lblListDate.Location = new System.Drawing.Point(13, 29);
            this.lblListDate.Name = "lblListDate";
            this.lblListDate.Size = new System.Drawing.Size(30, 13);
            this.lblListDate.TabIndex = 1;
            this.lblListDate.Text = "Date";
            // 
            // lblListTimes
            // 
            this.lblListTimes.AutoSize = true;
            this.lblListTimes.Location = new System.Drawing.Point(164, 29);
            this.lblListTimes.Name = "lblListTimes";
            this.lblListTimes.Size = new System.Drawing.Size(35, 13);
            this.lblListTimes.TabIndex = 2;
            this.lblListTimes.Text = "Times";
            // 
            // lblListHours
            // 
            this.lblListHours.AutoSize = true;
            this.lblListHours.Location = new System.Drawing.Point(282, 29);
            this.lblListHours.Name = "lblListHours";
            this.lblListHours.Size = new System.Drawing.Size(35, 13);
            this.lblListHours.TabIndex = 3;
            this.lblListHours.Text = "Hours";
            // 
            // lblListSalary
            // 
            this.lblListSalary.AutoSize = true;
            this.lblListSalary.Location = new System.Drawing.Point(379, 29);
            this.lblListSalary.Name = "lblListSalary";
            this.lblListSalary.Size = new System.Drawing.Size(36, 13);
            this.lblListSalary.TabIndex = 4;
            this.lblListSalary.Text = "Salary";
            // 
            // txtSalary
            // 
            this.txtSalary.Location = new System.Drawing.Point(512, 42);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(56, 20);
            this.txtSalary.TabIndex = 1;
            // 
            // txtOverTimeSalary
            // 
            this.txtOverTimeSalary.Location = new System.Drawing.Point(656, 42);
            this.txtOverTimeSalary.Name = "txtOverTimeSalary";
            this.txtOverTimeSalary.Size = new System.Drawing.Size(56, 20);
            this.txtOverTimeSalary.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(472, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(601, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Overtime";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(544, 80);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAdd.Location = new System.Drawing.Point(501, 243);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 46);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(501, 306);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 34);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblMins
            // 
            this.lblMins.AutoSize = true;
            this.lblMins.Location = new System.Drawing.Point(628, 380);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(29, 13);
            this.lblMins.TabIndex = 8;
            this.lblMins.Text = "Mins";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(595, 380);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(35, 13);
            this.lblHours.TabIndex = 7;
            this.lblHours.Text = "Hours";
            // 
            // txtEndMinutes
            // 
            this.txtEndMinutes.Location = new System.Drawing.Point(630, 422);
            this.txtEndMinutes.Name = "txtEndMinutes";
            this.txtEndMinutes.Size = new System.Drawing.Size(24, 20);
            this.txtEndMinutes.TabIndex = 14;
            // 
            // txtStartMinutes
            // 
            this.txtStartMinutes.Location = new System.Drawing.Point(630, 396);
            this.txtStartMinutes.Name = "txtStartMinutes";
            this.txtStartMinutes.Size = new System.Drawing.Size(24, 20);
            this.txtStartMinutes.TabIndex = 12;
            // 
            // btnChange
            // 
            this.btnChange.Location = new System.Drawing.Point(605, 306);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(88, 37);
            this.btnChange.TabIndex = 10;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // txtEndHours
            // 
            this.txtEndHours.Location = new System.Drawing.Point(600, 422);
            this.txtEndHours.Name = "txtEndHours";
            this.txtEndHours.Size = new System.Drawing.Size(24, 20);
            this.txtEndHours.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(530, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "End time";
            // 
            // txtStartHours
            // 
            this.txtStartHours.Location = new System.Drawing.Point(600, 396);
            this.txtStartHours.Name = "txtStartHours";
            this.txtStartHours.Size = new System.Drawing.Size(24, 20);
            this.txtStartHours.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Start time";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Location = new System.Drawing.Point(160, 554);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(36, 13);
            this.lblSalary.TabIndex = 17;
            this.lblSalary.Text = "Salary";
            // 
            // lblPerfHours
            // 
            this.lblPerfHours.AutoSize = true;
            this.lblPerfHours.Location = new System.Drawing.Point(275, 525);
            this.lblPerfHours.Name = "lblPerfHours";
            this.lblPerfHours.Size = new System.Drawing.Size(98, 13);
            this.lblPerfHours.TabIndex = 19;
            this.lblPerfHours.Text = "Performance Hours";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCount.Location = new System.Drawing.Point(101, 536);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(2, 15);
            this.lblCount.TabIndex = 24;
            // 
            // lblSalaryDisplay
            // 
            this.lblSalaryDisplay.AutoSize = true;
            this.lblSalaryDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSalaryDisplay.Location = new System.Drawing.Point(206, 552);
            this.lblSalaryDisplay.Name = "lblSalaryDisplay";
            this.lblSalaryDisplay.Size = new System.Drawing.Size(2, 15);
            this.lblSalaryDisplay.TabIndex = 25;
            // 
            // rbnChangeTime
            // 
            this.rbnChangeTime.AutoSize = true;
            this.rbnChangeTime.Location = new System.Drawing.Point(526, 457);
            this.rbnChangeTime.Name = "rbnChangeTime";
            this.rbnChangeTime.Size = new System.Drawing.Size(136, 17);
            this.rbnChangeTime.TabIndex = 15;
            this.rbnChangeTime.TabStop = true;
            this.rbnChangeTime.Text = "Add Custom Date/Time";
            this.rbnChangeTime.UseVisualStyleBackColor = true;
            // 
            // lblTotalHoursDisplay
            // 
            this.lblTotalHoursDisplay.AutoSize = true;
            this.lblTotalHoursDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalHoursDisplay.Location = new System.Drawing.Point(206, 523);
            this.lblTotalHoursDisplay.Name = "lblTotalHoursDisplay";
            this.lblTotalHoursDisplay.Size = new System.Drawing.Size(2, 15);
            this.lblTotalHoursDisplay.TabIndex = 27;
            // 
            // lblPerfHoursDisplay
            // 
            this.lblPerfHoursDisplay.AutoSize = true;
            this.lblPerfHoursDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPerfHoursDisplay.Location = new System.Drawing.Point(377, 525);
            this.lblPerfHoursDisplay.Name = "lblPerfHoursDisplay";
            this.lblPerfHoursDisplay.Size = new System.Drawing.Size(2, 15);
            this.lblPerfHoursDisplay.TabIndex = 28;
            // 
            // lblTotalHours
            // 
            this.lblTotalHours.AutoSize = true;
            this.lblTotalHours.Location = new System.Drawing.Point(161, 525);
            this.lblTotalHours.Name = "lblTotalHours";
            this.lblTotalHours.Size = new System.Drawing.Size(35, 13);
            this.lblTotalHours.TabIndex = 29;
            this.lblTotalHours.Text = "Hours";
            // 
            // lblTotalSalaryPerfDisplay
            // 
            this.lblTotalSalaryPerfDisplay.AutoSize = true;
            this.lblTotalSalaryPerfDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalSalaryPerfDisplay.Location = new System.Drawing.Point(377, 552);
            this.lblTotalSalaryPerfDisplay.Name = "lblTotalSalaryPerfDisplay";
            this.lblTotalSalaryPerfDisplay.Size = new System.Drawing.Size(2, 15);
            this.lblTotalSalaryPerfDisplay.TabIndex = 30;
            // 
            // lblTotalSalaryPerf
            // 
            this.lblTotalSalaryPerf.AutoSize = true;
            this.lblTotalSalaryPerf.Location = new System.Drawing.Point(273, 554);
            this.lblTotalSalaryPerf.Name = "lblTotalSalaryPerf";
            this.lblTotalSalaryPerf.Size = new System.Drawing.Size(99, 13);
            this.lblTotalSalaryPerf.TabIndex = 31;
            this.lblTotalSalaryPerf.Text = "Performance Salary";
            // 
            // lblTotalSalary
            // 
            this.lblTotalSalary.AutoSize = true;
            this.lblTotalSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalary.Location = new System.Drawing.Point(447, 521);
            this.lblTotalSalary.Name = "lblTotalSalary";
            this.lblTotalSalary.Size = new System.Drawing.Size(138, 16);
            this.lblTotalSalary.TabIndex = 32;
            this.lblTotalSalary.Text = "Total Gross Salary";
            // 
            // lblTotalSalaryDisplay
            // 
            this.lblTotalSalaryDisplay.AutoSize = true;
            this.lblTotalSalaryDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalSalaryDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalaryDisplay.Location = new System.Drawing.Point(587, 521);
            this.lblTotalSalaryDisplay.Name = "lblTotalSalaryDisplay";
            this.lblTotalSalaryDisplay.Size = new System.Drawing.Size(2, 18);
            this.lblTotalSalaryDisplay.TabIndex = 33;
            // 
            // lblNumberOfDays
            // 
            this.lblNumberOfDays.AutoSize = true;
            this.lblNumberOfDays.Location = new System.Drawing.Point(13, 537);
            this.lblNumberOfDays.Name = "lblNumberOfDays";
            this.lblNumberOfDays.Size = new System.Drawing.Size(83, 13);
            this.lblNumberOfDays.TabIndex = 36;
            this.lblNumberOfDays.Text = "Number of Days";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(750, 24);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newMenuItem
            // 
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.Size = new System.Drawing.Size(98, 22);
            this.newMenuItem.Text = "New";
            this.newMenuItem.Click += new System.EventHandler(this.newMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // rbnFourthShift
            // 
            this.rbnFourthShift.AutoSize = true;
            this.rbnFourthShift.Location = new System.Drawing.Point(550, 211);
            this.rbnFourthShift.Name = "rbnFourthShift";
            this.rbnFourthShift.Size = new System.Drawing.Size(88, 17);
            this.rbnFourthShift.TabIndex = 7;
            this.rbnFourthShift.TabStop = true;
            this.rbnFourthShift.Text = "10:30 - 19:00";
            this.rbnFourthShift.UseVisualStyleBackColor = true;
            // 
            // rbnThirdShift
            // 
            this.rbnThirdShift.AutoSize = true;
            this.rbnThirdShift.Location = new System.Drawing.Point(550, 187);
            this.rbnThirdShift.Name = "rbnThirdShift";
            this.rbnThirdShift.Size = new System.Drawing.Size(85, 17);
            this.rbnThirdShift.TabIndex = 6;
            this.rbnThirdShift.TabStop = true;
            this.rbnThirdShift.Text = "09:30- 18:00";
            this.rbnThirdShift.UseVisualStyleBackColor = true;
            // 
            // rbnSecondShift
            // 
            this.rbnSecondShift.AutoSize = true;
            this.rbnSecondShift.Location = new System.Drawing.Point(550, 163);
            this.rbnSecondShift.Name = "rbnSecondShift";
            this.rbnSecondShift.Size = new System.Drawing.Size(88, 17);
            this.rbnSecondShift.TabIndex = 5;
            this.rbnSecondShift.TabStop = true;
            this.rbnSecondShift.Text = "09:00 - 17:30";
            this.rbnSecondShift.UseVisualStyleBackColor = true;
            // 
            // rbnFirstShift
            // 
            this.rbnFirstShift.AutoSize = true;
            this.rbnFirstShift.Location = new System.Drawing.Point(550, 139);
            this.rbnFirstShift.Name = "rbnFirstShift";
            this.rbnFirstShift.Size = new System.Drawing.Size(88, 17);
            this.rbnFirstShift.TabIndex = 4;
            this.rbnFirstShift.TabStop = true;
            this.rbnFirstShift.Text = "08:15 - 16:45";
            this.rbnFirstShift.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Schedules";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(530, 364);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Set/Change Time";
            // 
            // btnAddWeek
            // 
            this.btnAddWeek.Location = new System.Drawing.Point(605, 243);
            this.btnAddWeek.Name = "btnAddWeek";
            this.btnAddWeek.Size = new System.Drawing.Size(88, 46);
            this.btnAddWeek.TabIndex = 40;
            this.btnAddWeek.Text = "Add Week";
            this.btnAddWeek.UseVisualStyleBackColor = true;
            this.btnAddWeek.Click += new System.EventHandler(this.btnAddWeek_Click);
            // 
            // lblTotalSalaryNet
            // 
            this.lblTotalSalaryNet.AutoSize = true;
            this.lblTotalSalaryNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalaryNet.Location = new System.Drawing.Point(465, 548);
            this.lblTotalSalaryNet.Name = "lblTotalSalaryNet";
            this.lblTotalSalaryNet.Size = new System.Drawing.Size(121, 16);
            this.lblTotalSalaryNet.TabIndex = 41;
            this.lblTotalSalaryNet.Text = "Total Net Salary";
            // 
            // lblTotalSalaryNetDisplay
            // 
            this.lblTotalSalaryNetDisplay.AutoSize = true;
            this.lblTotalSalaryNetDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalSalaryNetDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSalaryNetDisplay.Location = new System.Drawing.Point(587, 548);
            this.lblTotalSalaryNetDisplay.Name = "lblTotalSalaryNetDisplay";
            this.lblTotalSalaryNetDisplay.Size = new System.Drawing.Size(2, 18);
            this.lblTotalSalaryNetDisplay.TabIndex = 42;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(507, 83);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 43;
            this.lblDate.Text = "Date";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(750, 573);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblTotalSalaryNetDisplay);
            this.Controls.Add(this.lblTotalSalaryNet);
            this.Controls.Add(this.btnAddWeek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMins);
            this.Controls.Add(this.rbnFirstShift);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.txtEndMinutes);
            this.Controls.Add(this.rbnSecondShift);
            this.Controls.Add(this.txtStartMinutes);
            this.Controls.Add(this.rbnThirdShift);
            this.Controls.Add(this.txtEndHours);
            this.Controls.Add(this.lblNumberOfDays);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbnFourthShift);
            this.Controls.Add(this.txtStartHours);
            this.Controls.Add(this.lblTotalSalaryDisplay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTotalSalary);
            this.Controls.Add(this.rbnChangeTime);
            this.Controls.Add(this.lblTotalSalaryPerf);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.lblTotalSalaryPerfDisplay);
            this.Controls.Add(this.lblTotalHours);
            this.Controls.Add(this.lblPerfHoursDisplay);
            this.Controls.Add(this.lblTotalHoursDisplay);
            this.Controls.Add(this.lblSalaryDisplay);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblPerfHours);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtOverTimeSalary);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.lblListSalary);
            this.Controls.Add(this.lblListHours);
            this.Controls.Add(this.lblListTimes);
            this.Controls.Add(this.lblListDate);
            this.Controls.Add(this.lstResult);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.Text = "Salary Calculator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstResult;
        private System.Windows.Forms.Label lblListDate;
        private System.Windows.Forms.Label lblListTimes;
        private System.Windows.Forms.Label lblListHours;
        private System.Windows.Forms.Label lblListSalary;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.TextBox txtOverTimeSalary;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.TextBox txtEndHours;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStartHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblPerfHours;
        private System.Windows.Forms.TextBox txtEndMinutes;
        private System.Windows.Forms.TextBox txtStartMinutes;
        private System.Windows.Forms.Label lblMins;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblSalaryDisplay;
        private System.Windows.Forms.RadioButton rbnChangeTime;
        private System.Windows.Forms.Label lblTotalHoursDisplay;
        private System.Windows.Forms.Label lblPerfHoursDisplay;
        private System.Windows.Forms.Label lblTotalHours;
        private System.Windows.Forms.Label lblTotalSalaryPerfDisplay;
        private System.Windows.Forms.Label lblTotalSalaryPerf;
        private System.Windows.Forms.Label lblTotalSalary;
        private System.Windows.Forms.Label lblTotalSalaryDisplay;
        private System.Windows.Forms.Label lblNumberOfDays;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.RadioButton rbnFourthShift;
        private System.Windows.Forms.RadioButton rbnThirdShift;
        private System.Windows.Forms.RadioButton rbnSecondShift;
        private System.Windows.Forms.RadioButton rbnFirstShift;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnAddWeek;
        private System.Windows.Forms.Label lblTotalSalaryNet;
        private System.Windows.Forms.Label lblTotalSalaryNetDisplay;
        private System.Windows.Forms.Label lblDate;
    }
}

