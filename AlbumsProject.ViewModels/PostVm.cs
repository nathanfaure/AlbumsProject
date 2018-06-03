using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AlbumsProject.ViewModels
{
    public class PostVm
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public string Title { set; get; }
        [Required]
        public string Content { get; set; }
        [Required]
        public string Author { get; set; }

        public IEnumerable<CommentVm> Comments { get; set; }
    }
}
