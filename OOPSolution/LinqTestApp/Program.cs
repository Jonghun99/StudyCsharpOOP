using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 1, 2, 3, 4, 5 };
            arr.Sort();

            var profiles = new List<Profile>();
            profiles.Add(new Profile() { Name = "정우성", Height = 186 });
            profiles.Add(new Profile() { Name = "김태희", Height = 158 });
            profiles.Add(new Profile() { Name = "전지현", Height = 171 });
            profiles.Add(new Profile() { Name = "고현정", Height = 172 });
            profiles.Add(new Profile() { Name = "이문세", Height = 178 });
            profiles.Add(new Profile() { Name = "하하", Height = 171 });

            var profiles1 = from item in profiles
                            orderby item.Height
                            select new { Name = item.Name, Inch = item.Height * 0.393}; // select의 활용

            Console.WriteLine("전체 프로필 리스트(오름차순)");
            foreach (var item in profiles1)
            {
                Console.WriteLine($"{item.Name} : {item.Inch}inch");
            }

            /*List<Profile> newProfiles = new List<Profile>();
            foreach (var item in profiles)
            {
                if (item.Height < 172)
                    newProfiles.Add(item);
            }*/

            // Linq 사용
            var newProfiles = from item in profiles
                              where item.Height < 172
                              orderby item.Height descending // 정렬도 가능!
                              select item;

            Console.WriteLine("172cm이하 프로필 리스트");
            foreach (var item in newProfiles)
            {
                Console.WriteLine($"{item.Name} : {item.Height}cm");
            }

            //
            int maxSize = 100;
            int[] numbers = new int[100];
            for (int i = 0; i < maxSize; i++)
            {
                numbers[i] = (i + 1);
            }

            /*for (int i = 0; i < maxSize; i++)
            {
                Console.Write($"{numbers[i]}");
            }*/

            var result = from item in numbers
                         where item % 10 == 3 || item % 10 == 6 || item % 10 == 9 ||
                         item / 10 == 3 || item / 10 == 6 || item / 10 == 9
                         select item;

            foreach (var item in result)
            {
                Console.Write($"{item}\t");
            }

            // 15.3
            Console.WriteLine();
            InstClass[] arrClasses =
            {
                new InstClass(){ Name = "연두반", Scores= new int[] { 99, 80, 70, 24} },
                new InstClass(){ Name = "분홍반", Scores= new int[] { 60, 45, 87, 72} },
                new InstClass(){ Name = "연두반", Scores= new int[] { 92, 30, 85, 94} },
                new InstClass(){ Name = "연두반", Scores= new int[] { 90, 88, 0, 17} }
            };

            var rstClasses = from item in arrClasses
                                from score in item.Scores // 중첩 from
                             where score < 69
                             orderby score ascending
                             select new { Name = item.Name, Lowest = score};

            foreach (var item in rstClasses)
            {
                Console.WriteLine($"{item.Name} : {item.Lowest}");
            }

            // groupby
            var listProfiles = from item in profiles
                               orderby item.Height
                               group item by item.Height < 172 into g
                               select new { GroupKey = g.Key, Profiles = g };

            // groupby(Linq)
            var profiles2 = profiles.Where(p => p.Height < 172)
                            .OrderByDescending(p => p.Height)
                            .Select(item =>
                            new
                            {
                                Name = item.Name,
                                Inch = item.Height * 0.393
                            });

            foreach (var item in listProfiles)
            {
                Console.WriteLine($"- 172cm 미만? {item.GroupKey}");

                foreach (var sub in item.Profiles)
                {
                    Console.WriteLine($">>> {sub.Name} : {sub.Height}");
                }
            }
        }
    }
}
