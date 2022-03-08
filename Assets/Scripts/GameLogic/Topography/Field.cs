using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.GameLogic.Topography
{
    /// <summary>
    /// todo:バイナリ形式？
    /// todo:grid容量削減
    /// </summary>
    [Serializable]
    public class Field
    {
        int width;
        int height;
        GroundGrid[] grids;


    }
}
