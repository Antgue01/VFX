using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class FireWorksManager : MonoBehaviour
{
    [SerializeField] ControllerHandler _controller;
    [SerializeField] [ColorUsage(false)] Color[] _fireWorksColors;
    [SerializeField] VisualEffect[] _prefabs;
    VisualEffect[] _effects;
    [SerializeField] Transform[] _positions;
    int _current = 0;
    private void Start()
    {
        _controller.Controller.Trigger.ShootFireWorks.started += _ctx => { Boom(); };
        _effects = new VisualEffect[_prefabs.Length];
        for (int i = 0; i < _prefabs.Length; i++)
        {
            _effects[i] = Instantiate<VisualEffect>(_prefabs[i], _positions[i % _positions.Length].position, Quaternion.identity, transform);
            _effects[i].SetVector4("Color", _fireWorksColors[i % _fireWorksColors.Length]);
            _effects[i].enabled = false;
        }
        transform.Rotate(Vector3.up*40);
    }



    void Boom()
    {
        _effects[_current].enabled = true;
        _effects[_current].Reinit();
        //_effects[_current].Play();
        _current = (_current + 1) % _effects.Length;
    }

}
