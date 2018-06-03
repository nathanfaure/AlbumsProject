using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AlbumsProject.ViewModels
{
    public class UsersGroupsVm
    {
        public IEnumerable<SelectListItem> Groups { get; set; }

        public IEnumerable<SelectListItem> Users { get; set; }
    }
}
