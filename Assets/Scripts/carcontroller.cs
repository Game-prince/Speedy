using UnityEngine;

public class carcontroller : MonoBehaviour
{
    public float horizontalForce  = 500f;
    public float sideWaysForce = 500f;

    // getting a reference to the car
    public Rigidbody car;
    public Vector3 move;

    // updates once per frame
    void FixedUpdate() {
        
        // applying force on car
        car.AddForce(0, 0, horizontalForce);

        // Input management
        if (Input.GetKey("left"))
        {
            if (transform.position.x > 490)
            {
                transform.position -= move;
            }
        }

        if (Input.GetKey("right"))
        {
            if (transform.position.x < 510)
            {
                transform.position += move;
            }
            Debug.Log("This is working");
        }

    }
}
