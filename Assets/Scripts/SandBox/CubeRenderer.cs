using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.SandBox
{
    /// <summary>
    /// TODO:Mesh�쐬Map��
    /// �E�e�N�X�`��
    /// �E�V�F�[�_�ɂ�鉏���
    /// </summary>
    public class CubeRenderer : MonoBehaviour
    {
        void Start()
        {
            float height = 10.0f;
            // ���_���X�g���쐬
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

            // �ʂ��\������C���f�b�N�X���X�g���쐬
            List<int> triangles = new List<int> {
                0, 1, 2,  // ����
                0, 2, 3,  // ����
                4, 5, 6,  // �O��
                4, 6, 7,  // �O��
                0, 4, 7,  // �E��
                0, 3, 4,  // �E��
                6, 2, 1,  // ����
                6, 5, 2,  // ����
                6, 1, 0,  // ���
                7, 6, 0,  // ���
                4, 3, 2,  // ����
                5, 4, 2,  // ����
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

