using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.GameLogic.Topography
{
    /// <summary>
    /// 地表性質
    /// 
    /// 
    /// </summary>
    [Serializable]
    public class EarthMaterial
    {
        [SerializeField]
        string name;
        [SerializeField]
        Texture2D texture;

        public override string ToString()
        {
            return name;
        }
    }
}
