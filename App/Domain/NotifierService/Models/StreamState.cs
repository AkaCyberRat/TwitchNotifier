using System;

namespace App.Domain.NotifierService.Models
{
    public class StreamState
    {
        public string UserName { get; }
        public string UserId { get; } = "";
        public string GameId { get; } = "";
        public string GameName { get; } = "";
        public string Title { get; } = "";
        public string ThumbnailUrl { get; } = "";
        public string[] TagIds { get; } = new string[] { };
        public string Type { get; } = "";
        public int ViewerCount { get; } = 0;
        public DateTime StartedAt { get; } = DateTime.MinValue;
        public DateTime StateCreatedAt { get; } = DateTime.UtcNow;

        public bool IsLive()
        {
            if (string.IsNullOrWhiteSpace(Type))
                return false;
            return true;
        }

        public StreamState(string userName,
                        string userId,
                        string gameId,
                        string gameName,
                        string title,
                        string thumbnailUrl,
                        string[] tagIds,
                        string type,
                        int viewerCount,
                        DateTime startedAt)
        {
            UserName = userName;
            UserId = userId;
            GameId = gameId;
            GameName = gameName;
            Title = title;
            ThumbnailUrl = thumbnailUrl;
            TagIds = tagIds;
            Type = type;
            ViewerCount = viewerCount;
            StartedAt = startedAt;
        }

        public StreamState(string userName)
        {
            UserName = userName;
        }
    }
}
