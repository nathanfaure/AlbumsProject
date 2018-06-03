using AlbumsProject.BLL.Entities.Identity;
using AlbumsProject.Services.Contracts;
using AlbumsProject.ViewModels;
using AlbumsProject.Web.Controllers;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace AipBlog.Web.Controllers
{
    public class CommentController : BaseController
    {
        private readonly ICommentService _commentService;
        private readonly UserManager<User> _userManager;
        public CommentController(ICommentService commentService, UserManager<User> userManager)
        {
            _commentService = commentService;
            _userManager = userManager;
        }
        public JsonResult AddComment(AddCommentVm addCommentVm)
        {
            var user = _userManager.GetUserAsync(HttpContext.User).Result;
            addCommentVm.AuthorId = user.Id;
            _commentService.AddComment(addCommentVm);
            return Json(new { success = true });
        }
    }
}