using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Psdtohtml.Models
{
    public class ProductArtist
    {
        [Key]
        public int ArtistId { get; set; }
        public string Name { get; set; }
    }
}