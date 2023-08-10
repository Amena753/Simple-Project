using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace Psdtohtml.Models
{
    public class ProductAlbum
    {
        [Key]
       public int AlbumId { get; set; }
       public int GenreId { get; set; }
       public int ArtistId { get; set; }
       public string Title { get; set; }
       public decimal Price { get; set; }
       public byte[] AlbumArtUrl { get; set; }
       //public string AlbumArtUrl { get; set; }
       public GenreProductName Genre { get; set; }
       public ProductArtist Artist { get; set; } 
    }
}