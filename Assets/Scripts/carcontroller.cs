using UnityEngine;

public class Carcontroller : MonoBehaviour
{
    public float horizontalForce = 500f;
    public float sideWaysForce = 1000f;

    // getting a reference to the car
    public Rigidbody car;

    // updates once per frame
    void FixedUpdate()
    {

        // applying force on car
        car.AddForce(0, 0, horizontalForce);

        // Input management
        if (Input.GetKey("left"))
        {
            if (transform.position.x > 490) car.AddForce(-sideWaysForce, 0, 0);
        }

        if (Input.GetKey("right"))
        {
            if (transform.position.x < 510) car.AddForce(sideWaysForce, 0, 0);
        }

    }
}
