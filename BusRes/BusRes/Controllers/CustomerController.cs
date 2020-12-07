using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusRes.Models;

namespace BusRes.Controllers
{
    public class CustomerController : ApiController
    {
        dbNewBusEntities1 db = new dbNewBusEntities1();


        [Route("Getcustomer")]
        public HttpResponseMessage Get()
        {
            var cust = db.tblCustomers.ToList();
            if (cust.Count > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, cust);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "No data found.");
            }
        }

        public void Post([FromUri] string username, string Fname, string Lname, string password, string email, string contact, string address, DateTime dob,string gender,float wallet)
        {
            tblCustomer customer = new tblCustomer();
            customer.username = username;
            customer.Fname = Fname;
            customer.Lname = Lname;
            customer.Password_ = password;
            customer.EmailId = email;
            customer.ContactNo = contact;
            customer.Address = address;
            customer.DOB = dob;
            customer.Gender = gender;
            customer.WalletDetails = wallet;
            db.tblCustomers.Add(customer);
            db.SaveChanges();
        }



        //Get for userprofile
        [Route("GetUserbyUsername")]
        public IHttpActionResult GetUserbyUsername(string username)
        {
            var cust = db.tblCustomers.Where(p => p.username == username).Select(p => new { p.username, p.Fname, p.Lname, p.EmailId, p.ContactNo, p.Address, p.DOB, p.Gender });
            return Ok(cust);
        }


        //update Profile
        [HttpPut]
        [Route("api/UpdateProfile")]
        public void UpdateProfile(string username, [FromBody] tblCustomer customer)
        {
            var customer1 = db.tblCustomers.Find(username);

            customer1.Fname = customer.Fname;
            customer1.Lname = customer.Lname;
            customer1.EmailId = customer.EmailId;
            customer1.ContactNo = customer.ContactNo;
            customer1.Address = customer.Address;
            /*customer1.DOB = customer.DOB;
            customer1.Gender = customer.Gender;*/
            db.Entry(customer1).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        //update wallet
        [HttpPut]
        [Route("api/UpdateWallet")]
        public void UpdateWallet(string username, [FromBody] tblCustomer customer)
        {
            var customer1 = db.tblCustomers.Find(username);

            customer1.WalletDetails = customer.WalletDetails;
            db.Entry(customer1).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }


    }


}

