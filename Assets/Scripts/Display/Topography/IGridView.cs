using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ogre.GameLogic.Topography;

namespace Ogre.Display.Topography
{
    public interface IGridView
    {
        // fixed
        Material Surface { get; }
        Material Side { get; }

        // flex
        Height Height { get; }
        // bottom -> top
    }

    public interface IMeshMaker
    {
        // Material(s)とindex固定
        // -> Height可変

    }

    public interface IGridRenderer
    {
        void Render(IGridView[][] grids);
    }
}
