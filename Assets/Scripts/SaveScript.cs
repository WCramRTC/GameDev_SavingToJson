using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using JetBrains.Annotations;

public class SaveScript : MonoBehaviour
{

    public PlayerObject po;
    string dataPath;
    public string fileName;
    string jsonFileExtension = ".json";
    string playerLocation = "playerLoc";

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

        //SavePlayerLocation();
        //LoadData();
        //SaveData();
    }

    public void SaveData()
    {
        // Application.persistentDataPath\Filename.json
        //string fullFilePath = $"{dataPath}\\{fileName}{jsonFileExtension}";
        string fullFilePath = Application.persistentDataPath + "/savefile.json";

        string json = JsonUtility.ToJson(po);

        Debug.Log(json);

        File.WriteAllText(fullFilePath, json);

    }

    public void LoadData()
    {

        string fullFilePath = Application.persistentDataPath + "/savefile.json";

        string json = File.ReadAllText(fullFilePath);


        GameData loadedData = JsonUtility.FromJson<GameData>(json);

        Debug.Log(loadedData.playerName);
        Debug.Log(loadedData.playerNumber);
        Debug.Log(loadedData.score);


    }

    public void SavePlayerLocation()
    {
        // Application.persistentDataPath\Filename.json
        string fullFilePath = $"{dataPath}\\{fileName}{jsonFileExtension}";

        PositionData pd = new PositionData(po.transform.position);

        string json = JsonUtility.ToJson(pd);

        Debug.Log(json);

        //string fullFilePath = Application.persistentDataPath + "/savefile.json";


        File.WriteAllText(fullFilePath, json);

    }


    public void LoadPlayerLocation()
    {
        // Application.persistentDataPath\Filename.json
        string fullFilePath = $"{dataPath}\\{fileName}{jsonFileExtension}";

        string json = File.ReadAllText(fullFilePath);

        PositionData pd = JsonUtility.FromJson<PositionData>(json);

        po.UpdateLocation(pd.ToVector3());
    }
}
