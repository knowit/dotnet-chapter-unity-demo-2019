using UnityEngine;

public class SimpleMovementBehaviour : MonoBehaviour
{
    private Transform _transform;

    // Start is called before the first frame update
    void Start()
    {
        // Find transform component
        _transform = GetComponent<Transform>();

        // NOTE:
        // Since every gameObject is forced to have a
        // a Transform component, this component is also 
        // accessible from gameObject.transform
    }

    // Update is called once per frame
    void Update()
    {
        // Get input axis state
        var dx = Input.GetAxis("Horizontal");
        var dy = Input.GetAxis("Vertical");

        // Movement speed
        var speed = 20;

        // Change the position along the input axis by 20 units per second 
        _transform.position += new Vector3(dx, dy) * speed * Time.deltaTime;
    }
}
