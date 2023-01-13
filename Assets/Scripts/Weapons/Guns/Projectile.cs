using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float damage;
    
    public float range;

    Vector3 spawnPosition;

    public float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        spawnPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        if(Vector3.SqrMagnitude(transform.position - spawnPosition) > Mathf.Pow(range, 2))
        {
            Destroy(transform.gameObject);
        }
    }
}
