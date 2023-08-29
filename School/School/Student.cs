using System;
namespace School
{
    public class Student
    {
        String name;
        int ID;
        int level;
        String DoB;
        String homeTown;
        int grade; 
        Course courses = new Course[5];

        public Student ()
        {
        }

        public void register(String n, int id, int l, String dob, String ht)
        {
            name = n;
            ID = id;
            level = l;
            DoB = dob;
            homeTown = ht;
        }

        public addCourse(String name)
        {

        }
    }
}

// Person : Student >> inheret