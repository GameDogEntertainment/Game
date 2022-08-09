#if UNITY_2017_1_OR_NEWER
using UnityEditor;
using UnityEngine;
using UnityEngine.Playables;

namespace WAPI
{
    [CustomPropertyDrawer(typeof(WorldManagerSeasonBehaviour))]
    public class WorldManagerSeasonDrawer : PropertyDrawer
    {
        public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        {
            int fieldCount = 1;
            return fieldCount*EditorGUIUtility.singleLineHeight;
        }

        public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
        {
            SerializedProperty seasonProp = property.FindPropertyRelative("season");

            Rect singleFieldRect = new Rect(position.x, position.y, position.width, EditorGUIUtility.singleLineHeight);
            EditorGUI.PropertyField(singleFieldRect, seasonProp);
        }
    }
}
#endif