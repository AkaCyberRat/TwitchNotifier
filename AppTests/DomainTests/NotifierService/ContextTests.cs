using Domain.Services.NotifierService;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace UnitTests.DomainTests.NotifierService
{
    [TestFixture]
    internal class ContextTests
    {

        [TestCaseSource(nameof(ReturnsObjectCases))]
        public void ConstructorInvoke_ReturnsObject(object parmsObj)
        {
            var parms = parmsObj as object[];

            Assert.DoesNotThrow(() => new Context((StreamEvent)parms[0],
                                                    (StreamState)parms[1],
                                                    (StreamMetrics)parms[2]));
        }


        [TestCaseSource(nameof(ReturnsThrowCases))]
        public void ConstructorInvoke_ReturnsThrow(object parmsObj)
        {
            var parms = parmsObj as object[];

            Assert.Throws<ArgumentNullException>(() => new Context((StreamEvent)parms[0],
                                                    (StreamState)parms[1],
                                                    (StreamMetrics)parms[2]));
        }


        private static IEnumerable ReturnsObjectCases
        {
            get
            {
                yield return new TestCaseData(new object[] {
                        StreamEvent.StreamStart,
                        new StreamState("userName"),
                        null
                    } as object)
                    .SetName("Correct params: StreamEvent, StreamState, null(StreamMetrics).");

                yield return new TestCaseData(new object[] {
                        StreamEvent.StreamStart,
                        new StreamState("userName"),
                        new StreamMetrics(
                            new Dictionary<DateTime,int>().ToImmutableDictionary(),
                            new Dictionary<DateTime,string>().ToImmutableDictionary(),
                            new Dictionary<DateTime,string>().ToImmutableDictionary())
                    } as object)
                    .SetName("Correct params: StreamEvent, StreamState, StreamMetrics.");
            }
        }

        private static IEnumerable ReturnsThrowCases
        {
            get
            {
                yield return new TestCaseData(new object[] {
                        StreamEvent.StreamStart,
                        null,
                        null
                    } as object)
                    .SetName("Uncorrect params: StreamState(null).");

                yield return new TestCaseData(new object[] {
                        StreamEvent.StreamStart,
                        null,
                        new StreamMetrics(
                            new Dictionary<DateTime,int>().ToImmutableDictionary(),
                            new Dictionary<DateTime,string>().ToImmutableDictionary(),
                            new Dictionary<DateTime,string>().ToImmutableDictionary())
                    } as object)
                    .SetName("Uncorrect params: StreamState(null).");
            }
        }

    }
}
