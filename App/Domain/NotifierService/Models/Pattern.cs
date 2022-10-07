namespace App.Domain.NotifierService.Models
{
    public class Pattern
    {
        public string Channel { get; }
        public StreamEvent[] StreamEvents { get; }
        public string[] Categories { get; }
        public string[] NotifierTags { get; }


        public Pattern(string channel, string[] notifierTags, StreamEvent[] streamEvents = null, string[] categories = null)
        {
            Channel = channel;
            NotifierTags = notifierTags;
            StreamEvents = streamEvents;
            Categories = categories;
        }
    }
}
