using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour
{
    private Text textMoney;
    public int money=0;
    // Start is called before the first frame update
    void Start()
    {
        textMoney = GameObject.Find("moneyText").GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddMoney()

    {
        money += 50;
        textMoney.text = "$" + money;
    }
}
