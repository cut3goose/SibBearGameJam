﻿using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MainMenuSwitch : MonoBehaviour
{
    public BelkaGriefing belkaGriefing;
    public GameObject mainMenuScreen;
    public GameObject electricityStand;

    private void Awake()
    {
        //PlayerSettings.stripEngineCode = false;
        //PlayerSettings.SetManagedStrippingLevel(BuildTargetGroup.WebGL, ManagedStrippingLevel.Low);
    }

    private void Start()
    {
        electricityStand.SetActive(false);
        belkaGriefing.griefAvailable = false;
    }

    public void OnGameStart()
    {
        PlayerMovement.singleton.playerState = PlayerState.Alive;
        belkaGriefing.griefAvailable = true;
        mainMenuScreen.SetActive(false);
        electricityStand.SetActive(true);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
