using System;

namespace InterfaceTestApp
{
    class ClimateLogger : ILogger // ver 1.0에서 개발
    {
        public void WriteError(string error)
        {
            throw new NotImplementedException();
        }

        public void WriteLog(string message)
        {
            Console.WriteLine(value: $"날씨로그 [{DateTime.Now.ToShortDateString()}] : 현재날씨 {message}");
        }
    }
}
