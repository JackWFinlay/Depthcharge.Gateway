using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Depthcharge.Gateway.Controllers
{
    [Route("api/[controller]")]
    public class QueueController : Controller
    {
        private readonly IServiceSettings _serviceSettings;
        private readonly IHttpHelper _httpHelper;

        public QueueController(IServiceSettings serviceSettings, IHttpHelper httpHelper)
        {
            _serviceSettings = serviceSettings;
            _httpHelper = httpHelper;
        }

        // GET api/values
        [HttpGet]
        public async Task<string> Get()
        {
            return await _httpHelper.GetContentForUrlAsync(new Uri(_serviceSettings.QueueManagerUrl));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        
    }
}
