using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDigitalMovementBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log($"\"{gameObject.name}\" is loaded");
    }

    // Update is called once per frame
    void Update()
    {
        // If nothing is pressed we move nowhere
        var direction = Vector3.zero;

        if (Input.GetButton("Left"))
        {
            Debug.Log("Left is pressed");
            direction += Vector3.left;
        }

        if (Input.GetButton("Right"))
        {
            Debug.Log("Right is pressed");
            direction += Vector3.right;
        }

        if (Input.GetButton("Up"))
        {
            Debug.Log("Up is pressed");
            direction += Vector3.up;
        }

        if (Input.GetButton("Down"))
        {
            Debug.Log("Down is pressed");
            direction += Vector3.down;
        }

        gameObject.transform.position += direction * 20 * Time.deltaTime;
    }
}
