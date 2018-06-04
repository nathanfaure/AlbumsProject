using AlbumsProject.BLL.Entities.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AlbumsProject.BLL.Entities
{
    public class Comment2
    {
        [Key]
        private int id { get; set; }

        [Required]
        [ForeignKey("User")]
        private int user_id { get; set; }
        private User user { get; set; }

        [Required]
        private Album album { get; set; }

        [Required]
        private string text { get; set; }

        [Required]
        private DateTime date { get; set; }
    }
}
