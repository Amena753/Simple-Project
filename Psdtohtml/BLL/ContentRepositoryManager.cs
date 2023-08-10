using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Psdtohtml.Models;
using Psdtohtml.DAL;
namespace Psdtohtml.BLL
{
    public class ContentRepositoryManager
    {
        ContentRepository studentGateway = new ContentRepository();
        public IEnumerable<ContentViewModel>GetAllImages()
        {
            return studentGateway.GetAllimage(); 
        }

    }
}