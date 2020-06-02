
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour
{
    public Text CurrentScore;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "star" || collision.gameObject.tag == "finalStar")
        {
            GetComponent<Rigidbody>().isKinematic = true;
            int curScore = int.Parse(CurrentScore.text);
            curScore++;
            CurrentScore.text = curScore.ToString();
            Destroy(collision.gameObject);
            GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
