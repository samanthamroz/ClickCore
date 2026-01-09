using System;
using UnityEngine;
using UnityEngine.Events;

namespace ClickIt {
    [AddComponentMenu("ClickIt/BasicClickableObject")]
    public class BasicClickableObject : Interactable, ILeftClick, IRightClick, IMiddleClick {
        [SerializeField] private UnityEvent onLeftClick;
        [SerializeField] private UnityEvent onRightClick;
        [SerializeField] private UnityEvent onMiddleClick;

        public void DoLeftClick() {
            onLeftClick.Invoke();
        }

        public void DoRightClick() {
            onRightClick.Invoke();
        }

        public void DoMiddleClick() {
            onMiddleClick.Invoke();
        }
    }
}