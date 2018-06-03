using AlbumsProject.BLL.Entities;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace AlbumsProject.BLL.Entities.Identity
{
    public class User : IdentityUser<int>
    {
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Post> Posts { get; set; }

        public ICollection<ChatGroupToUsers> ChatGroupToUsers { get; set; }
    }
}
