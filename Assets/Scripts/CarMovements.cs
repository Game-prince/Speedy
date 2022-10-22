using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovements : MonoBehaviour
{
    private Rigidbody rb;

    private enum Position {
        Middle = 0,
        Left = -2,
        Right = 2
    }
        
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //applying velociy to the car
        rb.velocity = new Vector3(0f, 0f, 1000 * Time.deltaTime);

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            
        }
    }
}
