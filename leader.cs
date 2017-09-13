using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.WebSocket;
using Discord.Commands;

namespace DankBot.Modules
{
    public class leader : ModuleBase<SocketCommandContext>
    {

        [Command("leader")]
        public async Task Leadermsg()
        {
            await Context.Channel.SendMessageAsync("Calvin is the only leader, despite what Julian says or thinks. As a rule of thumb, discount what Julian says.");
        }

    }
}
