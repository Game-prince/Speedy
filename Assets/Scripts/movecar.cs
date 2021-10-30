using UnityEngine;
using System.Collections;

public class movecar : MonoBehaviour
{
    // referencing the car object in game
    public Transform car;
    public float forwardForce = 2000f;
    public float sidewaysForce = 1500f;

    // Update is called once per frame
    void FixedUpdate()
    {
        // apply force on the car
        car.GetComponent<Rigidbody>().AddForce(0, 0, forwardForce*Time.deltaTime);

        // Getting the input of left and right key
        if (Input.GetKey("right"))
        {
            car.GetComponent<Rigidbody>().AddForce(sidewaysForce*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("left"))
        {
            car.GetComponent<Rigidbody>().AddForce(-sidewaysForce*Time.deltaTime, 0, 0);
        }
    }
}
