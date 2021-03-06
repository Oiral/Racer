﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Controllers { Disconected, Keyboard, ps4_controller, wired_xbox_360_controller, wireless_xbox_360_controller, xbox_one_controller };

public class ControllerMapping : MonoBehaviour {

    public static ControllerMapping instance;

    public Controllers currentController = Controllers.Keyboard;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }else if (instance != this)
        {
            Destroy(this);
        }
        SetControllers();
    }

    public void SetControllers()
    {
        foreach (string joyName in Input.GetJoystickNames())
        {
            switch (joyName.Length)
            {
                case 19:
                    currentController = Controllers.ps4_controller;
                    Debug.Log("Found a ps4 Controller");
                    return;
                case 51:
                    currentController = Controllers.wireless_xbox_360_controller;
                    Debug.Log("Found a xbox 360 wireless controller");
                    return;
                default:
                    currentController = Controllers.Keyboard;
                    break;
            }
        }
    }

    public float TriggerAxis()
    {
        //Debug.Log("Checking");
        switch (currentController)
        {
            case Controllers.Keyboard:
                return Input.GetAxis("keyboard_Vertical");

            case Controllers.ps4_controller:
                float rightTrigger = Input.GetAxis("ps4_RightTrigger");

                float leftTrigger = -Input.GetAxis("ps4_LeftTrigger");
                return (rightTrigger + leftTrigger);
            
            case Controllers.wireless_xbox_360_controller:
                return (-Input.GetAxis("xbox_360_Wireless_Triggers"));
                /*
            case Controllers.wired_xbox_360_controller:
                break;
            case Controllers.xbox_one_controller:
                break;*/
            default:
                return 0;
        }
    }

    public float HorizontalMovement()
    {
        switch (currentController)
        {
            case Controllers.Keyboard:
                return Input.GetAxis("keyboard_Horizontal");

            case Controllers.ps4_controller:
                return Input.GetAxis("Left_Horizontal_Joystick");

            case Controllers.wireless_xbox_360_controller:
                return Input.GetAxis("Left_Horizontal_Joystick");
                /*
            case Controllers.wired_xbox_360_controller:
                break;
            
            case Controllers.xbox_one_controller:
                break;*/
            default:
                return 0;
        }
    }

    public float VerticalMovement()
    {
        switch (currentController)
        {
            case Controllers.Keyboard:
                return Input.GetAxis("keyboard_Vertical");

            case Controllers.ps4_controller:
                return Input.GetAxis("Left_Vertical_Joystick");

            case Controllers.wireless_xbox_360_controller:
                return Input.GetAxis("Left_Vertical_Joystick");
            /*
        case Controllers.wired_xbox_360_controller:
            break;

        case Controllers.xbox_one_controller:
            break;*/
            default:
                return 0;
        }
    }

    public bool GetSelectDown()
    {
        switch (currentController)
        {
            case Controllers.Keyboard:
                return Input.GetButtonDown("keyboard_Select");

            case Controllers.ps4_controller:
                return Input.GetButtonDown("ps4_X");

            case Controllers.wireless_xbox_360_controller:
                return Input.GetButtonDown("xbox_360_Wireless_A");
            /*
        case Controllers.wired_xbox_360_controller:
            break;

        case Controllers.xbox_one_controller:
            break;*/
            default:
                return false;
        }
    }

    public bool GetBackDown()
    {
        switch (currentController)
        {
            case Controllers.Keyboard:
                return Input.GetButtonDown("keyboard_Back");

            case Controllers.ps4_controller:
                return Input.GetButtonDown("ps4_Circle");

            case Controllers.wireless_xbox_360_controller:
                return Input.GetButtonDown("xbox_360_Wireless_B");
            /*
        case Controllers.wired_xbox_360_controller:
            break;

        case Controllers.xbox_one_controller:
            break;*/
            default:
                return false;
        }
    }

    public bool GetStartDown()
    {
        switch (currentController)
        {
            case Controllers.Keyboard:
                return Input.GetButtonDown("keyboard_Escape");

            case Controllers.ps4_controller:
                return Input.GetButtonDown("ps4_Options");

            case Controllers.wireless_xbox_360_controller:
                return Input.GetButtonDown("xbox_360_Wireless_Start");
            /*
        case Controllers.wired_xbox_360_controller:
            break;

        case Controllers.xbox_one_controller:
            break;*/
            default:
                return false;
        }
    }

#region Buttons
    public bool GetADown()
    {
        switch (currentController)
        {
            case Controllers.Keyboard:
                return Input.GetButtonDown("keyboard_Down");

            case Controllers.ps4_controller:
                return Input.GetButtonDown("ps4_X");

            case Controllers.wireless_xbox_360_controller:
                return Input.GetButtonDown("xbox_360_Wireless_A");
            /*
        case Controllers.wired_xbox_360_controller:
            break;

        case Controllers.xbox_one_controller:
            break;*/
            default:
                return false;
        }
    }

    public bool GetBDown()
    {
        switch (currentController)
        {
            case Controllers.Keyboard:
                return Input.GetButtonDown("keyboard_Right");

            case Controllers.ps4_controller:
                return Input.GetButtonDown("ps4_Circle");

            case Controllers.wireless_xbox_360_controller:
                return Input.GetButtonDown("xbox_360_Wireless_B");
            /*
        case Controllers.wired_xbox_360_controller:
            break;

        case Controllers.xbox_one_controller:
            break;*/
            default:
                return false;
        }
    }

    public bool GetYDown()
    {
        switch (currentController)
        {
            case Controllers.Keyboard:
                return Input.GetButtonDown("keyboard_Up");

            case Controllers.ps4_controller:
                return Input.GetButtonDown("ps4_Triangle");

            case Controllers.wireless_xbox_360_controller:
                return Input.GetButtonDown("xbox_360_Wireless_Y");
            /*
        case Controllers.wired_xbox_360_controller:
            break;

        case Controllers.xbox_one_controller:
            break;*/
            default:
                return false;
        }
    }

    public bool GetXDown()
    {
        switch (currentController)
        {
            case Controllers.Keyboard:
                return Input.GetButtonDown("keyboard_Left");

            case Controllers.ps4_controller:
                return Input.GetButtonDown("ps4_Square");

            case Controllers.wireless_xbox_360_controller:
                return Input.GetButtonDown("xbox_360_Wireless_X");
            /*
        case Controllers.wired_xbox_360_controller:
            break;

        case Controllers.xbox_one_controller:
            break;*/
            default:
                return false;
        }
    }


#endregion
}
