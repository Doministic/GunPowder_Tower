using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionStatus : MonoBehaviour
{
    public bool iSeeMouse;
    public bool iAmSelected;
    // Use this for initialization
    void Start()
    {

        iSeeMouse = false;
        iAmSelected = false;
    }

    private void OnMouseEnter()
    {
        iSeeMouse = true;
    }
    private void OnMouseExit()
    {
        iSeeMouse = false;
    }
    private void OnMouseDown()
    {
        if (iAmSelected == false)
        {
            Debug.Log("I been Click");
            iAmSelected = true;
            GetComponentInChildren<GunScript>().readyToMove();
        }
        else
        {
            iAmSelected = false;
            GetComponentInChildren<GunScript>().readyToMove();
        }
    }
    public void ClearSelection()
    {
        iAmSelected = false;
    }
}
