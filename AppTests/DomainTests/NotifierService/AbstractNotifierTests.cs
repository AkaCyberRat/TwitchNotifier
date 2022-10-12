using Domain.Services.NotifierService;
using NUnit.Framework;
using System;

namespace UnitTests.DomainTests.NotifierService
{
    [TestFixture]
    public abstract class AbstractNotifierTests
    {
        public abstract INotifier GetNotifier();

        [Test]
        public void GetTags_ReturnsNotNullOrEmpty()
        {
            var notifier = GetNotifier();

            var tags = notifier.GetTags();
            var result = tags == null || tags.Length == 0;

            Assert.That(result, Is.False);
        }

        [Test]
        public void Notify_NullContext_ReturnsThrow()
        {
            var notifier = GetNotifier();

            Assert.ThrowsAsync<ArgumentNullException>(async () => await notifier.Notify(null));
        }


    }
}
