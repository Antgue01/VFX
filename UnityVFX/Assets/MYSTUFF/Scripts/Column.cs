using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column : MonoBehaviour
{
    public float Speed { get { return _speed; } set { _speed = Mathf.Abs(value); } }
    public float Rad { get { return _rad; } set { _rad = Mathf.Abs(value); } }
    float _speed;
    float _rad;
    float _angle = 0;
    Vector3 _center;
    private void Start()
    {
        _center = transform.position;
    }
    private void Update()
    {
        _angle += (Time.deltaTime * Speed) % 360;
        transform.position = _center + new Vector3(Rad * Mathf.Cos(_angle), 0, Rad * Mathf.Sin(_angle));
    }
}
