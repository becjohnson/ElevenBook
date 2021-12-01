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
    public class PostController : ApiController
    {
        public IHttpActionResult Get()
        {
            PostService noteService = CreatePostService();
            var notes = noteService.GetPosts();
            return Ok(notes);
        }
        public IHttpActionResult Post(PostCreate note)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var service = CreatePostService();
            if (!service.CreatePost(note))
            {
                return InternalServerError();
            }
            return Ok();
        }
        private PostService CreatePostService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var noteService = new PostService(userId);
            return noteService;
        }
        public IHttpActionResult Get(int id)
        {
            PostService noteService = CreatePostService();
            var note = noteService.GetPostbyId(id);
            return Ok(note);
        }
        public IHttpActionResult Put(PostEdit note)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var service = CreatePostService();
            if (!service.UpdatePosts(note))
            {
                return InternalServerError();
            }
            return Ok();
        }
        public IHttpActionResult Delete(int id)
        {
            var service = CreatePostService();
            if (!service.DeletePost(id))
            {
                return InternalServerError();
            }
            return Ok();
        }
    }
}
