namespace App.Domain.NotifierService.Models
{
    public class Context
    {
        public StreamEvent StreamEvent { get; }
        public StreamState StreamState { get; }
        public StreamMetrics StreamMetrics { get; }
        

        public Context(StreamEvent streamEvent, StreamState streamState, StreamMetrics streamMetrics)
        {
            StreamEvent = streamEvent;
            StreamState = streamState;
            StreamMetrics = streamMetrics;
        }

        private Context()
        {

        }
    }
}
