using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCameraBehaviour : MonoBehaviour
{
    public float Sensitivity = 10.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        var dx = Input.GetAxis("Mouse X") * Sensitivity * Time.deltaTime;
        var dy = -Input.GetAxis("Mouse Y") * Sensitivity * Time.deltaTime;

        var position = gameObject.transform.position;
        var rightAxis = gameObject.transform.right;
        
        gameObject.transform.RotateAround(position, rightAxis, dy);
        gameObject.transform.RotateAround(position, Vector3.up, dx);

    }
}
