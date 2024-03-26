namespace Lab4Web.Services.Linq
{
    public interface ILinqService
    {
        List<Student> GetByGrade(int grade);
        List<string> GetCountries();

        int GetTotalStudents();
    }
}
