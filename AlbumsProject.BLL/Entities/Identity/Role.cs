using Microsoft.AspNetCore.Identity;

namespace AlbumsProject.BLL.Entities.Identity
{
    public class Role : IdentityRole<int>
    {
        public Role() { }

        public Role(string name) : base(name) { }
    }
}
