using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class maphard : MonoBehaviour
{
    public void Maphard(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("map_hard");
    }
}
