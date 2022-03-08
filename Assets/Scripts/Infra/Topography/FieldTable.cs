using System;
using System.Collections;
using System.Collections.Generic;
using Ogre.GameLogic.Topography;
using UnityEngine;

namespace Ogre.Infra.Topography
{
    [Serializable]
    public class FieldTable
    {
        [SerializeField]
        int width;
        [SerializeField]
        int height;

        [SerializeField]
        FieldMaterial[] fields;

        // TODO:水、溶岩など"流体" fluid

        FieldMaterial Material(int x, int y)
        {
            return fields[y * width + x];
        }

        public string ToJson()
        {
            return JsonUtility.ToJson(this, true);
        }

        public static FieldTable FromJson(string json)
        {
            return JsonUtility.FromJson<FieldTable>(json);
        }

        public override string ToString()
        {
            var res = new System.Text.StringBuilder();
            res.AppendFormat("Field {0}x{1}\n", width, height);
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    var m = Material(x, y);
                    res.AppendFormat("{0}", m);
                }
                res.AppendFormat("\n");
            }
            return res.ToString();
        }

        public Field ToField(TerrainMaterialTable table)
        {
            return null;
        }

        [Serializable]
        public struct FieldMaterial
        {
            [SerializeField]
            int index;
            [SerializeField]
            float height;

            public FieldMaterial(int index, float height)
            {
                this.index = index;
                this.height = height;
            }

            public override string ToString()
            {
                return string.Format("[{0}:{1}]", index, height);
            }
        }
    }
}
