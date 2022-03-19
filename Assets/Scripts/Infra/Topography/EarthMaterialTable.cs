using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ogre.GameLogic.Topography;
using Ogre.GameLogic.Topography.Location;

namespace Ogre.Infra.Topography
{
    [CreateAssetMenu(fileName = "EarthMaterials", menuName = "データ作成/EarthMaterials")]
    public class EarthMaterialTable : ScriptableObject, IEarthGridFactory
    {
        [SerializeField]
        List<EarthMaterial> materials;

        EarthGrid IEarthGridFactory.Create(short index, short height)
        {
            var m = materials[index];
            var h = new Height(height);
            return new EarthGrid(m, h);
        }
    }
}
