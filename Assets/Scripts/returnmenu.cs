using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnmenu : MonoBehaviour
{
    public void Returnmenu(string sceneName)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("menu");
    }
}
