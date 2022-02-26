using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.Display.Topography
{
    /// <summary>
    /// TODO:
    /// ・テクスチャちゃんとする
    /// 　Vert別々に分けたほうが良いかも
    /// ・シェーダ縁取り、効果
    /// 　マテリアル複数設定？
    /// 
    /// 
    /// </summary>
    public class GridRenderer : MonoBehaviour
    {
        [SerializeField]
        MeshFilter meshFilter;
        [SerializeField]
        MeshRenderer meshRenderer;

        [SerializeField]
        Material surface;
        [SerializeField]
        Material sideMaterial;

        // Type, x, z, Height

        private void Start()
        {
            //Height(2.5f);
        }
        public void Height(float height)
        {
            List<Vector3> vertices = new List<Vector3>
            {
                new Vector3(-0.5f, height, -0.5f),
                new Vector3(0.5f, height, -0.5f),
                new Vector3(0.5f, height, 0.5f),
                new Vector3(-0.5f, height, 0.5f),

                new Vector3(-0.5f, 0, -0.5f),
                new Vector3(0.5f, 0, -0.5f),
                new Vector3(0.5f, 0, 0.5f),
                new Vector3(-0.5f, 0, 0.5f),
            };
            // 右回り
            List<int> triangles = new List<int>
            {
                0, 2, 1,
                3, 2, 0,    // top

                0, 1, 4,
                5, 4, 1,    // front

                2, 3, 6,
                7, 6, 3,    // back

                3, 0, 7,
                4, 7, 0,    // left

                1, 2, 5,
                6, 5, 2,    // right
            };

            List<Vector2> uvs = new List<Vector2>
            {
                new Vector2(0, 0),
                new Vector2(1, 0),
                new Vector2(1, 1),
                new Vector2(0, 1),

                new Vector2(0, 0),
                new Vector2(1, 0),
                new Vector2(1, 1),
                new Vector2(0, 1),


            };
#if false
            List<Vector3> normals = new List<Vector3>
            {
                Vector3.up,
                Vector3.up,
                -Vector3.forward,
                -Vector3.forward,
                Vector3.back,
                Vector3.back,
                Vector3.left,
                Vector3.left,
                Vector3.right,
                Vector3.right,
            };
#endif
            var mesh = new Mesh();
            mesh.SetVertices(vertices);
            mesh.SetTriangles(triangles, 0);
            mesh.SetUVs(0, uvs);
//            mesh.SetNormals(normals, 0, normals.Count);
            meshFilter.mesh = mesh;
        }
    }
}
