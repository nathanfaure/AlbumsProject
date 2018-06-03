using System;
using System.Collections.Generic;
using AlbumsProject.BLL.Entities.Identity;
using AlbumsProject.Services.Contracts;
using AlbumsProject.ViewModels;
using AlbumsProject.Web.Controllers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AipBlog.Web.Controllers
{
    [Authorize]
    public class PostController : BaseController
    {
        private readonly IPostService _postService;
        private readonly UserManager<User> _userManager;
        public PostController(IPostService postService, UserManager<User> userManager)
        {
            _userManager = userManager;
            _postService = postService;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            IEnumerable<PostVm> postVm = _postService.GetPosts();
            if (HttpContext.Request.Headers["x-requested-with"] == "XMLHttpRequest")
                return PartialView(postVm);
            else
                return View(postVm);
        }

        public IActionResult AddPost()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPost(AddPostVm postVm)
        {
            var user = _userManager.GetUserAsync(HttpContext.User).Result;
            postVm.AuthorId = user.Id;
            postVm.Date = DateTime.Now;
            if (ModelState.IsValid)
            {
                _postService.AddOrUpdatePost(postVm);
                return RedirectToAction("Index");
            }
            else
                return View(ModelState);
        }

        public IActionResult EditPost(int id)
        {
            PostVm postVm = _postService.GetPost(x => x.Id == id);
            return View(postVm);
        }

        [HttpPost]
        public IActionResult EditPost(AddPostVm postVm)
        {
            if (ModelState.IsValid)
            {
                _postService.AddOrUpdatePost(postVm);
                return RedirectToAction("Index");
            }
            else
                return View(ModelState);
        }
    }
}
