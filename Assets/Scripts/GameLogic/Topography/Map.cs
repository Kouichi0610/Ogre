using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.GameLogic.Topography
{
    /// <summary>
    /// �E���n
    /// �E�ܑ����H
    /// �E�R�x
    /// �E�X
    /// �E�͐�
    /// 
    /// �E�ړ����x�d��
    /// �E�B�����d��
    /// �E��P�d���i�H�j
    /// 
    /// TODO:Hex, Viewer
    /// </summary>
    public class Map
    {
        // terrain[][]
    }

    public interface IRouter
    {
        // �ړ����
        int[] Route(int from, int to, Map map);
    }
}
