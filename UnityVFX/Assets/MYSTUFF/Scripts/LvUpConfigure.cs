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
            _character.sharedMaterial.SetColor("_Fresnel_Color", _settings._characterColor);
        if (_innerSphere)
        {
            _innerSphere.sharedMaterial.SetColor("_Primary", _settings._sphereMainColor);
            _innerSphere.sharedMaterial.SetColor("_Secondary", _settings._sphereSecondaryColor);
        }
        if (_outerSphere)
            _outerSphere.sharedMaterial.SetColor("_Secondary", _settings._sphereMainColor);
        if (_base)
            _base.sharedMaterial.SetColor("_Color", _settings._baseColor);
        if (_swirl)
        {
            _swirl.sharedMaterial.SetColor("_Main_Color", _settings._swirlPrimaryColor);
            _swirl.sharedMaterial.SetColor("_Secondary_Color", _settings._swirlSecondaryColor);
        }
        if (_width)
        {
            _width.sharedMaterial.SetColor("_Main_Color", _settings._widthMainColor);
            _width.sharedMaterial.SetColor("_Secondary_Color", _settings._widthSecondaryColor);

        }
        if (_tall)
            _tall.sharedMaterial.SetColor("_Secondary_Color", _settings._heightColor);
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