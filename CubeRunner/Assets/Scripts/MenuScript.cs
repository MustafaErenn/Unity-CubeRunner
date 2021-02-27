using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    void Start()
    {
        PlayerPrefs.GetInt("SceneIndex", 1).ToString();
    }
    public void PlayMenu()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("SceneIndex", 1));
    }  
    
    public void QuitButton()
    {
        Application.Quit();
    }
}
