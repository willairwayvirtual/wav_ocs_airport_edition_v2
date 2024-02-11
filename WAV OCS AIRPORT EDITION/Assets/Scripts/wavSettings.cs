using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class wavSettings : MonoBehaviour
{
    

    public Dropdown resolutionDropdown;
  
    Resolution[] resolutions;
    private void Start()
    {
        resolutions = Screen.resolutions;
       
        resolutionDropdown.ClearOptions();


        List<string> options = new List<string>();
        for (int i = 0; i < resolutions.Length; i++)
        {


            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);
        }
        resolutionDropdown.AddOptions(options);
    }
        public void SetQuality(int qualityIndex)
        {
            QualitySettings.SetQualityLevel(qualityIndex);
        }
        public void SetFullScreen(bool isFullScreen)
        {
            Screen.fullScreen = isFullScreen;
        }
        public void back()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);

        }
    }
