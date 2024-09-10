using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UIElements;
public class GradientBakerWindow : EditorWindow
{

    Button _bake;
    TextField _name;
    GradientField _gradient;
    FloatField _test;

    [MenuItem("Tools/GradientBaker")]
    public static void ShowWindow()
    {
        GradientBakerWindow wnd = GetWindow<GradientBakerWindow>();
        wnd.titleContent = new GUIContent("Gradient Baker");
    }
    public void CreateGUI()
    {
        _bake = new Button(Action);
        _bake.text = "Bake!";
        _name = new TextField("Gradient Name"/*, -1, false, false, ' '*/);
        _gradient = new GradientField("Gradient");
        _gradient.hdr = true;
        _test = new FloatField("Test");
        _test.isDelayed = true;
        rootVisualElement.Add(_name);
        rootVisualElement.Add(_gradient);
        rootVisualElement.Add(_test);
        rootVisualElement.Add(_bake);
    }
    // Start is called before the first frame update
    private void Action()
    {

        Texture2D t = new Texture2D(512, 1, TextureFormat.RGBAHalf, true);
        for (int i = 0; i < 512; i++)
            t.SetPixel(i, 0, _gradient.value.Evaluate((float)(i) / 512f));
        t.Apply();
        byte[] exr = t.EncodeToEXR();
        if (!System.IO.Directory.Exists("Assets/MYSTUFF/Images/Gradients"))
            System.IO.Directory.CreateDirectory("Assets/MYSTUFF/Images/Gradients");
        //AssetDatabase.CreateAsset(t, "Assets/MYSTUFF/Images/Gradients/" + _name + ".asset");
        System.IO.File.WriteAllBytes("Assets/MYSTUFF/Images/Gradients/" + _name.value + ".exr", exr);
        AssetDatabase.Refresh();
    }
}
