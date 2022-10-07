using System;
using System.Collections.Generic;

namespace App.Domain.NotifierService.Models
{
    public class StreamMetrics
    {
        public StreamMetrics(IReadOnlyDictionary<DateTime, int> viewersCountHistory,
                             IReadOnlyDictionary<DateTime, string> titlesHistory,
                             IReadOnlyDictionary<DateTime, string> categoriesHistory)
        {
            ViewersCountHistory = viewersCountHistory;
            TitlesHistory = titlesHistory;
            CategoriesHistory = categoriesHistory;
        }

        IReadOnlyDictionary<DateTime, int> ViewersCountHistory { get; }
        IReadOnlyDictionary<DateTime, string> TitlesHistory { get; }
        IReadOnlyDictionary<DateTime, string> CategoriesHistory { get; }
    }
}
