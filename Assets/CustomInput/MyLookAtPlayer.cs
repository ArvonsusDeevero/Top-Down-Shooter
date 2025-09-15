using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyLookAtPlayer : MonoBehaviour
{
    private Transform _playerTransform;

    private void Start()
    {
        _playerTransform = MyCode.GameManager.GetInstance().activePlayer?.transform;
    }

    private void Update()
    {
        LookAtPlayer();
    }

    private void LookAtPlayer()
    {
        if (_playerTransform == null)
        {
            _playerTransform = MyCode.GameManager.GetInstance().activePlayer?.transform;
            if (_playerTransform == null) return;
        }

        Vector3 direction = _playerTransform.position - transform.position;
        transform.up = direction;
    }
}
