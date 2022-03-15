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

        [SerializeField, Tooltip("移動コスト"), Range(1, 10)]
        int moveCost;

        // TODO:性質と見た目分ける？(テストコードは性質のみ)
        // nature 性質
        // looks 見た目、外見
        // INature, ILooks

        public override string ToString()
        {
            return name;
        }
    }
}
