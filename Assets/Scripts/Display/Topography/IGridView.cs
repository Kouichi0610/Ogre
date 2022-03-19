using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ogre.GameLogic.Topography.Location;

namespace Ogre.Display.Topography
{
    public class GridViewerTmp
    {
        // Grids[][]
    }

    /// <summary>
    /// ・Mesh作る
    /// ・高さは変動する
    /// 
    /// </summary>
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
