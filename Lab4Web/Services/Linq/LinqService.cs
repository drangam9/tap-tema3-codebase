namespace Lab4Web.Services.Linq
{
    public class LinqService : ILinqService
    {

        public List<Student> GetByGrade(int grade)
        {
            var students = StudentList.GetStudents();
            var result = from student in students
                         where student.GradeAvg > grade
                         select student;
            return result.ToList();
        }

        public List<string> GetCountries()
        {
            var students = StudentList.GetStudents();
            var result = from student in students
                         select student.Country;
            return result.ToList();
        }
        public int GetTotalStudents()
        {
            var students = StudentList.GetStudents();
            return students.Count;
        }
    }
}
