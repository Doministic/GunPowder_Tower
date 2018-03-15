using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkyRotation : MonoBehaviour {

    public float cur_Deg = 0f;
    public float max_Deg = 360f;


    void Start()
    {

    }

    void Update()
    {
        cur_Deg += 1f;
        transform.Rotate(eulerAngles: Vector3.forward * Time.deltaTime);
       // if (Input.GetKeyDown("space"))
       

    }

    void Degreset(float degrees)
    {
       
    }
}
