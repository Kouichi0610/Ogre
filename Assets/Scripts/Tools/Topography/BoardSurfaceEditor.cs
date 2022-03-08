using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;
using UnityEditor;
using Ogre.Infra.Topography;

namespace Orge.Tools.Topography
{
    /// <summary>
    /// TODO:
    /// ScriptableObject読み込み、新規作成
    /// 
    /// 幅、奥行設定
    /// マテリアル編集モード
    /// 高さ編集モード
    /// 
    /// TODO:json形式の保存を試す
    /// 
    /// 保存
    /// </summary>
    public class BoardSurfaceEditor : MonoBehaviour
    {
        [SerializeField]
        InputField width;
        [SerializeField]
        InputField height;

        [SerializeField]
        BoardSurfaceTable board;

        int Width => int.Parse(width.text);
        int Height => int.Parse(height.text);

        void Start()
        {
            Load(board);

            // test.
            width.text = "10";
            height.text = "5";

            // TODO:新規作成and上書き保存ができるか
            // TODO:boardの中身コピー->保存押す->書き換え
            board.Resize(Width, Height);
            Save();
        }

        void Load(BoardSurfaceTable board)
        {
            width.text = board.Width.ToString();
            height.text = board.Height.ToString();
        }

        void Save()
        {
            if (board == null) return;

            var so = new SerializedObject(board);


#if false
            so.FindProperty("width").intValue = Width;
            so.FindProperty("height").intValue = Height;
#endif
            var res = so.ApplyModifiedProperties();
            Debug.LogWarning("Apply: " + res);

        }

    }
}
