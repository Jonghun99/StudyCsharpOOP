using System;
using System.IO;

namespace FileReadingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullPath = @"C:\Test\Help\PFRO.log";
            StreamReader sr = new StreamReader(new FileStream(fullPath, FileMode.Open));

            while(sr.EndOfStream == false)
            {
                Console.WriteLine(sr.ReadLine());
            }
            sr.Close(); // 필수
            // 텍스트파일 읽어오는 부분


            string writePath = @"C:\Test\Help\LJH.txt";
            StreamWriter sw = new StreamWriter(new FileStream(writePath, FileMode.Create));

            sw.Write("Hello, World!");
            sw.Write("안녕하세요");
            sw.Write(12345);
            sw.Close(); // 필수

            Console.WriteLine("텍스트파일 작성완료!");
        }
    }
}
