using Assignment_EF_2.Contexts;
using Assignment_EF_2.Entities;

namespace Assignment_EF_2
{
    internal class Program
    {
        // CRUD operation for Student
        static void CreateStudent(string fname, string lname, string address, int age)
        {
            using ITIDbContext context = new ITIDbContext();
            Student student = new Student
            {
                FName = fname,
                LName = lname,
                Address = address,
                Age = age,
            };
            context.Students.Add(student);
            context.SaveChanges();
        }

        static void UpdateStudent(int id, string newAddress)
        {
            using ITIDbContext context = new ITIDbContext();
            Student student = context.Students.Find(id);
            if (student != null)
            {
                student.Address = newAddress;
                context.SaveChanges();
            }
        }

        static void DeleteStudent(int id)
        {
            using ITIDbContext context = new ITIDbContext();
            Student student = context.Students.Find(id);
            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }
        }

        // CRUD operations for Topic
        static void CreateTopic(string name)
        {
            using ITIDbContext context = new ITIDbContext();
            Topic topic = new Topic
            {
                Name = name
            };
            context.Topic.Add(topic);
            context.SaveChanges();
        }

        static void UpdateTopic(int id, string newName)
        {
            using ITIDbContext context = new ITIDbContext();
            Topic topic = context.Topic.Find(id);
            if (topic != null)
            {
                topic.Name = newName;
                context.SaveChanges();
            }
        }

        static void DeleteTopic(int id)
        {
            using ITIDbContext context = new ITIDbContext();
            Topic topic = context.Topic.Find(id);
            if (topic != null)
            {
                context.Topic.Remove(topic);
                context.SaveChanges();
            }
        }

        // CRUD operations for Instructor
        static void CreateInstructor(string name, double bonus, double salary, string address, double hourRate)
        {
            using ITIDbContext context = new ITIDbContext();
            Instructor instructor = new Instructor
            {
                Name = name,
                Bonus = bonus,
                Salary = salary,
                Address = address,
                HourRate = hourRate,
            };
            context.Instructors.Add(instructor);
            context.SaveChanges();
        }

        static void UpdateInstructor(int id, double newSalary)
        {
            using ITIDbContext context = new ITIDbContext();
            Instructor instructor = context.Instructors.Find(id);
            if (instructor != null)
            {
                instructor.Salary = newSalary;
                context.SaveChanges();
            }
        }

        static void DeleteInstructor(int id)
        {
            using ITIDbContext context = new ITIDbContext();
            Instructor instructor = context.Instructors.Find(id);
            if (instructor != null)
            {
                context.Instructors.Remove(instructor);
                context.SaveChanges();
            }
        }

        // CRUD operations for Department
        static void CreateDepartment(string name)
        {
            using ITIDbContext context = new ITIDbContext();
            Department department = new Department
            {
                Name = name,
                HiringDate = DateTime.Now
            };
            context.Departments.Add(department);
            context.SaveChanges();
        }

        static void UpdateDepartment(int id, string newName)
        {
            using ITIDbContext context = new ITIDbContext();
            Department department = context.Departments.Find(id);
            if (department != null)
            {
                department.Name = newName;
                context.SaveChanges();
            }
        }

        static void DeleteDepartment(int id)
        {
            using ITIDbContext context = new ITIDbContext();
            Department department = context.Departments.Find(id);
            if (department != null)
            {
                context.Departments.Remove(department);
                context.SaveChanges();
            }
        }

        // CRUD operations for Course
        static void CreateCourse(string name, string description, int duration, int topicId)
        {
            using ITIDbContext context = new ITIDbContext();
            Course course = new Course
            {
                Name = name,
                Description = description,
                Duration = duration,
                Top_ID = topicId
            };
            context.Courses.Add(course);
            context.SaveChanges();
        }

        static void UpdateCourse(int id, string newDescription)
        {
            using ITIDbContext context = new ITIDbContext();
            Course course = context.Courses.Find(id);
            if (course != null)
            {
                course.Description = newDescription;
                context.SaveChanges();
            }
        }

        static void DeleteCourse(int id)
        {
            using ITIDbContext context = new ITIDbContext();
            Course course = context.Courses.Find(id);
            if (course != null)
            {
                context.Courses.Remove(course);
                context.SaveChanges();
            }
        }
        static void Main(string[] args)
        {
            
            CreateStudent("John", "Doe", "123 Main St", 20);
            UpdateStudent(1, "789 Oak St"); 
            DeleteStudent(1);

            CreateTopic("Computer Science");
            UpdateTopic(1, "Advanced Computer Science");
            DeleteTopic(1);


            CreateInstructor("Jane Smith", 5000, 60000, "456 Elm St", 30);
            UpdateInstructor(1, 65000); 
            DeleteInstructor(1);

            CreateDepartment("Engineering");
            UpdateDepartment(1, "Applied Sciences");
            DeleteDepartment(1);

            CreateCourse("Data Structures", "Introduction to Data Structures", 40, 1);
            UpdateCourse(1, "Introduction to Advanced Data Structures");
            DeleteCourse(1); 

        }
    }
}
