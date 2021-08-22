using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace G_LINQ
{
   
        public static class LinqExtensions
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (source == null) throw new ArgumentNullException();

            foreach (var item in source)
            {
                action(item);
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            MinMaxSumAverage("Top100ChessPlayers.csv");
        }
        static void MinMaxSumAverage(string file)
        {
            IEnumerable<ChessPlayer> list = File.ReadAllLines(file)
                                         .Skip(1)
                                         .Select(ChessPlayer.ParseFideCsv)
                                         .Where(player => player.BirthYear > 1988)
                                         .OrderByDescending(player => player.Rating)
                                         .Take(10);
            Console.WriteLine($"The lowest rating in top 10: {list.Min(x => x.Rating)}");
            Console.WriteLine($"The highest rating in top 10: {list.Max(x => x.Rating)}");
            Console.WriteLine($"The average rating in top 10: {(int)list.Average(x => x.Rating)}"); 
        }
      
  
        private static void DisplayLargestFileWithoutLinq(string pathToDir)
        // предположим нам нужно разработать метод, который принимает путь к папке и нам нужно взять топ 5 крупных файлов. 
        // вариант без LINQ и Lambda
        {
            var dirInfo = new DirectoryInfo(pathToDir);
            FileInfo[] files = dirInfo.GetFiles();

            Array.Sort(files, FilesComparison);

            for (int i = 0; i < 5; i++)
            {
                FileInfo file = files[i];
                Console.WriteLine($"{file.Name} weights {file.Length}");
            }
        }
        static int FilesComparison(FileInfo x, FileInfo y)
        {
            if (x.Length == y.Length) return 0;
            if (x.Length > y.Length) return -1;
            return 1;
        }
        

        private static void DisplayLargestFileWithLinq(string pathToDir)
        // вариант c LINQ и Lambda
        {
            new DirectoryInfo(pathToDir)
                .GetFiles()
                .OrderByDescending(file => file.Length)
                .Take(5)
                .ForEach(file => Console.WriteLine($"{file.Name} weights {file.Length}"));

        }

    }
}
