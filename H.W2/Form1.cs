using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Models;
using WindowsFormsApplication1.Helpers;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public AttendanceManagement attendance = new AttendanceManagement();
        BindingList<Attendance> source;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            source = new BindingList<Attendance>(attendance.GetAttendances());
            dataGridView1.DataSource = source;
            ShowTeachers();
            ShowCourses();
            ShowRooms();
        }

        private void ShowTeachers()
        {
            cmb_teachers.DisplayMember = "teachername";
            cmb_teachers.ValueMember = "teacherid";
            cmb_teachers.DataSource = attendance.getAllTeachers();

        }

        private void ShowCourses()
        {
            cmb_courses.DisplayMember = "coursename";
            cmb_courses.ValueMember = "courseid";
            cmb_courses.DataSource = attendance.getAllCourses();

        }

        private void ShowRooms()
        {
            cmb_rooms.DisplayMember = "roomname";
            cmb_rooms.ValueMember = "roomid";
            cmb_rooms.DataSource = attendance.getAllRooms();
        }

        private void cmb_rooms_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string value = "";


            int id = ((Room)((ComboBox)sender).SelectedItem).roomid;

            if (id != 0)
            {
                return;
            }

            if (Prompt.InputBox("New Room", "New Room Name:", ref value) == DialogResult.OK)
            {
                if (value.Trim().Length > 0)
                {
                    attendance.addNewRoom(value.Trim());
                    ShowRooms();
                }
            }
        }

        private void cmb_teachers_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string value = "";


            int id = ((Teacher)((ComboBox)sender).SelectedItem).teacherid;

            if (id != 0)
            {
                return;
            }

            if (Prompt.InputBox("New Teacher", "New Teacher Name:", ref value) == DialogResult.OK)
            {
                if (value.Trim().Length > 0)
                {
                    attendance.addNewTeacher(value.Trim());
                    ShowTeachers();
                }
            }

        }

        private void cmb_courses_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string value = "";


            int id = ((Course)((ComboBox)sender).SelectedItem).courseid;

            if (id != 0)
            {
                return;
            }

            if (Prompt.InputBox("New 'course", "New 'course Name:", ref value) == DialogResult.OK)
            {
                if (value.Trim().Length > 0)
                {
                    attendance.addNewCourse(value.Trim());
                    ShowCourses();
                }
            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            attendance.saveAttendance(
                ((Teacher)cmb_teachers.SelectedItem).teachername.ToString(),
                ((Course)cmb_courses.SelectedItem).coursename.ToString(),
                ((Room)cmb_rooms.SelectedItem).roomname.ToString(),
                dt_date.Text.ToString(),
                dt_start.Text.ToString(),
                dt_leaving.Text.ToString(),
                txt_comment.Text.ToString()
            );

            source = new BindingList<Attendance>(attendance.GetAttendances());
            dataGridView1.DataSource = source;
        }
    }
}
