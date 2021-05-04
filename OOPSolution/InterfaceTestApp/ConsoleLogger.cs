using System;
using System.Diagnostics;

namespace InterfaceTestApp
{
    class ConsoleLogger : ILogger // ver 1.0에서 개발
    {
        public void WriteError(string error)
        {
            Debug.WriteLine($"Console error : {error}");
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"로그 {DateTime.Now} : {message}");
        }
    }
}
