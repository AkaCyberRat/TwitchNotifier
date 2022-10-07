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
            if (string.IsNullOrWhiteSpace(userName))
            {
                throw new ArgumentException($"'{nameof(userName)}' cannot be null or empty.", nameof(userName));
            }

            if (string.IsNullOrWhiteSpace(userId))
            {
                throw new ArgumentException($"'{nameof(userId)}' cannot be null or empty.", nameof(userId));
            }

            if (string.IsNullOrWhiteSpace(gameId))
            {
                throw new ArgumentException($"'{nameof(gameId)}' cannot be null or empty.", nameof(gameId));
            }

            if (string.IsNullOrWhiteSpace(gameName))
            {
                throw new ArgumentException($"'{nameof(gameName)}' cannot be null or empty.", nameof(gameName));
            }

            if (string.IsNullOrWhiteSpace(title))
            {
                throw new ArgumentException($"'{nameof(title)}' cannot be null or empty.", nameof(title));
            }

            if (string.IsNullOrWhiteSpace(thumbnailUrl))
            {
                throw new ArgumentException($"'{nameof(thumbnailUrl)}' cannot be null or empty.", nameof(thumbnailUrl));
            }

            if (tagIds is null)
            {
                throw new ArgumentNullException(nameof(tagIds));
            }

            if (string.IsNullOrWhiteSpace(type))
            {
                throw new ArgumentException($"'{nameof(type)}' cannot be null or empty.", nameof(type));
            }

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
            if (string.IsNullOrEmpty(userName))
            {
                throw new ArgumentException($"'{nameof(userName)}' cannot be null or empty.", nameof(userName));
            }
            UserName = userName;
        }
    }
}
