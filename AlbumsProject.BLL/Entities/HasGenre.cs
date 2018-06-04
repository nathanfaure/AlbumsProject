using System;
using System.Collections.Generic;
using System.Text;

namespace AlbumsProject.BLL.Entities
{
    public class HasGenre
    {
        private int id_album { get; set; }
        private Album album { get; set; }

        private int id_genre { get; set; }
        private Genre genre { get; set; }
    }
}
