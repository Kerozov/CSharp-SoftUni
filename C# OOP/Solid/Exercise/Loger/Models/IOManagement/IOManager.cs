using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Loger.Models.Contracts;

namespace Loger.Models.IOManagement
{
    public class IOManager:IIOManager
    {
        private string currnetPath;
        private string folderName;
        private string fileName;

        private IOManager()
        {
            currnetPath = this.GetCurrentDirectory();
        }
        public IOManager(string folderName,string fileName)
            :this()
        {
            this.folderName = folderName; 
            this.fileName = fileName;
        }

        public string CurrnetDirectoryPath => this.currnetPath + this.folderName;
        public string CurrentFilePath => this.CurrnetDirectoryPath + this.fileName;
        public string GetCurrentDirectory()
        {
            string currDir = Directory.GetCurrentDirectory();
            return currDir;
        }

        public void EnsureDirectoryAndFileExist()
        {
            if (!Directory.Exists(this.CurrnetDirectoryPath))
            {
                Directory.CreateDirectory(this.CurrnetDirectoryPath);
            }

            File.WriteAllText(this.CurrentFilePath, string.Empty);
        }
    }
}
