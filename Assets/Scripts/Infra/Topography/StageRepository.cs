using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ogre.GameLogic.Topography;

namespace Ogre.Infra.Topography
{
    /// <summary>
    /// TODO:バイナリ経由のStageRepository
    /// </summary>
    [CreateAssetMenu(fileName = "Stage", menuName = "地形/Stage", order = 102)]
    public class StageRepository : ScriptableObject, IStageRepository
    {
        // TODO:inject
        [SerializeField]
        GroundMaterialRepository materialRepository;

        [SerializeField]
        GroundData[] grounds;

        // TODO:拡張で
        // Materials編集
        // Heights編集

        Stage IStageRepository.Get()
        {
            throw new NotSupportedException();
        }

        [Serializable]
        class GroundData
        {
            [SerializeField]
            short material;
            [SerializeField]
            short height;
        }
    }
}
