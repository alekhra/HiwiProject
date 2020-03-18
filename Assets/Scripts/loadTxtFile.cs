using UnityEngine;

public class LoadTxtFile : MonoBehaviour
{
	public string textFile = "componentData";
	string textContents;
    // Start is called before the first frame update
    void Start()
    {
        TextAsset txtAssets = (TextAsset)Resources.Load(textFile);
        textContents = txtAssets.text;
    }

    // Update is called once per frame
    void OnGUI()
    {
        GUILayout.Label(textContents);
    }
}
