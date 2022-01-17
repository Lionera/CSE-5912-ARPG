using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterCreationState : BaseMenuState
{
    public override void Enter()
    {
        base.Enter();
        Debug.Log("entered character creation menu state");
        mainMenuController.createCharMenuCanvasObj.GetComponent<Canvas>().enabled = true;
        backFromCharCreateToMainButton.onClick.AddListener(() => OnBackButtonClicked());

    }

    public override void Exit()
    {
        base.Exit();
        mainMenuController.createCharMenuCanvasObj.GetComponent<Canvas>().enabled = false;
    }

    void OnBackButtonClicked()
    {
        mainMenuController.ChangeState<MainMenuRootState>();
    }
}
