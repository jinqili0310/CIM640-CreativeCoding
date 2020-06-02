using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour
{
    public GameObject panel;
    public Canvas screenCanvas;
    //bool visited = false;

    string[] questions = { "Green is one of the three official colors of University of Miami.", "The University of Miami's mascot is named Icky, not Sebastian." };
    string[] answers = { "YES", "NO" };
    bool[] visited = { false, false }; 

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {

        List<int> indices = new List<int>();
        for (int i = 0; i < questions.Length; i++)
        {
            if (visited[i] == false)
            {
                indices.Add(i);
            }
        }

        if (indices.Count > 0)
        {
            int cur_index = Random.Range(0, indices.Count - 1);
            string cur_question = questions[indices[cur_index]];
            string cur_answer = answers[indices[cur_index]];

            panel.SetActive(true);
            screenCanvas.GetComponent<CheckAnswer>().UpdateQuesionAnswer(cur_question, cur_answer);
            visited[indices[cur_index]] = true;
        }

        //if(!visited)
        //{
        //    panel.SetActive(true);
        //    screenCanvas.GetComponent<CheckAnswer>().UpdateQuesionAnswer("The University of Miami's mascot is named Icky, not Sebastian.", "NO");

        //    visited = true;
        //}

        Debug.Log("close");
    }

    private void OnTriggerExit(Collider other)
    {
        panel.SetActive(false);
        Debug.Log("leave");
    }
}
