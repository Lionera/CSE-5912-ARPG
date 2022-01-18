using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseGameState : BaseGameplayState
{
    public override void Enter()
    {
        base.Enter();
        Debug.Log("Game paused");
        Time.timeScale = 0;
        gameplayStateController.pauseMenuCanvas.enabled = true;
        resumeGameButton.onClick.AddListener(() => OnResumeGameClicked());
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

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            ResumeGame();
        }
    }

    void ResumeGame()
    {
        gameplayStateController.ChangeState<GameplayState>();
    }
}
