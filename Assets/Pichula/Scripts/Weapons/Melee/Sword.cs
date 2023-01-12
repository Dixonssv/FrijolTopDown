using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Melee
{
    public Transform swordHolder;

    public GameObject blade;

    public float swingSpeed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        swordHolder.rotation = transform.rotation;
    }

    public override void Fire()
    {
        base.Fire();

        blade.SetActive(false);

        StartCoroutine(Swing());
    }

    IEnumerator Swing()
    {
        float keyframe = 0.0f;

        ShowBlade();

        // 0 degrees
        Quaternion initialRotation = Quaternion.Euler(0.0f, -90, 0.0f);
        Quaternion finalRotation = Quaternion.Euler(0.0f, 90, 0.0f);

        while (keyframe < 1.0f)
        {
            keyframe += Time.deltaTime * swingSpeed;

            swordHolder.localRotation = Quaternion.Lerp(initialRotation, finalRotation, keyframe);

            yield return null;
        }

        HideBlade();
    }

    void ShowBlade()
    {
        blade.SetActive(true);
    }

    void HideBlade()
    {
        blade.SetActive(false);
    }
}
