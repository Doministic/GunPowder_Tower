using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {
	public float autoLoadNextLevel = 3.5f;

    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex > 2)
        {
           // Debug.Log("Index is greater than 0");
        }
        else
        {
            Invoke("LoadNextLevel", autoLoadNextLevel);
        }
    }

    public void LoadLevel(string levelName )
    {
        SceneManager.LoadScene(levelName);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
