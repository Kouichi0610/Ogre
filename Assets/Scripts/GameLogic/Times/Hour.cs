using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.GameLogic.Times
{
    public struct Hour
    {
        readonly int hour;

        public int Value => hour;

        public Hour(int hour)
        {
            this.hour = hour;
        }

        public (Day, Hour) Overflow(Day current)
        {
            var (add, hour) = Overflow();
            return (new Day(current.Value + add.Value), hour);
        }

        public (Day, Hour) Overflow()
        {
            var d = hour / 24;
            var h = hour % 24;

            return (new Day(d), new Hour(h));
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Hour)) return false;
            return GetHashCode() == obj.GetHashCode();
        }
        public override int GetHashCode()
        {
            return hour;
        }
        public override string ToString()
        {
            return hour.ToString();
        }
    }
}
