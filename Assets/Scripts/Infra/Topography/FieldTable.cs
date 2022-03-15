using System;
using System.Collections;
using System.Collections.Generic;
using Ogre.GameLogic.Topography;
using UnityEngine;

namespace Ogre.Infra.Topography
{

    /// <summary>
    /// Earth
    /// Liquid
    /// Architecture
    /// </summary>
    [CreateAssetMenu(fileName = "FieldTable", menuName = "データ作成/フィールド"), Serializable]
    public class FieldTable : ScriptableObject
    {
        [SerializeField]
        EarthMaterialTable earthMaterialTable;

        [SerializeField]
        int width;
        [SerializeField]
        int height;

        [SerializeField]
        EarthTable[] earthGrids;

        public Field ToField()
        {
            throw new NotSupportedException("未実装");
        }

        [Serializable]
        struct EarthTable
        {
            [SerializeField]
            short materialIndex;
            [SerializeField]
            short height;
        }

    }
}
