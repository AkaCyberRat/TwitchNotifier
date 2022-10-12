using System.ComponentModel.DataAnnotations;

namespace Concrete.Notifiers.Telegram
{
    public class TelegramNotifierConfig
    {
        [Required]
        public string BotSecret { get; set; }

        [Required]
        public Pattern[] Patterns { get; set; }



        public class Pattern
        {
            [Required]
            public string Tag { get; set; }

            [Required, MinLength(1)]
            public string[] Endpoints { get; set; }
        }
    }
}
