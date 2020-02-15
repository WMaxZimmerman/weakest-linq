using WeakestLinq.ApplicationCore.Services;
using NTrospection.CLI.Attributes;

namespace WeakestLinq.Console.Controllers
{
    [CliController("example", "An example of a CLI Controller")]
    public class ExampleController
    {
        [CliCommand("hello", "A Hello World for a CLI Project")]
        public void HelloWorld()
        {
            System.Console.WriteLine(ExampleService.HelloWorld());
        }
    }
}
