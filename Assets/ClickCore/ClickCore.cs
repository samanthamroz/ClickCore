using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using System;

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
            DontDestroyOnLoad(gameObject);
        } else {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        mouse = new Mouse();
        interactionTriggerer = new InteractionTriggerer();

        InputActionAsset inputActions = Resources.Load<InputActionAsset>("ClickCoreInputActions");
        mouseController = new MouseController(interactionTriggerer, mouse, inputActions);
    }

    public Vector2 GetMousePosition() {
        return mouse.ScreenPosition;
    }

    public bool IsMouseButtonDown(MouseButton button) {
        return mouse.IsButtonDown(button);
    }
}

