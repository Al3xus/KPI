using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace tic_tac_toe.DataBase
{
    public static class Json
    {
        // Опции сериализации
        private static readonly JsonSerializerOptions Options = new()
            { ReferenceHandler = ReferenceHandler.IgnoreCycles, WriteIndented = true };

        // Путь к файлу JSON
        private const string Filepath =
            @"C:\Cursova\Tic-Tac-Toe-master\tic-tac-toe\DataBase\Info.json";

        // Метод для загрузки данных из JSON
        public static DbContext Load()
        {
            // Считывание JSON из файла
            var json = File.ReadAllText(Filepath);
            // Десериализация JSON в объект DbContext с использованием Json.NET
            return JsonConvert.DeserializeObject<DbContext>(json);
        }

        // Метод для сохранения данных в JSON
        public static void Save(DbContext dbContext)
        {
            // Сериализация объекта DbContext в JSON-строку с использованием System.Text.Json
            var jsonString = JsonSerializer.Serialize(dbContext, Options);
            // Запись JSON-строки в файл
            File.WriteAllText(Filepath, jsonString);
        }
    }
}