using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete1 : MonoBehaviour
{

    public void OnLevelComplete()
    {
        if (levmun.currLevel == levmun.UnlockedLevels)
        {
            levmun.UnlockedLevels++;
            PlayerPrefs.SetInt("UnlockedLevels", levmun.UnlockedLevels);
        }
        SceneManager.LoadScene("LevelSelectionMenu");
    }
    public void Quit()
    {
        Debug.Log("quit?");
        Application.Quit();
    }
}