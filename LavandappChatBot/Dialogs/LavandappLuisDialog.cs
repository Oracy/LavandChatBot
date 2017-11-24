using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.Luis;
using Microsoft.Bot.Builder.Luis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LavandappChatBot.Dialogs
{
    [LuisModel("2957416e-b443-43ea-9fbe-00a4836e269d", "1d1493279e614ca5aad8b1c5dd86af64")]
    [Serializable]
    public class LavandappLuisDialog : LuisDialog<object>
    {
        [LuisIntent("None")]
        public async Task None(IDialogContext context, LuisResult result)
        {
            await context.PostAsync("I'm sorry. I didn't understand you.");
            context.Wait(MessageReceived);
        }
    }
}