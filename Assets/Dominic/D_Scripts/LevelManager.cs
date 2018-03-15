using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static bool isPaused = false;
    public static bool isRealTimePaused = false;


    private GameObject pauseMenuUI;
    private GameObject realTimePause;
    private float realTimePauseDelay = 2.0f;

    void Start()
    {
        float autoLoadNextLevel = 3.5f;
        realTimePause = GameObject.Find("RealTimePause");
        pauseMenuUI = GameObject.Find("PauseMenu");

        if (SceneManager.GetActiveScene().buildIndex > 2)
        {
            if (pauseMenuUI != null)
            {
                pauseMenuUI.SetActive(false);
            }
        }
        else
        {
            Invoke("LoadNextLevel", autoLoadNextLevel);
            pauseMenuUI = null;
            realTimePause = null;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                PauseGame();
            }
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            if (isRealTimePaused)
            {
                RealTimeResume();
                realTimePauseDelay -= Time.fixedUnscaledDeltaTime;

            }
            else
            {
                RealTimePause();
            }
        }
    }
    public void LoadLevel(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void RealTimePause()
    {
        isRealTimePaused = true;
        Time.timeScale = 0f;
    }

    public void RealTimeResume()
    {
        if (realTimePauseDelay <= 0)
        {
            isRealTimePaused = false;
            realTimePauseDelay = 10.0f;
        }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
