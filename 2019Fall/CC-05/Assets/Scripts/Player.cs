using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private string name;
    private int HP;

    public Player(string input_name, int input_HP)
    {
        name = input_name;
        HP = input_HP;
    }

    public string GetName()
    {
        return name;
    }

    public int GetHP()
    {
        return HP;
    }

    public void IncreaseHP(int value)
    {
        this.HP = this.HP + value;
    }

    public void DecreaseHP(int value)
    {
        this.HP = this.HP - value;
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
