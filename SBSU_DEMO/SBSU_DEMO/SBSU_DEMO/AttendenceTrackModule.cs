using SBSU_DEMO.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Linq;

namespace SBSU_DEMO
{
    public partial class AttendenceTrackModule : Form
    {
        public int LectID;
        public Course_Catalog course_Catalog;
        public CourseAttendance_Catalog courseAtt_Catalog;

        public AttendenceTrackModule(int lecturer_id)
        {
            InitializeComponent();
            button_Rate.Enabled = true;
            LectID = lecturer_id;
            comboBox_Date.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_Lessons.DropDownStyle = ComboBoxStyle.DropDownList;
            course_Catalog = new Course_Catalog();

            //SSD1 ENTER ATTENDANCE MODULE
            var Courses = course_Catalog.getLecturerCourses(lecturer_id);
            fillCombobox(Courses);
        }

        private void chooseCourses(object sender, EventArgs e)
        {
            if(comboBox_Lessons.SelectedIndex!=-1)
                button_Rate.Enabled = true;
            dataGridView1.DataSource = null;
            IList<DateTime> AttDates;
            Course SelectedCourse = (Course)comboBox_Lessons.SelectedItem;
            courseAtt_Catalog = new CourseAttendance_Catalog();

            //SSD2 CHOOSE COURSE
            var AttendanceLists = courseAtt_Catalog.getCourseAttendances(SelectedCourse.CourseId);
            AttDates = AttendanceLists.Select(s => s.AttendanceDate).ToList<DateTime>();

            fillCombobox2(AttDates);
        }

        #region[UI Methods]
        public void FillDataTable(IList<Attendance> AttList)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Student Number", typeof(int));
            table.Columns.Add("Student Name", typeof(string));
            table.Columns.Add("Student Surname", typeof(string));
            table.Columns.Add("Attendance", typeof(bool));

            foreach (Attendance att in AttList.OrderBy(x => x.student.StudentId))
                table.Rows.Add(att.student.StudentId, att.student.Name, att.student.Surname, att.Flag);

            BindingSource dataSource = new BindingSource(table, null);
            dataGridView1.DataSource = dataSource;
        }
        public void FillDataTable2(Dictionary<Student,float> StudentRateList)
        {
            DataTable table = new DataTable();
            table.Columns.Add("Student Number", typeof(int));
            table.Columns.Add("Student Name", typeof(string));
            table.Columns.Add("Student Surname", typeof(string));
            table.Columns.Add("Attendance Rate", typeof(string));

            foreach (var pair in StudentRateList.OrderBy(x => x.Key.StudentId))
                table.Rows.Add(pair.Key.StudentId, pair.Key.Name, pair.Key.Surname, "%" + pair.Value.ToString("0.##"));

            BindingSource dataSource = new BindingSource(table, null);
            dataGridView1.DataSource = dataSource;
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            LecturerMenu menu = new LecturerMenu(LectID);
            menu.Show();
        }
        private void button_Rate_Click(object sender, EventArgs e)
        {
            if (comboBox_Lessons.SelectedIndex == -1)
                MessageBox.Show("Please choose course.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                dataGridView1.DataSource = null;

                Course SelectedCourse = (Course)comboBox_Lessons.SelectedItem;
                var AllAttendanceList = SelectedCourse.AttendanceList.Select(s => s.AttendanceList).ToList();
                var WeekCount = AllAttendanceList.Count;

                Dictionary<Student, int> CountDict = new Dictionary<Student, int>();
                foreach (var Student in SelectedCourse.StudentList)
                {
                    CountDict.Add(Student, 0);
                }

                Dictionary<Student, float> RateDict = new Dictionary<Student, float>();

                foreach (var AttendanceList in AllAttendanceList)
                {
                    foreach (var Attendance in AttendanceList)
                    {
                        var StudentAttendanceCount = CountDict[Attendance.student];
                        if (Attendance.Flag == true)
                            StudentAttendanceCount++;
                        CountDict[Attendance.student] = StudentAttendanceCount;
                    }
                }

                foreach (var StudentAttendace in CountDict)
                {
                    RateDict.Add(StudentAttendace.Key, (float)StudentAttendace.Value / WeekCount * 100);
                }

                FillDataTable2(RateDict);
            }
        }
        private void fillCombobox(IList<Course> Courses)
        {
            comboBox_Lessons.Items.Clear();
            comboBox_Lessons.DisplayMember = "Course.CourseName";
            comboBox_Lessons.ValueMember = "Course.CourseId";
            foreach (var Course in Courses)
            {
                comboBox_Lessons.Items.Add(Course);
            }
        }
        private void fillCombobox2(IList<DateTime> AttDates)
        {
            comboBox_Date.Items.Clear();
            foreach (var date in AttDates)
            {
                comboBox_Date.Items.Add(date);
            }
        }
        private void comboBox_Date_SelectedIndexChanged(object sender, EventArgs e)
        {
            Course SelectedCourse = (Course)comboBox_Lessons.SelectedItem;
            DateTime SelectedDate = (DateTime)comboBox_Date.SelectedItem;
            var attList = StaticSession.session.QueryOver<CourseAttendance>().Where(s => s.RelatedCourse == SelectedCourse && s.AttendanceDate == SelectedDate).SingleOrDefault<CourseAttendance>();
            FillDataTable(attList.AttendanceList);
        }
        private void AttendenceTrackModule_Load(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
