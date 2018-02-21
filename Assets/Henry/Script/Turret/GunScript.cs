using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public bool MovementReady;
    void Update()
    {
        if (MovementReady == true)
        {
            if (Input.GetKey(KeyCode.A))
            {
                transform.Rotate(Vector3.forward * 50 * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.Rotate(Vector3.forward * -1.0f * 50 * Time.deltaTime);
            }
            if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D))
            {
                GetComponentInChildren<BulletScript>().CantFire();
            }
            if (Input.GetKeyUp("a") || Input.GetKeyUp("d"))
            {
                GetComponentInChildren<BulletScript>().CanFire();
            }
        }

    }
    public void readyToMove()
    {
        if (MovementReady == false)
        {
            MovementReady = true;
            print(" I Am ready movement");
        }
        else
        {
            MovementReady = false;
            print(" I Can't Move");
        }
    }
    public void ClearSelection()
    {
        MovementReady = false;
    }
}
