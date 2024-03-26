namespace Lab4Web.Services.Linq
{
    public static class StudentList
    {
        public static List<Student> GetStudents()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "John", Age = 18, GradeAvg = 70, Country = "USA" },
                new Student { Id = 2, Name = "Jane", Age = 19, GradeAvg = 95, Country = "Canada" },
                new Student { Id = 3, Name = "Gelucu", Age = 20, GradeAvg = 92, Country = "Romania" },
                new Student { Id = 4, Name = "Elvis", Age = 21, GradeAvg = 89, Country = "USA" },
                new Student { Id = 5, Name = "Mary", Age = 22, GradeAvg = 92, Country = "USA" },
                new Student { Id = 6, Name = "Peter", Age = 23, GradeAvg = 93, Country = "Australia" },
                new Student { Id = 7, Name = "Paul", Age = 24, GradeAvg = 94, Country = "France" },
                new Student { Id = 8, Name = "David", Age = 25, GradeAvg = 66, Country = "USA" },
                new Student { Id = 9, Name = "Gheorghita", Age = 26, GradeAvg = 97, Country = "Romania" },
                new Student { Id = 10, Name = "Lucy", Age = 27, GradeAvg = 98, Country = "USA" },
                new Student { Id = 11, Name = "Lucas", Age = 27, GradeAvg = 99, Country = "USA" },
                new Student { Id = 12, Name = "Bobby", Age = 27, GradeAvg = 99, Country = "USA" }

            };
            return students;
        }
    }
}
