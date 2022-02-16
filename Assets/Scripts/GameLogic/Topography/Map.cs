using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.GameLogic.Topography
{
    /// <summary>
    /// ・平地
    /// ・舗装道路
    /// ・山岳
    /// ・森
    /// ・河川
    /// 
    /// ・移動速度重視
    /// ・隠密性重視
    /// ・奇襲重視（？）
    /// 
    /// TODO:Hex, Viewer
    /// </summary>
    public class Map
    {
        // terrain[][]
    }

    public interface IRouter
    {
        // 移動種類
        int[] Route(int from, int to, Map map);
    }
}
