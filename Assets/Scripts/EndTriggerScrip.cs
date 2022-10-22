using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTriggerScrip : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            GameManager.sharedInstance.CreateRoad();
        }
    }
}
