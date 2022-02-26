using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.GameLogic.Topography
{

    public class RequidMaterial
    {

    }
    /// <summary>
    /// 盤面
    /// </summary>
    public class BoardSurface
    {
        List<List<GroundGrid>> terrains;

        public int Width => terrains[0].Count;
        public int Height => terrains.Count;

        public override string ToString()
        {
            var res = new System.Text.StringBuilder();
            res.AppendFormat("BoardSurface Width:{0} Height{1}", Width, Height);

            return res.ToString();
        }
    }
}
