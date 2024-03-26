using Lab4Web.Services.Delegate;
using Microsoft.AspNetCore.Mvc;

namespace Lab4Web.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class TestDelegateController : ControllerBase
    {
        private readonly IDelegateService _delegateService;

        public TestDelegateController(IDelegateService delegateService)
        {
            _delegateService = delegateService;
        }

        [HttpGet("exercise-1")]
        public string Exercise1(string firstName, string lastName)
        {

            return _delegateService.Introduction(firstName, lastName, (firstName, lastName) => $"First Name: {firstName}\n Last Name: {lastName} \nYour full name has a total of {firstName.Length + lastName.Length} letters  ");
        }
        [HttpGet("exercise-2")]
        public string Exercise2(string firstName, string lastName, bool bye)
        {

            var callback = _delegateService.Hello;
            if (bye)
            {
                callback = _delegateService.Goodbye;
            }


            return _delegateService.Introduction(firstName, lastName, callback);
        }

    }
}
