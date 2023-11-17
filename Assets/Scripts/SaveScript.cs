using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SaveScript : MonoBehaviour
{

    public PlayerObject po;
    string dataPath;
    public string fileName;
    string jsonFileExtension = ".json";

    public void Awake()
    {
       dataPath = Application.persistentDataPath;
    }

    // Start is called before the first frame update
    void Start()
    {
        //GameData myData = new GameData();
        //myData.score = 100;
        //myData.playerName = "Zach";
        //myData.playerNumber = 34;



        //string json = JsonUtility.ToJson(po);

        //string dataPath = Application.persistentDataPath;
        //Debug.Log(dataPath);
        //Debug.Log(json);

        //File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);

        LoadData();
        //SaveData();
    }

    public void SaveData()
    {
        // Application.persistentDataPath\Filename.json
        //string fullFilePath = $"{dataPath}\\{fileName}{jsonFileExtension}";
        string fullFilePath = Application.persistentDataPath + "/savefile1.json";

        string json = JsonUtility.ToJson(po);

        Debug.Log(json);

        File.WriteAllText(fullFilePath, json);

    }

    public void LoadData()
    {

        string fullFilePath = Application.persistentDataPath + "/savefile1.json";

        string json = File.ReadAllText(fullFilePath);
        //PlayerObject loaderPlayer = JsonUtility.FromJson<PlayerObject>(json);

        Debug.Log(json);


        //GameData loadedData = JsonUtility.FromJson<GameData>(json);

        //Debug.Log(loadedData.playerName);
        //Debug.Log(loadedData.playerNumber);
        //Debug.Log(loadedData.score);


    }

}
