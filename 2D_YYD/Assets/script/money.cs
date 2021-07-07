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

    public void AddMoney(int indexOrder)

    {
        switch (indexOrder){
            case 0:
                money += 100;
                break;
            case 1:
                money += 80;
                break;
            case 2:
                money += 50;
                break;
            case 3:
                money += 30;
                break;
            case 4:
                money += 50;
                break;
        }
        textMoney.text = "$" + money;
    }
}
