using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.VersionControl;
using UnityEngine;

    [CustomEditor(typeof(SDFBaker))]
public class MeshToSDFBakerEditor : Editor
{
    override public void OnInspectorGUI()
    {
        SDFBaker baker = (SDFBaker)target;
        GUILayoutOption[] a =new GUILayoutOption[1];
        DrawDefaultInspector();
        // Texture s =AssetDatabase.LoadAssetAtPath<Texture>("Packages/com.unity.inputsystem/InputSystem/Editor/Icons/Button@4x.png");
        EditorGUILayout.BeginHorizontal();
        if (EditorGUI.LinkButton(GUILayoutUtility.GetRect(20,20,"TextField"),"press"))
        {
            baker.bake();

        }
        EditorGUILayout.EndHorizontal();
    }
}
