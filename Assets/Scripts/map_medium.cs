using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapmedium : MonoBehaviour
{
    public void Mapmedium(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("map_medium");
    }
}
