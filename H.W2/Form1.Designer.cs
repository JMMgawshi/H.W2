namespace WindowsFormsApplication1
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
            this.dt_leaving = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_start = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.cmb_courses = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_teachers = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_rooms = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dt_date = new System.Windows.Forms.DateTimePicker();
            this.txt_comment = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dt_leaving
            // 
            this.dt_leaving.Location = new System.Drawing.Point(546, 105);
            this.dt_leaving.Name = "dt_leaving";
            this.dt_leaving.Size = new System.Drawing.Size(159, 20);
            this.dt_leaving.TabIndex = 39;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(473, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Leaving time";
            // 
            // dt_start
            // 
            this.dt_start.Location = new System.Drawing.Point(546, 61);
            this.dt_start.Name = "dt_start";
            this.dt_start.Size = new System.Drawing.Size(159, 20);
            this.dt_start.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(486, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Start time";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(615, 198);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(90, 23);
            this.btn_add.TabIndex = 35;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // cmb_courses
            // 
            this.cmb_courses.FormattingEnabled = true;
            this.cmb_courses.Location = new System.Drawing.Point(85, 102);
            this.cmb_courses.Name = "cmb_courses";
            this.cmb_courses.Size = new System.Drawing.Size(121, 21);
            this.cmb_courses.TabIndex = 34;
            this.cmb_courses.SelectionChangeCommitted += new System.EventHandler(this.cmb_courses_SelectionChangeCommitted);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 105);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Courses";
            // 
            // cmb_teachers
            // 
            this.cmb_teachers.FormattingEnabled = true;
            this.cmb_teachers.Location = new System.Drawing.Point(85, 58);
            this.cmb_teachers.Name = "cmb_teachers";
            this.cmb_teachers.Size = new System.Drawing.Size(121, 21);
            this.cmb_teachers.TabIndex = 32;
            this.cmb_teachers.SelectionChangeCommitted += new System.EventHandler(this.cmb_teachers_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Teachers";
            // 
            // cmb_rooms
            // 
            this.cmb_rooms.FormattingEnabled = true;
            this.cmb_rooms.Location = new System.Drawing.Point(85, 17);
            this.cmb_rooms.Name = "cmb_rooms";
            this.cmb_rooms.Size = new System.Drawing.Size(121, 21);
            this.cmb_rooms.TabIndex = 30;
            this.cmb_rooms.SelectionChangeCommitted += new System.EventHandler(this.cmb_rooms_SelectionChangeCommitted);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(24, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(681, 152);
            this.dataGridView1.TabIndex = 29;
            // 
            // dt_date
            // 
            this.dt_date.Location = new System.Drawing.Point(546, 20);
            this.dt_date.Name = "dt_date";
            this.dt_date.Size = new System.Drawing.Size(159, 20);
            this.dt_date.TabIndex = 28;
            // 
            // txt_comment
            // 
            this.txt_comment.Location = new System.Drawing.Point(85, 163);
            this.txt_comment.Name = "txt_comment";
            this.txt_comment.Size = new System.Drawing.Size(620, 20);
            this.txt_comment.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Comment:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Date:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Rooms";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 410);
            this.Controls.Add(this.dt_leaving);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.cmb_courses);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmb_teachers);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmb_rooms);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dt_date);
            this.Controls.Add(this.txt_comment);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_leaving;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cmb_courses;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_teachers;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_rooms;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DateTimePicker dt_date;
        private System.Windows.Forms.TextBox txt_comment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
    }
}

