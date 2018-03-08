using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIButtons : MonoBehaviour
{
<<<<<<< HEAD
    public GameObject[] SelectedTurrets;
=======
    GunScript SelectedTurrets;
>>>>>>> 4020e7a3f63bbda18f8636ee5c33fbe5155739fe


    public bool Eco;
    public bool Auto;
    public bool Hold;

    void Start()
    {
<<<<<<< HEAD
        SelectedTurrets = GameObject.FindGameObjectsWithTag("turret");
=======
        SelectedTurrets = GetComponent<GunScript>();

>>>>>>> 4020e7a3f63bbda18f8636ee5c33fbe5155739fe
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
<<<<<<< HEAD
            foreach (GameObject turret in SelectedTurrets)
            {
                print("hello");
            }
=======
            SelectedTurrets.printStrings();

>>>>>>> 4020e7a3f63bbda18f8636ee5c33fbe5155739fe
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
