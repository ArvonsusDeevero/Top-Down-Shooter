using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MyMoveable))]
public class AutoMover : MonoBehaviour
{
    public enum MoveMode { Forward, Random }
    public MoveMode moveMode = MoveMode.Forward;

    private MyMoveable moveable;

    private void Awake()
    {
        moveable = GetComponent<MyMoveable>();
    }

    private void Start()
    {
        if (moveMode == MoveMode.Random)
        {
            moveable.SetDirection(GetRandomDirection());
        }
    }

    private void Update()
    {
        if (moveMode == MoveMode.Forward)
        {
            moveable.SetDirection(transform.up);
        }
    }

    private Vector3 GetRandomDirection()
    {
        return new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0f).normalized;
    }
}
