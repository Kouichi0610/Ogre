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
                var so = new SerializedObject(table);

                var w = 15;
                var h = 3;
                so.FindProperty("width").intValue = w;
                so.FindProperty("height").intValue = h;

                var indices = so.FindProperty("indices");
                indices.arraySize = w * h;
                indices.GetArrayElementAtIndex(3).intValue = 18;
                so.ApplyModifiedProperties();
                so.Update();

            }).AddTo(this);
        }
    }
}
