using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] ControllerHandler _hndlr;
    [SerializeField] float _rotationSpd = 3;
    [SerializeField] float _movementSpd = 3;
    Controller _controller;
    void Start()
    {
        _controller = _hndlr.Controller;
    }

    private void Update()
    {
        Camera.main.transform.Rotate(new Vector3(_controller.Cam.Vertical.ReadValue<float>(),_controller.Cam.Horizontal.ReadValue<float>(),0)
            * _rotationSpd * Time.deltaTime);
        
        Camera.main.transform.Translate(new Vector3(_controller.Move.Horizontal.ReadValue<float>()*Time.deltaTime*_movementSpd,
                                                    _controller.Move.Vertical.ReadValue<float>()*Time.deltaTime*_movementSpd,
                                                    _controller.Move.Forward.ReadValue<float>()*Time.deltaTime*_movementSpd));   
    }
}
