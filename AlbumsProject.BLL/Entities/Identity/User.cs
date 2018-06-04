using AlbumsProject.BLL.Entities;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace AlbumsProject.BLL.Entities.Identity
{
    public class User : IdentityUser<int>
    {
        private string email { get; set; }

        private string first_name { get; set; }

        private string last_name { get; set; }

        private Role role { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<Post> Posts { get; set; }

        public ICollection<ChatGroupToUsers> ChatGroupToUsers { get; set; }
    }
}
