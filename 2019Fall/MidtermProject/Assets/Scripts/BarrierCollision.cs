using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BarrierCollision : MonoBehaviour
{
    public Text FinalScore;
    public Text GameOver;
    public Text CurrentScore;

    public GameObject PanelAfter;

    private StartGame script;
    // Start is called before the first frame update
    void Start()
    {
        script = GetComponent<StartGame>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "barrier" || collision.gameObject.tag == "finalStar")
        {
            GetComponent<Rigidbody>().isKinematic = true;
            script.OnUpdate = false;
           

            GameOver.text = "Game Over";

            int currentScore = int.Parse(CurrentScore.text);
            FinalScore.text = "Your score is " + currentScore.ToString();

            PanelAfter.gameObject.SetActive(true);
        }

    }
}
