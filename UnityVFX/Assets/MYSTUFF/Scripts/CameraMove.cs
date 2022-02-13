using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] ControllerHandler _hndlr;
    [SerializeField] float _spd = 3;
    Controller _controller;
    float _x = 0;
    void Start()
    {
        _controller = _hndlr.Controller;
    }

    private void Update()
    {
        Camera.main.transform.Rotate(new Vector3(_controller.Cam.Vertical.ReadValue<float>(),_controller.Cam.Horizontal.ReadValue<float>(),0)
            * _spd * Time.deltaTime);
    }
}
