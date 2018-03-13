using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MousePosition : MonoBehaviour
{
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MoveToMousePosition();
        }
    }
    public void MoveToMousePosition()
    {
        Vector3 mosPos = Input.mousePosition;

        mosPos = Camera.main.ScreenToWorldPoint(mosPos);
        mosPos.z = 0;
        transform.position = mosPos;

        print("i moved");
    }
}
