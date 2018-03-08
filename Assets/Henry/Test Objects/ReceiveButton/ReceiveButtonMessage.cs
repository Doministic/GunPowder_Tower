using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiveButtonMessage : MonoBehaviour
{
    public enum GunModes
    {
        Eco, Auto, Hold
    }
    public bool selected;
    public GunModes currentMode;
    // Use this for initialization
    void Start()
    {
        selected = false;
        print(currentMode);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnMouseDown()
    {
        selected = !selected;
		print (selected);
    }
    public void GunButtonClick(GunModes currentMode)
    {
        if (selected == true)
        {
            if (currentMode == GunModes.Eco)
            {
                print("ECO MODE!!");
            }
            if (currentMode == GunModes.Auto)
            {
                print("AUTO MODE");
            }
            if (currentMode == GunModes.Hold)
            {
                print("HOLD FIRE!!");
            }
        }
    }
}


