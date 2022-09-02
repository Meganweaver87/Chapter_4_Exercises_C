using System;


namespace SchoolPractice
{
    public class Instructor
    {
        public Instructor(string firstName, string lastName, string subject, int yearsTeaching)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Subject = subject;
            this.YearsTeaching = yearsTeaching;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Subject { get; set; }
        public int YearsTeaching { get; set; }

    }
}

