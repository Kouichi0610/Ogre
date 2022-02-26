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

        [Serializable]
        public class Info
        {
            public int index = 0;
            public float height = 0;
        }

        [SerializeField]
        int width;
        [SerializeField]
        int height;

        [SerializeField]
        List<Info> infos = new List<Info>();



        public bool Empty => infos.Count == 0;

        public void Resize(int w, int h)
        {
            width = w;
            height = h;
            infos = new List<Info>();
            for (int i = 0; i < w*h; i++)
            {
                infos.Add(new Info());
            }
        }

    }
}
