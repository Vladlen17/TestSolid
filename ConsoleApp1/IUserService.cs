using System.Threading.Tasks;

namespace ConsoleApp1
{
    // Принцип открытости/закрытости (Open/Closed Principle)
    // Интерфейс для сервиса работы с пользователями
    public interface IUserService
    {
        Task AddUserAsync(User user);
        void ToListUser();
    }
}
