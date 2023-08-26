using System;

namespace Classes;

public class Student
{
    public static int nextStudentId { get; set; }
    public string Name { set; get; }
    public int StudentId { set; get; }
    public int NumberOfCredits { set; get; }
    public double Gpa { set; get; }


    public Student(string name, int studentId, int numberOfCredits, double gpa)
    {
        Name = name;
        StudentId = studentId;
        NumberOfCredits = numberOfCredits;
        Gpa = gpa;
    }

    public Student(string name, int studentId) : this(name, studentId, 0, 0) { }

    public Student(string name) : this(name, nextStudentId) 
    {
        nextStudentId++;
    }
}