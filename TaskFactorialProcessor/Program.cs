namespace TaskFactorialProcessor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaskFactorialProcessor processor1 = new TaskFactorialProcessor();
            Console.WriteLine("Parallel Mode:");
            processor1.Go(10, true);

            Thread.Sleep(2000);

            TaskFactorialProcessor processor2 = new TaskFactorialProcessor();
            Console.WriteLine("\nSequential Mode:");
            processor2.Go(10, false);
        }
    }
}