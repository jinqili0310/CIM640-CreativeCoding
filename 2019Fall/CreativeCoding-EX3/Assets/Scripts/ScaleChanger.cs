using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    float start_scale;
    float speed;
    int direction = 1;

    // Start is called before the first frame update
    void Start()
    {
        start_scale = Random.Range(0.1f, 1.1f);

        transform.localScale = new Vector3(start_scale, start_scale, start_scale);

        speed = Random.Range(0.01f, 0.08f);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("start" + transform.localScale.x);

        if (transform.localScale.x >= 1.1f)
        {
            direction = -1;

        }
        else if (transform.localScale.x <= 0.1f)
        {
            direction = 1;
        }
           
       
        Debug.Log("after" + transform.localScale.x);

        transform.localScale = transform.localScale + (direction * new Vector3(speed, speed, speed));


    }
}
