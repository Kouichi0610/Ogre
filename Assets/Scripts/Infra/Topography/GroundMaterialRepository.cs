using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ogre.GameLogic.Topography;

namespace Ogre.Infra.Topography
{
    [CreateAssetMenu(fileName = "GroundMaterials", menuName = "地形/GroundMaterials", order = 101)]
    public class GroundMaterialRepository : ScriptableObject, IGroundMaterialRepository
    {
        [SerializeField]
        List<GroundMaterial> materials;


        GroundMaterial IGroundMaterialRepository.Get(short index)
        {
            return materials[index];
        }
    }
}
