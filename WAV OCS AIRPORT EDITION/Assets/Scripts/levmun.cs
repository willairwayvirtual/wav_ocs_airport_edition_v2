using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class levmun : MonoBehaviour
{

    public void OnclickLevel(int levelNum)
    {
        SceneManager.LoadScene("Gamescene");
    }
    public void OnClickBack()
    {
        this.gameObject.SetActive(false);
    }
    // Start is called before the first
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
