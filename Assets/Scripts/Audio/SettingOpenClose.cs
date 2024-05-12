using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingOpenClose : MonoBehaviour
{
    public GameObject settingmenu;
    public Action onsettingOpenAction;
    public Action onsettingCloseAction;
    

    public void Start()
    {
        settingmenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void OpenSettingsMenu()
    {
        settingmenu.SetActive(true);
        if(onsettingOpenAction != null)
        onsettingOpenAction();
        Time.timeScale = 0;
    }

    public void CloseSettingsMenu()
    {
        settingmenu.SetActive(false);
        if(onsettingCloseAction != null)
        onsettingCloseAction();
        Time.timeScale = 1;
    }
}
