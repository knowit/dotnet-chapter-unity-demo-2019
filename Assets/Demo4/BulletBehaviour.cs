using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    public float TravelSpeed = 50.0f;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += gameObject.transform.forward * TravelSpeed * Time.deltaTime;
    }
}
