using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class outwriteclick : MonoBehaviour
{

    [SerializeField] private Text money;
    [SerializeField] private InputField inputMoney;
    private int current_Money = 0;

    // Start is called before the first frame update

    public void Start()
    {

    }

    public void Output() 
    {
        current_Money = int.Parse(money.text); 
        //current_Money -= int.Parse(inputMoney.text); 

        //money.text = current_Money.ToString();
        if (Manager.instance.bank_money >= current_Money)
        {
            Manager.instance.my_money += current_Money;
            Manager.instance.bank_money -= current_Money;
        }
        else
        {
            Debug.Log("�ܾ��� �����մϴ�.");
        }
    }

}
