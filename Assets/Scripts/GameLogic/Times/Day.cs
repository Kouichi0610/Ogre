using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.GameLogic.Times
{
    public struct Day
    {
        int day;
        public int Value => day;

        public Day(int day)
        {
            this.day = day;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Day)) return false;
            return GetHashCode() == obj.GetHashCode();
        }
        public override int GetHashCode()
        {
            return day;
        }
        public override string ToString()
        {
            return day.ToString();
        }
    }
}
