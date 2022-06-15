using System;

namespace hw16june
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student
            {
                FullName = "Xeyal",
                GroupNo = "P227",

            };


            Student student2 = new Student
            {
                FullName = "Memmed",
                GroupNo = "P228",

            };

            Student student3 = new Student
            {
                FullName = "Hesen",
                GroupNo = "P229",

            };

            Student.CheckGroupNo(student1.GroupNo);
            Console.WriteLine("Total Students:" + Student.TotalCount);

        }
    }
}
