using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private DialogueUI dialogueUI;

    public DialogueUI DialogueUI => dialogueUI;

    public IInteractable Interactable {get; set; }

    void Update()
    {
        if (dialogueUI.IsOpen) return;
        if (Input.GetMouseButton(0))
        {
            MoveToCursor();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Interactable != null)
            {
                Interactable.Interact(player: this);
            }
        }
    }

    private void MoveToCursor()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit rcHit;
        if (Physics.Raycast(ray, out rcHit))
        {
            GetComponent<NavMeshAgent>().destination = rcHit.point;
        }

     
    }
}

