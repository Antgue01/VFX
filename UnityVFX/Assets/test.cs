using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    SDFTexture sdf;
    void Start()
    {
        sdf = GetComponent<SDFTexture>();
        SkinnedMeshRenderer mesh = GetComponent<SkinnedMeshRenderer>();
        int mats = mesh.materials.Length;
        for (int i = 0; i < mats; i++)
        {
            MaterialPropertyBlock mat = new MaterialPropertyBlock();
            GetComponent<SkinnedMeshRenderer>().GetPropertyBlock(mat, i);
            mat.SetMatrix("_World_To_SDF", sdf.worldToSDFTexCoords);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
