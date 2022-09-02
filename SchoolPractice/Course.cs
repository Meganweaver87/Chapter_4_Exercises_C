using System;
using System.Collections.Generic;


namespace SchoolPractice
{
    public class Course
    {
        public Course(string courseNumber, object Instructor, DateTime meetingTimes, List<Student> studentList)
        {
            this.CourseNumber = courseNumber;
            this.InstructorInfo = Instructor;
            this.MeetingTimes = meetingTimes;
            this.StudentList = studentList;
        }

        public string CourseNumber { get; set; }
        public object InstructorInfo { get; set; }
        public DateTime MeetingTimes { get; set; }
        public List<Student> StudentList { get; set; }
    }
}

