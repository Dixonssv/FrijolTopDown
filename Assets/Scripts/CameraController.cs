using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform player;

    Vector3 offset;

    void Start()
    {
        player = FindObjectOfType<Player>().GetComponent<Transform>();

        offset = new Vector3(0.0f, 7.0f, -4.0f);

        transform.LookAt(player.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.position + offset;
    }
}
