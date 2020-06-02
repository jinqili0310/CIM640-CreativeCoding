using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CylinderGenerator : MonoBehaviour
{
    public GameObject Cylinder0;

    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < 3; i++)
        {
            Instantiate(Cylinder0, new Vector3(Random.Range(-4, 4), 0.45f, Random.Range(-4, 4)), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
