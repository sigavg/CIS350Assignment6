/* Luke Lesimple
 * Assignment 6
 * Loads levels
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager: Singleton<GameManager>
{
    public int score;

    public GameObject pauseMenu;

    private string CurrentLevelName = string.Empty;

    /*#region Singleton
    public static GameManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            Debug.LogError("Trying to instantiate a second instance of sigleton game manager");
        }
    }
    #endregion*/

    public void LoadLevel(string name)
    {
        AsyncOperation ao = SceneManager.LoadSceneAsync(name, LoadSceneMode.Additive);
        if(ao == null)
        {
            Debug.LogError("[GameManager] Unable to load level");
            return;
        }
        CurrentLevelName = name;
    }

    public void UnloadLevel(string name)
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(name);
        if (ao == null)
        {
            Debug.LogError("[GameManager] Unable to load level");
            return;
        }
    }

    public void Pause()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    public void Unpause()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }
    }

    public void UnloadCurrentLevel()
    {
        AsyncOperation ao = SceneManager.UnloadSceneAsync(CurrentLevelName);
        if (ao == null)
        {
            Debug.LogError("[GameManager] Unable to unload level");
            return;
        }
    }


}