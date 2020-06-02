using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{
    public Text ScoreNum;
    //int scoreCounter = 0;
    public Text time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int currentTime = int.Parse(time.text);
        if(currentTime == 0)
        {
            int currentScore = int.Parse(ScoreNum.text);
            ScoreNum.text = "Final Score = " + currentScore.ToString();
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!ScoreNum.text.Contains("Final"))
        {
            if (collision.gameObject.tag == "cylinder")
            {
                int currentScore = int.Parse(ScoreNum.text);
                currentScore++;
                ScoreNum.text = currentScore.ToString();

                /*scoreCounter++;
                ScoreNum.text = scoreCounter.ToString();*/
            }
        }


    }
}
