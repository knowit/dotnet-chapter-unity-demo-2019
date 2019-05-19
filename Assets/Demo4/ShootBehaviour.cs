using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBehaviour : MonoBehaviour
{
    public GameObject Bullet;
    public float BulletLife = 1.0f;

    IEnumerator Fire()
    {
        var bullet = Instantiate(Bullet, gameObject.transform.position, gameObject.transform.rotation);
        yield return new WaitForSeconds(BulletLife);
        Destroy(bullet);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire"))
        {
            StartCoroutine(Fire());
        }
    }
}
