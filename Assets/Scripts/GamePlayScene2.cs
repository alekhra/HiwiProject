using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePlayScene2 : MonoBehaviour
{
    public static List<string> result = new List<string>();
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("p"))
        {
            Debug.Log("present");
            result.Add("present");
            Application.LoadLevel(0);
        }
        if (Input.GetKey("a"))
        {
            Debug.Log("absent");
            result.Add("absent");
            Application.LoadLevel(0);
        }
    }

    List<string> getResult()
	{
        return result;

    }
}
