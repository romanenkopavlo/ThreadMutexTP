using System.IO.IsolatedStorage;

namespace ThreadTD
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Mutex m = new Mutex();
            Random random = new Random();
            Work work;

            StreamWriter sw = new StreamWriter("thread.txt");
            sw.WriteLine("Hello world");
           
            for (int i = 0; i < 10; i++)
            {
                work = new Work();
                work.sw = sw;
                work.mut = m;
                work.random = random;
                Thread thread = new Thread(work.Run);
                thread.Start();
            }
            sw.Close();
        }
    }
}
