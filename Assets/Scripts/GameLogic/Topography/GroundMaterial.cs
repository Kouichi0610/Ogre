using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.GameLogic.Topography
{
    [Serializable]
    public class GroundMaterial
    {
        [SerializeField, Tooltip("名称")]
        string name;
        [SerializeField, Tooltip("表面")]
        Material surface;
        [SerializeField, Tooltip("側面")]
        Material side;
        [SerializeField, Tooltip("滑りやすさ")]
        int slipperiness;
        [SerializeField, Tooltip("脆さ、崩れやすさ")]
        int brittleness;

        public Material Side => side;
        public Material Surface => surface;

        public override string ToString()
        {
            return name;
        }
    }
}
