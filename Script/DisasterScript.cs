using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class DisasterScript : MonoBehaviour
{
    public GameObject statusBox;
    public float cookieCheck;
    public int getChance;
    public bool disasterActive = false;
    public int cookieLoss;
    void Update()
    {
        //100
        cookieCheck = GlobalCookie.cookieCount / 100;
        if (disasterActive == false)
        {
            StartCoroutine(StartDisaster());
        }

    }
    IEnumerator StartDisaster()
    {
        disasterActive = true;
        //200
        getChance = Random.Range(1, 200);
        if(cookieCheck >= getChance)
        {
            cookieLoss = Mathf.RoundToInt(GlobalCookie.cookieCount * 0.25f);
            statusBox.GetComponent<Text>().text = "You lost " + cookieLoss + " cookie in a factory fire";
            GlobalCookie.cookieCount -= cookieLoss;
            yield return new WaitForSeconds(3);
            statusBox.GetComponent<Animation>().Play("statusAnim");
            yield return new WaitForSeconds(1);
            statusBox.SetActive(false);
            statusBox.SetActive(true);

        }
        yield return new WaitForSeconds(10);
        disasterActive = false;
    
    }
}
