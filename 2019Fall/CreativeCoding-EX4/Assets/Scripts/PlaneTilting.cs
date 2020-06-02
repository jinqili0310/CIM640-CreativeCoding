using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneTilting : MonoBehaviour
{
    float hInput;
    float vInput;
    public float angle;
    float movingAngleH;
    float movingAngleV;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        //Debug.Log("hInput = " + hInput);

        vInput = Input.GetAxis("Vertical");

        movingAngleH = hInput * angle;

        movingAngleV = vInput * angle;

        Quaternion target = Quaternion.Euler(transform.rotation.eulerAngles.x + movingAngleV, 
            0, transform.rotation.eulerAngles.z - movingAngleH);
       
        transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
    }
}
