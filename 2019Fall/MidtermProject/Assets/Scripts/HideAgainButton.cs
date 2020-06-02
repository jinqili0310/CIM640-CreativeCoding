using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HideAgainButton : MonoBehaviour
{
    public GameObject PanelAfter;
    // Start is called before the first frame update
    void Start()
    {

        PanelAfter.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
