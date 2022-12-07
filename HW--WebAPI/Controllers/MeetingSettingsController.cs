using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HW__WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingSettingsController : ControllerBase
    {
        MeetingSettings _settings = new MeetingSettings();
        public MeetingSettingsController(IOptions<MeetingSettings> options) 
        {
            _settings = options.Value;
        }
        // GET: api/<MeetingSettings1Controller>
        [HttpGet]
        public MeetingSettings Get()
        {
            return _settings;
        }

        // GET api/<MeetingSettings1Controller>/5
        //[HttpGet("{id}")]
        //public MeetingSettings Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<MeetingSettings1Controller>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MeetingSettings1Controller>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MeetingSettings1Controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
