using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAutoShoot : MonoBehaviour
{
    private MyWeapon[] _weapons;

    private void Start()
    {
        _weapons = GetComponentsInChildren<MyWeapon>();
    }

    private void Update()
    {
        AutoShootAllWeapons();
    }

    private void AutoShootAllWeapons()
    {
        if (_weapons == null || _weapons.Length == 0) return;

        foreach (var weapon in _weapons)
        {
            weapon.Shoot();
        }
    }
}

