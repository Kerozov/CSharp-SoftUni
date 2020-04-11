using System;
using System.Collections.Generic;
using System.Text;

namespace Loger.Models.Contracts
{
  public  interface IIOManager
    {
        string CurrnetDirectoryPath { get; }

        string CurrentFilePath { get; }

        string GetCurrentDirectory();

        void EnsureDirectoryAndFileExist();

    }
}
