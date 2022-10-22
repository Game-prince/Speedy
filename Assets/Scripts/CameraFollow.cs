using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform car;

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(0, 3.5f, car.position.z - 8);
    }
}
