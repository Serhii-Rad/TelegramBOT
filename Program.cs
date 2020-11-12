using System;
using Telegram.Bot;

namespace TelegramBOT
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string token = "1231935235:AAFVWEpcTrQatzpDEreYzKs9iHP3eSvII6k";
            TelegramBotClient bot = new TelegramBotClient(token);
            Console.WriteLine($"@{bot.GetMeAsync().Result.Username} started");
            bot.OnMessage += (e, arg) =>
            {
                string message = $"{arg.Message.Chat.FirstName}: {arg.Message.Text} ";
                Console.WriteLine(message);

                if (arg.Message.Text != "/start")
                {
                    if (arg.Message.Chat.FirstName == "Vlad")
                    {
                        bot.SendTextMessageAsync(chatId: arg.Message.Chat.Id, text: $"Ты Закревский Владислав Александрович, +380686117897");
                    }
                    if (arg.Message.Chat.FirstName == "Anastasiia")
                    {
                        bot.SendTextMessageAsync(chatId: arg.Message.Chat.Id, text: $"Ты Настюша, люблю тебя!)");
                    }
                    bot.SendTextMessageAsync(chatId: arg.Message.Chat.Id, text: $"Ты написал(а): {arg.Message.Text}");
                    bot.SendTextMessageAsync(chatId: arg.Message.Chat.Id, text: $"Ты : {arg.Message.Chat.FirstName}");
                }
            };
            bot.StartReceiving();
            Console.ReadLine();
        }
    }
}
