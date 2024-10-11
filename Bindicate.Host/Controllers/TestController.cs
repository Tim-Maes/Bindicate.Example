using Bindicate.Project.Services;
using Bindicate.ProjectWithOptions.Services;
using Microsoft.AspNetCore.Mvc;

namespace Bindicate.Host.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IAddNumberService _addNumberService;
        private readonly ICreateStringService _createStringService;
        private readonly IServiceWithOptions _serviceWithOptions;

        public TestController(
        IAddNumberService addNumberService,
        ICreateStringService createStringService,
        IServiceWithOptions serviceWithOptions)
        {
            _addNumberService = addNumberService;
            _createStringService = createStringService;
            _serviceWithOptions = serviceWithOptions;
        }

        [HttpGet("transient-service")]
        public int GetTransientService()
        {
            int result = _addNumberService.AddNumber(5, 5); // = 10

            return result;
        }

        [HttpGet("service-with-options")]
        public string GetOptionsService()
        {
            var stringResult = _createStringService.CombineStrings("this", "that"); // = "this-that"
            var resultFromServiceWithOptions = _serviceWithOptions.CombineOptions(stringResult); // = "this-that_test_9"
            
            return resultFromServiceWithOptions;
        }

        [HttpGet("scoped-service")]
        public string GetScopedService()
        {
            var stringResult = _createStringService.CombineStrings("this", "that"); // = "this-that"

            return stringResult;
        }
    }
}
