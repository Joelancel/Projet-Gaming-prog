using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapeasy : MonoBehaviour
{
    public void Mapeasy(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("map_easy");
    }
}