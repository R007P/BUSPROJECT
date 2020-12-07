using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusRes.Models;

namespace BusRes.Controllers
{
    public class CancellationController : ApiController
    {
        dbNewBusEntities1 db = new dbNewBusEntities1();
        //Get
        [Route("Cancellation")]

        public HttpResponseMessage Get()
        {
            var cancel = db.tblCancellations.ToList();
            if (cancel.Count > 0)
            {
                return Request.CreateResponse(HttpStatusCode.OK, cancel);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "No data found");
            }
        }
        public void Post([FromUri] string PaymentId,string BookingId,float Refund)
        {
            tblCancellation cancellation = new tblCancellation();
            cancellation.PaymentId = PaymentId;
            cancellation.BookingId = BookingId;
            cancellation.Refund = Refund;
            db.tblCancellations.Add(cancellation);
            db.SaveChanges();
        }
    }
}
