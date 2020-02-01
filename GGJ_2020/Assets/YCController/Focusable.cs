using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Focusable : MonoBehaviour
{
    public FocusEvent focus;

    public void FocusEnter()
    {

    }

    public void FocusExit()
    {

    }

    public void TriggerObj()
    {
        focus.TriggerEvent();
    }

}
