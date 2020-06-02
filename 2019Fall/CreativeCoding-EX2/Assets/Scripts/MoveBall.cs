using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    private float speed = 0.1f;
    public Material yellow;
    public Material red;
    private float prePositionY = 0;


    void Start()
    {

    }

    void Update()
    {
        if (transform.position.y < -3 || transform.position.y > 3)
        {
            speed = -1 * speed;
        }

        transform.position = new Vector3(transform.position.x, transform.position.y + speed, transform.position.z);

        if (transform.position.y > prePositionY)
        {
            this.GetComponent<Renderer>().material = yellow;
            transform.localScale += new Vector3(0.04f, 0.04f, 0.04f);
        } 
        else if(transform.position.y < prePositionY)
        {
            this.GetComponent<Renderer>().material = red;
            transform.localScale -= new Vector3(0.04f, 0.04f, 0.04f);
        }

        prePositionY = transform.position.y;

    }
}
