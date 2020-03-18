using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCube : MonoBehaviour
{
    public GameObject redCube;

    // Update is called once per frame
    void Update()
    {
        redCube.transform.Rotate(new Vector3(0f, 100f, 0f) * Time.deltaTime);
    }
}
