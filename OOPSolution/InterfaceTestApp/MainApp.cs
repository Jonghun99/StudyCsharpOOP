using System;

namespace InterfaceTestApp
{
    class MainApp
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("콘솔로거 사용합니다.");

            ILogger logger = new ConsoleLogger();
            logger.WriteLog("기본 콘솔 로그입니다.");
            logger.WriteError("에러 메세지!!!");

            ILogger clmLogger = new FileLogger(); // ver 1.0 ClimateLogger -> 1.2 FileLogger로 변경
            clmLogger.WriteLog("맑음");
            clmLogger.WriteError("에러 메세지!!!");

            ILogger logger2 = new ClimateLogger();
            logger2.WriteLog("흐림//");
            //logger2.WriteError("");
        }
    }
}
