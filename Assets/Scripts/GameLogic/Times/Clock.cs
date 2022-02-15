using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.GameLogic.Times
{
    /// <summary>
    /// �Q�[�����̎���
    /// 
    /// �E�o�ߎ���
    /// �E�c�莞��
    /// �E���ݎ���
    /// 
    /// 
    /// TODO:�Q�[���i�s���x
    /// </summary>
    public class Clock
    {
        public int Hour => hour.Value;
        public int Minute => minute.Value;

        public int Day => day.Value;

        Day day;
        Hour hour;
        Minute minute;
        Duration duration;

        public Clock(int day, int hour, int minute, Duration duration)
        {
            this.day = new Day(day);
            this.hour = new Hour(hour);
            this.minute = new Minute(minute);
            this.duration = duration;
        }
        public void Progress(DeltaTime deltatime)
        {
            duration.Progress(deltatime);
            (minute, duration) = duration.Overflow(minute);
            (hour, minute) = minute.Overflow(hour);
            (day, hour) = hour.Overflow(day);
        }

        public override string ToString()
        {
            return string.Format("{0}Days {1}:{2}", Day, Hour.ToString("00"), Minute.ToString("00"));
        }
    }
}
