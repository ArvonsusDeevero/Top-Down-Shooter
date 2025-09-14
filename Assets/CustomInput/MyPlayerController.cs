using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine;

[RequireComponent(typeof(MyMoveable))]
public class PlayerController : MonoBehaviour
{
    public MyInputHandler inputHandler;

    private MyMoveable moveableComponent;

    private void Awake()
    {
        moveableComponent = GetComponent<MyMoveable>();
    }

    private void OnEnable()
    {
        if (inputHandler != null)
            inputHandler.OnSetDirectionAction += HandleDirectionInput;
    }

    private void OnDisable()
    {
        if (inputHandler != null)
            inputHandler.OnSetDirectionAction -= HandleDirectionInput;
    }

    private void HandleDirectionInput(Vector2 direction)
    {
        Debug.Log("Direction input received");
        moveableComponent.SetDirection(direction);
    }
}
