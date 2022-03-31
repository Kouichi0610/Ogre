using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.GameLogic.Topography
{
    public interface IGroundRenderer
    {
        void Clear();
        void Render(int x, int z, float bottom, float top, GroundMaterial material);
    }
}
