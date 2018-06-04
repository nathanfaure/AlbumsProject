using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AlbumsProject.BLL.Entities
{
    public class Genre
    {
        [Key]
        private int id { get; set; }

        [Required]
        private string name {get; set; }
    }
}
