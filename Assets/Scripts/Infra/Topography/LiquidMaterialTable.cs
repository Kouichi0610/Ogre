using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ogre.GameLogic.Topography;

namespace Ogre.Infra.Topography
{
    [CreateAssetMenu(fileName = "LiquidMaterials", menuName = "データ作成/LiquidMaterials")]
    public class LiquidMaterialTable : ScriptableObject
    {
        [SerializeField]
        List<LiquidMaterial> materials;
    }
}
