﻿using System;
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
            switch (e.Message.Text)
            {
                case "/time":
                    {
                        botClient.SendTextMessageAsync(e.Message.Chat.Id, DateTime.Now.ToShortTimeString());
                        break;
                    }
                case "/date":
                    {
                        botClient.SendTextMessageAsync(e.Message.Chat.Id, DateTime.Now.ToShortDateString());
                        break;
                    }
                case "/timezone":
                    {
                        botClient.SendTextMessageAsync(e.Message.Chat.Id, TimeZone.CurrentTimeZone.StandardName.ToString());
                        break;
                    }
                default:
                    botClient.SendTextMessageAsync(e.Message.Chat.Id, e.Message.Text);
                    break;
            }
        }
    }
}
