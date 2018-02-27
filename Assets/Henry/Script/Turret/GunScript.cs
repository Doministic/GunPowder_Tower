using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public bool MovementReady;
    public Transform MosLocation;
    void Update()
    {
        if (MovementReady == true)
        {
            if (Input.GetMouseButtonDown (1))
            {
            transform.LookAt(MosLocation);
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, Mathf.Clamp(transform.localEulerAngles.y, 45, 135), transform.localEulerAngles.z);

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
