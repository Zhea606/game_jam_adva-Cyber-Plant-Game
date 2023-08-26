using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //singleton, para poder acceder al GM desde cualquier objeto o clase
    public static GameManager Instance { get; private set; }

    public HUD hud;
    public GameObject pauseUI;
    private int foundPieces = 0;

    public static bool gameIsPaused;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameIsPaused = !gameIsPaused;
            PauseGame();
        }
    }
    void PauseGame()
    {
        if (gameIsPaused)
        {
            Time.timeScale = 0f;
            pauseUI.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            pauseUI.SetActive(false);
        }
    }
    public void Continue()
    {
        Time.timeScale = 1;
        pauseUI.SetActive(false);
    }

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Debug.Log("Mas de un Game Manager en escena");
        }
    }

    
    public void ObjectFind()
    {
        hud.RecollectPiece(foundPieces);
        foundPieces += 1;
    }
}
