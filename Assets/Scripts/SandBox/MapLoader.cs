using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Ogre.Display.Topography;

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
        GridRenderer grid;

        [SerializeField]
        GameObject cube;
        void Start()
        {
            StartCoroutine(SampleCoroutine());
#if false
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
#endif
        }

        IEnumerator SampleCoroutine()
        {
            var h = 0.0f;
            grid.Height(h);
            while (true)
            {
                yield return new WaitForSeconds(0.1f);
                h += 0.1f;
                if (h >= 10)
                {
                    h = 0;
                }
                grid.Height(h);
            }
        }
    }
}
