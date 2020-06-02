using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collision1 : MonoBehaviour
{
    public GameObject panel;
    public Canvas screenCanvas;
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
        screenCanvas.GetComponent<CheckAnswer>().UpdateQuesionAnswer("Green is one of the three official colors of University of Miami.", "YES");

        panel.SetActive(true);
        Debug.Log("close");
    }

    private void OnTriggerExit(Collider other)
    {
        panel.SetActive(false);
        Debug.Log("leave");
    }
}
