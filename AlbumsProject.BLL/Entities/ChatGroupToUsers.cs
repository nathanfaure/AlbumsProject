using AlbumsProject.BLL.Entities.Identity;

namespace AlbumsProject.BLL.Entities
{
    public class ChatGroupToUsers
    {
        public ChatGroup ChatGroup { get; set; }
        public int ChatGroupId { get; set; }

        public User User { get; set; }
        public int UserId { get; set; }
    }
}
