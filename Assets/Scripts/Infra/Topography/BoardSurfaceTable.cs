using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ogre.GameLogic.Topography;

namespace Ogre.Infra.Topography
{
    /// <summary>
    /// マップ
    /// TODO:エディタ
    /// </summary>
    [CreateAssetMenu(fileName = "BoardSurfaceTable", menuName = "データ作成/BoardSurface"), Serializable]
    public class BoardSurfaceTable : ScriptableObject
    {
        [SerializeField]
        string description;

        [SerializeField, Tooltip("マップ素材情報")]
        TerrainMaterialTable materials;

        [SerializeField, Tooltip("フィールド幅")]
        int width;
        [SerializeField, Tooltip("フィールド奥行")]
        int height;

        [SerializeField, Tooltip("素材インデックス")]
        List<int> indices = new List<int>();
        [SerializeField, Tooltip("高さ(0.1ずつ)")]
        List<float> heights = new List<float>();

        public int Width => width;
        public int Height => height;

        public BoardSurface ToBoardSurface()
        {
            throw new System.NotSupportedException();
        }

        // TODO:元のフィールドを元にリサイズ
        public List<int> ResizedIndices(int w, int h)
        {
            return null;
        }
        public List<float> ResizedHeights(int w, int h)
        {
            return null;
        }
    }
}
