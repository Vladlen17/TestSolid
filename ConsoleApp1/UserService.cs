using System;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.Database;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1
{
    // Реализация сервиса работы с пользователями
    public class UserService : IUserService
    {
        public async Task AddUserAsync(User user)
        {
            // Логика добавления пользователя в базу данных
            using (ApplicationContext db = new ApplicationContext())
            {
                db.Database.EnsureDeleted();
                //db.Database.EnsureCreated();

                await db.Users.AddAsync(user);
                await db.SaveChangesAsync();
            }
        }
        public void ToListUser()
        {
            using (ApplicationContext db = new ApplicationContext())
            {
                var users = db.Users.ToList();
                Console.WriteLine("Users list:");
                Console.WriteLine("Id Name Email");
                foreach (User u in users)
                {
                    Console.WriteLine($"{u.Id} {u.Name} {u.Email}");
                }
            }
        }
    }
}
