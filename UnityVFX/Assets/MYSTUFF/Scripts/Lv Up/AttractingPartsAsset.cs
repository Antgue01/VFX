using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.VFX;

public class AttractingPartsAsset : PlayableAsset
{
    public ExposedReference<Transform> SpherePos;
    public ExposedReference<VisualEffect> VFX;


    public override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
    {
        var playable = ScriptPlayable<AttractingParticlesBehaviour>.Create(graph);
        playable.GetBehaviour().Initialize(SpherePos.Resolve(graph.GetResolver()), VFX.Resolve(graph.GetResolver()));
        return playable;
    }
}
