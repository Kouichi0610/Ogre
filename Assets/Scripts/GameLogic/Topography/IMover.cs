using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.GameLogic.Topography
{
    /// <summary>
    /// 移動先
    /// </summary>
    public interface IMover
    {
        Position From(Position from);
    }
}
