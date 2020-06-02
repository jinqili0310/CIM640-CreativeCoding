using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenGem : MonoBehaviour
{
    public GameObject[] gemPrefabs = new GameObject[4];

    public void GenerateGem()
    {
        int index = (int)Random.Range(0, 4);

        GameObject gemInScene = Instantiate(gemPrefabs[index], new Vector3(transform.position.x, transform.position.y + 4.2f, transform.position.z), Quaternion.AngleAxis(90, Vector3.right));

        Destroy(gemInScene, 3);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
