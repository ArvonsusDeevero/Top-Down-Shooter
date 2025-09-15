using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

[CreateAssetMenu(fileName = "InputHandler", menuName = "Input Handler")]
public class InputHandler : ScriptableObject, MyCustomInput.INewactionmapActions
{
    private MyCustomInput input;
    public UnityAction<Vector2> OnMoveAction;

    private void OnEnable()
    {
        if (input == null)
        {
            input = new MyCustomInput();
        }
        input.Newactionmap.SetCallbacks(this);
        input.Newactionmap.Enable();
    }

    private void OnDisable()
    {
        input.Newactionmap.Disable();
    }

    public void OnSetDirection(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed || context.phase == InputActionPhase.Canceled)
        {
            OnMoveAction?.Invoke(context.ReadValue<Vector2>());
        }
    }
}
