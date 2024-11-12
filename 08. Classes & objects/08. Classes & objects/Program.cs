using System;

class Student
{
    int studentId;
    string name;
    int age;

    // constructor
    public Student(int studentId, string name, int age)
    {
        // here this keyword refers to th Student class
        this.studentId = studentId;
        this.name = name;
        this.age = age;
    }

    public int getStudentId() { return studentId; }
    public string getName() { return name; }
    public int getAge() { return age; }

    //here we use public access modifiers which means these methods can accessible for all classes
    

    // differes access modifiers are
    // public      - is accessible for all classes
    // private     - only accessible within this class
    // protected   - only accessible within this class and where this class is inherited
    // internal    - only accessible within its own assembly

}

namespace _08._Classes___objects
{
    
    internal class Program
    {
        int id = 5;
        string str = "hlo program class";
        static void Main(string[] args)
        {
            // Classes & objects
            Console.WriteLine("Classes & objects : ");
            

            Program p = new Program();
            // here p is the object of class Program


            Console.WriteLine("id : " + p.id);
            Console.WriteLine("str : "+ p.str);

            Student student_1 = new Student(1, "name1", 20);
            // student_1 is object of class Student

            Console.WriteLine("\nstudent_1 :");
            Console.WriteLine("studentId : " + student_1.getStudentId());
            Console.WriteLine("name : " + student_1.getName());
            Console.WriteLine("age : " + student_1.getAge());

        }
    }
}
