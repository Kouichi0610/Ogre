using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Ogre.GameLogic.Topography;
using Ogre.Display.Topography;
using UniRx;

// TODO:DI
using Ogre.Infra.Topography;

public class EarthRendererSandBox : MonoBehaviour
{
    [SerializeField]
    GroundMaterialRepository materialRepository;
    [SerializeField]
    GroundRenderer groundRenderer;

    void Start()
    {
#if false
        var s = Stage.FromHeights(materialRepository,
            new short[10, 10]
        {
            {80,81,82,83,84, 85, 84, 83, 82, 81,},
            {70,71,72,73,74, 75, 74, 73, 72, 71,},
            {60,61,62,63,64, 65, 64, 63, 62, 61,},
            {50,51,52,53,54, 55, 54, 53, 52, 51,},
            {40,41,42,43,44, 45, 44, 43, 42, 41,},
            {30,31,32,33,34, 35, 34, 33, 32, 31,},
            {90,91,92,93,94, 95, 94, 93, 92, 91,},
            {20,21,22,23,24, 25, 24, 23, 22, 21,},
            {10,11,12,13,14, 15, 14, 13, 12, 11,},
            {0,1,2,3,4, 5, 4, 3, 2, 1,},
        });
#endif

        StartCoroutine(SetupCoroutine(500, 500));

#if false
        Debug.Log("Z");
        var s = Stage.Random(materialRepository, 200, 200);
        Debug.Log("X");
        s.Render(groundRenderer);
#endif
    }

    IEnumerator SetupCoroutine(int width, int height)
    {
        IGroundRenderer renderer = groundRenderer;
        IGroundMaterialRepository repository = materialRepository;
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                renderer.Render(j, i, 0, 10, repository.Get(0));
            }
            yield return new WaitForFixedUpdate();
        }
        Debug.Log("Complete.");
    }


    void Update()
    {
        
    }
}
