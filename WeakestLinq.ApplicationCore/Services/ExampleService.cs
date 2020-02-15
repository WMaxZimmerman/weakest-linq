using WeakestLinq.DAL.Repositories;

namespace WeakestLinq.ApplicationCore.Services
{
    public class ExampleService
    {
        public static string HelloWorld()
        {
            return ExampleRepository.HelloWorld();
        }
    }
}
