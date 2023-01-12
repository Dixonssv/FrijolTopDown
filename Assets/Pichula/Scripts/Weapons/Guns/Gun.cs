using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun: Weapon
{
    public Projectile projectile;

    public float shootDistance;

    public float muzzleSpeed;
}
