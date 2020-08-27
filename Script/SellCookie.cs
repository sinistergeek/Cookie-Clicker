using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCookie : MonoBehaviour
{
    public GameObject Textbox;
    public GameObject statusBox;
    public AudioSource noCookie;
    public void ClickButton()
    {
        if (GlobalCookie.cookieCount == 0)
        {
            noCookie.Play();
            statusBox.GetComponent<Text>().text = "Not Enough Cookie to Sell";
            statusBox.GetComponent<Animation>().Play("statusAnim");
        }
        else
        {

            GlobalCookie.cookieCount -= 1;
            GlobalCash.cookieSell += 1;
        }
    }
}
