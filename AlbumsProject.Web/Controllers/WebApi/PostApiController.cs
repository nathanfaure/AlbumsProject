using System.Collections.Generic;
using AlbumsProject.Services.Contracts;
using AlbumsProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace AlbumsProject.Web.Controllers.WebApi
{
    [Produces("application/json")]
    [Route("api/PostApi/")]
    public class PostApiController : Controller
    {
        private readonly IPostService _postService;
        public PostApiController(IPostService postService)
        {
            _postService = postService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<PostVm> postVm = _postService.GetPosts();
            return Json(postVm);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            PostVm postVm = _postService.GetPost(x => x.Id == id);
            return Json(postVm);
        }

    }
}