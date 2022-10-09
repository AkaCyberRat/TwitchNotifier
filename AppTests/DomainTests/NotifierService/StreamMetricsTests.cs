using Domain.Services.NotifierService;
using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace UnitTests.DomainTests.NotifierService
{
    [TestFixture]
    public class StreamMetricsTests
    {
        [TestCaseSource(nameof(ReturnObjectCase))]
        public void ConstructorInvoke_ReturnsObject(object parmsObj)
        {
            var parms = parmsObj as object[];
            Assert.DoesNotThrow(() => new StreamMetrics((IReadOnlyDictionary<DateTime, int>)parms[0],
                                                        (IReadOnlyDictionary<DateTime, string>)parms[1],
                                                        (IReadOnlyDictionary<DateTime, string>)parms[2]));
        }

        [TestCaseSource(nameof(ReturnThrowCase))]
        public void ConstructorInvoke_ReturnsThrow(object parmsObj)
        {
            var parms = parmsObj as object[];
            Assert.Throws<ArgumentNullException>(() => new StreamMetrics((IReadOnlyDictionary<DateTime, int>)parms[0],
                                                                         (IReadOnlyDictionary<DateTime, string>)parms[1],
                                                                         (IReadOnlyDictionary<DateTime, string>)parms[2]));
        }


        private static IEnumerable ReturnObjectCase
        {
            get
            {
                yield return new TestCaseData(new object[]
                    {
                        new Dictionary<DateTime, int>().ToImmutableDictionary(),
                        new Dictionary<DateTime, string>().ToImmutableDictionary(),
                        new Dictionary<DateTime, string>().ToImmutableDictionary(),
                    } as object)
                    .SetName("All params correct.");
            }
        }

        private static IEnumerable ReturnThrowCase
        {
            get
            {
                yield return new TestCaseData(new object[]
                    {
                        null,
                        new Dictionary<DateTime, string>().ToImmutableDictionary(),
                        new Dictionary<DateTime, string>().ToImmutableDictionary(),
                    } as object)
                    .SetName("Viewers param incorrect.");

                yield return new TestCaseData(new object[]
                    {
                        new Dictionary<DateTime, int>().ToImmutableDictionary(),
                        null,
                        new Dictionary<DateTime, string>().ToImmutableDictionary(),
                    } as object)
                    .SetName("Titles param incorrect.");

                yield return new TestCaseData(new object[]
                    {
                        new Dictionary<DateTime, int>().ToImmutableDictionary(),
                        new Dictionary<DateTime, string>().ToImmutableDictionary(),
                        null,
                    } as object)
                    .SetName("Categories param incorrect.");
            }
        }
    }
}
