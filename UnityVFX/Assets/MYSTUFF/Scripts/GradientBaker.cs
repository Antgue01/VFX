using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;
using UnityEngine.Windows;
using Unity;
using System.IO;

[CreateAssetMenu(fileName = "GradientBaker", menuName = "Tools/Gradient Baker", order = 0)]
public class GradientBaker : ScriptableObject
{
    // Start is called before the first frame update
    [SerializeField]
    Gradient _gradient;
    [SerializeField]
    string _name;


    public void Bake()

    {
        Debug.Log(_name);

        Texture2D t = new Texture2D(512, 1, TextureFormat.RGBAHalf, true);
        for (int i = 0; i < 512; i++)
            t.SetPixel(i, 0, _gradient.Evaluate((float)(i) / 512f));
        t.Apply();
        byte[] b = t.EncodeToEXR();
        if (!System.IO.Directory.Exists("Assets/MYSTUFF/Images/Gradients"))
            System.IO.Directory.CreateDirectory("Assets/MYSTUFF/Images/Gradients");
        //AssetDatabase.CreateAsset(t, "Assets/MYSTUFF/Images/Gradients/" + _name + ".asset");
        System.IO.File.WriteAllBytes("Assets/MYSTUFF/Images/Gradients/" + _name + ".exr", b);
        AssetDatabase.Refresh();
    }
}
