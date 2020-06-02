using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckAnswer : MonoBehaviour
{
    string answer = "";
    public Text scoreText;
    public Text questionText;
    public GameObject panel;
    public GameObject avatar;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
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
            avatar.GetComponent<GenGem>().GenerateGem();
        }
        else
        {
            score--;
        }

        scoreText.text = score.ToString();
        panel.SetActive(false);
    }

    public void ButtonNoClicked()
    {
        int score = int.Parse(scoreText.text);

        if (answer == "NO")
        {
            score++;
            avatar.GetComponent<GenGem>().GenerateGem();
        }
        else
        {
            score--;
        }

        scoreText.text = score.ToString();
        panel.SetActive(false);
    }

    public void UpdateQuesionAnswer(string new_q, string new_a)
    {
        answer = new_a;
        questionText.text = new_q;
    }
}
