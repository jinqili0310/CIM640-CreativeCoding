using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer : MonoBehaviour
{
    string answer = "YES";
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ButtonYesClicked()
    {
        int score = int.Parse(scoreText.text);

        if(answer == "YES")
        {
            score++;
        }
        else
        {
            score--;
        }

        scoreText.text = score.ToString();
    }

}
