using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookAt : MonoBehaviour
{
    // Use this for initialization
    MousePosition mosPos;
    GameObject MouseCursor;
    Quaternion desiredRot;
    bool iAmRotating;

    void Start()
    {
        MouseCursor = GameObject.Find("MouseCursor");
        mosPos = GetComponent<MousePosition>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            mosPos.MoveToMousePosition();
            iAmRotating = true;
        }
        if (iAmRotating == true)
        {
            Vector3 direction = MouseCursor.transform.position - transform.position;
            direction.Normalize();
            float zAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
            Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, 90.0f * Time.deltaTime);
            if (transform.rotation == desiredRot)
            {
                iAmRotating = false;
            }
        }
    }
}
