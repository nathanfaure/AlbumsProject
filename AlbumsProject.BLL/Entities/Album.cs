using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AlbumsProject.BLL.Entities
{
    public class Album
    {
        [Key]
        private int id { get; set; }

        [Required]
        private string title { get; set; }

        [Required]
        private DateTime release_year { get; set; }

        [Required]
        [ForeignKey("Artist")]
        private int artist_id { get; set; }
        private Artist artist { get; set; }

        private ICollection<HasGenre> genres { get; set; }
    }
}
