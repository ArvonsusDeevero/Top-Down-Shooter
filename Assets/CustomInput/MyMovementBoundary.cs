using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MyMoveable))]
public class MovementBoundary : MonoBehaviour
{
    public Rect movementBounds;

    private MyMoveable moveable;

    private void Awake()
    {
        moveable = GetComponent<MyMoveable>();
    }

    private void Update()
    {
        Vector3 nextPosition = moveable.GetNextPosition();

        if (IsOutsideXBounds(nextPosition))
        {
            moveable.SetXDirection(0f);
        }

        if (IsOutsideYBounds(nextPosition))
        {
            moveable.SetYDirection(0f);
        }
    }

    private bool IsOutsideXBounds(Vector3 nextPos)
    {
        return nextPos.x < movementBounds.xMin || nextPos.x > movementBounds.xMax;
    }

    private bool IsOutsideYBounds(Vector3 nextPos)
    {
        return nextPos.y < movementBounds.yMin || nextPos.y > movementBounds.yMax;
    }
}
