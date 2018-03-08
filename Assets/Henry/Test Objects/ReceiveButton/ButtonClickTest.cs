using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClickTest : MonoBehaviour
{
    public GameObject[] testSceneObjects;
    ReceiveButtonMessage selectedTestObjects;
    // Use this for initialization
    void Start()
    {
        testSceneObjects = GameObject.FindGameObjectsWithTag("test");
        selectedTestObjects = GetComponent<ReceiveButtonMessage>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ButtonClickTestUI(string gunModeToSwitchTo)
    {
        foreach (GameObject test in testSceneObjects)
        {
            test.GetComponent<ReceiveButtonMessage>().GunButtonClick(gunModeToSwitchTo);
        }
    }
}
