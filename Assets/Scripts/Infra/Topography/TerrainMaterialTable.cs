using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ogre.GameLogic.Topography;

namespace Ogre.Infra.Topography
{
    [CreateAssetMenu(fileName = "TerrainMaterials", menuName = "データ作成/TerrainMaterials")]
    public class TerrainMaterialTable : ScriptableObject
    {
        [SerializeField]
        List<TerrainMaterial> terrains;

        public int Length => terrains.Count;

        public TerrainMaterial Terrain(int id)
        {
            return terrains[id];
        }
    }
}
