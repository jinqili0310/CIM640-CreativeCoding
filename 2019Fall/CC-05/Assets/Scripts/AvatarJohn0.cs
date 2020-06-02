using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarJohn0 : MonoBehaviour
{
    Player John = new Player("John", 80);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(John.GetName());
        Debug.Log(John.GetHP());
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("hit");
        if (collision.gameObject.name == "Cube")
        {
            John.IncreaseHP(5);
            Debug.Log(John.GetHP());
        }
    }
}