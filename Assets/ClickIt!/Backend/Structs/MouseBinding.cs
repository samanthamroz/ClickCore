using UnityEngine;
using System;
using UnityEngine.Events;

namespace ClickIt {
    [Serializable]
    public struct MouseClickBinding {
        [Tooltip("Optional label for organization")]
        public string optionalLabel;
        
        [Tooltip("Which mouse button triggers this binding")]
        public MouseButton button;
        
        [Tooltip("Functions to be triggered")]
        public UnityEvent onClick;
    }

    [Serializable]
    public struct MouseReleaseBinding {
        [Tooltip("Optional label for organization")]
        public string optionalLabel;
        
        [Tooltip("Which mouse button triggers this binding")]
        public MouseButton button;
        
        [Tooltip("Functions to be triggered")]
        public UnityEvent onRelease;
    }

    [Serializable]
    public struct MouseClickAwayBinding {
        [Tooltip("Optional label for organization")]
        public string optionalLabel;
        
        [Tooltip("Which mouse button triggers this binding")]
        public MouseButton button;
        
        [Tooltip("Functions to be triggered")]
        public UnityEvent onClickAway;
    }
}