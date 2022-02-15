using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.GameLogic.Times
{
    /// <summary>
    /// リアルタイムからゲーム時間へ
    /// </summary>
    public class Duration
    {
        float realSeconds;  // TODO:structにしてreadonlyにするべきか
        readonly float minutePerSeconds;
        public float RealSeconds => realSeconds;

        public Duration(float minutePerSeconds)
        {
            this.minutePerSeconds = minutePerSeconds;
            realSeconds = 0;
        }

        Duration(float minutePerSeconds, float realSeconds)
        {
            this.minutePerSeconds = minutePerSeconds;
            this.realSeconds = realSeconds;
        }

        public void Progress(DeltaTime deltatime)
        {
            realSeconds += deltatime.Time;
        }
        public Minute ToMinute()
        {
            var minute = (int)(realSeconds / minutePerSeconds);
            return new Minute(minute);
        }

        public (Minute, Duration) Overflow(Minute current)
        {
            var (add, d) = Overflow();
            return (new Minute(current.Value + add.Value), d);
        }

        public (Minute, Duration) Overflow()
        {
            var minute = ToMinute();
            var d = realSeconds - minute.Value * minutePerSeconds;
            return (minute, new Duration(minutePerSeconds, d));
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Duration)) return false;
            return GetHashCode() == obj.GetHashCode();
        }
        public override int GetHashCode()
        {
            return new { minutePerSeconds, realSeconds }.GetHashCode();
        }
    }
}
