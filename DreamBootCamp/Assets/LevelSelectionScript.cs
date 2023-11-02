using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectionScript : MonoBehaviour
{
    public Button[] lvlButtons;
    // Start is called before the first frame update
    void Start()
    {
        int MaxLevel = PlayerPrefs.GetInt("MaxLevel", 1);

        for (int i = 1; i <= lvlButtons.Length; i++) {
            if (i > MaxLevel) {
                lvlButtons[i-1].interactable = false;
            }
        }
    }
}
