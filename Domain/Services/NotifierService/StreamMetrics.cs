using System;
using System.Collections.Generic;

namespace Domain.Services.NotifierService
{
    public class StreamMetrics
    {
        public StreamMetrics(IReadOnlyDictionary<DateTime, int> viewersCountHistory,
                             IReadOnlyDictionary<DateTime, string> titlesHistory,
                             IReadOnlyDictionary<DateTime, string> categoriesHistory)
        {
            if (viewersCountHistory is null)
            {
                throw new ArgumentNullException(nameof(viewersCountHistory));
            }

            if (titlesHistory is null)
            {
                throw new ArgumentNullException(nameof(titlesHistory));
            }

            if (categoriesHistory is null)
            {
                throw new ArgumentNullException(nameof(categoriesHistory));
            }


            ViewersCountHistory = viewersCountHistory;
            TitlesHistory = titlesHistory;
            CategoriesHistory = categoriesHistory;
        }

        IReadOnlyDictionary<DateTime, int> ViewersCountHistory { get; }
        IReadOnlyDictionary<DateTime, string> TitlesHistory { get; }
        IReadOnlyDictionary<DateTime, string> CategoriesHistory { get; }
    }
}
