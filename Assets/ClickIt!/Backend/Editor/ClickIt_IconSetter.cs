using UnityEditor;
using UnityEngine;

namespace ClickIt.Editor
{
    [InitializeOnLoad]
    public class ClickItIconSetter
    {
        private static bool hasSetIcons = false;

        static ClickItIconSetter()
        {
            if (hasSetIcons) return;
            
            EditorApplication.delayCall += SetIcons;
        }

        private static void SetIcons()
        {
            if (hasSetIcons) return;

            // Load your custom icon
            Texture2D icon = AssetDatabase.LoadAssetAtPath<Texture2D>(
                "Assets/ClickIt!/Backend/Editor/ClickItIcon.png"
            );

            if (icon == null) {
                Debug.LogWarning("ClickIt: Could not find icon at Assets/ClickIt!/Editor/ClickItIcon.jpg");
                return;
            }
            
            // Get the script
            var script = AssetDatabase.LoadAssetAtPath<MonoScript>(
                "Assets/ClickIt!/Components/ClickIt_ClickableObject.cs"
            );

            if (script == null) {
                Debug.LogWarning("ClickIt: Could not find script at Assets/ClickIt!/Components/ClickIt_ClickableObject.cs");
            }
            
            MonoImporter importer = (MonoImporter)AssetImporter.GetAtPath(
                AssetDatabase.GetAssetPath(script)
            );
                    
            // Only set if different to avoid infinite loop
            if (importer.GetIcon() != icon)
            {
                importer.SetIcon(icon);
                importer.SaveAndReimport();
            }

            script = AssetDatabase.LoadAssetAtPath<MonoScript>(
                "Assets/ClickIt!/Components/ClickIt_ReleaseableObject.cs"
            );

            if (script == null) {
                Debug.LogWarning("ClickIt: Could not find script at Assets/ClickIt!/Components/ClickIt_ReleaseableObject.cs");
            }
            
            importer = (MonoImporter)AssetImporter.GetAtPath(
                AssetDatabase.GetAssetPath(script)
            );
                    
            // Only set if different to avoid infinite loop
            if (importer.GetIcon() != icon)
            {
                importer.SetIcon(icon);
                importer.SaveAndReimport();
            }

            script = AssetDatabase.LoadAssetAtPath<MonoScript>(
                "Assets/ClickIt!/Components/ClickIt_ClickAwayObject.cs"
            );

            if (script == null) {
                Debug.LogWarning("ClickIt: Could not find script at Assets/ClickIt!/Components/ClickIt_ClickAwayObject.cs");
            }
            
            importer = (MonoImporter)AssetImporter.GetAtPath(
                AssetDatabase.GetAssetPath(script)
            );
                    
            // Only set if different to avoid infinite loop
            if (importer.GetIcon() != icon)
            {
                importer.SetIcon(icon);
                importer.SaveAndReimport();
            }
                    
            hasSetIcons = true;
        }
    }
}