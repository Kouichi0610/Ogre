using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.SandBox
{
    /// <summary>
    /// TODO:Mesh作成Map分
    /// ・テクスチャ
    /// ・シェーダによる縁取り
    /// </summary>
    public class CubeRenderer : MonoBehaviour
    {
        void Start()
        {
            float height = 10.0f;
            // 頂点リストを作成
            List<Vector3> vertices = new List<Vector3>
            {
                new Vector3(1.0f, height, 1.0f),
                new Vector3(-1.0f, height, 1.0f),
                new Vector3(-1.0f, -1.0f, 1.0f),
                new Vector3(1.0f, -1.0f, 1.0f),
                new Vector3(1.0f, -1.0f, -1.0f),
                new Vector3(-1.0f, -1.0f, -1.0f),
                new Vector3(-1.0f, height, -1.0f),
                new Vector3(1.0f, height, -1.0f),
            };

            // 面を構成するインデックスリストを作成
            List<int> triangles = new List<int> {
                0, 1, 2,  // 奥面
                0, 2, 3,  // 奥面
                4, 5, 6,  // 前面
                4, 6, 7,  // 前面
                0, 4, 7,  // 右面
                0, 3, 4,  // 右面
                6, 2, 1,  // 左面
                6, 5, 2,  // 左面
                6, 1, 0,  // 上面
                7, 6, 0,  // 上面
                4, 3, 2,  // 下面
                5, 4, 2,  // 下面
            };

            var meshFilter = gameObject.GetComponent<MeshFilter>();

            var mesh = new Mesh();
            mesh.SetVertices(vertices);
            mesh.SetTriangles(triangles, 0);

            meshFilter.mesh = mesh;

        }

        void Update()
        {

        }
    }
}

