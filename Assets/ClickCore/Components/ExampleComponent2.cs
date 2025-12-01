using UnityEngine;

public class ExampleComponent2 : Interactable, ILeftClick, ILeftRelease, ILeftClickAway {
    public void DoLeftClick() {
        Debug.Log("Cube left clicked");
    }

    public void DoLeftClickAway() {
        Debug.Log("Cube left clicked away");
    }

    public void DoLeftRelease() {
        Debug.Log("Cube left released");
    }
}