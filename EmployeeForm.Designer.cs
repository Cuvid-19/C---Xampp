namespace WindowsFormsApp1
{
    partial class EmployeeForm
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
            this.logoutbtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ApplyLeaveBtn = new System.Windows.Forms.Button();
            this.dateCreated = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.DayBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.LeaveStart = new System.Windows.Forms.DateTimePicker();
            this.LeaveEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ApplyOvertimeBtn = new System.Windows.Forms.Button();
            this.OTEnd = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.OTstart = new System.Windows.Forms.DateTimePicker();
            this.dateCreate2 = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.namelabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 3;
            // 
            // logoutbtn
            // 
            this.logoutbtn.Location = new System.Drawing.Point(1384, 11);
            this.logoutbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutbtn.Name = "logoutbtn";
            this.logoutbtn.Size = new System.Drawing.Size(75, 34);
            this.logoutbtn.TabIndex = 1;
            this.logoutbtn.Text = "logout";
            this.logoutbtn.UseVisualStyleBackColor = true;
            this.logoutbtn.Click += new System.EventHandler(this.logoutbtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Day";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Time";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 18);
            this.label7.TabIndex = 9;
            this.label7.Text = "File Attached : ";
            // 
            // ApplyLeaveBtn
            // 
            this.ApplyLeaveBtn.Location = new System.Drawing.Point(78, 230);
            this.ApplyLeaveBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApplyLeaveBtn.Name = "ApplyLeaveBtn";
            this.ApplyLeaveBtn.Size = new System.Drawing.Size(131, 26);
            this.ApplyLeaveBtn.TabIndex = 10;
            this.ApplyLeaveBtn.Text = "Apply";
            this.ApplyLeaveBtn.UseVisualStyleBackColor = true;
            this.ApplyLeaveBtn.Click += new System.EventHandler(this.ApplyLeaveBtn_Click);
            // 
            // dateCreated
            // 
            this.dateCreated.Location = new System.Drawing.Point(133, 49);
            this.dateCreated.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.Size = new System.Drawing.Size(200, 24);
            this.dateCreated.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 187);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "File";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // DayBox
            // 
            this.DayBox.FormattingEnabled = true;
            this.DayBox.Location = new System.Drawing.Point(133, 93);
            this.DayBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(195, 26);
            this.DayBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "--";
            // 
            // LeaveStart
            // 
            this.LeaveStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.LeaveStart.Location = new System.Drawing.Point(78, 141);
            this.LeaveStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeaveStart.Name = "LeaveStart";
            this.LeaveStart.Size = new System.Drawing.Size(131, 24);
            this.LeaveStart.TabIndex = 19;
            // 
            // LeaveEnd
            // 
            this.LeaveEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.LeaveEnd.Location = new System.Drawing.Point(259, 141);
            this.LeaveEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeaveEnd.Name = "LeaveEnd";
            this.LeaveEnd.Size = new System.Drawing.Size(108, 24);
            this.LeaveEnd.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.ApplyLeaveBtn);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.LeaveEnd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.LeaveStart);
            this.groupBox1.Controls.Add(this.dateCreated);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.DayBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(1053, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(374, 295);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apply for Leave";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Gold;
            this.groupBox2.Controls.Add(this.ApplyOvertimeBtn);
            this.groupBox2.Controls.Add(this.OTEnd);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.OTstart);
            this.groupBox2.Controls.Add(this.dateCreate2);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Location = new System.Drawing.Point(781, 49);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(383, 235);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Apply for Overtime";
            // 
            // ApplyOvertimeBtn
            // 
            this.ApplyOvertimeBtn.Location = new System.Drawing.Point(132, 174);
            this.ApplyOvertimeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ApplyOvertimeBtn.Name = "ApplyOvertimeBtn";
            this.ApplyOvertimeBtn.Size = new System.Drawing.Size(131, 28);
            this.ApplyOvertimeBtn.TabIndex = 10;
            this.ApplyOvertimeBtn.Text = "Apply";
            this.ApplyOvertimeBtn.UseVisualStyleBackColor = true;
            this.ApplyOvertimeBtn.Click += new System.EventHandler(this.ApplyOvertimeBtn_Click);
            // 
            // OTEnd
            // 
            this.OTEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.OTEnd.Location = new System.Drawing.Point(265, 116);
            this.OTEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OTEnd.Name = "OTEnd";
            this.OTEnd.Size = new System.Drawing.Size(108, 22);
            this.OTEnd.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 17);
            this.label10.TabIndex = 6;
            this.label10.Text = "Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(221, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "--";
            // 
            // OTstart
            // 
            this.OTstart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.OTstart.Location = new System.Drawing.Point(77, 116);
            this.OTstart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OTstart.Name = "OTstart";
            this.OTstart.Size = new System.Drawing.Size(131, 22);
            this.OTstart.TabIndex = 19;
            // 
            // dateCreate2
            // 
            this.dateCreate2.Location = new System.Drawing.Point(132, 63);
            this.dateCreate2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateCreate2.Name = "dateCreate2";
            this.dateCreate2.Size = new System.Drawing.Size(200, 22);
            this.dateCreate2.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 116);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 17);
            this.label14.TabIndex = 8;
            this.label14.Text = "Time";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Fuchsia;
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.Deletebtn);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(15, 51);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1444, 403);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Leave Status";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chk});
            this.dataGridView1.Location = new System.Drawing.Point(9, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1017, 295);
            this.dataGridView1.TabIndex = 23;
            // 
            // chk
            // 
            this.chk.HeaderText = "";
            this.chk.MinimumWidth = 6;
            this.chk.Name = "chk";
            this.chk.Width = 50;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Location = new System.Drawing.Point(35, 353);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(106, 34);
            this.Deletebtn.TabIndex = 22;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(15, 485);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1256, 340);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "OverTime";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(27, 49);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(705, 235);
            this.dataGridView2.TabIndex = 28;
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(47, 13);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(64, 25);
            this.namelabel.TabIndex = 27;
            this.namelabel.Text = "Name";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(12, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 25);
            this.label15.TabIndex = 28;
            this.label15.Text = "Hi ,";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(100, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(61, 18);
            this.label16.TabIndex = 24;
            this.label16.Text = "Pending";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(596, 20);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 17);
            this.label17.TabIndex = 29;
            this.label17.Text = "1";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 1055);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.logoutbtn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "EmployeeForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logoutbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button ApplyLeaveBtn;
        private System.Windows.Forms.DateTimePicker dateCreated;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox DayBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker LeaveStart;
        private System.Windows.Forms.DateTimePicker LeaveEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ApplyOvertimeBtn;
        private System.Windows.Forms.DateTimePicker OTEnd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker OTstart;
        private System.Windows.Forms.DateTimePicker dateCreate2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chk;
    }
}