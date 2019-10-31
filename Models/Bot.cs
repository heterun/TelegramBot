﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using Telegram.Bot;
using TelegramBot.Models.Commands;

namespace TelegramBot.Models
{
    public static class Bot
    {
        private static TelegramBotClient client;
        private static List<Command> commandsList;
        //keep a collection of commands
        
        public static IReadOnlyList<Command> Commands { get => commandsList.AsReadOnly(); }

        public static async Task<TelegramBotClient> Get()
        { 
            if(client != null)
            {
                return client;
            }

            commandsList = new List<Command>();
            commandsList.Add(new HelloCommand());
            //TODO : add more commands

            client = new TelegramBotClient(AppSettings.Key);
            await client.SetWebhookAsync("");

            return client;

        }
    }
}