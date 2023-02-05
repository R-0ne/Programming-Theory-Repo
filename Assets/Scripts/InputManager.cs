using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour {
    [SerializeField] private Camera _mainCamera;


    private void Update() {
        if (Mouse.current.leftButton.wasPressedThisFrame) {
            RaycastCheckTarget();
        }
    }

    private void RaycastCheckTarget() {
        RaycastHit rayHit;
        Ray ray = _mainCamera.ScreenPointToRay(Mouse.current.position.ReadValue());

        if (Physics.Raycast(ray, out rayHit)) {
            string hitTag = rayHit.transform.tag;
            Transform hitTransform = rayHit.transform;

            switch (hitTag) {
                case "Capsule":
                    hitTransform.GetComponent<Capsule>().DisplayText();
                    break;
                case "Cube":
                    hitTransform.GetComponent<Cube>().DisplayText();
                    break;
                case "Cylinder":
                    hitTransform.GetComponent<Cylinder>().DisplayText();
                    break;
                case "Sphere":
                    hitTransform.GetComponent<Sphere>().DisplayText();
                    break;
            }
        }
    }
}

