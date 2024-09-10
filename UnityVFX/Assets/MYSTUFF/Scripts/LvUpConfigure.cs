using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class LvUpConfigure : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Renderer _character;
    [SerializeField] Renderer _innerSphere;
    [SerializeField] Renderer _outerSphere;
    [SerializeField] Renderer _base;
    [SerializeField] Renderer _swirl;
    [SerializeField] Renderer _width;
    [SerializeField] Renderer _tall;
    [SerializeField] VisualEffect _floating;
    [SerializeField] VisualEffect _attracting;
    [SerializeField] LvUpSettings _settings;
    public void Action()
    {

        if (_character)
            _character.material.SetColor("_Fresnel_Color", _settings._characterColor);
        if (_innerSphere)
        {
            _innerSphere.material.SetColor("_Primary", _settings._sphereMainColor);
            _innerSphere.material.SetColor("_Secondary", _settings._sphereSecondaryColor);
        }
        if (_outerSphere)
            _outerSphere.material.SetColor("_Secondary", _settings._sphereMainColor);
        if (_base)
            _base.material.SetColor("_Color", _settings._baseColor);
        if (_swirl)
        {
            _swirl.material.SetColor("_Main_Color", _settings._swirlPrimaryColor);
            _swirl.material.SetColor("_Secondary_Color", _settings._swirlSecondaryColor);
        }
        if (_width)
        {
            _width.material.SetColor("_Main_Color", _settings._widthMainColor);
            _width.material.SetColor("_Secondary_Color", _settings._widthSecondaryColor);

        }
        if (_tall)
            _tall.material.SetColor("_Secondary_Color", _settings._heightColor);
        if (_floating)
            _floating.SetVector4("Particles Color", new Vector4(_settings._floatingParticlesColor.gamma.r, _settings._floatingParticlesColor.gamma.g, _settings._floatingParticlesColor.gamma.b, 1));
        if (_attracting)
            _attracting.SetVector4("Particles Color", new Vector4(_settings._attractingParticlesColor.gamma.r, _settings._attractingParticlesColor.gamma.g, _settings._attractingParticlesColor.gamma.b, 1));
    }
    // Update is called once per frame
    void Update()
    {

    }
}
