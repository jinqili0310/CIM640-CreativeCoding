using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpAndDown : MonoBehaviour
{
    float height;
    float speed;
    int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        height = transform.localPosition.y;
        speed = Random.Range(0.1f, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localPosition.y < -0.5f)
        {
            direction = 1;

        } 
        else if (transform.localPosition.y >= height)
        {
            direction = -1;
        }

        transform.localPosition += new Vector3(0, direction * speed * Time.deltaTime, 0);
    }
}
