using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Psdtohtml.Models
{
    public partial class GenreProductName
    {
        [Key]
        public int GenreId { get; set; }
        public string Name { get; set; }
        public byte[] AlbumArtUrl { get; set; }
        public string Description { get; set; }
        public List<ContentViewModel> Albums { get; set; }
    }
}