using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingOpenClose : MonoBehaviour
{
    public GameObject settingmenu;
    public PlayerMovement playerMovement;

    public void Start()
    {
        settingmenu.SetActive(false);
        Time.timeScale = 1;
    }
    public void OpenSettingsMenu()
    {
        settingmenu.SetActive(true);
        playerMovement.enabled = false;
        Time.timeScale = 0;
    }

    public void CloseSettingsMenu()
    {
        settingmenu.SetActive(false);
        playerMovement.enabled = true;
        Time.timeScale = 1;
    }
}
