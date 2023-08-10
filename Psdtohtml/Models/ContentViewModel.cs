using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
namespace Psdtohtml.Models
{
    public class ContentViewModel
    {
        public int Id { get; set; }
        public int GenreId { get; set; }
        public byte[] AlbumArtUrl { get; set; }
         [Required]
        public string Name { get; set; }
         [Required]
        public decimal Price { get; set; }
               
    }
}