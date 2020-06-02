using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.anyKeyDown)
        {
            switch(Input.inputString)
            {
                case "w":
                    transform.localRotation = Quaternion.Euler(-10, 0, 0);
                    break;
                case "s":
                    transform.localRotation = Quaternion.Euler(30, 0, 0);
                    break;
                case "a":
                    transform.localRotation = Quaternion.Euler(10, -30, 0);
                    break;
                case "d":
                    transform.localRotation = Quaternion.Euler(10, 30, 0);
                    break;
                case "x":
                    transform.localRotation = Quaternion.Euler(10, 0, 0);
                    break;
                default:
                    Debug.Log("Another key is pressed");
                    break;
            }

        }
    }
}
