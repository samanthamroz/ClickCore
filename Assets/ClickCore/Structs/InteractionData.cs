using UnityEngine;

public struct InteractionData
{
    public Vector2 screenPosition;
    public MouseButton button;
    public InteractionType interactionType;
    public float timestamp;
    public Interactable target;

    public InteractionData(Vector2 position, MouseButton mouseButton, InteractionType type, Interactable interactable)
    {
        screenPosition = position;
        button = mouseButton;
        interactionType = type;
        timestamp = Time.time;
        target = interactable;
    }

    public override string ToString() {
        return $"{timestamp} | Interaction: {button}, {interactionType} | Screen Position: {screenPosition} (Object: {target.gameObject.name})";
    }

    public float TimeSinceInteraction()
    {
        return Time.time - timestamp;
    }
}