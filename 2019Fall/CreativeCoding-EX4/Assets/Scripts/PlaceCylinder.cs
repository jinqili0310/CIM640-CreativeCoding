using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceCylinder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = new Vector3(Random.Range(-4, 4), 0.45f, Random.Range(-4, 4));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
