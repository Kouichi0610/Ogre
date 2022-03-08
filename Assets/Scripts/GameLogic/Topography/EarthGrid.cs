using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.GameLogic.Topography
{
    /// <summary>
    /// 地表マス
    /// </summary>
    public class EarthGrid
    {
        EarthMaterial material;
        float height;

        public override string ToString()
        {
            return string.Format("[{0}:{1}]", material, height);
        }
    }
}
