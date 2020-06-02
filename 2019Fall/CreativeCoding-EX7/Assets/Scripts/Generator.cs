using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Generator : MonoBehaviour
{
    string[] alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };

    public Text A1, A2, A3;
    public int index1, index2, index3;

    public GameObject gemPrefab;

    bool buttonClicked = false;

    public void generateAlphabet()
    {
        buttonClicked = true;
        gemPrefab.SetActive(false);


        index1 = (int)Random.Range(0, alphabet.Length - 1);
        A1.text = alphabet[index1];

        index2 = (int)Random.Range(0, alphabet.Length - 1);
        A2.text = alphabet[index2];

        index3 = (int)Random.Range(0, alphabet.Length - 1);
        A3.text = alphabet[index3];
    }

    // Start is called before the first frame update
    void Start()
    {  
        buttonClicked = false;
        gemPrefab.SetActive(false);

        index1 = (int)Random.Range(0, alphabet.Length - 1);
        A1.text = alphabet[index1];

        index2 = (int)Random.Range(0, alphabet.Length - 1);
        A2.text = alphabet[index2];

        index3 = (int)Random.Range(0, alphabet.Length - 1);
        A3.text = alphabet[index3];
    }

    // Update is called once per frame
    public void Update()
    {
        if (buttonClicked)
        {

            if (index1 != index2 && index1 != index3 && index2 != index3)
            {
                index1 = (int)Random.Range(0, alphabet.Length - 1);
                A1.text = alphabet[index1];
                index1 = index1 + Random.Range(-1 * index1, alphabet.Length - 1 - index1);
                A1.text = alphabet[index1];

                index2 = (int)Random.Range(0, alphabet.Length - 1);
                A2.text = alphabet[index2];
                index2 = index2 + Random.Range(-1 * index2, alphabet.Length - 1 - index2);
                A2.text = alphabet[index2];

                index3 = (int)Random.Range(0, alphabet.Length - 1);
                A3.text = alphabet[index3];
                index3 = index3 + Random.Range(-1 * index3, alphabet.Length - 1 - index3);
                A3.text = alphabet[index3];

            } else if (index1 == index2 || index1 == index3 || index2 == index3)
            {
                gemPrefab.SetActive(true);
            }

        }

    }
}
