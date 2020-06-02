using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarMoving : MonoBehaviour
{
    float hInput;
    float vInput;
    public float speed;

    Quaternion pre_rotation = Quaternion.Euler(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        vInput = Input.GetAxis("Vertical");

        Quaternion target = pre_rotation;

        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow))
        {
            if (hInput > 0)
            {
                target = Quaternion.Euler(0, 90, 0);
            }
            else if (hInput < 0)
            {
                target = Quaternion.Euler(0, -90, 0);
            }
            else if (vInput > 0)
            {
                target = Quaternion.Euler(0, 0, 0);
            }
            else if (vInput < 0)
            {
                target = Quaternion.Euler(0, 180, 0);
            }

            transform.rotation = target;
            pre_rotation = target;

            float posX = transform.position.x + speed * hInput;
            float posZ = transform.position.z + speed * vInput;

            transform.position = new Vector3(posX, transform.position.y, posZ);
        }
    }
}
