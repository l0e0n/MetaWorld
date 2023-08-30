using System;
namespace School
{
    public class Student
    {
        String name;
        int nID;
        int ID = 0; //as count
        int level;
        String DoB;
        String homeTown;
        int grade; 
        Course courses = new Course[5];
        int numberOfCourses=0;

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
            ID = ++ID;
        }

        public addCourse(String name)
        {
            //Search ,, show list
            

            //input course name 

            // check if #c < 5 >> ok

            // assign course 





        }


    }
}

// Person : Student >> inheret