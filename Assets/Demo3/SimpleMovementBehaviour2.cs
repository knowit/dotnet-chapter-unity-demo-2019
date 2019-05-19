using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

public class SimpleMovementBehaviour2 : MonoBehaviour
{
    // public attributes are shown in editor
    public float MovementSpeed = 20;
    public bool AnalogMovement = true; 

    // Update is called once per frame
    void Update()
    {
        var direction = AnalogMovement ? GetAnalogDirection() : GetDigitalDirection();

        // Change the position along the input axis by units per second 
        gameObject.transform.position += direction * MovementSpeed * Time.deltaTime;
    }

    private Vector3 GetAnalogDirection()
    {
        var dx = Input.GetAxis("Horizontal");
        var dy = Input.GetAxis("Vertical");

        return new Vector3(dx, dy);
    }

    private Vector3 GetDigitalDirection()
    {
        var left = Input.GetButton("Left") ? Vector3.left : Vector3.zero;
        var right = Input.GetButton("Right") ? Vector3.right : Vector3.zero;
        var up = Input.GetButton("Up") ? Vector3.up : Vector3.zero;
        var down = Input.GetButton("Down") ? Vector3.down : Vector3.zero;

        return left + right + up + down;
    }
}
