using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ogre.GameLogic.Topography
{
    public class Stage
    {
        public int Width => grounds.GetLength(0);
        public int Height => grounds.GetLength(1);

        IGroundMaterialRepository materialRepository;
        Ground[,] grounds;

        public Stage(IGroundMaterialRepository materialRepository, Ground[,] grounds)
                                                                                                                                                                       {
            this.materialRepository = materialRepository;
            this.grounds = grounds;
        }

        public static Stage Random(IGroundMaterialRepository materialRepository, int w, int h)
        {
            var g = new Ground[h, w];
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    var height = (short)UnityEngine.Random.Range(0, 200);
                    g[i, j] = new Ground(0, height);
                }
            }
            return new Stage(materialRepository, g);
        }

        public static Stage FromHeights(IGroundMaterialRepository materialRepository, short[,] heights)
        {
            var height = heights.GetLength(0);
            var width = heights.GetLength(1);
            var g = new Ground[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    g[i, j] = new Ground(0, heights[i, j]);
                }
            }
            return new Stage(materialRepository, g);
        }

        public void DebugHeights()
        {
            for (int i = 0; i < Height; i++)
            {
                var s = new System.Text.StringBuilder();
                for (int j = 0; j < Width; j++)
                {
                    s.AppendFormat("[{0}]", grounds[i, j].Height.ToFloat);
                }
                Debug.Log(s.ToString());
            }
        }

        public void Render(IGroundRenderer renderer)
        {
            renderer.Clear();
            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    var height = grounds[y, x].Height.ToFloat;
                    var material = grounds[y, x].Material(materialRepository);
                    renderer.Render(x, y, 0, height, material);
                }
            }
        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}
