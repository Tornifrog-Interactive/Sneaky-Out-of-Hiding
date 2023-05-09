using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField]
    float movementSpeed = 10f;

    [SerializeField]
    InputAction moveHorizontal = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveVertical = new InputAction(type: InputActionType.Button);

    void OnEnable()
    {
        moveHorizontal.Enable();
        moveVertical.Enable();
    }

    void OnDisable()
    {
        moveHorizontal.Disable();
        moveVertical.Disable();
    }

    void Update()
    {
        float horizontal = moveHorizontal.ReadValue<float>();
        float vertical = moveVertical.ReadValue<float>();
        Vector3 movementVector =
            new Vector3(horizontal, vertical, 0) * movementSpeed * Time.deltaTime;

        transform.position += movementVector;
    }
}
