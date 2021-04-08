using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace SchoolEMS.Helpers
{
    public class Helper
    {
        public string FileStores(string imagePath, HttpPostedFileBase image)
        {
            string imageName = Guid.NewGuid() + Path.GetFileName(image.FileName);
            string fullPath = Path.Combine(imagePath, imageName);
            image.SaveAs(fullPath);
            return imageName;
        }
    }
}