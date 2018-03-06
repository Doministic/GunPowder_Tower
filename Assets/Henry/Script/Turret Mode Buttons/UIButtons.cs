using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtons : MonoBehaviour
{
    public GameObject[] SelectedTurrets;


    public bool Eco;
    public bool Auto;
    public bool Hold;

    void Start()
    {
        SelectedTurrets = GameObject.FindGameObjectsWithTag("turret");
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
            foreach (GameObject turret in SelectedTurrets)
            {
                print("hello");
            }
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
