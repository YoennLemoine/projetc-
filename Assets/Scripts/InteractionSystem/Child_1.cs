using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child_1 : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        var inventory = interactor.GetComponent<Inventory>();
        Debug.Log("Touching Child_1 !");
        inventory.HasSavedChild_1 = true;
        return true;
    }
}
