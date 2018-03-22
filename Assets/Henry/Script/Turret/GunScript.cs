using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public bool MovementReady;
    GameObject MosLocation;
    void Start()
    {
        MosLocation = GameObject.Find("MouseCursor");
        transform.LookAt(MosLocation.transform);
        transform.localEulerAngles = new Vector3(0, 0, Mathf.Clamp(transform.localEulerAngles.z, 45, 135));
    }

    void Update()
    {
        if (MovementReady == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                print("space pressed");
                transform.LookAt(MosLocation.transform);
                transform.localEulerAngles = new Vector3(0, 0, Mathf.Clamp(transform.localEulerAngles.z, 45, 135));

            }
        }
    }
    public void printStrings()
    {
        print("something");
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
