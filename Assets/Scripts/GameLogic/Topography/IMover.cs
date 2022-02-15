using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.GameLogic.Topography
{
    public interface IMover
    {
        Position From(Position from);
    }
}
