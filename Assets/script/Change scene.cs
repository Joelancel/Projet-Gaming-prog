using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class change : MonoBehaviour
{
    public void ChangeScene(string sceneName)
    {
        SceneManager.LoadScene("Selectlevel");
    }

    public void ChangeScene2(string sceneName)
    {
        SceneManager.LoadScene("option");
    }

    public void exit()
    {
        Application.Quit();        
    }
}

