using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Variant",menuName = "Effects/Lv Up")]
public class LvUpSettings : ScriptableObject
{
    [ColorUsage(false,true)]
    public Color _sphereMainColor;
    [ColorUsage(false, true)]
    public Color _sphereSecondaryColor;
    [ColorUsage(false, true)]
    public Color _baseColor;
    [ColorUsage(false, true)]
    public Color _characterColor;
    [ColorUsage(false, true)]
    public Color _heightColor;
    [ColorUsage(false, true)]
    public Color _swirlPrimaryColor;
    [ColorUsage(false, true)]
    public Color _swirlSecondaryColor;
    [ColorUsage(false, true)]
    public Color _widthMainColor;
    [ColorUsage(false, true)]
    public Color _widthSecondaryColor;
    [ColorUsage(false, true)]
    public Color _attractingParticlesColor;
    [ColorUsage(false, true)]
    public Color _floatingParticlesColor;



}
