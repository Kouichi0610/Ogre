using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ogre.GameLogic.Topography;

namespace Ogre.Display.Topography
{
    /// <summary>
    /// 
    /// </summary>
    public class BoardSurfaceRenderer : MonoBehaviour
    {
#if false
        BoardSurface board;

        public static BoardSurfaceRenderer Instantiate(Transform root, BoardSurface board)
        {
            var go = new GameObject(typeof(BoardSurfaceRenderer).Name);

            var res = go.AddComponent<BoardSurfaceRenderer>();
            res.Initialize(null);
            return res;
        }
        void Initialize(BoardSurface board)
        {
            this.board = board;
        }
#endif
    }
}
