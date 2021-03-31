using System;
using System.Collections.Generic;

namespace ConsoleApp4DataCollectionsDatastructure
{
    class Program
    {
        static void Main(string[] args)
        {
            // dictionary

            Dictionary<string, string> openWith = new Dictionary<string, string>();

            // openWith.Add("txt", "notepad.exe");
            openWith.Add("bmp", "paint.exe");
            openWith.Add("dib", "paint.exe");
            openWith.Add("rtf", "wordpad.exe");

            try
            {
                openWith.Add("txt", "windword.exe");
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine("key txt already exists");
                throw;
            }

            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);

            openWith["rtf"] = "winword.exe";

            Console.WriteLine("For key = \"rtf\", value = {0}.", openWith["rtf"]);

            openWith["doc"] = "winword.exe";

            try
            {
                Console.WriteLine("For key = \"tif\", value = {0}.", openWith["tif"]);
            }
            catch (Exception)
            {

                Console.WriteLine("Key = \"tif\" is not found.");
            }

            if (!openWith.ContainsKey("ht"))
            {
                openWith.Add("ht", "hypertrm.exe");
                Console.WriteLine("Value added for key = \"ht\": {0}", openWith["ht"]);
            }

            var result = openWith.TryAdd("xx", "hola") ? "bien" : "mal";

            foreach(var ow in openWith)
            {
                Console.WriteLine($"key: {ow.Key}, value{ow.Value}");
            }

            Console.WriteLine("--------------------");

            Dictionary<string, string>.KeyCollection keyColl = openWith.Keys;

            Console.WriteLine();
            foreach (string s in keyColl)
            {
                Console.WriteLine("Key = {0}", s);
            }

            openWith.Remove("doc");

            //string docResult = "";
            openWith.TryGetValue("doc", out string docResult);
            Console.WriteLine($"the result is this: { string.IsNullOrEmpty(docResult) }");

                    }
    }
}
