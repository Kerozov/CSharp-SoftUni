using System;
using System.IO;

namespace _04_CopyBinaryFile
{
    class Program
    {
        static void Main(string[] args)
        {
          using  var reader = new FileStream(@".\copyMe.png",FileMode.Open);
         using   var writter = new FileStream(@"..\..\..\copied.png",FileMode.Create);
            var buffer = new byte[1024];
            while (reader.CanRead)
            {
               var bayts =  reader.Read(buffer, 0, buffer.Length);
               if (bayts==0)
               {
                   break;
               }
                writter.Write(buffer,0,buffer.Length);
            }
        }
    }
}
