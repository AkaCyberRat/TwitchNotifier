using System;

namespace Domain.Services.NotifierService
{
    public class Context
    {
        public StreamEvent StreamEvent { get; }
        public StreamState StreamState { get; }
        public StreamMetrics StreamMetrics { get; }


        public Context(StreamEvent streamEvent, StreamState streamState, StreamMetrics streamMetrics = null)
        {
            if (streamState is null)
            {
                throw new ArgumentNullException(nameof(streamState));
            }

            StreamEvent = streamEvent;
            StreamState = streamState;
            StreamMetrics = streamMetrics;
        }
    }
}
