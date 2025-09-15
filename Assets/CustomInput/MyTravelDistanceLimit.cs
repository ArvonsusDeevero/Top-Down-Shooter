using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MyMoveable))]
public class MyTravelDistanceLimit : MonoBehaviour
{
    public float maxTravelDistance;

    private float _travelDistance;
    private MyMoveable _moveable;
    private MyPoolObject _poolObject;

    private void Awake()
    {
        _moveable = GetComponent<MyMoveable>();
        _poolObject = GetComponent<MyPoolObject>();
    }

    private void OnEnable()
    {
        _travelDistance = 0f;
    }

    private void Update()
    {
        _travelDistance += _moveable.NewPosition().magnitude;

        if (_travelDistance >= maxTravelDistance)
        {
            if (_poolObject != null)
            {
                _poolObject.Deactivate();
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}
