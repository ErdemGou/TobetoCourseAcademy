using Bussiness.Concretes;
using Entities.Concretes;

internal class Program
{
    private static void Main(string[] args)
    {
        Category category1 = new Category {Id = 1, Name = "Programlama" };

        Course course1 = new Course { Id = 1, CategoryId = 1,Name = "Java", Description = "Programlama dili", Price = 600, ImageUrl = "image.png"};

        Instructor instructor1 = new Instructor {Id = 1, FirstName="Erdem", LastName = "Köstek" };

        CourseInstructor courseInstructor = new CourseInstructor { Id = 1, CourseId = 1, InstructorId = 1 };

        // LIST
        List<Course> courses = new List<Course>
        {
            new Course { Id = 2, CategoryId = 1,Name = "Java", Description = "Programlama dili", Price = 600, ImageUrl = "image.png"},
            new Course { Id = 3, CategoryId = 1,Name = "C#", Description = "Programlama dili", Price = 700, ImageUrl = "image.png"}
        };

        CourseManager courseManager2 = new CourseManager();
        foreach (var item in courses)
        {
            courseManager2.Add(item);
        }



        Console.WriteLine("------------------------------------------------------");

        CourseInstructorManager courseInstructorManager = new CourseInstructorManager();
        courseInstructorManager.Add(courseInstructor);

        //CourseManager courseManager = new CourseManager();
        //courseManager.Add(course1);

        //Console.WriteLine("-----");
        //InstructorManager instructorManager = new InstructorManager();
        //instructorManager.Add(instructor1);

        //Console.WriteLine("-----");
        //CategoryManager categoryManager = new CategoryManager();
        //categoryManager.Add(category1);
    }
}