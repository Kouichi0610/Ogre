using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.ProjectWindowCallback;

public class ScriptCreator : EndNameEditAction
{
    [MenuItem("Assets/Create/CreateBehaviour", false,-1)]
    private static void CreateMonoBehaviour()
    {
        var resourceFile = Path.Combine(
            Application.dataPath,
            "Editor/81-MonoBehaviour-NewBehaviourScript.cs.txt"
            );

        var csIcon = EditorGUIUtility.IconContent("cs Script Icon").image as Texture2D;

        var endNameEditAction = ScriptableObject.CreateInstance<ScriptCreator>();

        ProjectWindowUtil.StartNameEditingIfProjectWindowExists(
            0,
            endNameEditAction,
            "NewBehaviourScript.cs",
            csIcon,
            resourceFile);
    }
    public override void Action(int instanceId, string pathName, string resourceFile)
    {
        var text = File.ReadAllText(resourceFile);
        var pathes = Application.dataPath.Split('/');

        var name = Path.GetFileNameWithoutExtension(pathName);
        var scriptName = name.Replace(" ", "");
        var projectName = "." + pathes[pathes.Length - 2];
        var directryName = Path.GetDirectoryName(pathName).
                           Replace("Assets", "").
                           Replace("/Scripts", "").
                           Replace("/", ".");


        text = text.Replace("#NAME#", name);
        text = text.Replace("#SCRIPTNAME#", scriptName);
        text = text.Replace("#PROJECTNAME#", projectName);
        text = text.Replace("#DIRECTORYNAME#", directryName);
        text = text.Replace("#NOTRIM#", "\n");

        var encoding = new UTF8Encoding(true, false);

        File.WriteAllText(pathName, text, encoding);

        AssetDatabase.ImportAsset(pathName);
        var asset = AssetDatabase.LoadAssetAtPath<MonoScript>(pathName);
        ProjectWindowUtil.ShowCreatedAsset(asset);
    }
}
