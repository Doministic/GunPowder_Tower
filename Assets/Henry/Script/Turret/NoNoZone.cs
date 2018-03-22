using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoNoZone : MonoBehaviour
{
    // Use this for initialization
    void OnTriggerEnter2D(Collider2D other)
    {
        print("Something WENT IN ME!!!!");
    }
    void OnTriggerExit2D(Collider2D other)
    {
        print("Something went boop");
    }
}






