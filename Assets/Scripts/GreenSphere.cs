using UnityEngine;

public class GreenSphere : MonoBehaviour
{
    public GameObject greenSphere;

    // Update is called once per frame
    void Update()
    {
        greenSphere.transform.Rotate(new Vector3(0f, 100f, 0f) * Time.deltaTime);
    }
}
