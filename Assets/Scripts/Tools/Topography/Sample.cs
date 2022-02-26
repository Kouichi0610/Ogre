using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using UniRx;
using UnityEditor;
using Ogre.Infra.Topography;

namespace Ogre.Tools.Topography
{
    public class Sample : MonoBehaviour
    {
        [SerializeField]
        Button button;
        [SerializeField]
        BoardSurfaceTable table;

        void Start()
        {
            button.OnClickAsObservable().Subscribe(_ =>
            {
                Debug.Log("AAAA");
                table.Resize(5, 15);
            }).AddTo(this);
        }
    }
}
