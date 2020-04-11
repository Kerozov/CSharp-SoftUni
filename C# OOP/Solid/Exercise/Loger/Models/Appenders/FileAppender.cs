using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Loger.Models.Contracts;
using Loger.Models.Enumerations;

namespace Loger.Models.Appenders
{
  public  class  FileAppender:IApender
    {
        public FileAppender(ILayout layout, Level level,IFile file)
        {
            this.Layout = layout;
            this.Level = level;
            this.File = file;
        }
        public ILayout Layout { get; private set; }
        public Level Level { get; private set; }
        public long MessagesAppend { get; private set; }
        public IFile File { get; private set; }
        public void Append(IError error)
        {
            string formattedMessage = this.File.Write(this.Layout, error);
            System.IO.File.AppendAllText(this.File.Path, formattedMessage);
            MessagesAppend++;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb
                .AppendLine($"Appender type: {this.GetType().Name}, Layout type: {this.Layout.GetType().Name}, Report level: {this.Level.ToString().ToUpper()}, Messages appended: {MessagesAppend}, File size{this.File.Size}");
            return sb.ToString().TrimEnd();
        }
    }
}
