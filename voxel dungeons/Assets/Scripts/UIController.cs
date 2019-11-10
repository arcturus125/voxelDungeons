﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public static bool isCursorVisible = true; //when true, the user can use mouse to navigate menus without rotating the camera or player in game

    // Start is called before the first frame update
    void Start()
    {
        ToggleMenus(); //default to cursor invisible on start
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) // when escape is pressed
            ToggleMenus();                    // toggle whether mouse moves character or cursor
    }

    void ToggleMenus()
    {
        isCursorVisible = !isCursorVisible;           // toggles between
        if (isCursorVisible)                          // - locking cursor and mouse movements
            Cursor.lockState = CursorLockMode.None;   //   move player and camera
        else                                          // - unlocking cursor so user can navigate menus
            Cursor.lockState = CursorLockMode.Locked; //   and locking the players rotation
        Cursor.visible = isCursorVisible;             //

    }
}
