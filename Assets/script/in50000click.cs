using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class in50000click : MonoBehaviour
{
    public int  inmoney;
    // Start is called before the first frame update
    public void  OnClick()
    {
        if (Manager.instance.my_money >= inmoney)
        {
            Manager.instance.my_money -= inmoney;
            Manager.instance.bank_money += inmoney;
        }
        else
        {
            Debug.Log("잔액이 부족합니다.");
        }

    }
}
