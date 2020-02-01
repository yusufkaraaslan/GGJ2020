using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YCController : MonoBehaviour
{
    private const float Y_ANGLE_MİN = 0f;
    private const float Y_ANGLE_MAX = 50.0f;

    public bool isLocked;
    public Transform ycObj, ycCam;
    public float camDistance;

    private GameObject focusObj;
    private Vector3 lastPointerPos;

    private float currX = 0.001f, currY = 0.001f;

    public void Look()
    {
        Vector3 dir = new Vector3(0, 0, -camDistance);
        Quaternion rot = Quaternion.Euler(currX, currY, 0);
        ycCam.position = ycObj.position + rot * dir;
        ycCam.LookAt(ycObj.position);
    }

    public void ClickFocusable()
    {
        focusObj.GetComponent<Focusable>().TriggerObj();
    }

    public void LockPlayer()
    {
        isLocked = true;
    }

    public void UnlockPlayer()
    {
        isLocked = false;
    }

    private void Update()
    {
        currY += Input.GetAxis("Mouse X");
        currX += Input.GetAxis("Mouse Y");

        currX = Mathf.Clamp(currX, Y_ANGLE_MİN, Y_ANGLE_MAX);
    }

    private void LateUpdate()
    {
        if (!isLocked)
        {
            Look();
        }
    }

}
