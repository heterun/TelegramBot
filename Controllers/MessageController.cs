using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using Telegram.Bot.Types;
using TelegramBot.Models;

namespace TelegramBot.Controllers
{
    public class MessageController : ApiController
    {
        [Route(@"api/message/update")] // webhook uri part
        public async Task<OkResult> Update([FromBody]Update update) // relevant info for bot
        {
            var commands = Bot.Commands;
            var message = update.Message; // message for bot
            var client = await Bot.Get(); // telegram bot client in order to send an answer // get is async

            foreach(var command in commands)
            {
                if (command.Contains(message.Text))
                {
                    command.Execute(message, client);
                    break;
                }
            }

            return Ok();
        }
    }
}
