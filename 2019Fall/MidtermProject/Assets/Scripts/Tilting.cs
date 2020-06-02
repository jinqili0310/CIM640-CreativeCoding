using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilting : MonoBehaviour
{
    private bool moveLeft, moveRight;

    // Create the rigidbody and the collider
    private Rigidbody rb;
    private Collider col;

    // Create a variable you can change in inspector window for speed
    [SerializeField]
    private float speed;

    void Start()
    {
       
    }


    void Update()
    {
        if (moveLeft)
        {

            transform.position = transform.position + new Vector3(0, 0, (speed * Time.deltaTime * -1));
        }
        else if (moveRight)
        {

            transform.position = transform.position + new Vector3(0, 0, (speed * Time.deltaTime * 1));
        }
    }

    public void MoveLeft()
    {
        moveLeft = true;
        moveRight = false;
    }

    public void MoveRight()
    {
        moveRight = true;
        moveLeft = false;
    }

}
