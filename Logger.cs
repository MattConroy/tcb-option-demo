namespace TCB.Option.Demo
{
    internal sealed class Logger : ILogger
    {
        public void WriteLine(string format)
        {
            System.Console.WriteLine(format);
        }
    }
}