using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace asynchronous
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //    var task = new List<Task>
            //    {
            //    Method1(),
            //    Method2()
            //};
            //    await Task.WhenAll(task);
            //    Console.ReadLine();

            string url = "https://raw.githubusercontent.com/l3oxer/Doggo/main/README.md";

            //ReadFile();

            //ReadUrl(url);

           

            var task = new List<Task>
            {
                //ReadFile() , ReadUrl(url)

                ReadUrl(url),ReadFile()  
            };

            await Task.WhenAll(task);
            
            Console.ReadLine();

            
        }
        //public static async Task Method1()
        //{
        //    Console.WriteLine("Method1 is Starting");
        //    StreamReader sr = new StreamReader("C:\\Users\\Shakeel Abbas Khan\\Desktop\\Sample.txt");
        //    //Read the first line of text
        //    string line = await sr.ReadLineAsync();
        //    int counts = line.Length;
        //    //Continue to read until you reach end of file
        //    Console.WriteLine(counts);
        //    Console.WriteLine("Method1 is Completed");
        //}
        //public static async Task Method2()
        //{
        //    Console.WriteLine("Method2 is Starting");
        //    StreamReader sr = new StreamReader("C:\\Users\\Shakeel Abbas Khan\\Desktop\\Sample2.txt");
        //    string line = await sr.ReadLineAsync();
        //    int counts = line.Length;
        //    Console.WriteLine(counts);
        //    Console.WriteLine("Method2 is Completed");
        //}

        static async Task ReadFile()
        {
            Console.WriteLine("ReadFile Starting...");
            StreamReader sr = new StreamReader("C:\\Users\\Shakeel Abbas Khan\\Desktop\\Sample.txt");
            string line = await sr.ReadLineAsync();
            int counts = line.Length;
            Console.WriteLine(counts);
            Console.WriteLine("ReadFile is Completed");
        }

        static async Task ReadUrl(string url)
        {
            Console.WriteLine("ReadUrl is Starting");
            using (HttpClient client = new HttpClient())
            {
                string s = await client.GetStringAsync(url);
                Console.WriteLine($"The Url is  \n{s}");
            }
            
        }

    }

    
}
