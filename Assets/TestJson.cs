using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;

//要儲存對象
[Serializable]
public class PlayerData
{
    public string PlayerName;
    public int Score;

}
public class TestJson : MonoBehaviour
{
    string JsonPath; //json文件的路徑
    PlayerData playerdata; //要存起來的對象
    PlayerData playerdatatemp; //要讀取出來的對象

    // Start is called before the first frame update
    void Start()
    {
        JsonPath = Application.streamingAssetsPath + "/PlayerState.json";
        InitJsonData();
    }

    //json 數據初始化
    void InitJsonData()
    {
        playerdata = new PlayerData();
        playerdata.PlayerName = "Andy";
        playerdata.Score = 0;
    }

    //將上面數據進行保存
    public void SaveJson()
    {
        //若本地沒有對應的json文件，則建置一個新的
        if (!File.Exists(JsonPath))
        {
            File.Create(JsonPath);
        }
        string json = JsonUtility.ToJson(playerdata, true);
        File.WriteAllText(JsonPath, json);
        Debug.Log("保存成功");
    }

    //從本地讀取json數據
    public void ReadJson()
    {
        if (!File.Exists(JsonPath))
        {
            Debug.Log("要讀取的文件不存在!");
            return;
        }
        string json = File.ReadAllText(JsonPath);
        playerdatatemp = JsonUtility.FromJson<PlayerData>(json);
        //讀取第一個資料:名字
        string name = playerdata.PlayerName;
        //讀取第二個文件:分數
        int number = playerdata.Score;
    }
}
