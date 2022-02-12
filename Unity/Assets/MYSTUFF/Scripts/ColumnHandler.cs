using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class ColumnHandler : MonoBehaviour
{
    [SerializeField] Transform[] _positions;
    [SerializeField] Gradient[] _gradients;
    [SerializeField] VisualEffect _prefab;
    [SerializeField] float[] _speed;
    [SerializeField] float[] _rad;
    private void Awake()
    {
        for (int i = 0; i < _positions.Length; i++)
        {
            VisualEffect e = VisualEffect.Instantiate<VisualEffect>(_prefab, _positions[i].position, transform.rotation, transform);
            e.SetGradient("Color", _gradients[i % _gradients.Length]);
            Column column = e.gameObject.GetComponent<Column>();
            column.Rad = _rad[i%_rad.Length];
            column.Speed =_speed[i%_speed.Length];
        }
    }
   
}


