using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingOpenClose : MonoBehaviour
{
    public GameObject settingmenu;

    public void Start()
    {
        settingmenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void OpenSettingsMenu()
    {
        settingmenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseSettingsMenu()
    {
        settingmenu.SetActive(false);
        Time.timeScale = 1;
    }
}
