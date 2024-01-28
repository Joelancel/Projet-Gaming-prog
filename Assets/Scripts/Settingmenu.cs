using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


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
    public Dropdown DResolution;
 
    public void SetResolution()
    {
        switch (DResolution.value)
        {
            case 0:
                Screen.SetResolution(640, 360, true);
                break;

                case 1:
                Screen.SetResolution(1920, 1080, true);
                break;
        }
    }

}
