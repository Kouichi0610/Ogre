using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Ogre.GameLogic.Times;

namespace Tests.GameLogic.Times
{
    /// <summary>
    /// ・時刻
    /// ・日数
    /// ・時
    /// ・分
    /// ・
    /// </summary>
    public class TimesTest
    {
        [Test]
        public void Duration()
        {
            var d = new Duration(10);   // 10秒で1分進む
            d.Progress(DeltaTime.FromSeconds(10.5f));

            Assert.That(d.ToMinute, Is.EqualTo(new Minute(1)));

            var (m, next) = d.Overflow();

            Assert.That(m, Is.EqualTo(new Minute(1)));
            Assert.That(next.RealSeconds, Is.EqualTo(0.5f));
        }
        [Test]
        public void Minute()
        {
            var m = new Minute(70);

            var (h, next) = m.Overflow();
            Assert.That(h, Is.EqualTo(new Hour(1)));
            Assert.That(next, Is.EqualTo(new Minute(10)));
        }
        [Test]
        public void Hour()
        {
            var h = new Hour(50);
            var (d, next) = h.Overflow();
            Assert.That(d, Is.EqualTo(new Day(2)));
            Assert.That(next, Is.EqualTo(new Hour(2)));
        }

        [Test]
        public void Clock()
        {
            var c = new Clock(1, 23, 30, new Duration(10));
            Assert.That(c.ToString(), Is.EqualTo("1Days 23:30"));
            c.Progress(DeltaTime.FromSeconds(15 * 10));
            Assert.That(c.ToString(), Is.EqualTo("1Days 23:45"));
            c.Progress(DeltaTime.FromSeconds(16 * 10));
            Assert.That(c.ToString(), Is.EqualTo("2Days 00:01"));
        }
    }
}
