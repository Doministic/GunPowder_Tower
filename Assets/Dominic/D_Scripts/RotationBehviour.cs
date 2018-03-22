using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationBehviour : MonoBehaviour
{
    GameObject background;
    public float curDegree = 0f;
    public float maxDeg = 360f;

    void Start()
    {
        background = GameObject.Find("Background");
    }
    void Update()
    {
        float zAngle = 1f;
        Quaternion rotator = transform.rotation;
        if (transform.rotation.z < 180)
        {
            background.transform.Rotate(eulerAngles: transform.forward * zAngle * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            zAngle = 2000f;
        }
    }
}
