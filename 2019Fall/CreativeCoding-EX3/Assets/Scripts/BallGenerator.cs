using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    public GameObject Ball;

    // Start is called before the first frame update
    void Start()
    {
     for(int i = 0; i < 10; i++)
        {
            Instantiate(Ball, new Vector3(Random.Range(-9, 9), Random.Range(-3, 5), 0), Quaternion.identity);
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
