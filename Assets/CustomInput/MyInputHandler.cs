using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "InputHandler", menuName = "Input/Input Handler")]
public class InputHandler : ScriptableObject, CustomInput.IGameplayActions
{
    private CustomInput inputActions;

    [Header("Gameplay Actions")]
    public UnityAction<Vector2> OnMove;
    public UnityAction OnPause;

    private void OnEnable()
    {
        InitializeInput();
    }

    private void OnDisable()
    {
        if (inputActions != null)
            inputActions.Gameplay.Disable();
    }

    private void InitializeInput()
    {
        if (inputActions == null)
        {
            inputActions = new CustomInput();
            inputActions.Gameplay.SetCallbacks(this);
        }

        inputActions.Gameplay.Enable();
    }

    public void OnPause(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed)
        {
            OnPause?.Invoke();
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed || context.phase == InputActionPhase.Canceled)
        {
            OnMove?.Invoke(context.ReadValue<Vector2>());
        }
    }
}
