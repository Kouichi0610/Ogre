using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;

public class BoardSurfaceEditor : EditorWindow
{
    [MenuItem("ツール/マップ作成")]
    static void Init()
    {
        Debug.Log("createMap.");
        var path = "Assets/Scenes/BoardSurfaceEditor.unity";
        var param = new LoadSceneParameters(LoadSceneMode.Single);
        EditorSceneManager.LoadSceneInPlayMode(path, param);

        var window = GetWindow<BoardSurfaceEditor>("マップエディタ");
        window.Show();
    }
    void OnGUI()
    {
        EditorGUILayout.LabelField("Sample.");
    }
}
