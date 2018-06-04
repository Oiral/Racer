using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Controllers { Disconected, Keyboard, ps4_controller, wired_xbox_360_controller, wireless_xbox_360_controller, xbox_one_controller };

public static class ControllerMapping{

    public static Controllers currentController = Controllers.Keyboard;

    public static void SetControllers()
    {
        foreach (string joyName in Input.GetJoystickNames())
        {
            switch (joyName.Length)
            {
                case 19:
                    currentController = Controllers.ps4_controller;
                    break;
            }
        }
    }


    public static float TriggerAxis()
    {
        //Debug.Log("Checking");
        switch (currentController)
        {
            case Controllers.Keyboard:
                return Input.GetAxis("keyboard_Vertical");
            case Controllers.ps4_controller:
                float rightTrigger = Input.GetAxis("ps4_RightTrigger");
                //rightTrigger = (rightTrigger + 1) / 2;

                float leftTrigger = -Input.GetAxis("ps4_LeftTrigger");
                //leftTrigger = -((leftTrigger + 1) / 2);
                //Debug.Log("PS4 :" + (rightTrigger + leftTrigger).ToString());
                return (rightTrigger + leftTrigger);
                /*
            case Controllers.wired_xbox_360_controller:
                break;
            case Controllers.wireless_xbox_360_controller:
                break;
            case Controllers.xbox_one_controller:
                break;*/
            default:
                return 0;
        }
    }
    public static float HorizontalMovement()
    {
        switch (currentController)
        {
            case Controllers.Keyboard:
                return Input.GetAxis("keyboard_Horizontal");
            case Controllers.ps4_controller:
                return Input.GetAxis("ps4_Left_Horizontal_Joystick");
                /*
            case Controllers.wired_xbox_360_controller:
                break;
            case Controllers.wireless_xbox_360_controller:
                break;
            case Controllers.xbox_one_controller:
                break;*/
            default:
                return 0;
        }
    }

}
