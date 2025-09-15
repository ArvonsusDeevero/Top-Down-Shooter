using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMoveable : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 moveDirection;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }

    public void SetDirection(Vector3 direction)
    {
        moveDirection = direction;
    }

    public void SetDirection(Vector2 direction)
    {
        moveDirection = new Vector3(direction.x, direction.y, 0f);
    }

    public Vector3 GetNextPosition()
    {
        return transform.position + moveDirection * moveSpeed * Time.deltaTime;
    }

    // ✅ Tambahan untuk kompatibilitas
    public Vector3 NewPosition()
    {
        return GetNextPosition();
    }

    public void SetXDirection(float x)
    {
        moveDirection.x = x;
    }

    public void SetYDirection(float y)
    {
        moveDirection.y = y;
    }

    public Vector3 newPosition()
    {
        return moveDirection * Time.deltaTime * moveSpeed;
    }
}
