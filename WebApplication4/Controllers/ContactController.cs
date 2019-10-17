using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using WebApplication4.Models;
using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    public class ContactController : ApiController
    {    
        // GET: Contact
        [HttpGet]
        [Route("contacts")]
        public IHttpActionResult Index()
        {               
            return Ok(DataContainer.contacts.ToList());
        }
        [Route("contacts/{id}")]
        [HttpGet]
        public IHttpActionResult GetById(int id)
        {
            return Ok(DataContainer.contacts.Where(a => a.Id == id).FirstOrDefault());
        }

        [HttpPost]
        [Route("contacts")]
        public IHttpActionResult Save(ContactInfo contact)
        {
            DataContainer.contacts.Add(contact);
            return Ok(DataContainer.contacts);

        }
        [HttpDelete]
        [Route("contacts/{id}")]
        public IHttpActionResult Delete(int id)
        {
            DataContainer.contacts.Remove(DataContainer.contacts.Find(x => x.Id == id));
            return Ok(DataContainer.contacts);
        }
        [HttpPut]
        [Route("contacts/{id}")]
        public IHttpActionResult update([FromBody]ContactInfo contact,[FromUri]int id)
        {
            DataContainer.contacts.Find(x => x.Id == id);          
            var obj=DataContainer.contacts.Where(x=>x.Id==id).FirstOrDefault();
            var index = DataContainer.contacts.IndexOf(obj);
            if (index != -1)
                DataContainer.contacts[index] = contact;
            return Ok(DataContainer.contacts);
        }
    }
   
   

}