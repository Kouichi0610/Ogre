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
        Height height;

        public EarthGrid(EarthMaterial material, Height height)
        {
            this.material = material;
            this.height = height;
        }

        public override string ToString()
        {
            return string.Format("[{0}:{1}]", material, height);
        }
    }
}
