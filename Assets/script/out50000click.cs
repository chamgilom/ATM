using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class out50000click : MonoBehaviour
{
    public int outmoney;
    // Start is called before the first frame update
    public void  OnClick()
    {
        if (Manager.instance.bank_money >= outmoney)
        {
            Manager.instance.my_money += outmoney;
            Manager.instance.bank_money -= outmoney;
        }
        else
        {
            Debug.Log("잔액이 부족합니다.");
        }
    }
}
