using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Psdtohtml.Models;
using System.Data;

namespace Psdtohtml.DAL
{
    public class ContentRepository : DBGateway
    {
        //private readonly ProductStoreEntities db = new ProductStoreEntities();
        //public int UploadImageInDataBase(HttpPostedFileBase file, ContentViewModel albums)
        //{
        //    albums.AlbumArtUrl = ConvertToBytes(file);
        //    var Content = new Content
        //    {
        //        Image = albums.AlbumArtUrl,
        //        Name = albums.Name,
        //        Contents = albums.Contents,
        //        Price = albums.Price
        //    };
        //    db.Contents.Add(Content);
        //    //db.Contents.Add(Content);
        //    int i = db.SaveChanges();
        //    if (i == 1)
        //    {
        //        return 1;
        //    }
        //    else
        //    {
        //        return 0;
        //    }

        //}
        public List<ContentViewModel> GetAllimage()
        {
            try
                {
                   List<ContentViewModel> students = new List<ContentViewModel>();
                   CommandObj.CommandText = "GetlistofimagesID";
                   CommandObj.CommandType = CommandType.StoredProcedure;                 
                   ConnectionObj.Open();
                    SqlDataReader reader = CommandObj.ExecuteReader();
                    while (reader.Read())
                    {
                       ContentViewModel student = new ContentViewModel
                        {
                            Id  =(int)reader["AlbumId"],
                            GenreId  = (int)reader["GenreId"],
                            //AlbumArtUrl  =Convert.ToSByte(reader["AlbumArtUrl"].ToString()),
                            AlbumArtUrl = (byte[])reader["AlbumArtUrl"],
                            Name =(string)reader["Name"],
                           
                            Price =(decimal)reader["Price"]
                        };
                        students.Add(student);
                    }

                    //reader.Close();
                    return students;
                }
            catch (Exception exception)
            {
                throw new Exception("Unable to get all images ", exception);
            }
            finally
            {
                CommandObj.Dispose();
                ConnectionObj.Close();
            }
            
        }

        

        

        //private byte[] ConvertToBytes(HttpPostedFileBase image)
        //{
        //    byte[] imageBytes = null;
        //    BinaryReader reader = new BinaryReader(image.InputStream);
        //    imageBytes = reader.ReadBytes((int)image.ContentLength);
        //    return imageBytes;
        //}
    }
}