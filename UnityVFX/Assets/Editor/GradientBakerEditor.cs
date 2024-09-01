using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
[CustomEditor(typeof(GradientBaker))]
public class GradientBakerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        //casteamos el target
        GradientBaker baker = (GradientBaker)target;
        //Al trabajar sobre un scriptable, es un serializable, así que necesitamos crear un SerializedObject a partir de él y modificar sus propiedades
        SerializedObject obj = new SerializedObject(baker);
        SerializedProperty nameProp = obj.FindProperty("_name");
        SerializedProperty gradProp = obj.FindProperty("_gradient");
        EditorGUILayout.PropertyField(nameProp);
        EditorGUILayout.PropertyField(gradProp);
        //Serializamos el scriptable
        obj.ApplyModifiedProperties();
        if (GUILayout.Button("Bake!"))
        {
            baker.Bake();
        }
        EditorUtility.SetDirty(baker);
    }

}
