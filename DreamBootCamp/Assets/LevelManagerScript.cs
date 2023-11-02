using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;
using Newtonsoft.Json;

public class LevelManagerScript : MonoBehaviour
{
    private int CurLevel;
    // Start is called before the first frame update
    void Start()
    {
        CurLevel = PlayerPrefs.GetInt("LevelAt");

        string LevelFileName = "level_" + CurLevel.ToString() + ".json";
        string jsonString = File.ReadAllText(LevelFileName);
        Level level = JsonConvert.DeserializeObject<Level>(jsonString);

        Debug.Log(level);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
