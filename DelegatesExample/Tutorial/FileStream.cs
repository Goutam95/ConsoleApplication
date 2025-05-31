namespace DelegatesExample.Tutorial
{
    public class FileStream
    {
        static void Stream()
        {
            string path   = "example.txt";
            using var fs  = new MemoryStream();
            byte[] buffer = new byte[fs.Length];
            fs.Read(buffer, 0, buffer.Length);
            string content = System.Text.Encoding.UTF8.GetString(buffer);
            Console.WriteLine(content);
        }
    }
}
/*
 In C#, streaming refers to the process of reading or writing data sequentially.
 Streams are used to handle input and output operations, such as reading from or writing to files, 
 network connections, or memory. The System.IO namespace provides various classes for working with streams,
including FileStream, MemoryStream, NetworkStream, and more.

Here are some key points about streaming in C#:

FileStream: Used for reading from and writing to files.
MemoryStream: Used for reading from and writing to memory.
NetworkStream: Used for network communication.
BufferedStream: Provides a buffer for another stream to improve read and write performance.g
*/