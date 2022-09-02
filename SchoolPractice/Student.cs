using System;

// Start working here with your Student class.
// To instantiate the Student class, add your code to the Main method in Program

namespace SchoolPractice
{
    public class Student
    {
        
        public static int nextStudentId = 001;
        public string Name { get; set; }
        public int StudentId { get; set; } = 0; //access private readonly in book example 5.2 but it gives me issues
        public int NumberOfCredits { get; set; } = 0;
        public double Gpa { get; set; } = 0.0;


        public Student(string name, int studentId, int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        //public Student(string name, int studentId) // new prev registered student???
        //{
            //Name = name;
            //StudentId = studentId;
            ////nextStudentId++;
            //NumberOfCredits = 0;
            //Gpa = 0.0;
        //}

        public Student(string name, int studentId)
            : this(name, nextStudentId, 0, 0) { } // exercise review had shorter way of doing things

        public Student(string name) // new student
        {
            Name = name;
            StudentId = nextStudentId;
            nextStudentId++;
            NumberOfCredits = 0;
            Gpa = 0.0;
        }

        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA: " + Gpa + ")";
            // optional: use template literal
        }

        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            Student studentObj = obj as Student;
            return StudentId == studentObj.StudentId;
        }

        public string StudentInfo()
        {
            return (Name + "'s GPA: " + Gpa);
        }


        public void AddGrade(int courseCredits, double grade)
        {
            double totalQualityScore = Gpa * NumberOfCredits;
            totalQualityScore += courseCredits * grade;
            NumberOfCredits += courseCredits;
            Gpa = totalQualityScore / NumberOfCredits;
        }


        public string GetGradeLevel(int courseCredits)
        {
            if (courseCredits <= 29)
            {
                return "Freshman";
            }
            else if (courseCredits <= 59)
            {
                return "Sophomore";
            }
            else if (courseCredits <= 89)
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }
        } // close string
    } // close student class


    //public Student(string name, int studentID): this(name, studentId, 0, 0) { }

    //public Student(string name): this(nameof, nextStudentId)
    //{
        //nextStudentId++;
    //}
   
} // close schoolpractice namespace