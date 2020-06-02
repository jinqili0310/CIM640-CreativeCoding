using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    public float number;
    public Text time;
    public Text message;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        number -= 0.01f;
        int output = (int)number;
        if (output <= 0)
        {
            time.text = "0";
            message.text = "Game Over!";
        }
        else
        {
            time.text = output.ToString();
        }
    }

}
