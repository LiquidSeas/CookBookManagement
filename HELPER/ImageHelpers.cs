using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookBook.HELPER
{
    internal class ImageHelpers
    {   //Convert Image that the user can see to format that can be stored in DB
        public static byte[] CovertToDbImage(string imagePath)
        {
            FileInfo fileInfo = new FileInfo(imagePath);
            long bytes=fileInfo.Length;
            FileStream fileStream = new FileStream(imagePath, FileMode.Open,FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            byte[] convertedImage=binaryReader.ReadBytes((int)bytes);
            return convertedImage;
        }

        //Convert image from DB to format user can see
        public static Image ConvertFromDbImage(byte[] bytes) 
        {
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                Image convertedImage = Image.FromStream(ms);
                return convertedImage;

            }
       
        
        }


    }
}
