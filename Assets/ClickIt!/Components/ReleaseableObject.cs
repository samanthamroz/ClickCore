using System;
using UnityEngine;
using UnityEngine.Events;

namespace ClickIt {
    [AddComponentMenu("ClickIt/ReleaseableObject")]
    public class ReleaseableObject : Interactable, ILeftRelease, IRightRelease, IMiddleRelease {
        [SerializeField] private MouseReleaseBinding[] bindings;

        public void DoLeftRelease() {
            InvokeBindingsForButton(MouseButton.left);
        }

        public void DoRightRelease() {
            InvokeBindingsForButton(MouseButton.right);
        }

        public void DoMiddleRelease() {
            InvokeBindingsForButton(MouseButton.middle);
        }

        private void InvokeBindingsForButton(MouseButton button) {
            foreach (var binding in bindings) {
                if (binding.button == button) {
                    binding.onRelease.Invoke();
                }
            }
        }
    }
}