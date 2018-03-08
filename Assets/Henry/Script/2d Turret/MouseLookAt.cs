using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLookAt : MonoBehaviour
{
    // Use this for initialization
    public float zAngle;
    MousePosition mosPos;
    GameObject MouseCursor;
    Quaternion desiredRot;
    bool iAmRotating;

    [SerializeField]
    Quaternion getParentRotation;
    Transform theParentsTransform;

    void Start()
    {
        MouseCursor = GameObject.Find("MouseCursor");
        mosPos = MouseCursor.GetComponent<MousePosition>();
        GetParentsRotation();

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
            zAngle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;

            Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle - getParentRotation.eulerAngles.z);
            transform.localRotation = Quaternion.RotateTowards(transform.localRotation, desiredRot, 90.0f * Time.unscaledDeltaTime);
            
            if (transform.rotation.z > 45)
            {
                transform.rotation.z = 45;
            }

            if (transform.localRotation == desiredRot)
            {
                iAmRotating = false;
            }
        }
    }
    public void GetParentsRotation()
    {
        theParentsTransform = GetComponentInParent<Transform>();
        getParentRotation = theParentsTransform.rotation;
    }

}