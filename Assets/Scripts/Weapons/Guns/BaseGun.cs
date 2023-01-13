using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseGun : Gun
{
    // Start is called before the first frame update
    void Start()
    {
        damage = 1.0f;
        fireRate = 2.0f;
        fireType = FireType.Linear;
        shootDistance = 3.0f;
        muzzleSpeed = 5.0f;
    }

    public override void Fire()
    {
        base.Fire();

        Projectile newProjectile = Instantiate(projectile, transform.position, transform.rotation);
        newProjectile.range = shootDistance;
        newProjectile.speed = muzzleSpeed;
        newProjectile.damage = damage;
    }
}
