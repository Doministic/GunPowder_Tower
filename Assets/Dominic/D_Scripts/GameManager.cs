using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : BaseSingletonBehaviour<GameManager>
{

    private float timeRemaining;
    private float maxTime = 180;

    void Start()
    {
        timeRemaining = maxTime;
    }

    void Update()
    {
        timeRemaining -= Time.fixedUnscaledDeltaTime;

        if (timeRemaining <= 0)
        {
            SceneManager.LoadScene("01_MainMenu_A");
            timeRemaining = maxTime;
        }
    }

    public float TimeRemaining
    {
        get { return timeRemaining; }
        set { timeRemaining = value; }
    }
}
