using Microsoft.Extensions.Time.Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsingTime;

namespace UsingTimeTests
{
    public class FakeTimeOfDayServiceTests
    {
        private TimeOfDayService _timeOfDayService;
        private FakeTimeProvider _fakeTimeProvider;

        public FakeTimeOfDayServiceTests()
        {
            _fakeTimeProvider = new FakeTimeProvider();
            _timeOfDayService = new TimeOfDayService(_fakeTimeProvider);
        }

        [Fact]
        public void TimeOfDay_ShouldReturnMorning_WhenItsMorning()
        {
            _fakeTimeProvider.SetUtcNow(new DateTime(2023, 12, 1, 8, 0, 0));
            _timeOfDayService = new TimeOfDayService(_fakeTimeProvider);

            var v = _timeOfDayService.GetTimeOfDay();
            Assert.Equal("Morning", v);

        }
    }
}
