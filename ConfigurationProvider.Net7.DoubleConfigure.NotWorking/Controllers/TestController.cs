using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace ConfigurationProvider.Net7.DoubleConfigure.NotWorking
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly IOptionsMonitor<TestOptions> _options;

        public TestController(IOptionsMonitor<TestOptions> options)
        {
            _options = options;
        }

        [HttpGet]
        public IDictionary<string, IDictionary<string, string[]>> Get()
        {
            return _options.CurrentValue.Connections;
        }
    }
}