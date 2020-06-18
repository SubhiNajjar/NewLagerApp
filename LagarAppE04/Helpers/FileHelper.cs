using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using static System.Console;

namespace LagarAppE04.Helpers
{
    public static class FileHelper
    {
        public static IEnumerable<T> LoadFromJson<T>(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            var records = JsonSerializer.Deserialize<List<T>>(jsonString);

            Clear();
            WriteLine(".. This is a List for All ..");
            //WriteLine("Product\tPrice\tManuFacturer");
            foreach (var Items in records)
            {
                WriteLine(Items);
            }
            WriteLine("\nPlease Press Enter For Continue... ");
            ReadLine();
            Clear();
            return records;
        }


        public static void SaveToJson<T>(string filePath, IEnumerable<T> records)
        {
            var jsonString = JsonSerializer.SerializeToUtf8Bytes(records);
            File.WriteAllBytes(filePath, jsonString);
        }

        public static string GetUserHomePath()
        {
            return
                Environment.GetFolderPath(Environment.SpecialFolder.UserProfile,
                    Environment.SpecialFolderOption.DoNotVerify);
        }

    }
}
