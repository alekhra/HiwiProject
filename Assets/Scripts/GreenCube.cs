using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCube : MonoBehaviour
{
    public GameObject greenCube;
    // Update is called once per frame
    void Update()
    {
        greenCube.transform.Rotate(new Vector3(0f, 100f, 0f) * Time.deltaTime);
    }
}
