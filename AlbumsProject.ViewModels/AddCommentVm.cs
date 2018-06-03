using System.ComponentModel.DataAnnotations;

namespace AlbumsProject.ViewModels
{
    public class AddCommentVm
    {
        [Required]
        public int PostId { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public int AuthorId { get; set; }


    }
}
