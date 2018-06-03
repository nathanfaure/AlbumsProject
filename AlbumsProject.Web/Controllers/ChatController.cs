using System;
using System.Collections.Generic;
using System.Linq;
using AlbumsProject.BLL.Entities;
using AlbumsProject.BLL.Entities.Identity;
using AutoMapper;
using DataAccessLayer.Core.Interfaces.UoW;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AlbumsProject.Web.Controllers
{
    [Authorize]
    public class ChatController : BaseController
    {
        private readonly IUnitOfWork _uow;
        public ChatController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IActionResult Index()
        {
            var users = _uow.Repository<User>().GetRange().ToList();
            users.Add(new User()
            {
                UserName ="All"
            });
            var chatGroups = _uow.Repository<ChatGroup>().GetRange().ToList();
            var userVm = Mapper.Map<IEnumerable<SelectListItem>>(users);
            var chatGroupVm = Mapper.Map<IEnumerable<SelectListItem>>(chatGroups);
            return View( new Tuple<IEnumerable<SelectListItem>, IEnumerable<SelectListItem>>(userVm, chatGroupVm));
        }
    }
}