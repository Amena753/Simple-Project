using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Psdtohtml.Models;
using Psdtohtml.BLL;
namespace Psdtohtml.Controllers
{
    public class StoreProductController : Controller
    {
        ContentViewModel db = new ContentViewModel();
        ContentRepositoryManager studentManager = new ContentRepositoryManager();
        // GET: /StoreProduct/
        [HttpGet]
        public ActionResult Index()
        {
           
            List<ContentViewModel> students = studentManager.GetAllImages().ToList();
            
            return View(students);
        }
        //
        // GET: /Store/Browse
        public ActionResult Browse(string genre)
        {
            var genreModel = new GenreProductName { Name = genre };
            return View(genreModel);
        }
        //
        // GET: /Store/Details
        //public ActionResult ProductDetails(int id)
        //{
        //    var album = new ContentViewModel { Title = "Album " + id };
        //    return View(album);
        //}
        //public ActionResult RetrieveImage()
        //{
        //    byte[] cover = GetImageFromDataBase();
        //    if (cover != null)
        //    {
        //        return File(cover, "image/jpg");
        //    }
        //    else
        //    {
        //        return null;
        //    }
        //}
        //public byte[] GetImageFromDataBase()
        //{
        //    //var q = from temp in db.ContentType where temp.Id == id select temp.AlbumArtUrl;
        //    var q = studentManager.GetAllImages.Where(x => x.ContentType == "image/jpeg").ToList();
        //    return q.ToList();
        //}
       
	}
}