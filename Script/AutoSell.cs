using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoSell : MonoBehaviour
{
    public bool SellingCookie = false;
    public static int CashIncrease =1;
    public int InternalIncrease;
  

    void Update()
    {
        CashIncrease = GlobalShop.shopPerSec;
        InternalIncrease = CashIncrease;
        if(SellingCookie == false)
        {
            SellingCookie = true;
            StartCoroutine(sellTheCookie());
        }
        
    }

    IEnumerator sellTheCookie()
    {
        if (GlobalCookie.cookieCount == 0)
        {
            ///Nothing for now
        }
        else{ 

            GlobalCash.cookieSell += InternalIncrease;
            GlobalCookie.cookieCount -= 1;
            yield return new WaitForSeconds(1);
            SellingCookie = false;
    }
    }
}
