using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.GameLogic.Times
{
    /// <summary>
    /// 分
    /// </summary>
    public struct Minute
    {
        readonly int minute;

        public int Value => minute;

        public Minute(int minute)
        {
            this.minute = minute;
        }

        public (Hour, Minute) Overflow(Hour current)
        {
            var (add, minute) = Overflow();
            return (new Hour(current.Value + add.Value), minute);
        }

        public (Hour, Minute) Overflow()
        {
            var h = minute / 60;
            var m = minute % 60;

            return (new Hour(h), new Minute(m));
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Minute)) return false;
            return GetHashCode() == obj.GetHashCode();
        }

        public override int GetHashCode()
        {
            return minute;
        }

        public override string ToString()
        {
            return minute.ToString();
        }
    }
}
