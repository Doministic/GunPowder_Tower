using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtons : MonoBehaviour
{

    public bool Eco;
    public bool Auto;
    public bool Hold;

    void Start()
    {
        GunScript SelectedTurrets = GetComponent<GunScript>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ButtonUiClick()
    {
        if (Eco == true)
        {
            print(" Eco");
        }
        if (Auto == true)
        {
            print(" Auto ");
        }
        if (Hold == true)
        {
            print(" Hold ");
        }
    }
}
