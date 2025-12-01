using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(PlayerInput))]
public class ClickCore : MonoBehaviour
{
    public static ClickCore self;
    private ClickCoreValidater validater;
    private MouseController mouseController;
    private IMouse mouse;
    private IInteractionTriggerer interactionTriggerer;
    
    void Awake() {
        if (self == null) {
            self = this;

            mouse = new Mouse();
            interactionTriggerer = new InteractionTriggerer();

            InputActionAsset inputActions = Resources.Load<InputActionAsset>("ClickCoreInputActions");
            mouseController = new MouseController(interactionTriggerer, mouse, inputActions);

            validater = new ClickCoreValidater();

            DoSceneValidation();
            SceneManager.sceneLoaded += SceneStart;

            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    //Required Unity Function Signature
    private void SceneStart(Scene scene, LoadSceneMode mode) {
        DoSceneValidation();
    }

    private void DoSceneValidation() {
        if (!validater.AllInteractablesValid()) {
            Debug.LogError("ClickCore >> Some Interactables are not configured properly");
        }
    }

    public Vector2 GetMousePosition() {
        return mouse.ScreenPosition;
    }

    public bool IsMouseButtonDown(MouseButton button) {
        return mouse.IsButtonDown(button);
    }
}

