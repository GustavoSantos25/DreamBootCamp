using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    void Start(){
        PlayerPrefs.SetInt("LevelSelectionScene", 1);
        PlayerPrefs.SetInt("LevelScene", 2);
    }

    public void playGame() {
        SceneManager.LoadScene(PlayerPrefs.GetInt("LevelSelectionScene"));
    }

    public void quitGame() {
        Debug.Log("Quit");
        Application.Quit();
    }
}
