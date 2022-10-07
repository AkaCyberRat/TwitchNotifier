using System;

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
            if (string.IsNullOrWhiteSpace(channel))
                throw new ArgumentException($"'{nameof(channel)}' cannot be null or empty.", nameof(channel));   

            if (notifierTags == null || notifierTags.Length == 0)
                throw new ArgumentException($"'{nameof(notifierTags)}' cannot be null or empty.", nameof(notifierTags));

            Channel = channel;
            NotifierTags = notifierTags;


            StreamEvents = streamEvents == null || streamEvents.Length == 0 ?
                new StreamEvent[] { StreamEvent.StreamStart, StreamEvent.StreamStop } : streamEvents;

            Categories = categories ?? new string[] { };
        }
    }
}
