using System.Collections.Generic;
using System.Linq;
using TCB.Option.Demo.Application;
using TCB.Option.Demo.Infrastructure;

namespace TCB.Option.Demo
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var id = int.Parse(GetIdParameter(args));

            var service = GetService();
            service.Execute(id);
        }

        private static string GetIdParameter(IEnumerable<string> args)
        {
            return args.FirstOrDefault() ?? "0";
        }

        private static IService GetService()
        {
            return new Service(new Repository(), new Validator(), new Logger());
        }
    }
}
