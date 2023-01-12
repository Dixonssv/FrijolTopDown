using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public enum FireType
    {
        Linear,
        Dual,
        Circle,
        Burst,
        Expanded,
        Boomerang
    }

    public float fireRate;
    float nextFireTime;
    public FireType fireType;

    public float damage;

    void Start()
    {
        nextFireTime = fireRate;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextFireTime)
        {
            Fire();
        }
    }

    public virtual void Fire()
    {
        Debug.Log("Fire!");
        nextFireTime = Time.time + fireRate;
    }
}
