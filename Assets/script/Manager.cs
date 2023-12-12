using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public int my_money;
    public int bank_money;
    public TMP_Text my_moneytext;
    public TMP_Text bank_moneytext;
    public static Manager instance;
    out50000click outclick;
    in50000click inclick;
    // Start is called before the first frame update

    private void text()
    {
        my_moneytext.text = my_money.ToString("");
        bank_moneytext.text = bank_money.ToString("");
    }
    public void Awake()
    {   
        instance = this;
        my_money = 100000;
        bank_money = 50000;

    }
    
    public void Update()
    {
        text();
    }


}
