using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    public Material original_material;
    public Material next_material;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Cylinder")
        {
            this.GetComponent<Renderer>().material = next_material;
        }

    }

    void OnCollisionExit(Collision collision)
    {
        this.GetComponent<Renderer>().material = original_material;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
