using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{


    // Update is called once per frame
    private void FixedUpdate()
    {
        transform.Rotate(new Vector3(1f, 0f, 0f) * Time.deltaTime * 100);
    }
}
