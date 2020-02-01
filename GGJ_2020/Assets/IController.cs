using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IController : MonoBehaviour
{
    public float speed;
    private float realSpeed;
    public GameObject camera;
    float rotation;
    void Update()
    {
        rotation = Input.GetAxis("Horizontal");

        if (Mathf.Abs(realSpeed - speed) > 0.05)
        {
            speed += ( realSpeed - speed) / 30;
        }

        if (rotation != 0)
        {
            move(rotation);
        }

    }

    public void move(float val)
    {

    }

    public void TriggerNPC()
    {

    }

    public void LockPlayer()
    {

    }
    public void UnLockPlayer()
    {

    }

}
