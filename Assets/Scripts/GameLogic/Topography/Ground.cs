using System;
using UnityEngine;
using Ogre.GameLogic.Topography.Location;

namespace Ogre.GameLogic.Topography
{
    public struct Ground
    {
        short material;
        Height height;
        public Height Height => height;
        public GroundMaterial Material(IGroundMaterialRepository repository)
        {
            return repository.Get(material);
        }

        public Ground(short material, short height)
        {
            this.material = material;
            this.height = new Height(height);
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}", material, height);
        }
    }
}
