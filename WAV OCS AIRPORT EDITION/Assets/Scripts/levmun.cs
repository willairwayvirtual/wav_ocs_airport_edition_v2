using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levmun : MonoBehaviour
{

    public LevelObject[] levelObjects;
    public static int currLevel;
    public static int UnlockedLevels;

    public void OnclickLevel(int levelNum)
    {
        currLevel = levelNum;
        SceneManager.LoadScene("Gamescene");
    }
    public void OnClickBack()
    {
        this.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        UnlockedLevels = PlayerPrefs.GetInt("UnlockedLevels", 0);

        for (int i = 0; 1 < levelObjects.Length; i++)
        {
            if (UnlockedLevels >= i)
            {
                levelObjects[i].levelButton.interactable = true;
            }
        }
    }
    public void back()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);

    }
    public void back2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);

    }

    public void Quit()
    {
        Debug.Log("quit?");
        Application.Quit();
    }



}
