using HolidayFrom91;
using NUnit.Framework;
using System;

namespace HolidayUnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        private HolidayForTest _holiday;

        [SetUp]
        public void SetUp()
        {
            _holiday = new HolidayForTest();
        }

        [Test]
        public void today_is_xmas()
        {
            var holiday = new HolidayForTest();
            holiday.Today = new DateTime(2020, 12, 25);
            Assert.AreEqual("Merry Xmas", holiday.SayHello());
        }

    }

    public class HolidayForTest : Holiday
    {
        private DateTime _today;

        public DateTime Today
        {
            set => _today = value;
        }

        protected override DateTime GetToday()
        {
            return _today;
        }
    }
}