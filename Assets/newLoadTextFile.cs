using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System;

public class newLoadTextFile : MonoBehaviour
{
	//public GameObject greenCube;
	public GameObject greenSphere;
	public GameObject redCube;
	public TextAsset csvFile;
    // Start is called before the first frame update
 	public string textFile = "componentData";
	string textContents;
    // Start is called before the first frame update
    void Start()
    {
        TextAsset txtAssets = (TextAsset)Resources.Load(textFile);
        textContents = txtAssets.text;
        ReadCSV(txtAssets);
    }

    // Update is called once per frame
    void OnGUI()
    {
        GUILayout.Label(textContents);
        //GUILayout.Label(textContents);
    }

    void ReadCSV(TextAsset txtAssets)
    {
    	string[] records = txtAssets.text.Split('\n');
        //Debug.Log("records");
        //Debug.Log(records[0]);
        for (int i =0; i < records.Length ;i++){
    		string[] fields = records[i].Split('=');
            //Debug.Log(fields[0]);
            if (fields[0].Contains("green cubes")){
                Debug.Log("hjhkjhk");
                //greenCube.transform.Rotate(new Vector3(0f,100f,0f)*Time.deltaTime);
    			//greenCube = float.Parse(fields[1]);
    		}
    		if(fields[0].Contains("green spheres")){
    			//greenSphere = float.Parse(fields[1]);
    		}
    		if(fields[0].Contains("red cube")){
    			//redCube = float.Parse(fields[1]);
    		}

    	}
    }
}
