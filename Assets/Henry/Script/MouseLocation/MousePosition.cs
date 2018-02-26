using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mosPos = Input.mousePosition;
        mosPos.z = 30;
        mosPos = Camera.main.ScreenToWorldPoint(mosPos);
        transform.position = mosPos;
    }
}
