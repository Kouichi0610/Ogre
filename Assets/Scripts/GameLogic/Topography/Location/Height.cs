
namespace Ogre.GameLogic.Topography.Location
{
    /// <summary>
    /// 高さ
    /// 0.1m単位
    /// </summary>
    public struct Height
    {
        short height;
        public float ToFloat => height / 10f;

        public Height(short height)
        {
            this.height = height;
            if (this.height < 0)
            {
                this.height = 0;
            }
        }

        public static Height operator ++(Height a)
        {
            return a + new Height(1);
        }
        public static Height operator --(Height a)
        {
            return a - new Height(1);
        }

        public static Height operator +(Height a, Height b)
        {
            var res = a.height + b.height;
            if (res > short.MaxValue) res = short.MaxValue;
            return new Height((short)res);
        }
        public static Height operator -(Height a, Height b)
        {
            var s = (short)(a.height - b.height);
            return new Height(s);
        }

        public static bool operator ==(Height a, Height b)
        {
            return a.height == b.height;
        }
        public static bool operator !=(Height a, Height b)
        {
            return a.height != b.height;
        }

        public static bool operator >(Height a, Height b)
        {
            return a.height > b.height;
        }
        public static bool operator <(Height a, Height b)
        {
            return a.height < b.height;
        }
        public static bool operator >=(Height a, Height b)
        {
            return a.height >= b.height;
        }
        public static bool operator <=(Height a, Height b)
        {
            return a.height <= b.height;
        }

        public override string ToString()
        {
            return string.Format("Height:{0}", ToFloat);
        }
    }
}
