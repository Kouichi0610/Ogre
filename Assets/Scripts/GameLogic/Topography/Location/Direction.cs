using Ogre.GameLogic.Enums;
using System;
using System.Collections.Generic;

namespace Ogre.GameLogic.Topography.Location
{
    public abstract class Direction : Enumeration, IMover
    {
        public static readonly Direction One = new OneOclock();
        public static readonly Direction Three = new ThreeOclock();
        public static readonly Direction Five = new FiveOclock();
        public static readonly Direction Seven = new SevenOclock();
        public static readonly Direction Nine = new NineOclock();
        public static readonly Direction Eleven = new ElevenOclock();

        public static IEnumerable<IMover> GetAll()
        {
            return GetAll<Direction>();
        }

        private Direction(int id, string name) : base(id, name) { }


        public abstract Position From(Position from);

        private class OneOclock : Direction
        {
            public OneOclock() : base(1, "1") { }
            public override Position From(Position from)
            {
                if (from.Y % 2 == 0) return new Position(from.X, from.Y + 1);
                return new Position(from.X + 1, from.Y + 1);
            }
        }
        private class ThreeOclock : Direction
        {
            public ThreeOclock() : base(2, "3") { }
            public override Position From(Position from)
            {
                return new Position(from.X + 1, from.Y);
            }
        }
        private class FiveOclock : Direction
        {
            public FiveOclock() : base(3, "5") { }
            public override Position From(Position from)
            {
                if (from.Y % 2 == 0) return new Position(from.X, from.Y - 1);
                return new Position(from.X + 1, from.Y - 1);
            }
        }
        private class SevenOclock : Direction
        {
            public SevenOclock() : base(4, "7") { }
            public override Position From(Position from)
            {
                if (from.Y % 2 == 0) return new Position(from.X - 1, from.Y - 1);
                return new Position(from.X, from.Y - 1);
            }
        }
        private class NineOclock : Direction
        {
            public NineOclock() : base(5, "9") { }
            public override Position From(Position from)
            {
                return new Position(from.X - 1, from.Y);
            }
        }
        private class ElevenOclock : Direction
        {
            public ElevenOclock() : base(6, "11") { }
            public override Position From(Position from)
            {
                if (from.Y % 2 == 0) return new Position(from.X - 1, from.Y + 1);
                return new Position(from.X, from.Y + 1);
            }
        }

        public override string ToString()
        {
            return string.Format("{0}時方向", Name);
        }
    }
}
