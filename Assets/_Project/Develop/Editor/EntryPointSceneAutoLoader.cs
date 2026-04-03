using System;
using UnityEditor;
using UnityEditor.SceneManagement;

namespace Assets._Project.Develop.Editor
{
    [InitializeOnLoad]
    public static class EntryPointSceneAutoLoader
    {
        private const string PlayFromBootsrapKey = "PlayFromBootstrapKey";
        private const string MenuPath = "PlayFromBootstrap/Enabled";

        static EntryPointSceneAutoLoader()
        {
            EditorApplication.playModeStateChanged += OnPlayModeStateChanged;
        }

        private static void OnPlayModeStateChanged(PlayModeStateChange state)
        {
            if(state == PlayModeStateChange.ExitingEditMode)
            {
                if(EditorPrefs.GetBool(PlayFromBootsrapKey) == false)
                {
                    EditorSceneManager.playModeStartScene = null;
                    return;
                }

                if(EditorBuildSettings.scenes.Length == 0)
                    return;

                EditorSceneManager.playModeStartScene = AssetDatabase
                   .LoadAssetAtPath<SceneAsset>(EditorBuildSettings.scenes[0].path);
            }
        }

        [MenuItem(MenuPath)]
        private static void Toggle()
        {
            bool result = EditorPrefs.GetBool(PlayFromBootsrapKey);

            EditorPrefs.SetBool(PlayFromBootsrapKey, !result);
        }

        [MenuItem(MenuPath, true)]
        private static bool ToggleValidate()
        {
            Menu.SetChecked(MenuPath, EditorPrefs.GetBool(PlayFromBootsrapKey));

            return true;
        }
    }
}
