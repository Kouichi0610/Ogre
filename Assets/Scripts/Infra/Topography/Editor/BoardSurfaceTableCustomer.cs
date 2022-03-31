
namespace Ogre.Infra.Topography
{
#if false
    [CustomEditor(typeof(BoardSurfaceTable))]
    public class BoardSurfaceTableCustomer : Editor
    {
        BoardSurfaceTable table;
        private void OnEnable()
        {
            table = target as BoardSurfaceTable;
        }
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();


            serializedObject.Update();
            using (new EditorGUILayout.VerticalScope())
            {
                if (GUILayout.Button("Load EditScene."))
                {
                    EditorApplication.EnterPlaymode();
                    var path = "Assets/Scenes/BoardSurfaceEditor.unity";
                    var param = new LoadSceneParameters(LoadSceneMode.Single);
                    EditorSceneManager.LoadSceneInPlayMode(path, param);
                }
                EditorGUILayout.LabelField("AAAA");

                Resize();

                Field();
            }
            serializedObject.ApplyModifiedProperties();
        }


        // TODO:マップっぽい描画
        void Field()
        {
            var width = serializedObject.FindProperty("width").intValue;
            var height = serializedObject.FindProperty("height").intValue;

            using (new EditorGUILayout.VerticalScope())
            {
                EditorGUILayout.HelpBox("Field", MessageType.Warning);
                EditorGUILayout.LabelField(string.Format("Field:{0}x{1}", width, height));

                int i = 0;

                EditorGUILayout.HelpBox("Field END", MessageType.Warning);
            }
        }

        int width;
        int height;
        void Resize()
        {
            using (new EditorGUILayout.VerticalScope())
            {
                var w = GUILayout.Width(200);

                var width = serializedObject.FindProperty("width");
                var height = serializedObject.FindProperty("height");

                EditorGUILayout.PropertyField(width);
                EditorGUILayout.PropertyField(height);

                if (GUILayout.Button("Resize"))
                {
                    // TODO:保存(落とせば保存される)
                    // TODO:リサイズ

#if false
                    var p = so.FindProperty("desctiption");
                    Debug.Log("" + p.stringValue);

                    
                    Debug.Log(string.Format("Resize W:{0} H:{1}", width, height));
#endif
                }
            }
        }
    }
#endif
}
