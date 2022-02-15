using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.GameLogic.Times
{
    /// <summary>
    /// TODO:倍速対応(コンストラクタではなくFactory経由で)
    /// </summary>
    public class DeltaTime
    {
        public readonly float Time;

        public static DeltaTime FromRealTime()
        {
            return new DeltaTime(UnityEngine.Time.deltaTime);
        }
        public static DeltaTime FromSeconds(float second)
        {
            return new DeltaTime(second);
        }

        private DeltaTime(float time)
        {
            Time = time;
        }
    }
}
