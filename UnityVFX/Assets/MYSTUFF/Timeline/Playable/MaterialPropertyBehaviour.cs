using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class MaterialPropertyBehaviour : PlayableBehaviour
{
    public Material mat;
    public string property;
    public float value;
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        
         mat.SetFloat(property, value);
    }
}
