using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(GradientBaker))]
public class GradientBakerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        GUIContent grad = new GUIContent("Gradient");
        GUIContent name = new GUIContent("Name");
        GradientBaker baker = (GradientBaker)target;
        baker.path=EditorGUILayout.TextField(name,baker.path);
        baker.gradient=EditorGUILayout.GradientField(grad,baker.gradient,true);
        if (GUILayout.Button("Bake!"))
        {
            baker.Bake();
        }
        EditorUtility.SetDirty(baker);
    }
}
