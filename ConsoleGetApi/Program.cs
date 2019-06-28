using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Http;

namespace ConsoleGetApi
{
    class Program
    {
        static void Main(string[] args)
        {

            GetRequest("https://reqres.in/api/users");

            Console.ReadKey();

        }

        async static void GetRequest(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(url))
                {
                    using (HttpContent content = response.Content)
                    {
                        string mycontent = await content.ReadAsStringAsync();


                        Console.WriteLine(mycontent);
                    }
                }
            }
        }
    }
}
