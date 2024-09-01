using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class MaterialPropertyAsset : PlayableAsset
{
    public ExposedReference<Renderer> gameObject;
    public string propName;
    public float value;
    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        ScriptPlayable<MaterialPropertyBehaviour> playable = ScriptPlayable<MaterialPropertyBehaviour>.Create(graph);
        MaterialPropertyBehaviour mat = playable.GetBehaviour();
        mat.mat = gameObject.Resolve(graph.GetResolver())?.sharedMaterial;
        mat.property = propName;
        mat.value = value;
        return playable;
    }


}
