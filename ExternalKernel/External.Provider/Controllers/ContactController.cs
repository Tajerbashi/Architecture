using External.Provider.ContextData;
using External.Provider.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace External.Provider.Controllers
{
    [Route("external/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        // GET: external/<ContactController>
        [HttpGet]
        public IEnumerable<Contact> Get()
        {
            return ApplicationContext.Contacts;
        }

        // GET external/<ContactController>/5
        [HttpGet("{id}")]
        public Contact Get(int id)
        {
            return ApplicationContext.Contacts.Where(x => x.ContactID == id).FirstOrDefault();
        }

        // POST external/<ContactController>
        [HttpPost]
        public void Post()
        {
            ApplicationContext.Contacts.Add(
                new Contact
                {
                    OwnerID = Guid.NewGuid().ToString(),
                    ContactID = new Random().Next(),
                    Family = $"Family {new Random().Next()}",
                    Name = $"Name {new Random().Next()}"
                }
            );
        }

        // PUT external/<ContactController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE external/<ContactController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
