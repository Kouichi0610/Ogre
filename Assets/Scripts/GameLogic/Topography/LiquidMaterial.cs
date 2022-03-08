using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.GameLogic.Topography
{
    /// <summary>
    /// 流体の性質
    /// (水、溶岩など)
    /// </summary>
    [Serializable]
    public class LiquidMaterial
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
