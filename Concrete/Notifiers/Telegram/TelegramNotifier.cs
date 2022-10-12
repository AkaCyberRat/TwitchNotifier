using Domain.Services.NotifierService;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Concrete.Notifiers.Telegram
{
    public class TelegramNotifier : INotifier
    {
        public TelegramNotifier(IOptions<TelegramNotifierConfig> options)
        {

        }


        public string GetTags()
        {
            throw new NotImplementedException();
        }

        public Task Notify(Context context)
        {
            throw new NotImplementedException();
        }
    }
}
