using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// シェーダの色をスクリプトから変更するサンプル
/// </summary>
public class ParamController : MonoBehaviour
{
    void Start()
    {
        var r = GetComponent<Renderer>();

        r.material.SetColor("_BaseColor", Color.cyan);
    }
}
