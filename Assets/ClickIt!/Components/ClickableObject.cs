using System;
using UnityEngine;
using UnityEngine.Events;

namespace ClickIt {
    [AddComponentMenu("ClickIt/ClickableObject")]
    public class ClickableObject : Interactable, ILeftClick, IRightClick, IMiddleClick {
        [SerializeField] private MouseClickBinding[] bindings;

        public void DoLeftClick() {
            InvokeBindingsForButton(MouseButton.left);
        }

        public void DoRightClick() {
            InvokeBindingsForButton(MouseButton.right);
        }

        public void DoMiddleClick() {
            InvokeBindingsForButton(MouseButton.middle);
        }

        private void InvokeBindingsForButton(MouseButton button) {
            foreach (var binding in bindings) {
                if (binding.button == button) {
                    binding.onClick.Invoke();
                }
            }
        }
    }
}