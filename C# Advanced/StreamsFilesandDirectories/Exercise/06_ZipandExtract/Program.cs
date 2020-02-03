using System;
using System.IO.Compression;

namespace _06_ZipandExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string startPath = @"..\..\..\start";
            string zipPath = @"..\..\..\final\soft.zip";
            string extractPath = @"..\..\..\final";

            ZipFile.CreateFromDirectory(startPath, zipPath);

            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }
    }
}
