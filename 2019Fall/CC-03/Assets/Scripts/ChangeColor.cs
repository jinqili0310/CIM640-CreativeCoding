using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    float pre_position_y = 5;
    public Material original_material;
    public Material next_material;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-5, 5), Random.Range(1, 8), Random.Range(-5, 5));

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y > pre_position_y)
        {
            this.GetComponent<Renderer>().material = next_material;
            //transform.localScale += new Vector3(0.1F, 0.1f, 0.1f);
        }
        else if (transform.position.y < pre_position_y)
        {
            this.GetComponent<Renderer>().material = original_material;
            //transform.localScale -= new Vector3(0.1F, 0.1f, 0.1f);
        }

        pre_position_y = transform.position.y;
    }
}
