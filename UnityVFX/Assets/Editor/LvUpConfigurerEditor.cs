using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
[CustomEditor(typeof(LvUpConfigure))]
public class LvUpConfigurerEditor : Editor
{
    public override void OnInspectorGUI()
    {
        LvUpConfigure lvUpConfigure = target as LvUpConfigure;
        DrawDefaultInspector();
        //if (GUILayout.Button("Apply"))
            lvUpConfigure.Action();
            
    }
}
