using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBalls : MonoBehaviour
{
    int i = 0;
    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        //for(int i = 0; i < 7; i++)
        //{
        //    Instantiate(Ball, new Vector3(Random.Range(-5, 5), Random.Range(1, 8), Random.Range(-5, 5)), Quaternion.identity);
        //}

    }

    // Update is called once per frame
    void Update()
    {
        if(i < 5)
        {
            Instantiate(Ball, new Vector3(Random.Range(-5, 5), Random.Range(1, 8), Random.Range(-5, 5)), Quaternion.identity);
            i++;
        }
    }
}
