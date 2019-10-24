using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace teamA_complex.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var client = new HttpClient();

            var response1 = await client.GetAsync("http://teama-simple/api/values?name=Ernst");
            var response2 = await client.GetAsync("http://teama-simple/api/values?name=Tobias");

            string text1 = await response1.Content.ReadAsStringAsync();
            string text2 = await response2.Content.ReadAsStringAsync();

            return Ok(string.Join("\n", new [] { text1, text2 }));
        }
    }
}
