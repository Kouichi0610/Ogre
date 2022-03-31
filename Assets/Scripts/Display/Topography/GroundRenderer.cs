using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ogre.GameLogic.Topography;

namespace Ogre.Display.Topography
{
    /// <summary>
    /// Stage描画
    /// </summary>
    public class GroundRenderer : MonoBehaviour, IGroundRenderer
    {
        [SerializeField]
        GridRenderer prefab;

        void IGroundRenderer.Clear()
        {
        }

        void IGroundRenderer.Render(int x, int z, float bottom, float top, GroundMaterial material)
        {
            var g = GridRenderer.Instantiate(prefab, transform, x, z, bottom, top, material);
            g.name = string.Format("Grid_{0}_{1}", x, z);
        }
    }
}
