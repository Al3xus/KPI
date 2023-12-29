using tic_tac_toe.PackageForPlayers;

namespace tic_tac_toe.Services.Base
{
    // Интерфейс для сервиса управления аккаунтами
    public interface IAccountService
    { 
        // Метод для поиска аккаунта по имени пользователя
        bool FindAccount(string userName);
        
        // Метод для добавления обычного аккаунта в базу данных
        Account AddAccountToDataBase(string firstName, string lastName, string userName, string password);
        
        // Метод для добавления премиум аккаунта в базу данных
        Account AddPremiumAccountToDataBase(string firstName, string lastName, string userName, string password);
    }
}