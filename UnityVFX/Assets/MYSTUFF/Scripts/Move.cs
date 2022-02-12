using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Vector3 offset;
    [SerializeField] float speed = 2;
    [SerializeField] ControllerHandler _handler;
    Controller _contr;

    private void Start()
    {
        _contr = _handler.Controller;
    }
    void Update()
    {
       

        transform.Translate(Vector3.ClampMagnitude(new Vector3(_contr.Move.Horizontal.ReadValue<float>() * speed * Time.deltaTime
            ,0, _contr.Move.Vertical.ReadValue<float>() * speed * Time.deltaTime), speed));
    }
    private void LateUpdate()
    {
        Camera.main.transform.position = transform.position + offset;
    }
}
