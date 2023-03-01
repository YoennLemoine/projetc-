using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Child_2 : MonoBehaviour, IInteractable
{
    [SerializeField] private string _prompt;
    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        var inventory = interactor.GetComponent<Inventory>();

        if (inventory == null) return false;        
            
        if (inventory.HasSavedChild_1 == true)
        {
            Debug.Log("Touching Child_2 !");
            return true;
        }

        Debug.Log("need to save Child_1");
        return true;
    }
}
