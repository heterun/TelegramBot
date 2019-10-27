using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramBot.Models
{
    public static class AppSettings
    {
        public static string Url { get; set; } = "https://telegrambotapp.azurewebsites.net:443/{0}";

        //name bot
        public static string Name { get; set; } = "first bot app telegram";

        //api
        public static string Key { get; set; } = "912179562:AAGak6ITHXCxMkdFgJyO1QpZJDB7Oo-IhAw";
    }
}