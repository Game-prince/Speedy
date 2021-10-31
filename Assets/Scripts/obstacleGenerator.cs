using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleGenerator : MonoBehaviour
{
    // referencing to our prefab object
    public GameObject obstacle;
    
    // Finding how much time has passed since the last obstacle was generated
    int timePassed = 50;

    // refrencing to the player
    public Transform player;

    // refrencing to the ground
    public Transform road;

    List<GameObject> obstacles = new List<GameObject>();
    int numbers = 0;

    
    // update is called once per frame
    void FixedUpdate()
    {
        // Getting the width of the obstacle
        float obstacleWidth = obstacle.GetComponent<Renderer>().bounds.size.x;
        
        // Getting width of ground
        float roadWidth = road.GetComponent<Renderer>().bounds.size.x;

        float[] lanes = new float[]{490, 500, 510};

        // if timePassed is equal to 0 we will generate the obstacle
        if (timePassed == 0)
        {
            int pos = Random.Range(0, 3);
            Instantiate(obstacle, new Vector3(lanes[pos], 0.15f, player.position.z + 100), Quaternion.identity);
            timePassed = 30;
            // obstacles.append(obstacle);
            numbers++;
        }

        // deleting the obstacle if it is out of the screen
        // for(int i = 0; i < numbers; i++)
        // {
        //     if (obstacles[i].transform.position.z < player.position.z - 30)
        //     {
        //         Destroy(obstacle);
        //     }
        // }

        timePassed--;
    }
}
