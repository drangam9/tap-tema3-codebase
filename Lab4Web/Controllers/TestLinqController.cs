using Lab4Web.Services.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Lab4Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestLinqController : ControllerBase
    {
        private readonly ILinqService _linqService;

        public TestLinqController(ILinqService linqService)
        {
            _linqService = linqService;
        }

        [HttpGet("where-clause")]
        public List<Student> Get(int grade)
        {
            return _linqService.GetByGrade(grade);
        }
        [HttpGet("select-clause")]
        public List<string> Get()
        {
            return _linqService.GetCountries();
        }
        [HttpGet("get-total-students")]
        public int GetTotalStudents()
        {
            return _linqService.GetTotalStudents();
        }
        [HttpGet("where-join-group-methods")]
        public IEnumerable<object> GroupTopStudentsByCountryCapital()
        {
            var students = StudentList.GetStudents();
            var countries = new List<Country>
            {
                new Country { Capital = "Washington", Name = "USA" },
                new Country { Capital = "Ottawa", Name = "Canada" },
                new Country { Capital = "Bucharest", Name = "Romania" },
                new Country { Capital = "Sydney", Name = "Australia" },
                new Country { Capital = "Paris", Name = "France" }
            };
            // Groups students with grade average greater than 90 by the capital of the country they are from
            var result = students
                            .Where(s => s.GradeAvg > 90)
                            .Join(countries,
                                  s => s.Country,
                                  c => c.Name,
                                  (s, c) => new
                                  {
                                      s.Name,
                                      City = c.Capital
                                  })
                            .GroupBy(obj => obj.City);
            return result.ToList();

        }
    }
}
