using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGameState : BaseGameplayState
{
    public override void Enter()
    {
        base.Enter();
        Debug.Log("Game paused");
        Time.timeScale = 0;
        gameplayStateController.pauseMenuCanvas.enabled = true;
        resumeGameButton.onClick.AddListener(() => OnResumeGameClicked());
        exitToMainMenuButton.onClick.AddListener(() => OnExitToMenuClicked());
    }

    public override void Exit()
    {
        base.Exit();
        gameplayStateController.pauseMenuCanvas.enabled = false;
        Time.timeScale = 1;
    }

    void OnResumeGameClicked()
    {
        ResumeGame();
    }

    void OnExitToMenuClicked()
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Debug.Log("Escape Pressed");
            ResumeGame();
        }
    }

    void ResumeGame()
    {
        gameplayStateController.ChangeState<GameplayState>();
    }
}
