using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Loger.Models.Contracts;
using Loger.Models.Enumerations;
using Loger.Models.IOManagement;

namespace Loger.Models
{
  public  class LogFile :IFile
  {
      private IOManager IOManger;

      public LogFile(string folderName,string fileName)
      {
          this.IOManger = new IOManager(folderName,fileName);
          this.IOManger.EnsureDirectoryAndFileExist();
      }

      public string Path => IOManger.CurrentFilePath;
      public long Size => this.GetSize(); 
        public string Write(ILayout layout, IError error)
        {
            string format = layout.Format;
            DateTime dateTime = error.DateTime;
            Level level = error.level;
            string message = error.Message;
            return  
                string.Format(dateTime.ToString("M/dd/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)
                    , message, level.ToString())+Environment.NewLine;
        }

        public long GetSize()
        {
            string text = File.ReadAllText(Path);
            return text
                .Where(ch => Char.IsLetter(ch))
                .Sum(ch=>ch);
        }

  }
}
