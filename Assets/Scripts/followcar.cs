using UnityEngine;

public class Followcar : MonoBehaviour
{
    public Transform car;
    public Vector3 offset;
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = car.position + offset;
    }
}
