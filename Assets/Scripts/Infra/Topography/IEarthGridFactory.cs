using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ogre.GameLogic.Topography;

namespace Ogre.Infra.Topography
{
    public interface IEarthGridFactory
    {
        EarthGrid Create(short index, short height);
    }
}
