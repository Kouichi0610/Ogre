using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.GameLogic.Topography
{
    /// <summary>
    /// 地形の性質
    /// 名称
    /// テクスチャ
    /// 移動種別(平地、森、水)ごとの移動力
    /// 
    /// 
    /// ・移動力
    /// ・隠れやすさ
    /// ・性質
    /// 
    /// ・＋高さ
    /// </summary>
    [Serializable]
    public class TerrainMaterial
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
