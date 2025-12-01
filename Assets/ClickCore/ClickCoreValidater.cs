using UnityEngine;

public class ClickCoreValidater
{
    public bool AllInteractablesValid() {
        foreach (Interactable i in GameObject.FindObjectsByType<Interactable>(FindObjectsSortMode.None)) {
            if (!i.ValidInteractableConfiguration()) {
                return false;
            }
        }
        
        return true;
    }

}