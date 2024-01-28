using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Settingmenu : MonoBehaviour
{
    public void SetVolume(float volume)
    {
        Debug.Log(volume);
    }

    public void SetQuality (int qualityIndex)
    {
        QualitySettings.SetQualityLevel (qualityIndex);
    }
       
    public void SetFullscreen (bool isFullscreen) 
    { 
        Screen.fullScreen = isFullscreen;
    }


}
