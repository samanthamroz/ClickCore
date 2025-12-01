using UnityEngine;

public class ExampleComponent : Interactable, ILeftClick, ILeftRelease, IRightRelease {
    public void DoLeftClick() {
        Debug.Log("Sphere left clicked");
    }
    public void DoLeftRelease() {
        Debug.Log("Sphere left released");
    }
    public void DoRightRelease() {
        Debug.Log("Sphere right released");
    }
}