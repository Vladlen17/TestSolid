using Microsoft.Extensions.Logging;

namespace ConsoleApp1
{
    // Принцип инверсии зависимостей (Dependency Inversion Principle)
    // Класс, использующий сервис и логгер через интерфейсы
    public class UserProcessor
    {
        private readonly IUserService _userService;
        private readonly ILogger _logger;

        public UserProcessor(IUserService userService, ILogger logger)
        {
            _userService = userService;
            _logger = logger;
        }

        public void ProcessAddUser(User user)
        {
            _userService.AddUserAsync(user);
            _logger.LogDebug($"User с ид {user.Id} added successfully");
        }
        public void ProcessGiveListUser()
        {
            _logger.LogDebug("Получение из БД");
            _userService.ToListUser();
        }
    }
}
