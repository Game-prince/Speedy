using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform car;
    public List<GameObject> roadList = new List<GameObject>();
    public List<GameObject> obstacleList = new List<GameObject>();
    private List<GameObject> activeRoadList = new List<GameObject>();

    private enum GameState
    {
        Start,
        Playing,
        Pause,
        End
    }

    private GameState currentGameState;
    private static GameManager _sharedInstance;


    private void Awake()
    {
        _sharedInstance = this;
    }


    public static GameManager sharedInstance
    {
        get
        {
            return _sharedInstance;
        }
    }

    private void Start()
    {
        changeState(GameState.Start);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            print(currentGameState);
            if (currentGameState == GameState.Start || currentGameState == GameState.Pause)
            {
                changeState(GameState.Playing);
            }
            else if (currentGameState == GameState.Playing)
            {
                changeState(GameState.Pause);
            }
        }

        if (CarMovements.instance.HasCollided() == true)
        {
            changeState(GameState.End);
        }
    }

    private void changeState(GameState state)
    {
        currentGameState = state;
        
        switch (currentGameState)
        {
            case GameState.Start:
                CarMovements.instance.StartGame();
                activeRoadList.Clear();
                for (byte i = 0; i < 6; i++)
                {
                    CreateRoad();
                }
                break;
            case GameState.Playing:
                CarMovements.instance.Playing();
                break;
            case GameState.End:
                CarMovements.instance.End();
                break;
            default:
                break;
        }
    }

    public void CreateRoad()
    {
        var RandomNumber = activeRoadList.Count == 0 ? 0 : Random.Range(0, roadList.Count);
        var road_instance = Instantiate(roadList[RandomNumber]);

        if (activeRoadList.Count == 0)
        {
            road_instance.transform.position = new Vector3(0, 0, 0);
        }
        else 
        {
            var lastRoad = activeRoadList[activeRoadList.Count - 1];
            road_instance.transform.position = new Vector3(0, 0, lastRoad.transform.GetChild(2).position.z + 10);
        }

        activeRoadList.Add(road_instance);

        if (activeRoadList.Count > 7)
        {
            DestroyFirstRoad();
        }
    }

    private void DestroyFirstRoad()
    {
        var firstRoad = activeRoadList[0];
        activeRoadList.Remove(firstRoad);
        Destroy(firstRoad);
    }

}
