using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptSwitch : MonoBehaviour
{

    private bool RotateOn = false;
    private bool ScaleOn = false;

    public void RotateSwitch()
    {
        if (RotateOn)
        {
            gameObject.GetComponent<SwipeRotate>().enabled = true;
        }

        else if (RotateOn != false)
        {
            gameObject.GetComponent<SwipeRotate>().enabled = false;
        }
    }

    public void ScaleSwitch()
    {
        if (ScaleOn)
        {
            gameObject.GetComponent<PinchScale>().enabled = true;
        }

        else if (ScaleOn != false)
        {
            gameObject.GetComponent<PinchScale>().enabled = false;
        }
    }

    /*public void TurnOffRotate()
    {
        gameObject.GetComponent<SwipeRotate>().enabled = false;
    }

    public void TurnOnRotate()
    {
        gameObject.GetComponent<SwipeRotate>().enabled = true;
    }*/

}
