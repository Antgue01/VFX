using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(menuName = "Test/Scriptable Test")]
public class  ScriptableTest : ScriptableObject
{
    [SerializeField] private float Total;
    //Las propiedades no se serializan

}
