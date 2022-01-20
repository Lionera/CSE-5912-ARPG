using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameplayState : BaseGameplayState
{
    private static bool res = true;
    public override void Enter()
    {
        base.Enter();
        Debug.Log("entered GameplayState");
        gameplayStateController.gameplayUICanvas.enabled = true;
        pauseMenuButton.onClick.AddListener(() => OnPauseMenuClicked());

        resumeGameButton.onClick.AddListener(() => OnResumeGameClicked());
        exitToMainMenuButton.onClick.AddListener(() => OnExitToMenuClicked());
        exitGameButton.onClick.AddListener(() => OnExitGameClicked());
    }

    public override void Exit()
    {
        base.Exit();
        // Can remove this line to keep gameplay HUD visible while game is paused.
        gameplayStateController.gameplayUICanvas.enabled = false;
    }
    void OnResumeGameClicked()
    {
        ResumeGame();
    }

    void OnExitToMenuClicked()
    {
        Time.timeScale = 1;
        res = true;
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    void OnExitGameClicked()
    {
        Application.Quit();
    }

    void OnPauseMenuClicked()
    {
        PauseGame();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            if (res)
            {
                Debug.Log("Escape Pressed GP State");
                PauseGame();
            }
            else
            {
                ResumeGame();
            }
        }
    }

    void PauseGame()
    {
        gameplayStateController.gameplayUICanvas.enabled = false;
        Debug.Log("Game paused");
        Time.timeScale = 0;
        gameplayStateController.pauseMenuCanvas.enabled = true;
        res = false;
        //gameplayStateController.ChangeState<PauseGameState>();
    }
    void ResumeGame()
    {
        Debug.Log("entered GameplayState");
        gameplayStateController.gameplayUICanvas.enabled = true;
       // base.Exit();
        gameplayStateController.pauseMenuCanvas.enabled = false;
        Time.timeScale = 1;
        res = true;
        // gameplayStateController.ChangeState<GameplayState>();
    }
}
