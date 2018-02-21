using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

	public string helloWorldTestStart = "Hello World";
	public string helloWorldTestUpdate = "Hello Worlds";


	// Use this for initialization
	void Start () {
		Debug.Log(helloWorldTestStart);
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log(helloWorldTestUpdate);
	}
}
