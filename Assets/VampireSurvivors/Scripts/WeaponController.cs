using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public Weapon startingWeapon;
    List<Weapon> equippedWeapons;

    public Transform weaponHolder;

    void Start()
    {
        equippedWeapons = new List<Weapon>();

        equipWeapon(startingWeapon);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void equipWeapon(Weapon weapon)
    {
        Weapon newWeapon = Instantiate(weapon, weaponHolder.position, weaponHolder.rotation);
        newWeapon.transform.parent = weaponHolder;

        equippedWeapons.Add(newWeapon);
    }
}
