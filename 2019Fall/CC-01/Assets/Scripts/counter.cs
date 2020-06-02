using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class counter : MonoBehaviour
{
    float count = 0;
    public Text output;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        count = count + speed;
        int countInt = (int)count;
        output.text = "score: " + countInt.ToString();
        Debug.Log(countInt);
        //count = count - 1;

    }
}
