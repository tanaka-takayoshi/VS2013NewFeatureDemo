using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AsyncDebugging
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.WaitAll(Enumerable.Range(1, 5).Select(_ => MainAsync()).ToArray());
            Console.ReadKey();
        }

        static async Task MainAsync()
        {
            var task = DownloadAsync();
            Console.WriteLine(task.Result);
        }

        static async Task<string> DownloadAsync()
        {
            var client = new HttpClient();
            var res = await  client.GetAsync("http://google.com/");
            return await res.Content.ReadAsStringAsync();
        }
    }
}
