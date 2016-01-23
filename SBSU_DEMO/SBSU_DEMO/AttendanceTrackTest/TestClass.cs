using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SBSU_DEMO.classes;
using SBSU_DEMO;

namespace AttendanceTrackTest
{
    [TestClass]
    public class TestClass
    {
        [TestMethod]
        public void TestMethodGetLecturerCourses()
        {

            Course_Catalog catalog = new Course_Catalog();
            int Lecturer_id = 1;

            var courses = catalog.getLecturerCourses(1);

            foreach (var course in courses)
            {
                Assert.AreEqual(Lecturer_id, course.CourseLecturer.LecturerId);
            }
        }

        [TestMethod]
        public void TestMethodGetCourseAttendances()
        {

            CourseAttendance_Catalog catalog = new CourseAttendance_Catalog();
            int CourseId = 2;

            var AttendanceLists = catalog.getCourseAttendances(CourseId);

            foreach (var AttendanceList in AttendanceLists)
            {
                Assert.AreEqual(CourseId, AttendanceList.RelatedCourse.CourseId);
            }
        }
    }
}
