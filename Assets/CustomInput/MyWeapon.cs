using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyWeapon : MonoBehaviour
{
    [Tooltip("Waktu jeda antara tembakan (detik)")]
    [Min(0f)]
    public float fireRate = 0.5f;

    private float _cooldownTimer;

    private void Update()
    {
        UpdateCooldown();
    }   

    private void UpdateCooldown()
    {
        if (_cooldownTimer > 0f)
            _cooldownTimer -= Time.deltaTime;

        if (_cooldownTimer < 0f)
            _cooldownTimer = 0f;
    }

    public void Shoot()
    {
        if (_cooldownTimer > 0f) return;

        Fire();
        _cooldownTimer = fireRate;
    }

    private void Fire()
    {
        Debug.Log("Fire!");
    }
}

