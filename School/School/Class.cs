namespace School
{
    public class Class
    {
        Course course;
        string name;


        public Class()
        {

        }

        public void createClass( Course course, string name )
        {
            this.name = name;
            this.course = course;
        }


    }
}