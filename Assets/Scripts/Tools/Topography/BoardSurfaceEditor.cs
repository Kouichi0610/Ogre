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
            width.text = "15";
            height.text = "13";
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

            so.FindProperty("width").intValue = Width;
            so.FindProperty("height").intValue = Height;

            so.ApplyModifiedProperties();
        }

    }
}
