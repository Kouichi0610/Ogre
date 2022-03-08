using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ogre.GameLogic.Topography;

namespace Ogre.Infra.Topography
{
    [CreateAssetMenu(fileName = "EarthMaterials", menuName = "データ作成/EarthMaterials")]
    public class EarthMaterialTable : ScriptableObject
    {
        [SerializeField]
        List<EarthMaterial> materials;
    }
}
