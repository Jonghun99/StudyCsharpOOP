using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingInterfaceTestApp
{
    class FileLogger : ILogger
    {
        private StreamWriter writer;
        private DateTime now;

        public FileLogger(string path)
        {
            writer = File.CreateText(path); // 파일을 만드는 작업
            writer.AutoFlush = true;
        }

        public FileLogger(DateTime now)
        {
            this.now = now;
        }

        public void WriteLog(string message)
        {
            writer.WriteLine($"FileLog {DateTime.Now}\t>>>>> {message}");
        }
    }
}
