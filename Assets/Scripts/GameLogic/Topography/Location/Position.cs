using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.GameLogic.Topography.Location
{
    public class Position
    {
        // 進入禁止
        public static readonly Position NoEntry = new Position(-1, -1);

        public readonly int X;
        public readonly int Y;

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Position)) return false;
            return GetHashCode() == obj.GetHashCode();
        }
        public override int GetHashCode()
        {
            return new { X, Y }.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("Position X:{0} Y:{1}", X, Y);
        }
    }
}
