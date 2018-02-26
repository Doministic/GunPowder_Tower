using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : BaseSingletonBehaviour<GameManager> {

	public float minutesInGame = 1;

	private float timeRemaining;
	private float maxTime;

	void Start () {
		maxTime = minutesInGame * 60;
		timeRemaining = maxTime;
	}
	
	void Update () {
		timeRemaining -= Time.deltaTime;

		if (timeRemaining <= 0){
			SceneManager.LoadScene("01_MainMenu_A");
			timeRemaining = maxTime;
		}
	}

	public float TimeRemaining{
		get {return timeRemaining;}
		set {timeRemaining = value;}
	}
}
