using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.VFX;

public class AttractingParticlesBehaviour : PlayableBehaviour
{
    Transform _transform;
    VisualEffect _vfx;

    public void Initialize(Transform t, VisualEffect vfx)
    {
        _transform = t;
        _vfx = vfx;
    }
    public override void ProcessFrame(Playable playable, FrameData info, object playerData)
    {
        _vfx.SetVector3("Center Pos", _transform.position);
        
    }
}
