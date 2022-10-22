using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform car;
    public List<GameObject> roadList = new List<GameObject>();

    
    private void Awake()
    {
        _sharedInstance = this;
    }

    private static GameManager _sharedInstance;

    public static GameManager sharedInstance
    {
        get
        {
            return _sharedInstance;
        }
    }

    private void Start()
    {
    }

    public void CreateRoad()
    {
        var RandomNumber = Random.Range(0, roadList.Count);
        var lastRoad = roadList[roadList.Count - 1];
        var road_instance = Instantiate(roadList[RandomNumber]);

        if (roadList.Count == 0)
        {
            road_instance.transform.position = new Vector3(0, 0, -10);
        }
        else 
        {
            road_instance.transform.position = new Vector3(0, 0, lastRoad.transform.GetChild(2).position.z + 10);
        }

        roadList.Add(road_instance);

        if (roadList.Count > 6)
        {
            DestroyFirstRoad();
        }
    }

    private void DestroyFirstRoad()
    {
        var firstRoad = roadList[0];
        roadList.Remove(firstRoad);
        Destroy(firstRoad);
    }
}
