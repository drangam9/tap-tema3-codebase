using Lab4Web.Services.Lambda;
using Microsoft.AspNetCore.Mvc;

namespace Lab4Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestLambdaController : ControllerBase
    {
        private readonly ILambdaService _lambdaService;

        public TestLambdaController(ILambdaService lambdaService)
        {
            _lambdaService = lambdaService;
        }

        [HttpGet("exercise-1")]
        public string Get(string name, int age)
        {
            var result = "i) " + _lambdaService.NoParameter();
            result += "\n ii) Your first name is " + _lambdaService.OneParameter(name);
            result += "\n iii) " + _lambdaService.TwoParameters(name, age);
            result += "\n iv) What's the answer to life, the universe, and everything? " + _lambdaService.UnusedParameters(1, 2);
            result += "\n v) " + _lambdaService.DefaultParameters(name) +
                      "\n " + _lambdaService.DefaultParameters();
            return result;
        }
        [HttpGet("exercise-1-tuple-parameter")]
        public int Get(int digit1, int digit2, int digit3)
        {
            var value = new Tuple<int, int, int>(digit1, digit2, digit3);
            return _lambdaService.TupleParameter(value);
        }
        [HttpGet("exercise-2")]
        public string Get(int SecondsToWait)
        {
            async Task<string> asyncLambda()
            {
                await Task.Delay(SecondsToWait * 1000);
                return $"Async action completed successfully in {SecondsToWait} seconds. ";
            }

            return asyncLambda().Result;
        }
    }
}
