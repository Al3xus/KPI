using System.Linq;
using tic_tac_toe.DataBase;
using tic_tac_toe.PackageForPlayers;
using tic_tac_toe.Services.Base;

namespace tic_tac_toe.Services
{
    // Сервис управления аккаунтами
    public class AccountService : IAccountService
    {
        // БД, для хранения аккаунтов
        public DbContext DbContext { get; }

        // Конструктор класса AccountService
        public AccountService()
        {
            // Загружаем контекст базы данных из JSON-файла
            DbContext = Json.Load();
        }
        
        // Метод для поиска аккаунта по имени пользователя
        public bool FindAccount(string userName)
        {
            // Проверяем наличие аккаунта с указанным именем пользователя в базе данных
            return DbContext.Accounts.Find(x => x.UserName.Equals(userName)) != null;
        }

        // Метод для добавления обычного аккаунта в базу данных
        public Account AddAccountToDataBase(string firstName, string lastName, string userName, string password)
        {
            // Создаем новый обычный аккаунт и добавляем его в базу данных
            DbContext.Accounts.Add(new Account(firstName, lastName, userName, password));
            // Возвращаем добавленный аккаунт (последний в списке)
            return DbContext.Accounts.Last();
        }

        // Метод для добавления премиум аккаунта в базу данных
        public Account AddPremiumAccountToDataBase(string firstName, string lastName, string userName, string password)
        {
            // Создаем новый премиум аккаунт и добавляем его в базу данных
            DbContext.Accounts.Add(new PremiumAccount(firstName, lastName, userName, password));
            // Возвращаем добавленный аккаунт (последний в списке)
            return DbContext.Accounts.Last();
        }
    }
}