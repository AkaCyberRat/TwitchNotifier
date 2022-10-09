using NUnit.Framework;
using System;
using System.Text.Json;
using System.Collections;
using System.Threading.Tasks;
using Domain.Services.NotifierService;

namespace UnitTests.DomainTests.NotifierService
{
    public abstract class AbstractTwitchPollerServiceTests
    {
        protected abstract ITwitchPollerService GetTwitchPoller();


        [TestCaseSource(nameof(ReturnsCorrectStreamStatesCases))]
        public async Task GetStreamStates_ReturnsCorrectStreamStates(string[] usernames, StreamState[] streamStates)
        {
            var twitchPoller = GetTwitchPoller();

            var result = await twitchPoller.GetStreamStates(usernames);

            Assert.True(AreEqualByJson(result, streamStates));
        }

        [TestCaseSource(nameof(ReturnsThrowCases))]
        public void GetStreamStates_ReturnsThrow(string[] usernames)
        {
            var twitchPoller = GetTwitchPoller();

            Assert.ThrowsAsync<ArgumentException>(() => twitchPoller.GetStreamStates(usernames));
        }


        private bool AreEqualByJson(object obj1, object obj2)
        {
            var jsonOfObj1 = JsonSerializer.Serialize(obj1);
            var jsonOfObj2 = JsonSerializer.Serialize(obj2);

            if (string.Equals(jsonOfObj1, jsonOfObj2))
                return true;

            return false;
        }


        private static IEnumerable ReturnsCorrectStreamStatesCases()
        {

            yield return new TestCaseData(ArrOfCorrectUserNames(1), ArrOfCorrectEmptyStreamStates(1))
                .SetName("Pass usernames param as array of 1 correct username.");

            yield return new TestCaseData(ArrOfCorrectUserNames(10), ArrOfCorrectEmptyStreamStates(1))
                .SetName("Pass usernames param as array of 10 correct usernames.");
        }

        private static IEnumerable ReturnsThrowCases()
        {
            yield return new TestCaseData(null)
                .SetName("Pass usernames param as null.");

            yield return new TestCaseData(new string[] { })
                .SetName("Pass usernames param as empty array.");

            yield return new TestCaseData(new string[] { null })
                .SetName("Pass usernames param as array with nullable string.");

            yield return new TestCaseData(new string[] { "" })
                .SetName("Pass usernames param as array with empty string.");

            yield return new TestCaseData(new string[] { "   " })
                .SetName("Pass usernames param as array with whitespace string.");

            yield return new TestCaseData(new string[] { "username", "username" })
                .SetName("Pass usernames param as array with two equal strings.");

            yield return new TestCaseData(new string[] { "username", "userName" })
                .SetName("Pass usernames param as array with two equal strings in different registers.");

            yield return new TestCaseData(ArrOfCorrectUserNames(100))
                .SetName("Pass usernames param as array of 100 usernames.");
        }

        private static IEnumerable ArrOfCorrectUserNames(int count)
        {
            for (int i = 0; i < count; i++)
                yield return $"SomeUserName{i}";

            yield break;
        }

        private static IEnumerable ArrOfCorrectEmptyStreamStates(int count)
        {
            for (int i = 0; i < count; i++)
                yield return new StreamState($"SomeUserName{i}");

            yield break;
        }
    }
}
