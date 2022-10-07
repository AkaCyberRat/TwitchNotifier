using App.Domain.NotifierService.Models;
using NUnit.Framework;
using System;
using System.Collections;

namespace AppTests.ModelTests
{
    [TestFixture]
    public class StreamStateTests
    {

        [TestCaseSource(nameof(ReturnsObjectCases))]
        public void InvokeConstructor_ReturnsObject(object parmsObj)
        {
            var parms = parmsObj as object[];
            if (parms.Length > 1)
            {
                Assert.DoesNotThrow(() => new StreamState(
                    (string)parms[0], (string)parms[1],
                    (string)parms[2], (string)parms[3],
                    (string)parms[4], (string)parms[5],
                    (string[])parms[6], (string)parms[7],
                    (int)parms[8], (DateTime)parms[9]));
            }
            else
            {
                Assert.DoesNotThrow(() => new StreamState((string)parms[0]));
            }
        }

        [TestCaseSource(nameof(ReturnsThrowCases))]
        public void InvokeConstructor_ReturnsThrow(object parmsObj)
        {
            var parms = parmsObj as object[];
            if (parms.Length > 1)
            {
                Assert.Throws<ArgumentException>(() => new StreamState(
                    (string)parms[0], (string)parms[1],
                    (string)parms[2], (string)parms[3],
                    (string)parms[4], (string)parms[5],
                    (string[])parms[6], (string)parms[7],
                    (int)parms[8], (DateTime)parms[9]));
            }
            else
            {
                Assert.Throws<ArgumentException>(() => new StreamState((string)parms[0]));
            }
        }


        private static IEnumerable ReturnsObjectCases
        {
            get
            {
                yield return new TestCaseData(new object[]
                    {
                        "userName",
                        "userId",
                        "gameId",
                        "gameName",
                        "title",
                        "thumbnailUrl",
                        new string[] {"tagIds"},
                        "type",
                        10,
                        new DateTime(2022,10,7)
                    } as object)
                    .SetName("Long constructor params is correct.");

                yield return new TestCaseData(new object[]
                    {
                        "Recrent",
                        "0000000",
                        "0000000",
                        "PUBG: BATTLEGROUNDS",
                        "КУСКУТЕ",
                        "https://thumbnailUrl",
                        new string[]{ "123" },
                        "live",
                        5543,
                        new DateTime(2022,10,7)
                    } as object)
                    .SetName("Long constructor with another params is correct.");

                yield return new TestCaseData(new object[]
                    {
                        "userName"
                    } as object)
                    .SetName("Short constructor params is correct.");

                yield return new TestCaseData(new object[]
                    {
                        "Recrent"
                    } as object)
                    .SetName("Short constructor with another params is correct.");
            }
        }

        private static IEnumerable ReturnsThrowCases
        {
            get
            {
                yield return new TestCaseData(new object[]
                   {
                        "",
                        "",
                        "",
                        "",
                        "",
                        "",
                        new string[] { },
                        "",
                        10,
                        new DateTime(2022,10,7)
                   } as object)
                   .SetName("Long constructor strings params is whitespace.");

                yield return new TestCaseData(new object[]
               {
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        null,
                        10,
                        new DateTime(2022,10,7)
               } as object)
               .SetName("Long constructor all link params is null.");

                yield return new TestCaseData(new object[]
                    {
                        ""
                    } as object)
                    .SetName("Short constructor username is whitespace.");

                yield return new TestCaseData(new object[]
                    {
                        null
                    } as object)
                    .SetName("Short constructor username is null.");
            }
        }
    }
}
