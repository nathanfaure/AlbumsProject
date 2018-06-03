using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AlbumsProject.BLL.Entities
{
    public class ChatGroup
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<ChatGroupToUsers> ChatGroupToUsers { get; set; }
    }
}
