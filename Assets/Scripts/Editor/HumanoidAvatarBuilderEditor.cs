using UnityEditor;
using UnityEngine;
using UtilsSpherum;

namespace Editor
{
    public class HumanoidAvatarBuilderEditor : EditorWindow
    {
        [MenuItem("Tools/Avatar Tools")]
        private static void ShowWindow()
        {
            var window = GetWindow<HumanoidAvatarBuilderEditor>();
            
            window.titleContent = new GUIContent("Avatar Tools");
            
            window.Show();
        }

        private void OnGUI()
        {
            if (!GUILayout.Button("Build Avatar")) return;
            
            var select = Selection.activeGameObject;
                
            var description = AvatarBuilderUtils.CreateHumanDescription(select);
			
            var avatar = AvatarBuilder.BuildHumanAvatar(select, description);
            avatar.name = select.name;
                
            var animator = select.GetComponent<Animator>();
            animator.avatar = avatar;
        }
    }
}