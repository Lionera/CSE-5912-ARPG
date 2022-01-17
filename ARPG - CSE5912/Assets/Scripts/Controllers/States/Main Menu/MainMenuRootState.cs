using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuRootState : BaseMenuState
{
    public override void Enter()
    {
        base.Enter();
        Debug.Log("entered main menu root state");
        mainMenuController.mainMenuCanvasObj.GetComponent<Canvas>().enabled = true;
        startGameButton.onClick.AddListener(() => OnStartGameClicked());
        createCharButton.onClick.AddListener(() => OnCreateCharClicked());
    }

    public override void Exit()
    {
        base.Exit();
        mainMenuController.mainMenuCanvasObj.GetComponent<Canvas>().enabled = false;
    }

    void OnStartGameClicked()
    {
        Debug.Log("Start Button Clicked!");
    }

    void OnCreateCharClicked()
    {
        mainMenuController.ChangeState<CharacterCreationState>();
    }
}
