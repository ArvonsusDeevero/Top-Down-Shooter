using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MyMoveable))]
public class MyPlayerController : MonoBehaviour
{
    [Header("Assign InputHandler (ScriptableObject) here")]
    public InputHandler inputHandler; // ✅ Pastikan ini diisi di Inspector

    private MyMoveable moveableComponent;

    private void Awake()
    {
        moveableComponent = GetComponent<MyMoveable>();
    }

    private void OnEnable()
    {
        if (inputHandler != null)
        {
            inputHandler.OnMoveAction += HandleDirectionInput;
        }
        else
        {
            Debug.LogWarning($"{name}: InputHandler belum di-assign di Inspector!");
        }
    }

    private void OnDisable()
    {
        if (inputHandler != null)
        {
            inputHandler.OnMoveAction -= HandleDirectionInput;
        }
    }

    private void HandleDirectionInput(Vector2 direction)
    {
        // Debug log untuk memastikan input diterima
        Debug.Log($"[{name}] Direction input received: {direction}");

        // Panggil komponen MyMoveable untuk menggerakkan player
        moveableComponent.SetDirection(direction);
    }
}
