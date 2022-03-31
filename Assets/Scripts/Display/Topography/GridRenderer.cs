using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ogre.GameLogic.Topography;

namespace Ogre.Display.Topography
{
    public class GridRenderer : MonoBehaviour
    {
        [SerializeField]
        MeshFilter meshFilter;
        [SerializeField]
        MeshRenderer meshRenderer;

        public static GridRenderer Instantiate(GridRenderer prefab, Transform root, int x, int z, float bottom, float top, GroundMaterial material)
        {

            float xx = z % 2 == 0 ? x : (x + 0.5f);
            var pos = new Vector3(xx, 0, z);
            var res = Instantiate(prefab, pos, Quaternion.identity, root);
            res.Initialize(bottom, top, material);
            return res;
        }

        void Initialize(float bottom, float top, GroundMaterial material)
        {
            List<Vector3> vertices = new List<Vector3>
            {
                new Vector3(-0.5f, top, -0.5f),
                new Vector3(0.5f, top, -0.5f),
                new Vector3(0.5f, top, 0.5f),
                new Vector3(-0.5f, top, 0.5f),

                new Vector3(-0.5f, bottom, -0.5f),
                new Vector3(0.5f, bottom, -0.5f),
                new Vector3(0.5f, bottom, 0.5f),
                new Vector3(-0.5f, bottom, 0.5f),
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

            meshRenderer.materials = new Material[]
            {
                material.Surface,
            };
            //            mesh.SetNormals(normals, 0, normals.Count);
            meshFilter.mesh = mesh;
        }
    }
}
