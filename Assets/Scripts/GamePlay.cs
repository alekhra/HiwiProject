using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Events;
using System.IO;

public class GamePlay : MonoBehaviour
{
    public GameObject greenCubeOriginal;
    public GameObject greenSphereOriginal;
    public GameObject redCubeOriginal;
    public GameObject gameObjectContatiner;
    public string textFile = "componentData";
    string textContents;
    int num=1;
    string id;
    string sceneObjectGC, sceneObjectGS, sceneObjectRC;
    GameObject objectOriginal;
    static int eventcounter = 0;
    static List<string> idList = new List<string>();
    static List<string> trueAnsList = new List<string>();
    // Start is called before the first frame update
    void Start()
    {
        TextAsset txtAssets = (TextAsset)Resources.Load(textFile);
        textContents = txtAssets.text;
        string[] records = txtAssets.text.Split('\n');
        print("records.Length  " + records.Length + "eventcounter: " + eventcounter);
        if (records.Length < eventcounter+1){
            GamePlayScene2 gs2 = new GamePlayScene2();
            List<string> result = GamePlayScene2.result;

            string path = "Assets/Resources/result.txt";
            StreamWriter writer = new StreamWriter(path, true);
            bool res = false;
            for (int fi = 0; fi< result.Count; fi++)
			{
				if (result[fi].Equals(trueAnsList[fi]))
				{
                    res = true;
				}
				else
				{
                    res = false;
				}
                writer.WriteLine("ID:"+idList[fi]+ "   User Answer:"+result[fi]+ "   True Answers:"+ trueAnsList[fi]+ "  Result:"+ res);
                
            }
            writer.Close();
            Application.LoadLevel(2);
		}
		else
		{
            string[] columns = records[eventcounter].Split(':');
            id = columns[0];
            idList.Add(id);
            sceneObjectGC = columns[1];
            sceneObjectGS = columns[2];
            sceneObjectRC = columns[3];
            //string[] fields = records[i].Split('=');
            //Debug.Log(fields[0]);
            if (sceneObjectGC.Split('=')[0].Contains("green cubes"))
            {
                num = int.Parse(sceneObjectGC.Split('=')[1].Trim());
                objectOriginal = greenCubeOriginal;
                CreateGreenCubes(num, objectOriginal);
            }
            if (sceneObjectGS.Split('=')[0].Contains("green spheres"))
            {
                num = int.Parse(sceneObjectGS.Split('=')[1].Trim());
                objectOriginal = greenSphereOriginal;
                CreateGreenCubes(num, objectOriginal);
            }
            if (sceneObjectRC.Split('=')[0].Contains("red cube"))
            {
                num = int.Parse(sceneObjectRC.Split('=')[1].Trim());
				if (num == 0)
				{
                    trueAnsList.Add("absent");

				}
				else
				{
                    trueAnsList.Add("present");
                }
                print("red cube " + num);
                objectOriginal = redCubeOriginal;
                CreateGreenCubes(num, objectOriginal);
            }
        }
        eventcounter++;

    }

    void Update()
    {
        if (Input.anyKey)
        {

            Debug.Log("quit");
            //SceneManager.LoadScene(2);
            Application.LoadLevel(1);
            //Application.Quit();
        }
    }

    
    void CreateGreenCubes(int num, GameObject objectOriginal)
    {
        GameObject objectClone;
        int x;
        int y;
        int z;
        for (int i = 0; i< num; i++)
        {
            if (objectOriginal == greenCubeOriginal)
            {
                x = Random.Range(0, 50);
                y = Random.Range(8, 50);
                z = Random.Range(-50, 50);

                objectClone = Instantiate(objectOriginal, new Vector3(x, y, z), objectOriginal.transform.rotation);
                //objectClone = Instantiate(objectOriginal, new Vector3(i, objectOriginal.transform.position.y, i), objectOriginal.transform.rotation);
                objectClone.transform.parent = gameObjectContatiner.transform;
                objectClone.name = "GreenCubeClone" + (i + 1);
            }
            if (objectOriginal == greenSphereOriginal)
            {
                x = Random.Range(0, 50);
                y = Random.Range(8, 50);
                z = Random.Range(-50, 50);
                objectClone = Instantiate(objectOriginal, new Vector3(x, y, z), objectOriginal.transform.rotation);
                //objectClone = Instantiate(objectOriginal, new Vector3(i+4, objectOriginal.transform.position.y+1, i), objectOriginal.transform.rotation);
                objectClone.transform.parent = gameObjectContatiner.transform;
                objectClone.name = "GreenSphereClone" + (i + 1);
            }
            if (objectOriginal == redCubeOriginal)
            {
                x = Random.Range(0, 50);
                y = Random.Range(8, 50);
                z = Random.Range(-50, 50);
                objectClone = Instantiate(objectOriginal, new Vector3(x, y, z), objectOriginal.transform.rotation);
                //objectClone = Instantiate(objectOriginal, new Vector3(i+10 , objectOriginal.transform.position.y, i), objectOriginal.transform.rotation);
                objectClone.transform.parent = gameObjectContatiner.transform;
                objectClone.name = "RedCubeOriginal" + (i + 1);
            }
        }
    }
}
