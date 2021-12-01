using ElevenBook.Models;
using ElevenBook.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ElevenBook.Controllers
{
    [Authorize]
    public class ReplyController : ApiController
    {
        private ReplyService CreateReplyService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var replyService = new ReplyService(userId);
            return replyService;
        }

        public IHttpActionResult Get()
        {
            ReplyService replyService = CreateReplyService();
            var reply = replyService.GetReply();
            return Ok(reply);
        }
        public IHttpActionResult Post(ReplyCreate reply)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateReplyService();

            if (!service.CreateReply(reply))
                return InternalServerError();
           
            return Ok();
        }
        public IHttpActionResult Get(int id)
        {
            ReplyService ReplyService = CreateReplyService();
            var reply = ReplyService.GetReplyById(id);
            return Ok(reply);
        }

        public IHttpActionResult Put(ReplyEdit note)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateReplyService();

            if (!service.UpdateReply(note))
                return InternalServerError();

            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            var service = CreateReplyService();

            if (!service.DeleteReply(id))
                return InternalServerError();
            return Ok();
        }

    }
}


