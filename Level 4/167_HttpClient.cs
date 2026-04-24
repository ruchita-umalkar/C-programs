// API Consumption using HttpClient 
using System;
using System.Net.Http;
using System.Threading.Tasks;

public class Program
{
    static async Task Main()
    {
        using (var httpClient = new HttpClient())
        {
            var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts/1");
            var content = await response.Content.ReadAsStringAsync();
            Console.WriteLine(content);
        }
    }
}
