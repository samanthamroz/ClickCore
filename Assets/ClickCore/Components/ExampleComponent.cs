using UnityEngine;

public class ExampleComponent : Interactable, ILeftClick {
    void Start() {
        DoLeftClick();
    }
    public void DoLeftClick() {
        Debug.Log("Left clicked!");
    }
}