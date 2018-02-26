using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public bool MovementReady;
    public Transform MosLocation;
    void Update()
    {
        transform.LookAt(MosLocation);
        if (transform.localEulerAngles.x > 0)
        {
            transform.localEulerAngles = new Vector3 (Mathf.Clamp(transform.localEulerAngles.x,0,180),transform.localEulerAngles.y,transform.localEulerAngles.z);
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
