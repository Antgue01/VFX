using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr : MonoBehaviour
{
    [SerializeField]
    Transform[] transforms;
    [SerializeField]
    float speed = 1;
    int index = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if ((transforms[index].position - transform.position).magnitude < .1f)
            index = (index + 1) % transforms.Length;
        transform.position += (transforms[index].position - transform.position).normalized * speed * Time.deltaTime;
    }
}
