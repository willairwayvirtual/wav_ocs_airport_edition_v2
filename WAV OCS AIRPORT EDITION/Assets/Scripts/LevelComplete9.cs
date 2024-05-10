using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelComplete9 : MonoBehaviour
{

    public void OnLevelComplete()
    {
        
        SceneManager.LoadScene("Credit scene");
    }
    public void Quit()
    {
        Debug.Log("quit?");
        Application.Quit();
    }
}
