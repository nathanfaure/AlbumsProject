using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AlbumsProject.ViewModels
{
    public class AddPostVm
    {
        public DateTime Date { get; set; }

        [Required]
        public string Title { set; get; }
        [Required]
        public string Content { get; set; }
        [Required]
        public int AuthorId { get; set; }
    }
}
