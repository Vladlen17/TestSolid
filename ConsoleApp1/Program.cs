using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogger l = new ConsoleLogger();
            UserService s = new UserService();
            UserProcessor process = new UserProcessor(s, l);

            int i = 10000;
            ParallelOptions parallelOptions = new ParallelOptions();
            parallelOptions.MaxDegreeOfParallelism = 2;
            Parallel.For(0, i, parallelOptions, k =>
            {
                User user1 = new User
                {
                    Id = k,
                    Name = "NameTest",
                    Email = "EmailTest"
                };
                process.ProcessAddUser(user1);
            });
            process.ProcessGiveListUser();
        }
    }
}
