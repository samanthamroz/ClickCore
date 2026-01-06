using System;
using UnityEngine;
using UnityEngine.Events;

namespace ClickIt {

    [AddComponentMenu("ClickIt/ClickAwayObject")]
    public class ClickAwayObject : Interactable, ILeftClickAway, IRightClickAway, IMiddleClickAway {
        [SerializeField] private MouseClickAwayBinding[] bindings;

        public void DoLeftClickAway() {
            InvokeBindingsForButton(MouseButton.left);
        }

        public void DoRightClickAway() {
            InvokeBindingsForButton(MouseButton.right);
        }

        public void DoMiddleClickAway() {
            InvokeBindingsForButton(MouseButton.middle);
        }

        private void InvokeBindingsForButton(MouseButton button) {
            foreach (var binding in bindings) {
                if (binding.button == button) {
                    binding.onClickAway.Invoke();
                }
            }
        }
    }
}