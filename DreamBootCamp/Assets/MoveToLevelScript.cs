using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToLevelScript : MonoBehaviour
{
    public int LevelNumber;
    // Start is called before the first frame update
    /*void Start()
    {
        LevelNumber += SceneManager.GetActiveScene().buildIndex;
    }*/

    public void MoveToLevel() {
        PlayerPrefs.SetInt("LevelAt", LevelNumber);

        if(LevelNumber > PlayerPrefs.GetInt("MaxLevel", 1)) {
            PlayerPrefs.SetInt("MaxLevel", LevelNumber);
        }

        SceneManager.LoadScene(PlayerPrefs.GetInt("LevelScene"));
    }
}
