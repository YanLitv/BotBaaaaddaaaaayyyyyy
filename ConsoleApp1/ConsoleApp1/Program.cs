using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;

namespace ConsoleApp1
{
    class Program
    {
        public static TelegramBotClient botClient;
        static void Main(string[] args)
        {
            botClient = new TelegramBotClient("745606871:AAGqN588lpsuNDJlzeSx3FFZz1RHgS9VCtU");
            botClient.OnMessage += BotClient_OnMessage;
            botClient.StartReceiving();
            Console.Read();
        }

        private static void BotClient_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            Console.WriteLine("Badaj!");
        }
    }
}
