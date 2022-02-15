using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.SandBox
{
    /// <summary>
    /// マップ表示試作
    /// 
    /// TODO:シェーダによる縁取り
    /// </summary>
    public class MapLoader : MonoBehaviour
    {
        [SerializeField]
        GameObject cube;
        void Start()
        {
            const int w = 100;
            const int h = 100;

            var ax = -w / 2;
            var ay = -h / 2;

            var t = transform;
            for (var i = 0; i < h; i++)
            {
                for (var j = 0; j < w; j++)
                {
                    var add = i % 2 == 0 ? 0 : 0.5f;
                    float x = j + add + ax;
                    float y = i + ay;

                    var scale = Mathf.Deg2Rad * (i+j) * j + 1;
                    var v = new Vector3(x, 0, y);
                    var o = Instantiate(cube, v, Quaternion.identity, t);
                    o.transform.localScale = new Vector3(1, scale, 1);
                }
            }

        }
    }
}
