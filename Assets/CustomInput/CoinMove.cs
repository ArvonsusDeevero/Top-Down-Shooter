using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MyCode;

[RequireComponent(typeof(MyMoveable))]
public class CoinMove : MonoBehaviour
{
    private MyMoveable moveable;

    private void Awake()
    {
        moveable = GetComponent<MyMoveable>();
    }

    private void Start()
    {
        moveable.SetDirection(GetDirectionToPlayer());
    }

    private Vector3 GetDirectionToPlayer()
    {
        Vector3 direction = GameManager.GetInstance().GetPlayerPosition() - transform.position;
        return direction.normalized;
    }
}
