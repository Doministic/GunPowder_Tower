using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManagerMain : MonoBehaviour {
	public float autoLoadNextLevel = 3.5f;
    public GameObject pauseMenuUI;

    public static bool isPaused = false;

    private void Start()
    {
        pauseMenuUI.SetActive(false);
        if (SceneManager.GetActiveScene().buildIndex > 2)
        {
           // Debug.Log("Index is greater than 0");
        }
        else
        {
            Invoke("LoadNextLevel", autoLoadNextLevel);
        }
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P)){
            if(isPaused){
                Resume();
            }
            else{
                PauseGame();
            }
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

    public void PauseGame(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
