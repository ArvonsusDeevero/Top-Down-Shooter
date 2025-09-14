using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMoveable : MonoBehaviour
{
    public float moveSpeed = 1;

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
        moveDirection = new Vector3(direction.x, direction.y, moveDirection.z);
    }
}
