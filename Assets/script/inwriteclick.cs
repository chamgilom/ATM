using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI; 

public class inwriteclick : MonoBehaviour
{

    [SerializeField] private Text money;
    [SerializeField] private InputField inputMoney;
    private int current_Money = 0;

    // Start is called before the first frame update

    public void Start()
    {

    }
    public void Input() 
    {
        current_Money = int.Parse(money.text);

        if (Manager.instance.my_money >= current_Money)
        {
            Manager.instance.my_money -= current_Money;
            Manager.instance.bank_money += current_Money;
        }
        else
        {
            Debug.Log("잔액이 부족합니다.");
        }
    }
    //public void OnClick()
    //{


    //}

}