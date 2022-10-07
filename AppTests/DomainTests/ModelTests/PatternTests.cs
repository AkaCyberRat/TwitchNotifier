using App.Domain.NotifierService.Models;
using NUnit.Framework;
using System;
using System.Collections;

namespace AppTests.ModelTests
{
    [TestFixture]
    public class PatternTests
    {
        [TestCaseSource(nameof(ReturnsObjectCases))]
        public void InvokeConstructor_ReturnsObject(string channel, StreamEvent[] streamEvents, string[] categories, string[] notifierTags)
        {
            Assert.DoesNotThrow(() => new Pattern(channel, notifierTags, streamEvents, categories));
        }

        [TestCaseSource(nameof(ReturnsThrowCases))]
        public void InvokeConstructor_ReturnsThrow(string channel, StreamEvent[] streamEvents, string[] categories, string[] notifierTags)
        {
            var ex = Assert.Throws<ArgumentException>(() =>
                new Pattern(channel, notifierTags, streamEvents, categories));

        }


        private static IEnumerable ReturnsObjectCases
        {
            get
            {
                yield return new TestCaseData("Recrent", new StreamEvent[] { StreamEvent.CategoryStart }, new string[] { "PUBG" }, new string[] { "SomeTag" })
                    .SetName("All test params filled.");

                yield return new TestCaseData("Recrent", new StreamEvent[] { }, new string[] { }, new string[] { "SomeTag" })
                    .SetName("StreamEvents array is empty.");

                yield return new TestCaseData("Recrent", null, new string[] { "PUBG" }, new string[] { "SomeTag" })
                    .SetName("StreamEvents array is null.");

                yield return new TestCaseData("Recrent", new StreamEvent[] { StreamEvent.CategoryStart }, new string[] { }, new string[] { "SomeTag" })
                    .SetName("Categories array is empty.");

                yield return new TestCaseData("Recrent", new StreamEvent[] { StreamEvent.CategoryStart }, null, new string[] { "SomeTag" })
                    .SetName("Categories array is null.");
            }
        }
        private static IEnumerable ReturnsThrowCases
        {
            get
            {
                yield return new TestCaseData("", new StreamEvent[] { StreamEvent.CategoryStart }, null, new string[] { "SomeTag" })
                    .SetName("Empty channel name.");

                yield return new TestCaseData("", new StreamEvent[] { StreamEvent.CategoryStart }, null, new string[] { "SomeTag" })
                    .SetName("Whitespace channel name.");

                yield return new TestCaseData(null, new StreamEvent[] { StreamEvent.CategoryStart }, null, new string[] { "SomeTag" })
                    .SetName("Nullable channel name.");

                yield return new TestCaseData("", new StreamEvent[] { StreamEvent.CategoryStart }, null, new string[] { })
                    .SetName("Empty notifier tags array.");

                yield return new TestCaseData("", new StreamEvent[] { StreamEvent.CategoryStart }, null, null)
                    .SetName("Nullable notifier tags array.");
            }
        }
    }
}
                            