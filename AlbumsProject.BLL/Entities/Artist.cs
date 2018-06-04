using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AlbumsProject.BLL.Entities
{
    public class Artist
    {
        [Key]
        private int id { get; set; }

        [Required]
        private string name { get; set; }

        [Required]
        private string nationality { get; set; }

        [Required]
        private string website { get; set; }

        private ICollection<Album> albums { get; set; }
    }
}
