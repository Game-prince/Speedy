using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovements : MonoBehaviour
{
    // Getting rigidbody of the car
    private Rigidbody rb;

    // Creating enum of car positions on road
    private enum Position {
        Middle = 0,
        Left = -3,
        Right = 3
    }

    // Creating different speeds for car
    private enum Speed
    {
        slow = 10,
        medium = 20,
        fast = 30
    }

    // Current position of the car
    private Position position = Position.Middle;

    //Current Speed of the car
    private Speed speed = Speed.slow;

    // Creating a shared instance
    private static CarMovements _instance;

    // Creating a variable know if the car has collided with any obstacle or not
    private bool HasCollidedWithObstacle;


    private void Awake()
    {
        _instance = this;
    }

    public static CarMovements instance
    {
        get
        {
            return _instance;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        HasCollidedWithObstacle = false;
    }

    public void StartGame()
    {
        speed = 0;
        transform.position = new Vector3(0, 1, 2);
    }

    public void Playing()
    {
        speed = Speed.slow;
    }

    public void End()
    {
        speed = 0;
        print("The game has ended");
    }

    // Update is called once per frame
    void Update()
    {

        //applying velociy to the car
        rb.velocity = new Vector3(0f, 0f, (int)speed * Time.deltaTime * 200);

        if (Input.GetKeyDown(KeyCode.LeftArrow) && position != Position.Left)
        {
            position -= 3;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow) && position != Position.Right)
        {
            position += 3;
        }

        transform.position = Vector3.MoveTowards(transform.position, new Vector3((int)position, transform.position.y, transform.position.z), 1000 * Time.deltaTime);
    }

    public bool HasCollided()
    {
        return HasCollidedWithObstacle;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "obstacles")
        {
            HasCollidedWithObstacle = true;
        }
    }
}
