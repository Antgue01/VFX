using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;
[CustomEditor(typeof(ScriptableTest))]
public class ScriptableTestEditor : Editor
{

	public override void OnInspectorGUI()
	{
		ScriptableTest test = (ScriptableTest)target;
		//Hacemos que el objeto sea serializado para acceder a sus propiedades
		SerializedObject obj = new SerializedObject(test);
		//Accedemos a la propiedad
		SerializedProperty total = obj.FindProperty("Total");

		//Configuramos el texto
		GUIStyle style = new GUIStyle();
		style.richText = true;
		//Escribimos el texto, para ello accedemos a la propiedad
		EditorGUILayout.LabelField("<color=#3eee4c>Total ammount equals to </color> <b><color=#57eeff>" + total.floatValue.ToString() + "</color></b>", style);
		//Pedimos el float, hacemos la operación y le decimos al objeto serializado que se serialice
		//Otra opción sería que el propio scriptable tuviera un método para sumar y que se llamara desde aquí
		float ammountToAdd = EditorGUILayout.DelayedFloatField("Ammount to Add", 0);
		total.floatValue += ammountToAdd;
		obj.ApplyModifiedProperties();



	}
}
