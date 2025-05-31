namespace DelegatesExample.Tutorial
{
    public class AsyncAndAwait
    {

        public static async Task Mainss(string[] args)
        {
            Console.WriteLine("Starting download...");
            string content = await DownloadContentAsync("https://www.example.com");
            Console.WriteLine("Download complete.");
            Console.WriteLine(content);
        }

        public static async Task<string> DownloadContentAsync(string url)
        {
            using HttpClient client = new();
            string content = await client.GetStringAsync(url);
            return content;
        }

    }
}
//async and await
/*async and await are keywords in C# that are used to write asynchronous code, 
which allows you to perform tasks without blocking the main thread. 
This is particularly useful for I/O-bound operations like reading from a file, 
making network requests, or accessing a database.

Explanation:
async keyword:The async keyword is used to declare an asynchronous method. In the example,
    both Main and DownloadContentAsync methods are marked as async.

await keyword:The await keyword is used to pause the execution of an async method until the awaited task completes. 
    In the example, await client.GetStringAsync(url) pauses the DownloadContentAsync method until the HTTP request completes.

Return type:An async method that returns a value must have a return type of Task<T>, where T is the type of the value. 
    If the method does not return a value, it should return Task. In the example,
    DownloadContentAsync returns Task<string>, and Main returns Task.

Non-blocking:The await keyword allows the method to be non-blocking. While waiting for the task to complete, 
    the control is returned to the caller, allowing other work to be done.*/ 
// bgbfvghfdffsccgfvfdcd