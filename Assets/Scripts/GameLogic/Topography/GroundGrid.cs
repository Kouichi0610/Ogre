using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.GameLogic.Topography
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]    
    public class GroundGrid
    {
        [SerializeField]
        TerrainMaterial terrain;
        [SerializeField]
        float height;

        public GroundGrid(TerrainMaterial terrain, float height)
        {
            this.terrain = terrain;
            this.height = height;
        }

        public override string ToString()
        {
            return string.Format("[{0}{1]]", terrain.ToString(), height);
        }
    }
}
