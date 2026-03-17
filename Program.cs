using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter Course Name: ");
        string cname = Console.ReadLine();

        Console.Write("Enter Course ID: ");
        string cid = Console.ReadLine();

        Course course = new Course(cname, cid);

        while (true)
        {
            Console.WriteLine("\n===== MENU =====");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Show Students");
            Console.WriteLine("3. Show Average Score");
            Console.WriteLine("4. Show Max/Min Score");
            Console.WriteLine("5. Exit");

            Console.Write("Choose: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Student Name: ");
                string name = Console.ReadLine();

                Console.Write("Student ID: ");
                string id = Console.ReadLine();

                Console.Write("Score: ");
                double score = Convert.ToDouble(Console.ReadLine());

                Student s = new Student(name, id, score);
                course.AddStudent(s);

                Console.WriteLine("Student added!");
            }
            else if (choice == "2")
            {
                course.ShowStudents();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Average Score: " + course.AverageScore());
            }
            else if (choice == "4")
            {
                Console.WriteLine("Max Score: " + course.MaxScore());
                Console.WriteLine("Min Score: " + course.MinScore());
            }
            else if (choice == "5")
            {
                Console.WriteLine("Exit Program");
                break;
            }
        }
    }
}