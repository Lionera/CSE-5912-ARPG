using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayState : BaseGameplayState
{
    public override void Enter()
    {
        base.Enter();
        Debug.Log("entered GameplayState");
        gameplayStateController.gameplayUICanvas.enabled = true;
        pauseMenuButton.onClick.AddListener(() => OnPauseMenuClicked());
    }

    public override void Exit()
    {
        base.Exit();
        // Can remove this line to keep gameplay HUD visible while game is paused.
        gameplayStateController.gameplayUICanvas.enabled = false;
    }

    void OnPauseMenuClicked()
    {
        PauseGame();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            PauseGame();
        }
    }

    void PauseGame()
    {
        gameplayStateController.ChangeState<PauseGameState>();
    }
}
