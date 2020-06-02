using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public GameObject PanelBefore;
    //public GameObject PlayerBall;
    public float BallSpeed = 10;
    public bool OnUpdate = false;

    public GameObject ButtonLeft;
    public GameObject ButtonRight;

    // Start is called before the first frame update
    void Start()
    {
        //GetComponent<Rigidbody>().isKinematic = true;
        ButtonLeft.gameObject.SetActive(false);
        ButtonRight.gameObject.SetActive(false);


    }

    // Update is called once per frame
    void Update()
    {
        if(OnUpdate == true)
        {
            transform.position = transform.position + new Vector3(BallSpeed * Time.deltaTime * -1, 0, 0);
        }

    }

    public void BeginGame()
    {

        PanelBefore.gameObject.SetActive(false);
        ButtonLeft.gameObject.SetActive(true);
        ButtonRight.gameObject.SetActive(true);
        //GetComponent<Rigidbody>().isKinematic = false;
        OnUpdate = true;

    } 
}
