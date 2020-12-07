using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusRes.Models;

namespace BusRes.Controllers
{
    public class UnauthcustomerController : ApiController
    {
        dbNewBusEntities1 db = new dbNewBusEntities1();
        // GET: Unauthorizedcustomer

        //GET
        [Route("unauthcustomer")]

        public HttpResponseMessage Get()
        {
            var uacust = db.tblUnAuthCustomers.ToList();
            if (uacust.Count > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, uacust);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "No data found.");
            }
        }

        public void Post([FromUri] string Fname, string Lname, string EmailId, string PhoneNo)
        {
            tblUnAuthCustomer unAuthCustomer = new tblUnAuthCustomer();
            unAuthCustomer.Fname = Fname;
            unAuthCustomer.Lname = Lname;
            unAuthCustomer.EmailId = EmailId;
            unAuthCustomer.PhoneNo = PhoneNo;
            db.tblUnAuthCustomers.Add(unAuthCustomer);
            db.SaveChanges();
        }
    }
}

